using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Steam
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            bool createdNew;
            Mutex _Mutex = new Mutex(true, "SteamKonaLove", out createdNew);
            if (createdNew)
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                try
                {
                    var lgn = new MainForm();
                    lgn.FormClosed += new FormClosedEventHandler(FormClosed);
                    lgn.Show();


                    Application.Run();
                    _Mutex.ReleaseMutex();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
            else
            {
                MessageBox.Show("Already Running", "Warning");
                return;
            }

        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
