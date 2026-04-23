using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System.Windows.Forms;
using Core.Models;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using DVLD.Pop_Ups;

namespace DVLD.UserControls
{
    public partial class ApplicationDetails : UserControl
    {
        private readonly ApplicationsController _applicationsController;

        private Applications _application;

        public ApplicationDetails()
        {
            InitializeComponent();

            lb_view_person_info.Visible = false; // Hide edit label initially
            _applicationsController = new ApplicationsController(new ApplicationsRepository(), new LicenseRepository());
        }

        private void UpdateUI()
        {
            if (_application == null)
                return;

            lb_application_id.Text = _application.ApplicationId.ToString();
            lb_person_id.Text = _application.ApplicantPersonId.ToString();
            lb_date.Text = _application.ApplicationDate.ToString();
            lb_type.Text = _application.ApplicationType.ApplicationTypeName;
            lb_type_fees.Text = _application.ApplicationType.ApplicationTypeFees.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_status.Text = _application.enApplicationStatus.ToString();
            lb_user_id.Text = _application.CreatedByUserId.ToString();
            lb_paid_fees.Text = _application.PaidFees?.ToString("C", CultureInfo.GetCultureInfo("en-US")) ?? "N/A";

            lb_view_person_info.Visible = true;
        }

        public async void setApplication(int applicationId)
        {
            try
            {
                _application = await _applicationsController.GetApplicationById(applicationId);
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching application details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lb_view_person_info_Click(object sender, EventArgs e)
        {
            Show_Person_Details personDetails = new Show_Person_Details(_application.ApplicantPersonId);
            personDetails.Show(this.FindForm());
        }
    }
}
