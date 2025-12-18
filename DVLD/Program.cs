using DVLD.Dialogs;
using DVLD.Session;
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
                CurrentUserProvider.SetCurrentUser(login.AuthenticatedUser);
                Application.Run(new MainForm());
            }
        }
    }
}
