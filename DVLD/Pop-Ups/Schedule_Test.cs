using Core.Models;
using Core.Enums;
using DVLD.Views.Components;
using System.Windows.Forms;
using System.Globalization;
using System;

namespace DVLD.Pop_Ups
{
    public partial class Schedule_Test : RoundedBaseForm
    {
        private LocalDrivingLicenseApplication _localDrivingLicenseApplication;
        private TestTypes _testType;
        public Schedule_Test(int localDrivingLicenseApplicationId, int appointmentId = -1 )
        {
            InitializeComponent();
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
                        lb_test_type.Text = "Vision Test";
                        pictureBox.Image = imageList.Images[1];
                        break;
                    case TestTypes.StreetTest:
                        lb_test_type.Text = "Street Test";
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
            lb_test_fees.Text = _localDrivingLicenseApplication.LicenseClass.ClassFees.ToString("C", CultureInfo.GetCultureInfo("en-US"));

            // Retake test info
            
        }

        private void Schedule_Test_Load(object sender, System.EventArgs e)
        {
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
