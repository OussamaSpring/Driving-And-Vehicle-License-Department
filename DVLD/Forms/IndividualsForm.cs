using Core.Models;
using DVLD.UserControls;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            _personController = new PersonController(new PersonRepository());
            _driverController = new DriverController(new DriverRepository());


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


        }

        private void IndividualsForm_Load(object sender, EventArgs e)
        {
            OnPeopleTabSelected();

            // Person top bar settings
            uc_person_topbar.AddButtonClicked = AddNewPerson;
            uc_person_topbar.FillFilterCriteria(GetPersonFilterCriteria());
            uc_person_topbar.FilterPerformed = Uc_person_topbar_FilterPerformed;

            // Driver top bar settings
            uc_driver_topbar.btn_add_Hide();
            uc_driver_topbar.FillFilterCriteria(GetDriverFilterCriteria());
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
                    person.enGender == Core.Enums.Gender.Male ? "Male" : "Female",
                    person.DateOfBirth.ToString("yyyy/M/dd"),
                    person.NationalityCountry,
                    person.Phone,
                    person.Email
                );
            }
            lb_footer_text.Text = "Total Number of People: " + dgv_people.RowCount.ToString();
        }
        private void AddNewPerson()
        {
            MessageBox.Show("This feature will be available soon...", "Add New Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private List<string> GetPersonFilterCriteria()
        {
            var filterCriteria = new List<string>
            {
                "Person ID",
                "National No.",
                "First Name",
                "Second Name",
                "Third Name",
                "Last Name",
                "Nationality",
                "Gender",
                "Phone",
                "Email"
            };
            return filterCriteria;
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
                        return person.NationalityCountry != null && person.NationalityCountry.ToLower().Contains(e.SearchText.ToLower());
                    case "Gender":
                        var genderStr = person.enGender == Core.Enums.Gender.Male ? "Male" : "Female";
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
        private List<string> GetDriverFilterCriteria()
        {
            var filterCriteria = new List<string>
            {
                "Driver ID",
                "Person ID",
                "National No.",
                "Full Name"
            };
            return filterCriteria;
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
        
        #endregion
    }
}
