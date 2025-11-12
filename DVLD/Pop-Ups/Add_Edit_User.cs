using Core.Enums;
using Core.Models;
using DVLD.Views.Components;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Pop_Ups
{
    public partial class Add_Edit_User : RoundedBaseForm
    {
        public Action<int> ClosingEvent;

        private readonly PersonController _personController;
        private readonly UserController _userController;
        private enum State { Add = 1, Update = 2 }
        private State state;

        private User _user;
        private int _personId;
        private bool isPersonSelected = false;

        public Add_Edit_User(int? id)
        {
            InitializeComponent();

            _personController = new PersonController(new PersonRepository());
            _userController = new UserController(new UserRepository());

            if (id == null)
            {
                state = State.Add;
                lb_title.Text = "Add New User";
                lb_password_1.Text = "Password:";
                lb_password_2.Text = "Confirm Password:";

                lb_password_3.Visible = false;
                txt_password_3.Visible = false;
            }
            else
            {
                state = State.Update;
                lb_title.Text = "Edit User Info";
                cb_filter.Visible = false;
                txt_search.Visible = false;
                btn_search.Visible = false;

                lb_password_1.Text = "Current Password:";
                lb_password_2.Text = "New Password:";
                lb_password_3.Text = "Confirm Password:";

                _user = _userController.GetUserByIdAsync(id.Value).Result;
                _personId = _user.PersonId;
                isPersonSelected = true;
                personDetailsCard.SetPerson(_user.PersonId);

                lb_user_id.Text = _user.UserId.ToString();
                txt_username.Text = _user.Username;
                chk_is_active.Checked = _user.IsActive;
            }
        }
        private void Add_Edit_User_Load(object sender, EventArgs e)
        {
            object[] filters = { "Person ID", "National Number" };
            cb_filter.Items.Add(filters);
        }


        #region Help Functions


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

        #region UI Events
        private void btn_search_Click(object sender, EventArgs e)
        {
            btn_search.Enabled = false; // Disable button to prevent multiple clicks
            if (!ValidateSearchTerm())
                return;

            switch (cb_filter.SelectedItem)
            {
                case "Person ID":
                    int personId = int.Parse(txt_search.Text.Trim());
                    var personById = _personController.GetPersonByIdAsync(personId).Result;
                    if (personById == null)
                    {
                        MessageBox.Show("No person found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    personDetailsCard.SetPerson(personById.PersonId);
                    _personId = personById.PersonId;
                    isPersonSelected = true;
                    break;
                case "National Number":
                    string nationalNumber = txt_search.Text.Trim();
                    var personByNationalNumber = _personController.GetPersonByNationalNumberAsync(nationalNumber).Result;
                    if (personByNationalNumber == null)
                    {
                        MessageBox.Show("No person found with the given National Number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    personDetailsCard.SetPerson(personByNationalNumber.PersonId);
                    _personId = personByNationalNumber.PersonId;
                    isPersonSelected = true;
                    break;
            }
        }

        private async void btn_save_MouseClick(object sender, MouseEventArgs e)
        {
            btn_save.Enabled = false;

            try
            {
                // Validate inputs
                if (!isPersonSelected || !ValidateUsernameInput() || !ValidatePasswordInput(txt_password_2.Text))
                {
                    MessageBox.Show("Please ensure all fields are correctly filled and a person is selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_save.Enabled = true;
                    return;
                }

                User userToSave = new User
                {
                    UserId = state == State.Update ? _user.UserId : 0,
                    PersonId = _personId,
                    Username = txt_username.Text.Trim(),
                    Password = txt_password_2.Text,
                    IsActive = chk_is_active.Checked
                };

                var result = await _userController.SaveUserAsync(userToSave, state == State.Add);

                if (!result.Success)
                {
                    MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_save.Enabled = true;
                    return;
                }

                if (state == State.Add)
                {
                    MessageBox.Show($"User added successfully with ID: {result.UserId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClosingEvent?.Invoke(result.UserId.Value);
                }
                else
                {
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClosingEvent?.Invoke(userToSave.UserId);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TODO: Log ex.ToString() if needed
            }
            finally
            {
                btn_save.Enabled = true;
            }
        }

        private void btn_Exit_Clicked(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit without saving?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            this.Dispose();
        }

        #endregion


        #region Input Validation

        // Each validation function checks a specific input field and sets an error message if validation fails.

        private bool ValidateSearchTerm()
        {
            string input = txt_search.Text.Trim();
            string errorMessage;

            switch (cb_filter.SelectedItem)
            {
                case "Person ID":
                    if (!InputValidation.IsNumber(input, out errorMessage) || !InputValidation.IsNotEmpty(input, out errorMessage))
                    {
                        err_input_validation.SetError(txt_search, errorMessage);
                        return false;
                    }
                    break;
                case "National Number":
                    if (!InputValidation.IsNotEmpty(input, out errorMessage))
                    {
                        err_input_validation.SetError(txt_search, errorMessage);
                        return false;
                    }
                    break;
                default:
                    err_input_validation.SetError(txt_search, "Please select a valid filter.");
                    return false;
            }

            err_input_validation.SetError(txt_search, string.Empty);
            return true;
        }
        private bool ValidateUsernameInput()
        {
            string input = txt_username.Text.Trim();
            if (!InputValidation.IsNotEmpty(input, out string errorMessage))
            {
                err_input_validation.SetError(txt_username, errorMessage);
                return false;
            }
            if (!InputValidation.IsAlphanumeric(input, out errorMessage))
            {
                err_input_validation.SetError(txt_username, errorMessage);
                return false;
            }
            if (!InputValidation.IsWithinLength(input, 3, 20, out errorMessage))
            {
                err_input_validation.SetError(txt_username, errorMessage);
                return false;
            }
            err_input_validation.SetError(txt_username, string.Empty);
            return true;
        }
        private bool ValidatePasswordInput(string password_1)
        {
            string password1 = txt_password_1.Text;
            string password2 = txt_password_2.Text;
            string password3 = txt_password_3.Text;
            if (!InputValidation.IsNotEmpty(password1, out string errorMessage))
            {
                err_input_validation.SetError(txt_password_1, errorMessage);
                return false;
            }
            if (!InputValidation.IsPassword(password1, out errorMessage))
            {
                err_input_validation.SetError(txt_password_1, errorMessage);
                return false;
            }
            if (password1 != password2)
            {
                err_input_validation.SetError(txt_password_2, "Passwords do not match.");
                return false;
            }

            if(state == State.Update)
            {
                if (!InputValidation.IsNotEmpty(password3, out errorMessage))
                {
                    err_input_validation.SetError(txt_password_3, errorMessage);
                    return false;
                }
                if (password2 != password3)
                {
                    err_input_validation.SetError(txt_password_3, "New passwords do not match.");
                    return false;
                }
            }

            err_input_validation.SetError(txt_password_1, string.Empty);
            return true;
        }

        #endregion

        #region Mouse Events for Dragging the Form

        /* These events are linked to the header panel to allow dragging the form by the header.
         * They call the base class methods to handle the dragging logic.
         */

        private void pl_header_MouseDown(object sender, MouseEventArgs e)
        {
            base.RoundedBaseForm_MouseDown(sender, e);
        }

        private void pl_header_MouseMove(object sender, MouseEventArgs e)
        {
            base.RoundedBaseForm_MouseMove(sender, e);
        }

        private void pl_header_MouseUp(object sender, MouseEventArgs e)
        {
            base.RoundedBaseForm_MouseUp(sender, e);
        }


        #endregion

    }
}
