using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using HtmlAgilityPack;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Microsoft.Win32;
using Microsoft.VisualBasic;

namespace Steam
{

    public partial class MainForm : Form
    {
        [DllImport("kernel32")]
        static extern bool AllocConsole();
        public string SteamID = "";
        ChromeDriver _ChromeDriver;
        Thread Commentth;
        public MainForm()
        {

            InitializeComponent();
        }


        static bool IsDnsByPassed(string p_dnsName)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");
            string hostsText = File.ReadAllText(path);
            return hostsText.ToLower().Contains(p_dnsName.ToLower());
        }
        private void CheckWEB()
        {
            try
            {
                WebClient web = new WebClient();
                if (IsDnsByPassed("konachan"))
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                if (IsDnsByPassed("steam"))
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                string re = web.DownloadString("http://konachan.dothome.co.kr/SteamK9sad1FdDSAdssadROjdfsoasdfjklJLFJSDKLJ13JFJE89SA89FJ89F23IJFIOJsiodfjsioajdf89J89FJIDSOFJ89fj89sdj890fhuHU9H893JHFJI9UF89UJSDIOFJOASUDF89FIjdklsaknmlNM.jsp");
                if (re.Contains("OFF"))
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
            catch
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
        void DatabaseWrite()
        {
            DatagridDB db = new DatagridDB();
            db.UserProfileStatus = false;
            db.UserFriendCount = 0;
            db.SteamID = "";
            this.DataGrid.SelectedObject = db;
        }
        void Tabpagermeove()
        {
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
        }
        void Tabpageadd()
        {

            this.Invoke(new MethodInvoker(delegate () { tabControl1.TabPages.Add(tabPage2); }));
            this.Invoke(new MethodInvoker(delegate () { tabControl1.TabPages.Add(tabPage3); }));
            this.Invoke(new MethodInvoker(delegate () { tabControl1.TabPages.Add(tabPage4); }));
        }
        void MainForm_Load(object sender, EventArgs e)
        {
            RefreshCommentList();
            Tabpagermeove();
            DatabaseWrite();
            CheckWEB();
            AllocConsole();

            Control.CheckForIllegalCrossThreadCalls = false;

        }
        private void TypingRandomly(IWebElement we, string text)
        {
            Random Rand = new Random();

            string str = text;
            for (int i = 0; i < str.Length; i++)
            {
                we.SendKeys(str[i].ToString());
                Thread.Sleep(Rand.Next(10, 50));
            }
        }
        const int FRIEND_NAME = 1;
        const int FRIEND_UID = 2;

        private void DoSteamJob(ChromeDriver c, string id, string pw)
        {
            try
            {
                Console.WriteLine("TryLogin");
                c.Navigate().GoToUrl("https://steamcommunity.com/login");
                Thread.Sleep(1000);
                c.FindElementByName("username").Click();
                Thread.Sleep(500);
                TypingRandomly(c.FindElementByName("username"), id);
                Thread.Sleep(500);
                c.FindElementByName("password").Click();
                Thread.Sleep(500);
                TypingRandomly(c.FindElementByName("password"), pw);
                Thread.Sleep(500);
                c.FindElementById("SteamLogin").Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                MessageBox.Show(ex.Message);
                c.Quit();
                return;
            }
            Console.WriteLine("You Need To Steam Login Veirfy and Click Continue Button");
            Console.WriteLine("You Need Your Profile Make Public too !");
            Continue.Enabled = true; autoEvent.WaitOne();




            Thread.Sleep(2000);
       

            button1.Text = "LoginSucess";
            c.Navigate().GoToUrl("http://steamcommunity.com/my");
            Thread.Sleep(1000);

            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();

            doc1.LoadHtml(c.PageSource);
            HtmlNode node1 = doc1.DocumentNode.SelectSingleNode("//div[@class=\"responsive_menu_user_persona persona online\"]//div[@class=\"playerAvatar online\"]//a");
            Regex r = new Regex("http://steamcommunity.com/profiles/(.*?)/");
            Match m = r.Match(node1.Attributes["href"].Value);
            SteamID = m.Groups[1].Value;
            DatagridDB db = new DatagridDB();
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                string dl = web.DownloadString(SteamAPI.API_AdvancePlayer(SteamID));

                SteamAdvance adv = JsonConvert.DeserializeObject<SteamAdvance>(dl);
                bool chk = false;
                foreach (var item in adv.response.players)
                {
                    if (item.communityvisibilitystate != 3)
                    {
                        button1.Enabled = true;
                        button1.Text = "Login";
                        chk = true;
                        c.Quit();
                        break;
                    }
                }
                if (chk)
                {
                    MessageBox.Show("Profile Status Not Public", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            //using (WebClient web = new WebClient())
            //{
            //    web.Encoding = Encoding.UTF8;
            //    string dl = web.DownloadString("http://steamcommunity.com/groups/steamcommentbot/memberslistxml/?xml=1");
            //    HtmlAgilityPack.HtmlDocument dldoc = new HtmlAgilityPack.HtmlDocument();
            //    if (!dl.Contains("<steamID64>" + SteamID + "</steamID64>"))
            //    {
            //        c.Quit();
            //        System.Diagnostics.Process.Start("http://steamcommunity.com/groups/steamcommentbot");
            //        MessageBox.Show("You Are Not In Group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        return;
            //    }

            //}
            Console.WriteLine("Auth Passed!");
            Tabpageadd();
            string dl2 = "";
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                dl2 = web.DownloadString(SteamAPI.API_GetFriend(SteamID));
            }
            SteamFriendAdvance sfv = JsonConvert.DeserializeObject<SteamFriendAdvance>(dl2);

            foreach (var item in sfv.friendslist.friends)
            {
                ListViewItem itema = new ListViewItem();
                using (WebClient web = new WebClient())
                {
                    web.Encoding = Encoding.UTF8;
                    string tempdl = web.DownloadString(SteamAPI.API_AdvancePlayer(item.steamid));
                    SteamAdvance tempadv = JsonConvert.DeserializeObject<SteamAdvance>(tempdl);
                    string personname = "";
                    
                    foreach (var tempitem in tempadv.response.players)
                    {
                        if (tempitem.communityvisibilitystate == 3)
                        {
                            if (tempitem.commentpermission != 2)
                            {
                                itema.Text = "ok";
                            }
                            else
                            {
                                itema.Text = "no";
                                itema.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            itema.BackColor = Color.Gray;
                        }

                        personname = tempitem.personaname;
                    }
                    itema.SubItems.Add(personname);
                    itema.SubItems.Add(item.steamid);
                    this.Invoke(new MethodInvoker(delegate () { FriendList.Items.Add(itema); }));

                 
                }
            }
            db.SteamID = SteamID;
            db.UserFriendCount = sfv.friendslist.friends.Count;
            db.UserProfileStatus = true;
            Console.WriteLine("UserSteamidParsing");
            DataGrid.SelectedObject = db;
            Thread.Sleep(1000);
            this.Text = "Steam Comment Bot [ " + SteamID + " ]";
        }
        private ChromeDriver RunChrome()
        {
            ChromeDriver c = null;
            try
            {
                ChromeOptions chromeOption = new ChromeOptions();
                chromeOption.AddExcludedArgument("disable-popup-blocking");
                c = new ChromeDriver(chromeOption);
                c.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(60));
                c.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                c.Navigate().GoToUrl("chrome://settings-frame/");
                Thread.Sleep(1000);
                c.FindElementByCssSelector("#advanced-settings-expander").Click();
                Thread.Sleep(1000);
                c.FindElementByCssSelector("#privacyContentSettingsButton").Click();
                Thread.Sleep(1000);
                c.FindElementByCssSelector("#notifications-section input[value='block']").Click();
                Thread.Sleep(1000);
                c.FindElementByCssSelector("#content-settings-overlay-confirm").Click();
                Thread.Sleep(1000);
            }
            catch
            {
            }
            return c;
        }
        Thread Main;
        AutoResetEvent autoEvent = new AutoResetEvent(false);
        void MainTask()
        {
            ChromeDriver chrome;
            try
            {

                try
                {
                    chrome = RunChrome();

                }
                catch
                {
                    return;
                }
                try
                {
                    DoSteamJob(chrome, id.Text, pw.Text);
                }
                catch (Exception EX)
                {
                    chrome.Quit();
                    Console.WriteLine(EX.Message);
                    return;
                }
                _ChromeDriver = chrome;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void CommentTask()
        {
            try
            {
                ChromeDriver chrome = _ChromeDriver;
                Comment.Enabled = false;
                foreach (ListViewItem item in FriendList.CheckedItems)
                {
                    string uid = item.SubItems[FRIEND_UID].Text;
                    chrome.Navigate().GoToUrl("http://steamcommunity.com/profiles/" + uid);
                    Thread.Sleep(1000);
                    string read = chrome.PageSource;
                    try
                    {
                        chrome.FindElementByXPath("//textarea[@class=\"commentthread_textarea\"]").Click();
                    }
                    catch
                    {
                        item.BackColor = Color.Red;
                        Console.WriteLine(item.Text + "Not Able");
                        continue;
                    }
                    if (read.Contains("This profile is private."))
                    {
                        item.BackColor = Color.Red;
                        continue;
                    }
                    else
                    {

                        chrome.FindElementByXPath("//textarea[@class=\"commentthread_textarea\"]").Click();
                        Thread.Sleep(500);
                        TypingRandomly(chrome.FindElementByXPath("//textarea[@class=\"commentthread_textarea\"]"), Comment.Text);
                        Thread.Sleep(1000);
                        chrome.FindElementByXPath("//span[@class=\"btn_green_white_innerfade btn_small\"]").Click();
                        item.BackColor = Color.Lime;
                        Thread.Sleep(1000);
                    }

                }
              
                Console.WriteLine("Sucess");

                button1.Text = "Login";
          
                FriendList.Enabled = true;
                
                Comment.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }catch(Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
        }
        private void CommentBtn_Click(object sender, EventArgs e)
        {
            if (CommentBtn.Text == "Stop")
            {
                Commentth.Abort();
                CommentBtn.Text = "Write Comment";
            }
            else
            {
                if (Comment.Text.Length == 0)
                {
                    MessageBox.Show("Please Insert Text on CommentBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (FriendList.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Error Friend List Not Checked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                Commentth = new Thread(new ThreadStart(CommentTask));
                Commentth.Start();
      
                FriendList.Enabled = false;
                CommentBtn.Text = "Stop";
                button2.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text.Length == 0 || pw.Text.Length == 0)
            {
                MessageBox.Show("Please Insert ID or Pw", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            button1.Enabled = false;
            Main = new Thread(new ThreadStart(MainTask));
            Main.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamcommunity.com/profiles/76561198289882777");
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            autoEvent.Set();
            Continue.Enabled = false;
        }

        private void allselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in FriendList.Items)
            {
                if (item.BackColor == Color.White || item.BackColor == Color.Lime)
                {
                    item.BackColor = Color.White;
                }
                if (item.BackColor != Color.Red || item.Text == "ok")
                {
                    item.Checked = true;
                }
            }
        }

        private void 체크해제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in FriendList.Items)
            {
                item.Checked = false;
            }
        }
        void RefreshCommentList()
        {
            CommentList.Items.Clear();
            try
            {
                RegistryKey rkey = Registry.CurrentUser.OpenSubKey("KONASOFT").OpenSubKey("SteamCommentBot");
                foreach(var v in rkey.GetValueNames())
                {
                    CommentList.Items.Add(v);
                }
            }
            catch
            {

            }
        }
        void CommentGet(string item)
        {
            Comment.Text = "";
            try
            {
                RegistryKey rkey = Registry.CurrentUser.OpenSubKey("KONASOFT").OpenSubKey("SteamCommentBot");
                string commentvalue = rkey.GetValue(item).ToString();
                Comment.Text = commentvalue;
            }
            catch
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox(Comment.Text + " Saveto List", "Insert ListName?", "");
            if (input == "" || input.Equals(""))
            {
                return;
            }
            try
            {
                RegistryKey rkey = Registry.CurrentUser.OpenSubKey("KONASOFT").OpenSubKey("SteamCommentBot", true);
                rkey.SetValue(input, Comment.Text, RegistryValueKind.String);
            }
            catch
            {
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("KONASOFT").CreateSubKey("SteamCommentBot");
                rkey.SetValue(input, Comment.Text, RegistryValueKind.String);
            }
            RefreshCommentList();
        }

        private void CommentList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(CommentList.SelectedItem.ToString().Length !=0)
            {
                CommentGet(CommentList.SelectedItem.ToString());
            }
        }

        private void FriendList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamcommunity.com/groups/steamcommentbot");
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CommentList.SelectedItems.Count == 0)
            {
                return;
            }
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey("KONASOFT").OpenSubKey("SteamCommentBot", true);
            rkey.DeleteValue(CommentList.SelectedItem.ToString());
            RefreshCommentList();
            
        }
    }
}
