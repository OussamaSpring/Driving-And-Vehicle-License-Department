using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Models;
using DVLD.Pop_Ups;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;

namespace DVLD.UserControls
{
    public partial class DriverLicenseCard : UserControl
    {
        private readonly LicenseController _licenseController;
        private readonly DriverController _dirverController;
        private readonly PersonController _personController;
        private readonly LicenseDetainController _licenseDetainController;

        private License _driverLicense;
        private Driver _driver;
        private Person _person;
        private bool _isDetained = false;


        public DriverLicenseCard()
        {
            InitializeComponent();

            _licenseController = new LicenseController(new LicenseRepository());
            _dirverController = new DriverController(new DriverRepository());
            _personController = new PersonController(new PersonRepository());
            _licenseDetainController = new LicenseDetainController(new LicenseDetainRepository());
        }


        private void UpdateUI()
        {
            if(_driverLicense == null || _driver == null || _person == null)
                return;

            lb_license_id.Text = _driverLicense.LicenseId.ToString();
            lb_license_class.Text = _licenseController.GetLicenseClassNameById(_driverLicense.ClassId);
            lb_is_detained.Text = _isDetained ? "Yes" : "No";
            lb_driver_id.Text = _driver.DriverId.ToString();
            lb_name.Text = string.Join(" ", _person.FirstName, _person.SecondName ?? " ", _person.ThirdName ?? " ", _person.LastName);
            lb_date_of_birth.Text = _person.DateOfBirth.ToShortDateString();
            lb_gender.Text = _person.enGender.ToString();
            lb_national_number.Text = _person.NationalNumber;
            lb_is_active.Text = _driverLicense.IsActive ? "Yes" : "No";
            lb_issue_date.Text = _driverLicense.IssueDate.ToShortDateString();
            lb_issue_reason.Text = _driverLicense.enIssuesReason.ToString();
            lb_expiration_date.Text = _driverLicense.ExpirationDate.ToShortDateString();
            lb_notes.Text = _driverLicense.Notes ?? "N/A";
        }

        public async void SetDriverLicense(int licenseId)
        {
            try
            {
                _driverLicense = await _licenseController.GetLicenseByIdAsync(licenseId);
                _driver = await _dirverController.GetDriverByIdAsync(_driverLicense.DriverId);
                _person = await _personController.GetPersonByIdAsync(_driver.DriverPersonId);
                _isDetained = await _licenseDetainController.IsLicenseDetainedAsync(licenseId);

                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching driver license details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TODO: Log exception
            }

        }


    }
}
