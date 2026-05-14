using Core.Models;
using DVLD.CustomForms;
using System.Windows.Forms;
using System;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using DVLD.Session;
using Core.Enums;
using System.Globalization;

namespace DVLD.Pop_Ups
{
    public partial class Take_Test : RoundedBaseForm
    {


        private TestAppointmentController _testAppointmentController;
        private LocalDrivingLicenseApplicationController _ldlController;
        private TestController _testController;

        private readonly int _appointmentId;
        private TestAppointment _appointment;
        private LocalDrivingLicenseApplication _ldlApp;
        private int _totalTrials;
        private bool _canTakeTest = false;
        private TestTypes _testType;

        public TestTypes TestType
        {
            get => _testType;
            set
            {
                _testType = value;
                switch (_testType)
                {
                    case TestTypes.VisionTest:
                        lb_test_type.Text = "Vision Test";
                        pictureBox.Image = Properties.Resources.eyetest;
                        break;
                    case TestTypes.WrittenTest:
                        lb_test_type.Text = "Written (Theory)  Test";
                        pictureBox.Image = Properties.Resources.exam;
                        break;
                    case TestTypes.StreetTest:
                        lb_test_type.Text = "Practical (Street) Test";
                        pictureBox.Image = Properties.Resources.driving_test;
                        break;
                }
            }
        }

        public Take_Test(int appointmentId, TestTypes testType)
        {
            InitializeComponent();
            _testAppointmentController = new TestAppointmentController(new TestAppointmentRepository());
            _testController = new TestController(new TestRepository());
            _ldlController = new LocalDrivingLicenseApplicationController(new LocalDrivingLicenseApplicationRepository(), new LicenseRepository());
            
            
            _appointmentId = appointmentId;
            TestType = testType;
        }

        private async void Take_Test_Load(object sender, EventArgs e)
        {
            _appointment = await _testAppointmentController.GetTestAppointmentByIdAsync(_appointmentId);
            if (_appointment == null)
            {
                MessageBox.Show("Test appointment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _ldlApp = await _ldlController.GetLocalDrivingLicenseApplicationByIdAsync(_appointment.LocalDrivingLicenseApplicationId);

            _totalTrials = await _ldlController.GetTotalTrialsPerTestAsync(_appointment.LocalDrivingLicenseApplicationId, _appointment.TestType.TypeId);

            MapData();
            ValidateTestDate();
        }

        private void MapData()
        {
            lb_ldl_app_id.Text = _appointment.LocalDrivingLicenseApplicationId.ToString();
            lb_license_class.Text = _ldlApp.LicenseClass.Name;
            lb_person_name.Text = _ldlApp?.FullName ?? "";
            lb_trial_number.Text = _totalTrials.ToString();
            lb_test_date.Text = _appointment.AppointmentDate.ToString("yyyy-MM-dd HH:mm");
            lb_test_fees.Text = _appointment.TestType.TypeFee.ToString("C", CultureInfo.GetCultureInfo("en-US"));
        }

        private void ValidateTestDate()
        {
            DateTime today = DateTime.Now.Date;
            DateTime appDate = _appointment.AppointmentDate.Date;

            if (appDate < today)
            {
                lb_warning.Text = "Missed test appointment!";
                lb_warning.Visible = true;
                SetTestControlsEnabled(false);
                _canTakeTest = false;
            }
            else if (appDate > today)
            {
                lb_warning.Text = "Future test appointment!";
                lb_warning.Visible = true;
                SetTestControlsEnabled(false);
                _canTakeTest = false;
            }
            else
            {
                lb_warning.Visible = false;
                SetTestControlsEnabled(true);
                _canTakeTest = true;
            }
        }

        private void SetTestControlsEnabled(bool enabled)
        {
            rb_passes.Enabled = enabled;
            rb_fails.Enabled = enabled;
            rtb_notes.Enabled = enabled;
            btn_save.Enabled = enabled;
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (!_canTakeTest)
                return;

            // Validate result selection
            if (!rb_passes.Checked && !rb_fails.Checked)
            {
                MessageBox.Show("Please select the test result.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var test = new Test
            {
                TestAppointmentId = _appointmentId,
                Result = rb_passes.Checked,
                Notes = rtb_notes.Text,
                CreatedByUserId = CurrentUserProvider.CurrentUser.UserId
            };

            int newTestId = await _testController.AddTestAsync(test);
            if (newTestId > 0)
            {
                MessageBox.Show("Test result saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save test result.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void lb_exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit without saving?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Dispose();
        }
    }
}
