using Core.Models;
using Core.Enums;
using DVLD.Views.Components;
using System.Windows.Forms;
using System.Globalization;
using System;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;

namespace DVLD.Pop_Ups
{
    public partial class Schedule_Test : RoundedBaseForm
    {

        // Controllers
        private LocalDrivingLicenseApplicationController _localDrivingLicenseApplicationController;
        private TestTypeController _testTypeController;
        private ApplicationTypeController _applicationTypeController;


        // Data
        private LocalDrivingLicenseApplication _localDrivingLicenseApplication;
        private TestTypes _testType;
        private decimal _testFees;
        private int _totalTrials;
        private decimal _retakeTestAppFees;


        // Schedule mode to determine if it's a first-time schedule or a retake schedule
        private enum ScheduleMode { FirstTimeSchedule = 1, RetakeSchedule = 2 }
        private ScheduleMode _scheduleMode;

        private enum Mode { Create = 1, Edit = 2 }
        private Mode _mode;

        public Schedule_Test(int localDrivingLicenseApplicationId, int appointmentId = -1)
        {
            InitializeComponent();

            _localDrivingLicenseApplicationController = new LocalDrivingLicenseApplicationController(new LocalDrivingLicenseApplicationRepository(), new LicenseRepository());
            _testTypeController = new TestTypeController(new TestTypeRepository());
            _applicationTypeController = new ApplicationTypeController(new ApplicationTypeRepository());

            _mode = appointmentId == -1 ? Mode.Create : Mode.Edit;

        }

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
                        pictureBox.Image = imageList.Images[0];
                        break;
                    case TestTypes.VisionTest:
                        lb_test_type.Text = "Vision (Theory) Test";
                        pictureBox.Image = imageList.Images[1];
                        break;
                    case TestTypes.StreetTest:
                        lb_test_type.Text = "Practical (Street) Test";
                        pictureBox.Image = imageList.Images[2];
                        break;
                }
            }
        }

        private void MapData()
        {

            lb_ldl_app_id.Text = _localDrivingLicenseApplication.ApplicationId.ToString();
            lb_license_class.Text = _localDrivingLicenseApplication.LicenseClass.Name;
            lb_person_name.Text = _localDrivingLicenseApplication.FullName;
            dtp_test_schedule_date.Value = DateTime.Now.AddDays(7); // Default to one week from now
            lb_trial_number.Text = (_totalTrials + 1).ToString();
            lb_test_fees.Text = _testFees.ToString("C", CultureInfo.CurrentCulture);


            // Retake test info

            if (_scheduleMode == ScheduleMode.RetakeSchedule)
            {
                lb_retake_test_app_id.Text = "N/A";
                lb_retake_test_fees.Text = _retakeTestAppFees.ToString("C", CultureInfo.CurrentCulture);
                lb_retake_total_fees.Text = (_testFees + _retakeTestAppFees).ToString("C", CultureInfo.CurrentCulture);
            }

        }

        private async void Schedule_Test_Load(object sender, System.EventArgs e)
        {
            _localDrivingLicenseApplication = await _localDrivingLicenseApplicationController.GetLocalDrivingLicenseApplicationByIdAsync(_localDrivingLicenseApplication.ApplicationId);

            _totalTrials = await _localDrivingLicenseApplicationController.GetTotalTrialsPerTestAsync(_localDrivingLicenseApplication.ApplicationId, (int)_testType);

            _testFees = await _testTypeController.GetTestFeeByIdAsync((int)_testType);

            _scheduleMode = _totalTrials == 0 ? ScheduleMode.FirstTimeSchedule : ScheduleMode.RetakeSchedule;

            if (_scheduleMode == ScheduleMode.RetakeSchedule)
            {
                _retakeTestAppFees = await _applicationTypeController.GetApplicationTypeFeeByIdAsync((int)ApplicationTypes.RetakeTest);
            }

            MapData();
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
