using Core.Models;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System.Globalization;
using System.Windows.Forms;
using Core.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVLD.Pop_Ups
{
    public partial class Local_Driving_License_Test_Management : Form
    {
        private readonly LocalDrivingLicenseApplicationController _ldlApplicationsController;
        private readonly TestAppointmentController _testAppointmentController;

        private readonly int _LDL_Id;
        private LocalDrivingLicenseApplication _localDrivingLicenseApplication;
        private TestTypes enSelectedTestType;

        private readonly Dictionary<TestTypes, List<TestAppointment>> _testAppointments = new Dictionary<TestTypes, List<TestAppointment>>();

        public Local_Driving_License_Test_Management(int LDL_Id)
        {
            InitializeComponent();
            _LDL_Id = LDL_Id;
            _ldlApplicationsController = new LocalDrivingLicenseApplicationController(new LocalDrivingLicenseApplicationRepository(), new LicenseRepository());
            _testAppointmentController = new TestAppointmentController(new TestAppointmentRepository());
        }

        private async void Local_Driving_License_Test_Management_Load(object sender, EventArgs e)
        {
            await LoadLocalDrivingLicenseApplicationAsync();
            enSelectedTestType = TestTypes.VisionTest;
            personDetailsCard.SetPerson(_localDrivingLicenseApplication?.NationalNumber);
        }

        private void MapDataToUI()
        {
            if (_localDrivingLicenseApplication == null) return;
            lb_app_class.Text = _localDrivingLicenseApplication.LicenseClass.Name;
            lb_app_date.Text = _localDrivingLicenseApplication.ApplicationDate.ToShortDateString();
            lb_app_status.Text = _localDrivingLicenseApplication.Status.ToString();
            lb_license_fees.Text = _localDrivingLicenseApplication.LicenseClass.ClassFees.ToString("C", CultureInfo.GetCultureInfo("en-us"));
            lb_passed_tests.Text = _localDrivingLicenseApplication.PassedTest.ToString();
        }

        private async Task LoadLocalDrivingLicenseApplicationAsync()
        {
            _localDrivingLicenseApplication = await _ldlApplicationsController.GetLocalDrivingLicenseApplicationByIdAsync(_LDL_Id);
            MapDataToUI();
            await LoadAllTestAppointmentsAsync();
        }

        private async Task LoadAllTestAppointmentsAsync()
        {
            await LoadTestAppointmentsAsync(TestTypes.VisionTest);
            await LoadTestAppointmentsAsync(TestTypes.WrittenTest);
            await LoadTestAppointmentsAsync(TestTypes.StreetTest);
        }

        private async Task LoadTestAppointmentsAsync(TestTypes testType)
        {
            if (_localDrivingLicenseApplication == null) return;
            var appointments = await _testAppointmentController.GetTestAppointmentsByLocalDrivingLicenseApplicationIdAndTestTypeIdAsync(_localDrivingLicenseApplication.LDL_ApplicationId, (int)testType);
            _testAppointments[testType] = new List<TestAppointment>(appointments);
            BindTestAppointmentsToUI(testType);
        }

        private void BindTestAppointmentsToUI(TestTypes testType)
        {
            List<TestAppointment> appointments = _testAppointments.ContainsKey(testType) ? _testAppointments[testType] : new List<TestAppointment>();
            switch (testType)
            {
                case TestTypes.VisionTest:
                    dgv_vision_test.Rows.Clear();
                    foreach (var apt in appointments)
                    {
                        dgv_vision_test.Rows.Add(
                            apt.TestAppointmentId,
                            apt.AppointmentDate.ToShortDateString(),
                            apt.PaidFees.ToString("C", CultureInfo.GetCultureInfo("en-us")),
                            apt.isLocked
                        );
                    }
                    lb_vision_test_number.Text = appointments.Count.ToString();
                    break;
                case TestTypes.WrittenTest:
                    dgv_written_test.Rows.Clear();
                    foreach (var apt in appointments)
                    {
                        dgv_written_test.Rows.Add(
                            apt.TestAppointmentId,
                            apt.AppointmentDate.ToShortDateString(),
                            apt.PaidFees.ToString("C", CultureInfo.GetCultureInfo("en-us")),
                            apt.isLocked
                        );
                    }
                    lb_written_test_number.Text = appointments.Count.ToString();
                    break;
                case TestTypes.StreetTest:
                    dgv_street_test.Rows.Clear();
                    foreach (var apt in appointments)
                    {
                        dgv_street_test.Rows.Add(
                            apt.TestAppointmentId,
                            apt.AppointmentDate.ToShortDateString(),
                            apt.PaidFees.ToString("C", CultureInfo.GetCultureInfo("en-us")),
                            apt.isLocked
                        );
                    }
                    lb_street_test_number.Text = appointments.Count.ToString();
                    break;
            }
        }

        #region Tests Appointments Tabs Control
        private void tc_test_appointments_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (_localDrivingLicenseApplication == null) { e.Cancel = true; return; }
            if (e.TabPage == tp_written_test && _localDrivingLicenseApplication.PassedTest < 1)
            {
                e.Cancel = true;
                MessageBox.Show("The applicant must pass the written test before proceeding to the vision test.", "Test Requirement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.TabPage == tp_street_test && _localDrivingLicenseApplication.PassedTest < 2)
            {
                e.Cancel = true;
                MessageBox.Show("The applicant must pass both the written and the vision test before proceeding to the street test.", "Test Requirement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                e.Cancel = false;
            }
        }

        private async void tc_test_appointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_test_appointments.SelectedTab == null) return;
            switch (tc_test_appointments.SelectedTab.Name)
            {
                case "tp_vision_test":
                    enSelectedTestType = TestTypes.VisionTest;
                    await LoadTestAppointmentsAsync(TestTypes.VisionTest);
                    break;
                case "tp_written_test":
                    enSelectedTestType = TestTypes.WrittenTest;
                    await LoadTestAppointmentsAsync(TestTypes.WrittenTest);
                    break;
                case "tp_street_test":
                    enSelectedTestType = TestTypes.StreetTest;
                    await LoadTestAppointmentsAsync(TestTypes.StreetTest);
                    break;
            }
        }

        private async void btn_schedule_test_Click(object sender, EventArgs e)
        {
            if (!await ValidateTestSchedulePermission(enSelectedTestType))
            {
                return;
            }

            var testScheduleForm = new Schedule_Test(_LDL_Id) { TestType = enSelectedTestType };
            testScheduleForm.ShowDialog(this);
            await LoadTestAppointmentsAsync(enSelectedTestType);
        }
        #endregion

        private async Task<bool> ValidateTestSchedulePermission(TestTypes testType)
        {
            return DoesPassedPreviousTests(testType) && !await DoesPassTestType(testType) && !await IsThereActiveAppointment(testType);
        }

        private bool DoesPassedPreviousTests(TestTypes testType)
        {
            bool doesPassPrevious = _localDrivingLicenseApplication != null && _localDrivingLicenseApplication.PassedTest >= (int)testType - 1;
            if(!doesPassPrevious)
            {
                MessageBox.Show($"You must pass the previous tests before scheduling a {testType} test.", "Test Requirement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return doesPassPrevious;


        }

        private async Task<bool> DoesPassTestType(TestTypes testType)
        {
            bool doesPassTest = await _ldlApplicationsController.DoesPassTestTypeAsync(_LDL_Id, (int)testType);
            if (doesPassTest)
            {
                MessageBox.Show($"The applicant has already passed the {testType} test.", "Already Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        private async Task<bool> IsThereActiveAppointment(TestTypes testType)
        {
            bool activeApp = await _ldlApplicationsController.IsThereActiveScheduledTestExistAsync(_LDL_Id, (int)testType);
            if (activeApp)
            {
                MessageBox.Show($"There is already an active appointment for the {testType} test.", "Active Appointment Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        private void tsmi_edit_Click(object sender, EventArgs e)
        {
            var dgv = GetCurrentTestDataGridView();

            if (dgv == null || dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgv.SelectedRows[0];
            int appointmentId = Convert.ToInt32(row.Cells[0].Value); // TestAppointmentId is the 1st column


            Schedule_Test editForm = new Schedule_Test(_LDL_Id, appointmentId) { TestType = enSelectedTestType };
            editForm.ShowDialog(this);
            _ = LoadTestAppointmentsAsync(enSelectedTestType);
        }

        private void tsmi_take_test_Click(object sender, EventArgs e)
        {
            var dgv = GetCurrentTestDataGridView();
            if (dgv == null || dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to take the test.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgv.SelectedRows[0];
            bool isLocked = Convert.ToBoolean(row.Cells[3].Value); // isLocked is the 4th column
            int appointmentId = Convert.ToInt32(row.Cells[0].Value); // TestAppointmentId is the 1st column

            if (isLocked)
            {
                MessageBox.Show("You cannot take a test for a locked appointment.", "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var takeTestForm = new Take_Test(appointmentId, enSelectedTestType);
            takeTestForm.ShowDialog(this);
            _ = LoadTestAppointmentsAsync(enSelectedTestType);
        }

        private DataGridView GetCurrentTestDataGridView()
        {
            switch (enSelectedTestType)
            {
                case TestTypes.VisionTest:
                    return dgv_vision_test;
                case TestTypes.WrittenTest:
                    return dgv_written_test;
                case TestTypes.StreetTest:
                    return dgv_street_test;
                default:
                    return null;
            }
        }
    }
}
