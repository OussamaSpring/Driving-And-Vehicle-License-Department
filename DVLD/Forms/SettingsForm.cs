using Core.Enums;
using Core.Models;
using DVLD.Pop_Ups;
using DVLD.UserControls;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace DVLD.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly UserController _userController;
        private readonly PersonController _personController;


        private User currentUser;
        private Person currentPerson;

        private List<User> _usersList = new List<User>();


        private bool HasImageChanged = false;
        private bool IsImageEmpty = true;
        private bool HasPersonDataChanged = false;
        private bool HasUsernameChanged = false;

        public SettingsForm(User user)
        {
            InitializeComponent();

            var tabs = new TabBar
            {
                Dock = DockStyle.Fill,
                Height = 50
            };
            tabs.SetTabs("Profile Settings", "Users Management");
            tabs.SelectedIndexChanged += (s, e) =>
            {
                switch (tabs.SelectedIndex)
                {
                    case 0:
                        OnProfileSettingsTabSelected();
                        break;
                    case 1:
                        OnUsersManagementTabSelected();
                        break;
                }
            };

            tlp_header.Controls.Add(tabs, 1, 0);



            _userController = new UserController(new UserRepository());
            _personController = new PersonController(new PersonRepository());

            this.currentUser = user;


        }


        #region Help Functions

        private async Task<Person> MapPersonData()
        {
            Person p = new Person();

            p.FirstName = tb_first_name.Text;
            p.SecondName = tb_second_name.Text;
            p.ThirdName = tb_third_name.Text;
            p.LastName = tb_last_name.Text;
            p.NationalNumber = tb_national_no.Text;
            p.DateOfBirth = dtp_date_of_birth.Value;
            p.enGender = cb_gender.SelectedIndex == 0 ? Genders.Male : Genders.Female;
            p.Email = tb_email.Text;
            p.Phone = tb_phone.Text;
            p.NationalityCountry = await _personController.GetCountryByNameAsync(cb_country.Text);
            p.Address = rtb_address.Text;
            p.PersonalImage = HasImageChanged == true ? (IsImageEmpty == true ? null : ImageToByteArray(rpb_profile_image.Image)) : null; // If image has changed, update it; otherwise, keep it as is.

            return p;
        }
        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        #endregion

        #region Form Events and Methods

        private void OnProfileSettingsTabSelected()
        {
            htc_tab_nav.SelectedIndex = 0;
        }
        private void OnUsersManagementTabSelected()
        {
            htc_tab_nav.SelectedIndex = 1;
            LoadUsersAsync();
        }
        private async void SettingsForm_Load(object sender, EventArgs e)
        {
            OnProfileSettingsTabSelected();


            // Load countries into combobox
            var countries = await _personController.GetAllCountriesAsync();

            if (countries != null)
            {
                cb_country.Items.Clear();
                foreach (var country in countries)
                {
                    cb_country.Items.Add(country.CountryName);
                }
            }

            // Load user and person data
            LoadPersonData();
            LoadUserData();

            uc_users_topbar.AddButtonClicked = AddNewUser; // Disable add button
            uc_users_topbar.FillFilterCriteria(_userController.GetUserFilterCriteria());
            uc_users_topbar.FilterPerformed = uc_users_topbar_FilterPerformed;
        }
        private async void LoadPersonData()
        {
            currentPerson = await _personController.GetPersonByIdAsync(currentUser.PersonId);
            if (currentPerson != null)
            {
                lb_person_id.Text = currentPerson.PersonId.ToString();
                tb_national_no.Text = currentPerson.NationalNumber;
                tb_first_name.Text = currentPerson.FirstName;
                tb_second_name.Text = currentPerson.SecondName;
                tb_third_name.Text = currentPerson.ThirdName;
                tb_last_name.Text = currentPerson.LastName;
                dtp_date_of_birth.Value = currentPerson.DateOfBirth;
                cb_gender.SelectedIndex = (int)currentPerson.enGender;
                tb_email.Text = currentPerson.Email;
                tb_phone.Text = currentPerson.Phone;
                cb_country.SelectedIndex = cb_country.FindString(currentPerson.NationalityCountry.CountryName);
                rtb_address.Text = currentPerson.Address;
                if (currentPerson.PersonalImage == null)
                {
                    rpb_profile_image.Image = img_list_default_profile.Images[cb_gender.SelectedIndex];
                    IsImageEmpty = true;
                }
                else
                {
                    rpb_profile_image.Image = ByteArrayToImage(currentPerson.PersonalImage) ?? img_list_default_profile.Images[cb_gender.SelectedIndex];
                    IsImageEmpty = false;
                }
            }
            err_input_validation.Clear();
        }
        private async void LoadUserData()
        {
            currentUser = await _userController.GetUserByUsernameAsync(currentUser.Username);
            lb_user_id.Text = currentUser.UserId.ToString();
            lb_is_active.Text = currentUser.IsActive ? "Active" : "Inactive";
            tb_username.Text = currentUser.Username;
            err_input_validation.Clear();
        }

        #endregion


        #region Person Info UI Events and Methods

        private void btn_discard_person_Click(object sender, EventArgs e)
        {
            if (HasPersonDataChanged || HasImageChanged)
            {
                if (MessageBox.Show("Are you sure you want to discard changes?", "Confirm Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            HasPersonDataChanged = false;
            HasImageChanged = false;

            LoadPersonData();
            DisablePersonEditing();
        }
        private async void btn_save_person_Click(object sender, EventArgs e)
        {
            btn_save_person.Enabled = false; // Disable button to prevent multiple clicks

            if ((!HasPersonDataChanged && !HasImageChanged))
                return;

            if(!ValidatePersonInputs())
            {
                MessageBox.Show("Please correct the input fields errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_save_person.Enabled = true;
                return;
            }

            try
            {
                Person updatedPerson = await MapPersonData();
                updatedPerson.PersonId = currentPerson.PersonId; // Ensure we set the correct PersonId for update

                if(HasPersonNationalNumberChanged())
                {
                    if (await _personController.IsPersonExistAsync(updatedPerson.NationalNumber))
                    {
                        MessageBox.Show("Failed to update national number. National number already exist!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                bool updateInfoResult = await _personController.UpdatePersonInfoAsync(updatedPerson);

                bool updatePersonImageResult = false;
                if (HasImageChanged)
                    updatePersonImageResult = await _personController.UpdatePersonPhotoAsync(updatedPerson.PersonId, updatedPerson.PersonalImage);

                if (updateInfoResult)
                {
                    MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if(HasImageChanged && !updatePersonImageResult)
                    {
                        MessageBox.Show("Profile image update failed, but other information was updated successfully.", "Partial Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    HasPersonDataChanged = false;
                    HasImageChanged = false;
                    DisablePersonEditing();
                }
                else
                {
                    MessageBox.Show("Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadPersonData();
                btn_save_person.Enabled = true; // Re-enable button
            }
        }
        private void lb_upload_image_Click(object sender, EventArgs e)
        {
            ofd_upload_image.Title = "Select Profile Image";
            ofd_upload_image.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd_upload_image.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd_upload_image.FileName);
                rpb_profile_image.Image = img;
                lb_remove_image.Visible = true;
                HasImageChanged = true;
                IsImageEmpty = false;
            }
        }
        private void lb_remove_image_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the profile image?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            rpb_profile_image.Image = img_list_default_profile.Images[cb_gender.SelectedIndex];
            lb_remove_image.Visible = false;
            HasImageChanged = true;
            IsImageEmpty = true;
        }
        private void cb_gender_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (IsImageEmpty)
                rpb_profile_image.Image = img_list_default_profile.Images[cb_gender.SelectedIndex];
        }
        private void EnablePersonEditing(object sender, EventArgs e)
        {
            tb_national_no.Enabled = true;
            tb_first_name.Enabled = true;
            tb_second_name.Enabled = true;
            tb_third_name.Enabled = true;
            tb_last_name.Enabled = true;
            dtp_date_of_birth.Enabled = true;
            cb_gender.Enabled = true;
            tb_email.Enabled = true;
            tb_phone.Enabled = true;
            cb_country.Enabled = true;
            rtb_address.Enabled = true;
            lb_upload_image.Visible = true;
            if (!IsImageEmpty)
                lb_remove_image.Visible = true;
            btn_save_person.Enabled = true;
            btn_discard_person.Enabled = true;
        }
        private void DisablePersonEditing()
        {
            tb_national_no.Enabled = false;
            tb_first_name.Enabled = false;
            tb_second_name.Enabled = false;
            tb_third_name.Enabled = false;
            tb_last_name.Enabled = false;
            dtp_date_of_birth.Enabled = false;
            cb_gender.Enabled = false;
            tb_email.Enabled = false;
            tb_phone.Enabled = false;
            cb_country.Enabled = false;
            rtb_address.Enabled = false;
            lb_upload_image.Visible = false;
            if (!IsImageEmpty)
                lb_remove_image.Visible = false;
            btn_save_person.Enabled = false;
            btn_discard_person.Enabled = false;
        }
        private void cb_gender_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            HasPersonDataChanged = true;
        }
        private void txt_input_fields_TextChanged(object sender, EventArgs e)
        {
            HasPersonDataChanged = true;
        }
        private bool HasPersonNationalNumberChanged()
        {
            return tb_national_no.Text.Trim() != currentPerson.NationalNumber;
        }
        private void date_ValueChanged(object sender, EventArgs e)
        {
            HasPersonDataChanged = true;
        }

        #endregion

        #region User Management UI Events and Methods

        // Current User Tab     ----------------------------------------------------------------------
        private void btn_discard_user_Click(object sender, EventArgs e)
        {
            if (HasUsernameChanged)
            {
                if (MessageBox.Show("Are you sure you want to discard changes?", "Confirm Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            HasUsernameChanged = false;

            LoadUserData();
            DisableUserInfoEditing();
        }
        private async void btn_save_user_Click(object sender, EventArgs e)
        {
            btn_save_user.Enabled = false;

            if (!HasUsernameChanged)
                return;

            if (!ValidateUsernameInput())
            {
                MessageBox.Show("Please correct the input field errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_save_person.Enabled = true;
                return;
            }

            try
            {
                User updatedUser = currentUser;
                updatedUser.Username = tb_username.Text;

                bool updateResult = await _userController.UpdateUserAsync(updatedUser);

                if (updateResult)
                {
                    MessageBox.Show("Username updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HasUsernameChanged = false;
                    DisableUserInfoEditing();
                }
                else
                {
                    MessageBox.Show("Failed to update username. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the username: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadUserData();
                btn_save_user.Enabled = true; // Re-enable button
            }
        }
        private void EnableUserInfoEditing(object sender, EventArgs e)
        {
            tb_username.Enabled = true;
            btn_discard_user.Enabled = true;
            btn_save_user.Enabled = true;
        }
        private void DisableUserInfoEditing()
        {
            tb_username.Enabled = false;
            btn_discard_user.Enabled = false;
            btn_save_user.Enabled = false;
        }
        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            HasUsernameChanged = true;
        }
        private async void btn_change_password_Click(object sender, EventArgs e)
        {
            btn_change_password.Enabled = false;

            if (!ValidatePasswordInput())
            {
                MessageBox.Show("Please correct the password fields errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_change_password.Enabled = true;
                return;
            }

            string currentPassword = tb_current_password.Text.Trim();
            string newPassword = tb_confirm_password.Text.Trim();

            try
            {
                var result = await _userController.ChangePasswordAsync(currentUser.UserId, currentPassword, newPassword);

                if (!result.Success)
                {
                    MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_change_password.Enabled = true;
                    return;
                }

                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_current_password.Text = string.Empty;
                tb_confirm_new_password.Text = string.Empty;
                tb_confirm_password.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while changing the password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TODO: Log ex.ToString() if needed
            }
            finally
            {
                btn_change_password.Enabled = true;
            }
        }


        // Users Management Tab ----------------------------------------------------------------------

        private async void LoadUsersAsync()
        {
            _usersList = (await _userController.GetAllUsersAsync()).ToList();
            BindUsersToGrid(_usersList);
        }
        private async void dgv_NewUserAdded(int newUserId)
        {
            try
            {
                User user = await _userController.GetUserByIdAsync(newUserId);
                _usersList.Add(user);
                BindUsersToGrid(_usersList);
            } catch(Exception ex)
            {
                MessageBox.Show(
                "An error occurred:\n" + ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }
        private async void dgv_UserUpdated(int userId)
        {
            try
            {
                User updatedUser = await _userController.GetUserByIdAsync(userId);
                int index = _usersList.FindIndex(u => u.UserId == userId);
                if (index != -1)
                {
                    _usersList[index] = updatedUser;
                    BindUsersToGrid(_usersList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                "An error occurred:\n" + ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }
        private void dgv_UserDeleted(int userId)
        {
            try
            {
                int index = _usersList.FindIndex(u => u.UserId == userId);
                if (index != -1)
                {
                    _usersList.RemoveAt(index);
                    BindUsersToGrid(_usersList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                "An error occurred:\n" + ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }
        private void BindUsersToGrid(IEnumerable<User> users)
        {
            dgv_users.Rows.Clear();
            foreach (User user in users)
            {
                dgv_users.Rows.Add(
                    user.UserId,
                    user.PersonId,
                    user.Username,
                    user.IsActive
                );
            }

            lb_footer_text_users.Text = "Total Number of Users: " + dgv_users.RowCount.ToString();
        }
        private void AddNewUser()
        {
            Add_Edit_User user_pop_up = new Add_Edit_User(null);
            user_pop_up.ClosingEvent = dgv_NewUserAdded;
            user_pop_up.ShowDialog(this.FindForm());
        }
        private void uc_users_topbar_FilterPerformed(object sender, FilterArgs e)
        {
            var filtered = _usersList.Where(user =>
            {
                switch (e.FilterCriteria)
                {
                    case "Username":
                        return user.Username.Contains(e.SearchText);
                    case "Active Status":
                        bool status = e.SearchText == "1";
                        return user.IsActive == status;
                    default:
                        return true;
                }
            }).ToList();

            BindUsersToGrid(filtered);
        }

        #region DataGridView Events - Context Menue Stripe

        private void tsmi_View_Click(object sender, EventArgs e)
        {
            if (dgv_users.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedUserId = Convert.ToInt32(dgv_users.SelectedRows[0].Cells["user_id"].Value);
            Show_User_Details show_User_Details = new Show_User_Details(selectedUserId);
            show_User_Details.Show(this.FindForm());
        }
        private void tsmi_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_users.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedUserId = Convert.ToInt32(dgv_users.SelectedRows[0].Cells["user_id"].Value);
            Add_Edit_User user_pop_up = new Add_Edit_User(selectedUserId);
            user_pop_up.ClosingEvent = dgv_UserUpdated;
            user_pop_up.ShowDialog(this.FindForm());
        }
        private async void tsmi_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_users.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedUserId = Convert.ToInt32(dgv_users.SelectedRows[0].Cells["user_id"].Value);
            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool result = await _userController.DeleteUserAsync(selectedUserId);
                if (result)
                {
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_UserDeleted(selectedUserId); // Update the data grid
                }
                else
                {
                    MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #endregion

        #region Input Validation

        // Each validation function checks a specific input field and sets an error message if validation fails.

        private bool ValidateNationalNumber()
        {
            string input = tb_national_no.Text.Trim();
            if (!InputValidation.IsNotEmpty(input, out string errorMessage))
            {
                err_input_validation.SetError(tb_national_no, errorMessage);
                return false;
            }

            err_input_validation.SetError(tb_national_no, string.Empty);
            return true;
        }
        private bool ValidateFirstName()
        {
            string input = tb_first_name.Text.Trim();
            if (!InputValidation.IsNotEmpty(input, out string errorMessage))
            {
                err_input_validation.SetError(tb_first_name, errorMessage);
                return false;
            }
            if (!InputValidation.IsAlphaWithSpaces(input, out errorMessage))
            {
                err_input_validation.SetError(tb_first_name, errorMessage);
                return false;
            }
            err_input_validation.SetError(tb_first_name, string.Empty);
            return true;
        }
        private bool ValidateSecondName()
        {
            string input = tb_second_name.Text.Trim();
            if (!string.IsNullOrEmpty(input) && !InputValidation.IsAlphaWithSpaces(input, out string errorMessage))
            {
                err_input_validation.SetError(tb_second_name, errorMessage);
                return false;
            }
            err_input_validation.SetError(tb_second_name, string.Empty);
            return true;
        }
        private bool ValidateThirdName()
        {
            string input = tb_third_name.Text.Trim();
            if (!string.IsNullOrEmpty(input) && !InputValidation.IsAlphaWithSpaces(input, out string errorMessage))
            {
                err_input_validation.SetError(tb_third_name, errorMessage);
                return false;
            }
            err_input_validation.SetError(tb_third_name, string.Empty);
            return true;
        }
        private bool ValidateLastName()
        {
            string input = tb_last_name.Text.Trim();
            if (!InputValidation.IsNotEmpty(input, out string errorMessage))
            {
                err_input_validation.SetError(tb_last_name, errorMessage);
                return false;
            }
            if (!InputValidation.IsAlphaWithSpaces(input, out errorMessage))
            {
                err_input_validation.SetError(tb_last_name, errorMessage);
                return false;
            }
            err_input_validation.SetError(tb_last_name, string.Empty);
            return true;
        }
        private bool ValidateDateOfBirth()
        {
            DateTime input = dtp_date_of_birth.Value;
            if (input > DateTime.Now)
            {
                err_input_validation.SetError(dtp_date_of_birth, "Date of Birth must be in the past.");
                return false;
            }
            err_input_validation.SetError(dtp_date_of_birth, string.Empty);
            return true;
        }
        private bool ValidateEmail()
        {
            string input = tb_email.Text.Trim();
            if (!string.IsNullOrEmpty(input) && !InputValidation.IsEmail(input, out string errorMessage))
            {
                err_input_validation.SetError(tb_email, errorMessage);
                return false;
            }
            err_input_validation.SetError(tb_email, string.Empty);
            return true;
        }
        private bool ValidatePhoneNumber()
        {
            string input = tb_phone.Text.Trim();
            if (!InputValidation.IsNotEmpty(input, out string errorMessage))
            {
                err_input_validation.SetError(tb_phone, errorMessage);
                return false;
            }
            if (!InputValidation.IsPhoneNumber(input, out errorMessage))
            {
                err_input_validation.SetError(tb_phone, errorMessage);
                return false;
            }
            err_input_validation.SetError(tb_phone, string.Empty);
            return true;
        }
        private bool ValidateCountry()
        {
            string input = cb_country.Text.Trim();
            if (!InputValidation.IsNotEmpty(input, out string errorMessage))
            {
                err_input_validation.SetError(cb_country, errorMessage);
                return false;
            }
            if (!InputValidation.IsAlphaWithSpaces(input, out errorMessage))
            {
                err_input_validation.SetError(cb_country, errorMessage);
                return false;
            }
            err_input_validation.SetError(cb_country, string.Empty);
            return true;
        }
        private bool ValidateAddress()
        {
            string input = rtb_address.Text.Trim();
            if (!InputValidation.IsNotEmpty(input, out string errorMessage))
            {
                err_input_validation.SetError(rtb_address, errorMessage);
                return false;
            }
            err_input_validation.SetError(rtb_address, string.Empty);
            return true;
        }
        private bool ValidatePersonInputs()
        {
            return ValidateFirstName() &&
                   ValidateSecondName() &&
                   ValidateThirdName() &&
                   ValidateLastName() &&
                   ValidateDateOfBirth() &&
                   ValidateEmail() &&
                   ValidatePhoneNumber() &&
                   ValidateCountry() &&
                   ValidateAddress() &&
                   ValidateNationalNumber();
        }
        private bool ValidateUsernameInput()
        {
            string input = tb_username.Text.Trim();
            if (!InputValidation.IsNotEmpty(input, out string errorMessage))
            {
                err_input_validation.SetError(tb_username, errorMessage);
                return false;
            }
            if (!InputValidation.IsAlphanumeric(input, out errorMessage))
            {
                err_input_validation.SetError(tb_username, errorMessage);
                return false;
            }
            if (!InputValidation.IsWithinLength(input, 3, 20, out errorMessage))
            {
                err_input_validation.SetError(tb_username, errorMessage);
                return false;
            }
            err_input_validation.SetError(tb_username, string.Empty);
            return true;
        }
        private bool ValidatePasswordInput()
        {
            string newPassword = tb_current_password.Text;
            string confirmPassword = tb_confirm_password.Text;
            if (!InputValidation.IsNotEmpty(newPassword, out string errorMessage))
            {
                err_input_validation.SetError(tb_current_password, errorMessage);
                return false;
            }
            if (!InputValidation.IsPassword(newPassword, out errorMessage))
            {
                err_input_validation.SetError(tb_current_password, errorMessage);
                return false;
            }
            if (newPassword != confirmPassword)
            {
                err_input_validation.SetError(tb_confirm_password, "Passwords do not match.");
                return false;
            }
            err_input_validation.SetError(tb_current_password, string.Empty);
            return true;
        }


        #endregion


    }
}
