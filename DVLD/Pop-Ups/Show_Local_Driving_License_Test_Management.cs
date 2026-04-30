using Core.Models;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System.Globalization;
using System.Windows.Forms;
using Core.Enums;
using System;

namespace DVLD.Pop_Ups
{
    public partial class Local_Driving_License_Test_Management : Form
    {
        private ApplicationsController _applicationsController;

        private int _LDL_Id;
        private LocalDrivingLicenseApplication _localDrivingLicenseApplication;
        private TestTypes enSelectedTestType;

        public Local_Driving_License_Test_Management(int LDL_Id)
        {
            InitializeComponent();

            _LDL_Id = LDL_Id;

            _applicationsController = new ApplicationsController(new ApplicationsRepository(), new LicenseRepository(), new InternationalLicenseRepository());
        }

        private void Local_Driving_License_Test_Management_Load(object sender, EventArgs e)
        {
            personDetailsCard.SetPerson(_localDrivingLicenseApplication.NationalNumber);
            LoadLocalDrivingLicenseApplication();
            enSelectedTestType = TestTypes.WrittenTest;
        }
        private void MapDataToUI()
        {
            if (_localDrivingLicenseApplication != null)
            {
                lb_app_class.Text = _localDrivingLicenseApplication.LicenseClass.Name;
                lb_app_date.Text = _localDrivingLicenseApplication.ApplicationDate.ToShortDateString();
                lb_app_status.Text = _localDrivingLicenseApplication.Status.ToString();
                lb_license_fees.Text = _localDrivingLicenseApplication.LicenseClass.ClassFees.ToString("C", CultureInfo.GetCultureInfo("en-us"));
                lb_passed_tests.Text = _localDrivingLicenseApplication.PassedTest.ToString();
            }
        }
        private async void LoadLocalDrivingLicenseApplication()
        {
            _localDrivingLicenseApplication = await _applicationsController.GetLocalDrivingLicenseApplicationByIdAsync(_LDL_Id);
            MapDataToUI();
        }




        #region Tests Appointments Tabs Control
        private void tc_test_appointments_Selecting(object sender, TabControlCancelEventArgs e)
        {

            if (e.TabPage == tp_written_test && _localDrivingLicenseApplication.PassedTest < 1)
            {
                e.Cancel = false;
                MessageBox.Show("The applicant must pass the written test before proceeding to the vision test.", "Test Requirement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.TabPage == tp_street_test && _localDrivingLicenseApplication.PassedTest < 2)
            {
                e.Cancel = false;
                MessageBox.Show("The applicant must pass both the written and the vision test before proceeding to the street test.", "Test Requirement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void tc_test_appointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tc_test_appointments.SelectedTab.Name)
            {
                case "tp_written_test":
                    enSelectedTestType = TestTypes.WrittenTest;
                    break;
                case "tp_vision_test":
                    enSelectedTestType = TestTypes.VisionTest;
                    break;
                case "tp_street_test":
                    enSelectedTestType = TestTypes.StreetTest;
                    break;
            }
        }
        private void btn_schedule_test_Click(object sender, EventArgs e)
        {

            // in switch case, we check first if he can schedule or not, if not, we show a message box with the reason, if yes, we open the schedule test form

            //switch(enSelectedTestType)
            //{
            //    case TestTypes.WrittenTest:
            //        Schedule_Test scheduleWrittenTest = new Schedule_Test(_localDrivingLicenseApplication, TestTypes.WrittenTest);
            //        scheduleWrittenTest.ShowDialog(this);
            //        break;
            //    case TestTypes.VisionTest:
            //        Schedule_Test scheduleVisionTest = new Schedule_Test(_localDrivingLicenseApplication, TestTypes.VisionTest);
            //        scheduleVisionTest.ShowDialog(this);
            //        break;
            //    case TestTypes.StreetTest:
            //        Schedule_Test scheduleStreetTest = new Schedule_Test(_localDrivingLicenseApplication, TestTypes.StreetTest);
            //        scheduleStreetTest.ShowDialog(this);
            //        break;
            //}
        }

        #endregion
    }
}
