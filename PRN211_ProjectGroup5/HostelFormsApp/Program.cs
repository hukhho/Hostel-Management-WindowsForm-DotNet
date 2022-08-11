using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelFormsApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //LoginForm lf = new LoginForm();
            //lf.Show();
            //if (lf.ShowDialog().Equals("OK"))
            //{
            //    frmMain mainFrm = new frmMain();
            //    mainFrm.Show();
            //    MessageBox.Show("OK");

            //}
            LoginForm logonForm = new LoginForm();
            if (logonForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }



        }
    }
}
