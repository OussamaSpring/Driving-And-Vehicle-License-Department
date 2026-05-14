using Core.Enums;
using Core.Models;
using DVLD.CustomForms;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Pop_Ups
{
    public partial class Add_Edit_Person : RoundedBaseForm
    {
        public Action<int> ClosingEvent;

        private readonly PersonController _personController;
        private enum State { Add = 1, Update = 2 }
        private State state;

        private Person _person;
        private bool HasImageChanged = false;
        private bool IsImageEmpty = true;
        private bool HasDataChanged = false;

        public Add_Edit_Person(int? id)
        {
            InitializeComponent();

            _personController = new PersonController(new PersonRepository());

            if (id == null)
            {
                state = State.Add;
                lb_title.Text = "Add New Person";
                lb_person_id.Text = "N/A";
                cb_gender.SelectedIndex = 0;
                rpb_profile_image.Image = img_list_default_profile.Images[0];
                lb_remove_image.Visible = false;
            }
            else
            {
                state = State.Update;
                lb_title.Text = "Edit Person Details";
                _person = new Person { PersonId = id.Value };
            }
        }

        private async void LoadPersonDetails(int personId)
        {
            _person = await _personController.GetPersonByIdAsync(personId);

            // Fill person details
            lb_person_id.Text = _person.PersonId.ToString();
            tb_national_no.Text = _person.NationalNumber;
            tb_first_name.Text = _person.FirstName;
            tb_second_name.Text = _person.SecondName ?? string.Empty;
            tb_third_name.Text = _person.ThirdName ?? string.Empty;
            tb_last_name.Text = _person.LastName;
            dtp_date_of_birth.Value = _person.DateOfBirth;
            cb_gender.SelectedIndex = Convert.ToInt16(_person.enGender);
            tb_email.Text = _person.Email ?? string.Empty;
            tb_phone.Text = _person.Phone;
            cb_country.SelectedIndex = cb_country.FindString(_person.NationalityCountry.CountryName);
            rtb_address.Text = _person.Address;
            rpb_profile_image.Image = ByteArrayToImage(_person.PersonalImage) ?? img_list_default_profile.Images[cb_gender.SelectedIndex];
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


        #region UI Events

        private async void Add_Edit_Person_Load(object sender, EventArgs e)
        {
            var countries = await _personController.GetAllCountriesAsync();

            if (countries != null)
            {
                cb_country.Items.Clear();
                foreach (var country in countries)
                {
                    cb_country.Items.Add(country.CountryName);
                }
                if (state == State.Add)
                    cb_country.SelectedIndex = 0;
            }

            if(state == State.Update)
            {
                try
                {
                    int personId = _person.PersonId;
                    LoadPersonDetails(personId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading person details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
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
            if(MessageBox.Show("Are you sure you want to remove the profile image?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            rpb_profile_image.Image = img_list_default_profile.Images[cb_gender.SelectedIndex];
            lb_remove_image.Visible = false;
            HasImageChanged = true;
            IsImageEmpty = true;
        }
        private async void btn_save_MouseClick(object sender, MouseEventArgs e)
        {
            btn_save.Enabled = false; // Disable button to prevent multiple clicks

            if (!(HasDataChanged || HasImageChanged) && state == State.Update)
            {
                this.Dispose();
                return;
            }

            if (!ValidateAllInputs())
            {
                MessageBox.Show("Please correct the input fields errors before saving.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_save.Enabled = true;
                return;
            }

            try
            {
                var person = await MapPersonData();
                if (state == State.Update)
                    person.PersonId = _person.PersonId;

                var result = await _personController.SavePersonAsync(person, state == State.Add, HasImageChanged);

                if (!result.Success)
                {
                    MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_save.Enabled = true;
                    return;
                }

                if (state == State.Add)
                {
                    MessageBox.Show($"Person added successfully with ID: {result.PersonId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClosingEvent?.Invoke(result.PersonId.Value);
                }
                else
                {
                    MessageBox.Show("Person details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClosingEvent?.Invoke(person.PersonId);
                }

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_save.Enabled = true;
            }
        }
        private void btn_Exit_Clicked(object sender, MouseEventArgs e)
        {
            if(!HasDataChanged && !HasImageChanged)
            {
                this.Dispose();
                return;
            }
            else if (MessageBox.Show("Are you sure you want to exit without saving?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            this.Dispose();
        }
        private void cb_gender_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(IsImageEmpty)
                rpb_profile_image.Image = img_list_default_profile.Images[cb_gender.SelectedIndex];
        }

        #endregion


        #region Input Validation

        // Each validation function checks a specific input field and sets an error message if validation fails.

        private bool ValidateNationalNumber()
        {
            string input = tb_national_no.Text.Trim();
            if (!InputValidation.IsAlphanumeric(input, out string errorMessage))
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
            if (!InputValidation.IsAlpha(input, out errorMessage))
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
            if (!string.IsNullOrEmpty(input) && !InputValidation.IsAlpha(input, out string errorMessage))
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
            if (!string.IsNullOrEmpty(input) && !InputValidation.IsAlpha(input, out string errorMessage))
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
            if (!InputValidation.IsAlpha(input, out errorMessage))
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
        private bool ValidateAllInputs()
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

        #endregion

        #region Track Data Changes
        private void cb_gender_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            HasDataChanged = true;
        }

        private void txt_input_fields_TextChanged(object sender, EventArgs e)
        {
            HasDataChanged = true;
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            HasDataChanged = true;
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
