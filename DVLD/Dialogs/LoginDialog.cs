using System;
using System.Windows.Forms;
using System.Threading.Tasks;

using Core.Models;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using Microsoft.Win32;

using DVLD;

namespace DVLD.Dialogs
{
    public partial class LoginDialog : DVLD.Views.Components.RoundedBaseForm
    {

        private readonly UserController _userController;
        private User _authenticatedUser;
        public User AuthenticatedUser => _authenticatedUser;

        public LoginDialog()
        {
            InitializeComponent();
            _userController = new UserController(new UserRepository());
        }

        private void LoginDialog_Load(object sender, EventArgs e)
        {
            var credentials = RegistryCredentials.LoadCredentials();

            if (!string.IsNullOrEmpty(credentials.Username) && !string.IsNullOrEmpty(credentials.Password))
            {
                txt_username.Text = credentials.Username;
                txt_password.Text = credentials.Password;
                chk_remember_me.Checked = true;
            }
        }

        private void lb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private async void btn_login_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateUsername() && ValidatePassword();

            if (isValid)
            {
                string username = txt_username.Text.Trim();
                string password = txt_password.Text;

                await AuthenticationAsync(username, password);

            }
        }



        #region LoginLogic
        private async Task AuthenticationAsync(string username, string password)
        {
            try
            {
                short result = await _userController.AuthenticateUserAsync(username, password);

                if (result == 0)
                {
                    MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 2)
                {
                    MessageBox.Show("Your account is inactive. Please contact the administrator.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _authenticatedUser = await _userController.GetUserByUsernameAsync(username);
                    SaveCredentials();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during authentication: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveCredentials()
        {
            if(chk_remember_me.Checked)
            {
                RegistryCredentials.SaveCredentials(txt_username.Text, txt_password.Text);
            }
        }

        #endregion

        #region Validation
        private bool ValidateUsername()
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                err_login_credential.SetError(txt_username, "Username cannot be empty.");
                return false;
            }
            err_login_credential.SetError(txt_username, string.Empty);
            return true;
        }
        private bool ValidatePassword()
        {
            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                err_login_credential.SetError(txt_password, "Password cannot be empty.");
                return false;
            }
            err_login_credential.SetError(txt_password, string.Empty);
            return true;
        }

        #endregion
    }
}
