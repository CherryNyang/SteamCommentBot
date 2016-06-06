namespace Steam
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.allselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.체크해제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambiance_ThemeContainer1 = new Ambiance.Ambiance_ThemeContainer();
            this.ambiance_ControlBox1 = new Ambiance.Ambiance_ControlBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGrid = new System.Windows.Forms.PropertyGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Continue = new Ambiance.Ambiance_Button_1();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.akaTagBox2 = new Aka.UI.AkaTagBox();
            this.akaTagBox1 = new Aka.UI.AkaTagBox();
            this.FriendList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CommentList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Comment = new System.Windows.Forms.TextBox();
            this.CommentBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.ambiance_ThemeContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allselToolStripMenuItem,
            this.toolStripMenuItem1,
            this.체크해제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 54);
            // 
            // allselToolStripMenuItem
            // 
            this.allselToolStripMenuItem.Name = "allselToolStripMenuItem";
            this.allselToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.allselToolStripMenuItem.Text = "Select All";
            this.allselToolStripMenuItem.Click += new System.EventHandler(this.allselToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 6);
            // 
            // 체크해제ToolStripMenuItem
            // 
            this.체크해제ToolStripMenuItem.Name = "체크해제ToolStripMenuItem";
            this.체크해제ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.체크해제ToolStripMenuItem.Text = "Unselect All";
            this.체크해제ToolStripMenuItem.Click += new System.EventHandler(this.체크해제ToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(109, 26);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.delToolStripMenuItem.Text = "Delect";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // ambiance_ThemeContainer1
            // 
            this.ambiance_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_ControlBox1);
            this.ambiance_ThemeContainer1.Controls.Add(this.tabControl1);
            this.ambiance_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambiance_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ambiance_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ambiance_ThemeContainer1.Name = "ambiance_ThemeContainer1";
            this.ambiance_ThemeContainer1.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.ambiance_ThemeContainer1.RoundCorners = true;
            this.ambiance_ThemeContainer1.Sizable = true;
            this.ambiance_ThemeContainer1.Size = new System.Drawing.Size(519, 386);
            this.ambiance_ThemeContainer1.SmartBounds = true;
            this.ambiance_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ambiance_ThemeContainer1.TabIndex = 2;
            this.ambiance_ThemeContainer1.Text = "SteamCommentBot - KONA SOFT -";
            // 
            // ambiance_ControlBox1
            // 
            this.ambiance_ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_ControlBox1.EnableMaximize = true;
            this.ambiance_ControlBox1.Font = new System.Drawing.Font("Marlett", 7F);
            this.ambiance_ControlBox1.Location = new System.Drawing.Point(5, 13);
            this.ambiance_ControlBox1.Name = "ambiance_ControlBox1";
            this.ambiance_ControlBox1.Size = new System.Drawing.Size(64, 22);
            this.ambiance_ControlBox1.TabIndex = 2;
            this.ambiance_ControlBox1.Text = "ambiance_ControlBox1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 314);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(471, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 177);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UserInfo";
            // 
            // DataGrid
            // 
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(3, 19);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(459, 155);
            this.DataGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Continue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pw);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 97);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SteamLogin With Chrome";
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Transparent;
            this.Continue.Enabled = false;
            this.Continue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Continue.Image = null;
            this.Continue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Continue.Location = new System.Drawing.Point(6, 71);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(453, 20);
            this.Continue.TabIndex = 10;
            this.Continue.Text = "Continue";
            this.Continue.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(122, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "* Your Profile Must Be Public *";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(77, 22);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(106, 23);
            this.id.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "SteamID";
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(265, 20);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(106, 23);
            this.pw.TabIndex = 5;
            this.pw.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.akaTagBox2);
            this.tabPage2.Controls.Add(this.akaTagBox1);
            this.tabPage2.Controls.Add(this.FriendList);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(471, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FriendList";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // akaTagBox2
            // 
            this.akaTagBox2.Background = System.Drawing.Color.White;
            this.akaTagBox2.Border = System.Drawing.Color.Gray;
            this.akaTagBox2.Location = new System.Drawing.Point(409, 6);
            this.akaTagBox2.Name = "akaTagBox2";
            this.akaTagBox2.Size = new System.Drawing.Size(48, 15);
            this.akaTagBox2.TabIndex = 3;
            this.akaTagBox2.Text = "Private";
            this.akaTagBox2.TextColor = System.Drawing.Color.DimGray;
            // 
            // akaTagBox1
            // 
            this.akaTagBox1.Background = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.akaTagBox1.Border = System.Drawing.Color.Red;
            this.akaTagBox1.Location = new System.Drawing.Point(335, 6);
            this.akaTagBox1.Name = "akaTagBox1";
            this.akaTagBox1.Size = new System.Drawing.Size(68, 15);
            this.akaTagBox1.TabIndex = 2;
            this.akaTagBox1.Text = "NotAvliable";
            this.akaTagBox1.TextColor = System.Drawing.Color.Red;
            // 
            // FriendList
            // 
            this.FriendList.CheckBoxes = true;
            this.FriendList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.FriendList.ContextMenuStrip = this.contextMenuStrip1;
            this.FriendList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FriendList.FullRowSelect = true;
            this.FriendList.GridLines = true;
            this.FriendList.Location = new System.Drawing.Point(3, 3);
            this.FriendList.Name = "FriendList";
            this.FriendList.Size = new System.Drawing.Size(465, 280);
            this.FriendList.TabIndex = 1;
            this.FriendList.UseCompatibleStateImageBehavior = false;
            this.FriendList.View = System.Windows.Forms.View.Details;
            this.FriendList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.FriendList_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CommentAble";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SteamID";
            this.columnHeader3.Width = 191;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Controls.Add(this.CommentBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(471, 286);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Comment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Current Comment Save to List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 248);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CommentList);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(235, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 242);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CommentList";
            // 
            // CommentList
            // 
            this.CommentList.ContextMenuStrip = this.contextMenuStrip2;
            this.CommentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommentList.FormattingEnabled = true;
            this.CommentList.ItemHeight = 15;
            this.CommentList.Location = new System.Drawing.Point(3, 19);
            this.CommentList.Name = "CommentList";
            this.CommentList.Size = new System.Drawing.Size(221, 220);
            this.CommentList.TabIndex = 0;
            this.CommentList.SelectedIndexChanged += new System.EventHandler(this.CommentList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Comment);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 242);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comment";
            // 
            // Comment
            // 
            this.Comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Comment.Location = new System.Drawing.Point(3, 19);
            this.Comment.Multiline = true;
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(220, 220);
            this.Comment.TabIndex = 0;
            // 
            // CommentBtn
            // 
            this.CommentBtn.Location = new System.Drawing.Point(6, 257);
            this.CommentBtn.Name = "CommentBtn";
            this.CommentBtn.Size = new System.Drawing.Size(226, 23);
            this.CommentBtn.TabIndex = 8;
            this.CommentBtn.Text = "Write Comment";
            this.CommentBtn.UseVisualStyleBackColor = true;
            this.CommentBtn.Click += new System.EventHandler(this.CommentBtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.linkLabel2);
            this.tabPage4.Controls.Add(this.linkLabel1);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(471, 286);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Information";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(30, 200);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(132, 15);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Developer Steam Group";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(30, 162);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Developer Steam";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 75);
            this.label3.TabIndex = 1;
            this.label3.Text = "1. This Program Only Allows Steam CommentBot Groups User\r\n2. Login With steam \r\n3" +
    ". Check Friends\r\n4. Write Comment\r\n5. Sucess\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 386);
            this.Controls.Add(this.ambiance_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteamCommentBot - KONA SOFT -";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ambiance_ThemeContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private Ambiance.Ambiance_ThemeContainer ambiance_ThemeContainer1;
        private System.Windows.Forms.ListView FriendList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button CommentBtn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PropertyGrid DataGrid;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Ambiance.Ambiance_Button_1 Continue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allselToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 체크해제ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox CommentList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private Aka.UI.AkaTagBox akaTagBox2;
        private Aka.UI.AkaTagBox akaTagBox1;
        private Ambiance.Ambiance_ControlBox ambiance_ControlBox1;
    }
}