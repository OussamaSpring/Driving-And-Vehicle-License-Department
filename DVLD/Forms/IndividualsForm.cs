using Core.Models;
using DVLD.UserControls;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Pop_Ups;

namespace DVLD.Forms
{
    public partial class IndividualsForm : Form
    {
        private PersonController _personController;
        private DriverController _driverController;

        private List<Person> _peopleList = new List<Person>();
        private List<Driver> _driversList = new List<Driver>();

        public IndividualsForm()
        {
            InitializeComponent();

            var tabs = new TabBar
            {
                Dock = DockStyle.Fill,
                Height = 50
            };
            tabs.SetTabs("People", "Drivers");
            tabs.SelectedIndexChanged += (s, e) =>
            {
                switch (tabs.SelectedIndex)
                {
                    case 0:
                        OnPeopleTabSelected();
                        break;
                    case 1:
                        OnDriversTabSelected();
                        break;
                }
            };

            tlp_header.Controls.Add(tabs, 1, 0);



            _personController = new PersonController(new PersonRepository());
            _driverController = new DriverController(new DriverRepository());
        }

        private void IndividualsForm_Load(object sender, EventArgs e)
        {
            OnPeopleTabSelected();

            // Person top bar settings
            uc_person_topbar.AddButtonClicked = AddNewPerson;
            uc_person_topbar.FillFilterCriteria(_personController.GetPersonFilterCriteria());
            uc_person_topbar.FilterPerformed = Uc_person_topbar_FilterPerformed;

            // Driver top bar settings
            uc_driver_topbar.btn_add_Hide();
            uc_driver_topbar.FillFilterCriteria(_driverController.GetDriverFilterCriteria());
            uc_driver_topbar.FilterPerformed = Uc_driver_topbar_FilterPerformed;

        }
        private async void OnPeopleTabSelected()
        {
            htc_tab_nav.SelectedIndex = 0; // Select the "People" tab
            await LoadPeopleAsync();
        }
        private async void OnDriversTabSelected()
        {
            htc_tab_nav.SelectedIndex = 1; // Select the "Drivers" tab
            await LoadDriversAsync();
        }


        #region People Functions

        private async Task LoadPeopleAsync()
        {
            _peopleList = (await _personController.GetPeopleListAsync()).ToList();
            BindPeopleToGrid(_peopleList);
        }
        private void BindPeopleToGrid(IEnumerable<Person> people)
        {
            dgv_people.Rows.Clear();

            foreach (Person person in people)
            {
                dgv_people.Rows.Add(
                    person.PersonId,
                    person.NationalNumber,
                    person.FirstName,
                    person.SecondName,
                    person.ThirdName,
                    person.LastName,
                    person.enGender == Core.Enums.Genders.Male ? "Male" : "Female",
                    person.DateOfBirth.ToString("yyyy/M/dd"),
                    person.NationalityCountry.CountryName,
                    person.Phone,
                    person.Email
                );
            }
            lb_footer_text.Text = "Total Number of People: " + dgv_people.RowCount.ToString();
        }
        private void Uc_person_topbar_FilterPerformed(object sender, FilterArgs e)
        {
            var filtered = _peopleList.Where(person =>
            {
                switch (e.FilterCriteria)
                {
                    case "Person ID":
                        return person.PersonId.ToString().Contains(e.SearchText);
                    case "National No.":
                        return person.NationalNumber?.Contains(e.SearchText) == true;
                    case "First Name":
                        return person.FirstName != null && person.FirstName.ToLower().Contains(e.SearchText.ToLower());
                    case "Second Name":
                        return person.SecondName != null && person.SecondName.ToLower().Contains(e.SearchText.ToLower());
                    case "Third Name":
                        return person.ThirdName != null && person.ThirdName.ToLower().Contains(e.SearchText.ToLower());
                    case "Last Name":
                        return person.LastName != null && person.LastName.ToLower().Contains(e.SearchText.ToLower());
                    case "Nationality":
                        return person.NationalityCountry != null && person.NationalityCountry.CountryName.ToLower().Contains(e.SearchText.ToLower());
                    case "Gender":
                        var genderStr = person.enGender == Core.Enums.Genders.Male ? "Male" : "Female";
                        return genderStr.ToLower().Contains(e.SearchText.ToLower());
                    case "Phone":
                        return person.Phone != null && person.Phone.Contains(e.SearchText);
                    case "Email":
                        return person.Email != null && person.Email.ToLower().Contains(e.SearchText.ToLower());

                    default:
                        return true;
                }
            }).ToList();

            BindPeopleToGrid(filtered);
        }
        private void AddNewPerson()
        {
            Add_Edit_Person person_pop_up = new Add_Edit_Person(null);
            person_pop_up.ClosingEvent = dgv_NewPersonAdded;
            person_pop_up.ShowDialog();
        }
        private async void dgv_NewPersonAdded(int newPersonId)
        {
            try
            {
                Person newPerson = await _personController.GetPersonByIdAsync(newPersonId);
                _peopleList.Add(newPerson);
                BindPeopleToGrid(_peopleList);
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
        private async void dgv_PersonUpdated(int updatedPersonId)
        {
            try
            {
                Person updatedPerson = await _personController.GetPersonByIdAsync(updatedPersonId);
                int index = _peopleList.FindIndex(p => p.PersonId == updatedPersonId);
                if (index != -1)
                {
                    _peopleList[index] = updatedPerson;
                    BindPeopleToGrid(_peopleList);
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
        private void dgv_PersonDeleted(int deletedPersonId)
        {
            try
            {
                int index = _peopleList.FindIndex(p => p.PersonId == deletedPersonId);

                if (index != -1)
                {
                    _peopleList.RemoveAt(index);
                    BindPeopleToGrid(_peopleList);
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

        #region DataGridView Events - Context Menue Stripe

        private void tsmi_View_Click(object sender, EventArgs e)
        {
            if (dgv_people.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a person to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedPersonId = Convert.ToInt32(dgv_people.SelectedRows[0].Cells["person_id"].Value);
            Show_Person_Details show_Person_Details = new Show_Person_Details(selectedPersonId);
            show_Person_Details.Show(this.FindForm());
        }
        private void tsmi_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_people.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a person to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedPersonId = Convert.ToInt32(dgv_people.SelectedRows[0].Cells["person_id"].Value);
            Add_Edit_Person editPersonPopUp = new Add_Edit_Person(selectedPersonId);
            editPersonPopUp.ClosingEvent = dgv_PersonUpdated;
            editPersonPopUp.ShowDialog(this.FindForm());
        }
        private async void tsmi_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_people.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a person to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int selectedPersonId = Convert.ToInt32(dgv_people.SelectedRows[0].Cells["person_id"].Value);

            try
            {
                if (MessageBox.Show("Are you sure you want to delete the selected person?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool result = await _personController.DeletePersonAsync(selectedPersonId);

                    if (result)
                    {
                        MessageBox.Show("Person deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv_PersonDeleted(selectedPersonId);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while deleting the person:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        #endregion

        #endregion

        #region Drivers Functions

        private async Task LoadDriversAsync()
        {
            _driversList = (await _driverController.GetAllDriversAsync()).ToList();
            BindDriversToGrid(_driversList);
        }
        private void BindDriversToGrid(IEnumerable<Driver> drivers)
        {
            dgv_drivers.Rows.Clear();

            foreach (Driver driver in drivers)
            {
                dgv_drivers.Rows.Add(
                    driver.DriverId,
                    driver.DriverPersonId,
                    driver.NationalNumber,
                    driver.FullName,
                    driver.CreateDate.ToString("yyyy/M/dd"),
                    driver.ActiveLicensesCount,
                    driver.CreatedByUserId
                    );
            }
            lb_footer_text_driver.Text = "Total Number of Drivers: " + dgv_drivers.RowCount.ToString();
        }
        private void Uc_driver_topbar_FilterPerformed(object sender, FilterArgs e)
        {
            var filtered = _driversList.Where(driver =>
            {
                switch (e.FilterCriteria)
                {
                    case "Driver ID":
                        return driver.DriverId.ToString().Contains(e.SearchText);
                    case "Person ID":
                        return driver.DriverPersonId.ToString().Contains(e.SearchText);
                    case "National No.":
                        return driver.NationalNumber != null && driver.NationalNumber.Contains(e.SearchText);
                    case "Full Name":
                        return driver.FullName != null && driver.FullName.ToLower().Contains(e.SearchText.ToLower());
                    default:
                        return true;
                }
            }).ToList();

            BindDriversToGrid(filtered);
        }


        #region DataGridView Events - Context Menue Stripe

        private void tsmi_ViewPersonInfo_Click(object sender, EventArgs e)
        {
            if (dgv_drivers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a driver to view personal information.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int selectedDriverPersonId = Convert.ToInt32(dgv_drivers.SelectedRows[0].Cells["driver_person_id"].Value);
            Show_Person_Details show_Person_Details = new Show_Person_Details(selectedDriverPersonId);
            show_Person_Details.Show(this.FindForm());
        }

        private void tsmi_ShowLicenseHistory_Click(object sender, EventArgs e)
        {
            if(dgv_drivers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a driver to view license history.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int selectedDriverPersonId = Convert.ToInt32(dgv_drivers.SelectedRows[0].Cells["driver_person_id"].Value);
            Show_Person_License_History show_Person_License_History = new Show_Person_License_History(selectedDriverPersonId);
            show_Person_License_History.Show(this.FindForm());
        }

        private void tsmi_IssueInternationalLicense_Click(object sender, EventArgs e)
        {
            if (dgv_drivers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a driver to view personal information.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Feature under development.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #endregion


    }
}
