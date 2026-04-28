using Core.Models;
using Core.Enums;
using DVLD.Views.Components;
using System.Windows.Forms;

namespace DVLD.Pop_Ups
{
    public partial class Schedule_Test : RoundedBaseForm
    {
        private LocalDrivingLicenseApplication _localDrivingLicenseApplication;
        private TestTypes _testType;

        public Schedule_Test(LocalDrivingLicenseApplication localDrivingLicenseApplication, TestTypes testType)
        {
            InitializeComponent();
            _localDrivingLicenseApplication = localDrivingLicenseApplication;
            _testType = testType;
        }

        private void Schedule_Test_Load(object sender, System.EventArgs e)
        {
            switch(_testType)
            {
                case TestTypes.WrittenTest:
                    lb_test_type.Text = "Written Test";
                    break;
                case TestTypes.VisionTest:
                    lb_test_type.Text = "Vision Test";
                    break;
                case TestTypes.StreetTest:
                    lb_test_type.Text = "Street Test";
                    break;
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


    }
}
