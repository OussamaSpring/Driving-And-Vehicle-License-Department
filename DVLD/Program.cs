using DVLD.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginDialog login = new LoginDialog();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(login.AuthenticatedUser));
            }
        }
    }
}
