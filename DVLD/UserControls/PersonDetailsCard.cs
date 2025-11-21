using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Models;
using DVLD.Pop_Ups;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;

namespace DVLD.UserControls
{
    public partial class PersonDetailsCard : UserControl
    {
        private PersonController _personController;

        private Person _person;

        public PersonDetailsCard()
        {
            InitializeComponent();
            lb_edit.Visible = false; // Hide edit label initially

            _personController = new PersonController(new PersonRepository());
        }

        private void UpdateUI()
        {
            if (_person == null)
                return;

            lb_person_id.Text = _person.PersonId.ToString();
            lb_national_no.Text = _person.NationalNumber;
            lb_name.Text = string.Join(" ", _person.FirstName, _person.SecondName ?? " ", _person.ThirdName ?? " ", _person.LastName);
            lb_date_of_birth.Text = _person.DateOfBirth.ToShortDateString();
            lb_gender.Text = _person.enGender.ToString();
            lb_email.Text = _person.Email;
            lb_phone.Text = _person.Phone;
            lb_country.Text = _person.NationalityCountry.CountryName;
            lb_address.Text = _person.Address;

            rpb_profile_image.Image = _person.PersonalImage != null
                ? System.Drawing.Image.FromStream(new System.IO.MemoryStream(_person.PersonalImage))
                : img_list_default_profile.Images[Convert.ToInt16(_person.enGender)];
            
            lb_edit.Visible = true;
        }
        public async void SetPerson(int personId)
        {
            try
            {
                _person = await _personController.GetPersonByIdAsync(personId);
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching person details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async void SetPerson(string nationalNo)
        {
            try
            {
                _person = await _personController.GetPersonByNationalNumberAsync(nationalNo);
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching person details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lb_edit_Click(object sender, System.EventArgs e)
        {
            Add_Edit_Person edit_person = new Add_Edit_Person(_person.PersonId);
            edit_person.ClosingEvent += RefreshPersonDetails;
            edit_person.Show(this.FindForm());
        }
        private void RefreshPersonDetails(int personId)
        {
            SetPerson(personId);
        }
    }
}
