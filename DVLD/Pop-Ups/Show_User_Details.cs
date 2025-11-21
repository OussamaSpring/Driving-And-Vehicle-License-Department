using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Models;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;

namespace DVLD.Pop_Ups
{
    public partial class Show_User_Details : Form
    {
        private readonly UserController _userController;

        public Show_User_Details(int userId)
        {
            InitializeComponent();
            _userController = new UserController(new UserRepository());
            LoadUserDetailsAsync(userId);
        }

        private async void LoadUserDetailsAsync(int userId)
        {
            try
            {
                User user = await _userController.GetUserByIdAsync(userId);
                if (user == null)
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                lb_user_id.Text = user.UserId.ToString();
                lb_username.Text = user.Username;
                lb_is_active.Text = user.IsActive ? "Yes" : "No";

                // Populate the person details card
                personDetailsCard.SetPerson(user.PersonId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}