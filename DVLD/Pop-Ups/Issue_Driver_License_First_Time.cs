using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLD.Session;

namespace DVLD.Pop_Ups
{
    public partial class Issue_Driver_License_First_Time : DVLD.Views.Components.RoundedBaseForm
    {
        private LocalDrivingLicenseApplicationController _localDrivingLicenseApplicationController;
        private LicenseController _licenseController;

        private int _ldl_app_id;
        private LocalDrivingLicenseApplication _ldl_Application;

        public Issue_Driver_License_First_Time(int ldl_app_id)
        {
            InitializeComponent();
            _localDrivingLicenseApplicationController = new LocalDrivingLicenseApplicationController(new LocalDrivingLicenseApplicationRepository(), new LicenseRepository());
            _licenseController = new LicenseController(new LicenseRepository());

            _ldl_app_id = ldl_app_id;
        }
        private async void Issue_Driver_License_First_Time_Load(object sender, EventArgs e)
        {
            _ldl_Application = await _localDrivingLicenseApplicationController.GetLocalDrivingLicenseApplicationByIdAsync(_ldl_app_id);
            applicationDetails.setApplication(_ldl_Application.ApplicationId);
            lb_ldl_application_id.Text = _ldl_Application.LDL_ApplicationId.ToString();
            lb_passed_tests.Text = _ldl_Application.PassedTest.ToString();
            lb_license_class.Text = _ldl_Application.LicenseClass.Name.ToString();
        }

        private async void btn_issue_Click(object sender, EventArgs e)
        {
            btn_issue.Enabled = false;

            if (_ldl_Application == null)
            {
                MessageBox.Show("Application data is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prevent issuing if passed tests are below 3
            if (_ldl_Application.PassedTest < 3)
            {
                MessageBox.Show("Issuing a license is not allowed unless the applicant has passed at least 3 tests.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_issue.Enabled = true;
                return;
            }

            try
            {

                int userId = CurrentUserProvider.CurrentUser.UserId;
                int personId = applicationDetails.GetApplication().ApplicantPersonId;

                string notes = txt_notes.Text;

                int newLicenseId = await _licenseController.IssueLicenseFirstTime(_ldl_Application, personId, userId, notes);

                if(newLicenseId > 0)
                    MessageBox.Show($"License issued successfully! License ID: {newLicenseId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to issue license: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to cancel issuing the license?",
                "Cancel Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
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
