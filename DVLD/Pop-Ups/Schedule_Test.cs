using Core.Models;
using Core.Enums;
using DVLD.CustomForms;
using System.Windows.Forms;
using System.Globalization;
using System;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using DVLD.Session;

namespace DVLD.Pop_Ups
{
    public partial class Schedule_Test : RoundedBaseForm
    {

        // Controllers
        private LocalDrivingLicenseApplicationController _localDrivingLicenseApplicationController;
        private TestTypeController _testTypeController;
        private ApplicationTypeController _applicationTypeController;
        private TestAppointmentController _testAppointmentController;
        private PersonController _personController;


        // Data
        private int _localDrivingLicenseApplicationId; // Set from constructor parameter
        private int _appointmentId; // Used for editing existing appointments, -1 for new appointments
        private LocalDrivingLicenseApplication _localDrivingLicenseApplication;
        private TestTypes _testType;
        private decimal _testFees;
        private int _totalTrials;
        private decimal _retakeTestAppFees;

        private TestAppointment _existingAppointment; // Used in edit mode to hold the existing appointment data

        // Schedule mode to determine if it's a first-time schedule or a retake schedule


        public TestTypes TestType
        {
            get => _testType;
            set
            {
                _testType = value;
                switch (_testType)
                {
                    case TestTypes.WrittenTest:
                        lb_test_type.Text = "Written Test";
                        pictureBox.Image = Properties.Resources.exam;
                        break;
                    case TestTypes.VisionTest:
                        lb_test_type.Text = "Vision (Theory) Test";
                        pictureBox.Image = Properties.Resources.eyetest;
                        break;
                    case TestTypes.StreetTest:
                        lb_test_type.Text = "Practical (Street) Test";
                        pictureBox.Image = Properties.Resources.driving_test;
                        break;
                }
            }
        }


        private enum ScheduleMode { FirstTimeSchedule = 1, RetakeSchedule = 2 }
        private ScheduleMode _scheduleMode;

        private enum Mode { Create = 1, Edit = 2 }
        private Mode _mode
        {
            get => field;
            set
            {
                field = value;
                switch (field)
                {
                    case Mode.Create:
                        lb_title.Text = "Schedule Test";
                        break;
                    case Mode.Edit:
                        lb_title.Text = "Edit Schedule";
                        break;
                }
            }
        }

        public Schedule_Test(int localDrivingLicenseApplicationId, int appointmentId = -1)
        {
            InitializeComponent();

            _localDrivingLicenseApplicationController = new LocalDrivingLicenseApplicationController(new LocalDrivingLicenseApplicationRepository(), new LicenseRepository());
            _testTypeController = new TestTypeController(new TestTypeRepository());
            _applicationTypeController = new ApplicationTypeController(new ApplicationTypeRepository());
            _testAppointmentController = new TestAppointmentController(new TestAppointmentRepository());
            _personController = new PersonController(new PersonRepository());

            _localDrivingLicenseApplicationId = localDrivingLicenseApplicationId;
            _appointmentId = appointmentId;
            _mode = _appointmentId == -1 ? Mode.Create : Mode.Edit;

        }

        private async void Schedule_Test_Load(object sender, EventArgs e)
        {
            // Always load the application using the constructor parameter
            _localDrivingLicenseApplication = await _localDrivingLicenseApplicationController.GetLocalDrivingLicenseApplicationByIdAsync(_localDrivingLicenseApplicationId);

            if (_mode == Mode.Edit)
            {
                _existingAppointment = await _testAppointmentController.GetTestAppointmentByIdAsync(_appointmentId);
                if (_existingAppointment != null)
                {
                    _testType = (TestTypes)_existingAppointment.TestType.TypeId;
                    _testFees = _existingAppointment.PaidFees;

                    if (_existingAppointment.isLocked)
                    {
                        dtp_test_schedule_date.Enabled = false;
                        lb_warning.Visible = true;
                    }
                    else
                    {
                        dtp_test_schedule_date.Enabled = true;
                        lb_warning.Visible = false;
                    }
                }

            }
            else
            {
                // _testType should be set externally before showing the form in create mode
                _testFees = await _testTypeController.GetTestFeeByIdAsync((int)_testType);
            }

            // Always get total trials after loading application and test type
            _totalTrials = await _localDrivingLicenseApplicationController.GetTotalTrialsPerTestAsync(_localDrivingLicenseApplication.LDL_ApplicationId, (int)_testType);


            _scheduleMode = _totalTrials > 0 ? ScheduleMode.RetakeSchedule : ScheduleMode.FirstTimeSchedule;

            // Only get retake fees if needed
            if (_scheduleMode == ScheduleMode.RetakeSchedule)
            {
                _retakeTestAppFees = await _applicationTypeController.GetApplicationTypeFeeByIdAsync((int)ApplicationTypes.RetakeTest);
            }

            MapData();
        }

        private void MapData()
        {
            lb_ldl_app_id.Text = _localDrivingLicenseApplication.ApplicationId.ToString();
            lb_license_class.Text = _localDrivingLicenseApplication.LicenseClass.Name;
            lb_person_name.Text = _localDrivingLicenseApplication.FullName;
            dtp_test_schedule_date.Value = DateTime.Now.AddDays(7); // Default to one week from now
            lb_trial_number.Text = (_totalTrials + 1).ToString();
            lb_test_fees.Text = _testFees.ToString("C", CultureInfo.GetCultureInfo("en-us"));

            // Set test type label and image
            TestType = _testType;

            // Retake test info
            if (_scheduleMode == ScheduleMode.RetakeSchedule)
            {
                lb_retake_test_app_id.Text = _existingAppointment != null
                        ? _existingAppointment.RetakeApplicationId.ToString()
                        : "N/A";
                lb_retake_test_fees.Text = _retakeTestAppFees.ToString("C", CultureInfo.GetCultureInfo("en-us"));
                lb_retake_total_fees.Text = (_testFees + _retakeTestAppFees).ToString("C", CultureInfo.GetCultureInfo("en-us"));
            }
            else
            {
                lb_retake_test_app_id.Text = string.Empty;
                lb_retake_test_fees.Text = string.Empty;
                lb_retake_total_fees.Text = string.Empty;
            }
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = false;

            try
            {
                if (!IsValidTestDate())
                {
                    btn_save.Enabled = true;
                    return;
                }

                if (_mode == Mode.Edit)
                {
                    // Only update the date
                    if (_existingAppointment != null)
                    {
                        _existingAppointment.AppointmentDate = dtp_test_schedule_date.Value;
                        bool updated = await _testAppointmentController.UpdateTestAppointmentAsync(_existingAppointment);
                        if (updated)
                        {
                            MessageBox.Show("Test appointment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update test appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else // Create mode
                {
                    var newAppointment = new TestAppointment
                    {
                        TestType = new TestType { TypeId = (int)_testType },
                        LocalDrivingLicenseApplicationId = _localDrivingLicenseApplication.LDL_ApplicationId,
                        AppointmentDate = dtp_test_schedule_date.Value,
                        PaidFees = _testFees,
                        CreatedByUserId = CurrentUserProvider.CurrentUser.UserId,
                        isLocked = false,
                        RetakeApplicationId = -1 // will be set in repo if retake
                    };

                    if (_scheduleMode == ScheduleMode.RetakeSchedule)
                    {
                        Person person = await _personController.GetPersonByNationalNumberAsync(_localDrivingLicenseApplication.NationalNumber);
                        // Prepare Applications object for retake
                        var retakeApplication = new Applications
                        {
                            ApplicantPersonId = person.PersonId, // or the correct person id if available
                            ApplicationDate = DateTime.Now,
                            ApplicationType = new ApplicationType { ApplicationTypeId = (int)ApplicationTypes.RetakeTest },
                            enApplicationStatus = ApplicationStatus.Completed,
                            LastStatusDate = DateTime.Now,
                            PaidFees = _retakeTestAppFees,
                            CreatedByUserId = CurrentUserProvider.CurrentUser.UserId
                        };

                        int newId = await _testAppointmentController.RescheduleTestAppointmentAsync(newAppointment, retakeApplication);
                        if (newId > 0)
                        {
                            MessageBox.Show("Test appointment rescheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to reschedule test appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else // First time schedule
                    {
                        int newId = await _testAppointmentController.AddTestAppointmentAsync(newAppointment);
                        if (newId > 0)
                        {
                            MessageBox.Show("Test appointment scheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to schedule test appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
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

        private bool IsValidTestDate()
        {
            if (dtp_test_schedule_date.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("The test date must be today or in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        private void lb_exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to cancel scheduling?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Dispose();
        }

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
