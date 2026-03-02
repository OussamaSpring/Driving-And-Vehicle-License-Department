using Core.Models;
using Core.Enums;
using DVLD.Pop_Ups;
using DVLD.Session;
using DVLD.UserControls;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DVLD.Forms
{
    public partial class ApplicationsForm : Form
    {
        private readonly ApplicationTypeController _applicationTypeController;
        private readonly ApplicationsController _applicationController;
        private readonly LicenseClassController _licenseClassController;
        private readonly LicenseDetainController _licenseDetainController;

        private Dictionary<ApplicationTypes, ApplicationType> _applicationTypesDict;
        
        private List<LicenseClass> _licenseClassesList;

        public ApplicationsForm()
        {
            InitializeComponent();

            var tabs = new TabBar
            {
                Dock = DockStyle.Fill,
                Height = 50
            };
            tabs.SetTabs("Operations", "Applications List", "Applications Types");
            tabs.SelectedIndexChanged += (s, e) =>
            {
                
                switch (tabs.SelectedIndex)
                {
                    case 0:
                        OnOperationsTabSelected();
                        break;
                    case 1:
                        OnApplicationsListTabSelected();
                        break;
                    case 2:
                        OnApplicationsTypesTabSelected();
                        break;
                }
            };

            tlp_header.Controls.Add(tabs, 1, 0);


            _applicationTypeController = new ApplicationTypeController(new ApplicationTypeRepository());
            _applicationController = new ApplicationsController(new ApplicationsRepository());
            _licenseClassController = new LicenseClassController(new LicenseClassRepository());
            _licenseDetainController = new LicenseDetainController(new LicenseDetainRepository());
        }

        #region Operations Page Initialization
        private void InitializeLocalDrivingLicenseApplicationPage()
        {
            decimal applicationFee = _applicationTypesDict.TryGetValue(ApplicationTypes.AddLocalLicense, out var appType)
                ? appType.ApplicationTypeFees : 0;

            txt_search_local.Text = string.Empty;
            cb_filter_local.SelectedIndex = 0;

            cb_license_class_local.Items.Clear();
            cb_license_class_local.Items.Add("None");
            cb_license_class_local.Items.AddRange(_licenseClassesList.Select(lc => lc.Name).ToArray());
            cb_license_class_local.SelectedIndex = 0;

            lb_application_fees_local.Text = applicationFee.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_created_by_local.Text = CurrentUserProvider.CurrentUser.Username;
            lb_application_date_local.Text = DateTime.Now.ToShortDateString();

            local_personDetailsCard.Clear();
        }
        private void InitializeInternationalDrivingLicenseApplicationPage()
        {
            decimal applicationFee = _applicationTypesDict.TryGetValue(ApplicationTypes.AddInternationalLicense, out var appType)
                ? appType.ApplicationTypeFees : 0;

            txt_search_inter.Text = string.Empty;
            lb_application_fees_inter.Text = applicationFee.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_created_by_inter.Text = CurrentUserProvider.CurrentUser.Username;
            lb_application_date_inter.Text = DateTime.Now.ToShortDateString();

            driverLicenseCard_inter.Clear();
        }
        private void InitializeReleaseLicensePage()
        {
            decimal applicationFee = _applicationTypesDict.TryGetValue(ApplicationTypes.ReleaseLicense, out var appType)
                ? appType.ApplicationTypeFees : 0;

            txt_search_release.Text = string.Empty;
            lb_application_fees_release.Text = applicationFee.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_created_by_release.Text = CurrentUserProvider.CurrentUser.Username;

            lb_detain_id_release.Text = "??";
            lb_detain_date_release.Text = "??";
            lb_total_fees_release.Text = "??";
            lb_fine_fees_release.Text = "??";

            driverLicenseCard_release.Clear();
        }
        private void InitializeRenewLicensePage()
        {
            decimal applicationFee = _applicationTypesDict.TryGetValue(ApplicationTypes.RenewLicense, out var appType)
                ? appType.ApplicationTypeFees : 0;

            txt_search_renew.Text = string.Empty;
            lb_old_license_id_renew.Text = "??";
            lb_renew_date.Text = DateTime.Now.ToShortDateString();
            lb_renewed_license_id.Text = "??";
            lb_expiration_date_renew.Text = "??";
            lb_license_fees_renew.Text = "??";
            lb_application_fees_renew.Text = applicationFee.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_created_by_renew.Text = CurrentUserProvider.CurrentUser.Username;
            lb_total_fees_release.Text = "??";
            rtb_notes_renew.Text = string.Empty;

            driverLicenseCard_renew.Clear();
        }
        private void InitializeReplaceDamagedLicensePage()
        {
            decimal applicationFee = _applicationTypesDict.TryGetValue(ApplicationTypes.ReplaceDamagedLicense, out var appType)
                ? appType.ApplicationTypeFees : 0;

            txt_search_damaged.Text = string.Empty;
            lb_old_license_id_damaged.Text = "??";
            lb_replace_date_damaged.Text = DateTime.Now.ToShortDateString();
            lb_replaced_license_id_damaged.Text = "??";
            lb_application_fees_damaged.Text = applicationFee.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_created_by_damaged.Text = CurrentUserProvider.CurrentUser.Username;

            driverLicenseCard_damaged.Clear();
        }
        private void InitializeReplaceLostLicensePage()
        {
            decimal applicationFee = _applicationTypesDict.TryGetValue(ApplicationTypes.ReplaceLostLicense, out var appType)
                ? appType.ApplicationTypeFees : 0;

            txt_search_lost.Text = string.Empty;

            lb_replaced_license_id_lost.Text = "??";
            lb_replace_date_lost.Text = DateTime.Now.ToShortDateString();
            lb_replaced_license_id_lost.Text = "??";
            lb_application_fees_lost.Text = applicationFee.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_created_by_lost.Text = CurrentUserProvider.CurrentUser.Username;

            driverLicenseCard_lost.Clear();
        }
        private void InitializeApplicationOperationsPages()
        {
            InitializeLocalDrivingLicenseApplicationPage();
            InitializeInternationalDrivingLicenseApplicationPage();
            InitializeReleaseLicensePage();
            InitializeRenewLicensePage();
            InitializeReplaceDamagedLicensePage();
            InitializeReplaceLostLicensePage();
        }
        private void cb_license_class_local_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal applicationFee = _applicationTypesDict.TryGetValue(ApplicationTypes.AddLocalLicense, out var appType)
                ? appType.ApplicationTypeFees : 0;

            decimal licenceClassFee = 0;
            if (cb_license_class_local.SelectedItem != null && cb_license_class_local.SelectedItem.ToString() != "None")
            {
                var selectedName = cb_license_class_local.SelectedItem.ToString();
                var selectedClass = _licenseClassesList.FirstOrDefault(lc => lc.Name == selectedName);
                licenceClassFee = selectedClass?.ClassFees ?? 0;
            }

            lb_application_fees_local.Text = (applicationFee + licenceClassFee).ToString("C", CultureInfo.GetCultureInfo("en-US"));
        }
        #endregion

        private async Task FillApplicationTypesAndLicenseClassesAsync()
        {
            var applicationTypes = await _applicationTypeController.GetAllApplicationTypesAsync();
            _applicationTypesDict = applicationTypes.ToDictionary(
                at => (ApplicationTypes)at.ApplicationTypeId,
                at => at);

            var licenseClasses = await _licenseClassController.GetLicenseClassesListAsync();

            _licenseClassesList = licenseClasses.ToList();

        }
        private async void ApplicationsForm_Load(object sender, EventArgs e)
        {
            OnOperationsTabSelected();
            

            uc_application_list_topbar.btn_add_Hide();
            uc_application_list_topbar.FillFilterCriteria(_applicationController.GetApplicationFilterCriteria());
            uc_application_list_topbar.FilterPerformed += Uc_application_list_topbar_FilterPerformed;

            await FillApplicationTypesAndLicenseClassesAsync();

            InitializeApplicationOperationsPages();
        }



        #region Application Operations

        #region HelpFunctions
        private int? GetLicenseIdFrom(TextBox textBox)
        {
            err_input_validation.SetError(textBox, string.Empty);

            string input = textBox.Text.Trim();
            if (!InputValidation.IsNumber(input, out string errorMessage))
            {
                err_input_validation.SetError(textBox, errorMessage);
                return null;
            }

            return int.Parse(input);
        }

        private void PopulateReleaseUi(int licenseId, int detainId, DateTime detainDate, decimal fineFees)
        {
            driverLicenseCard_release.SetDriverLicense(licenseId);

            decimal applicationFee = _applicationTypesDict[ApplicationTypes.ReleaseLicense].ApplicationTypeFees;
            decimal totalFees = applicationFee + fineFees;

            lb_detain_id_release.Text = detainId.ToString();
            lb_detain_date_release.Text = detainDate.ToString("yyyy-MM-dd");
            lb_fine_fees_release.Text = fineFees.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_application_fees_release.Text = applicationFee.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_total_fees_release.Text = totalFees.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_created_by_release.Text = CurrentUserProvider.CurrentUser.Username;
        }


        private void PopulateRenewUi(License license)
        {
            lb_old_license_id_renew.Text = license.LicenseId.ToString();
            lb_renew_date.Text = DateTime.Now.ToString("yyyy-MM-dd");

            LicenseClass licenseClass = _licenseClassesList.FirstOrDefault(lc => lc.Id == license.ClassId);
            decimal licenseClassFees = licenseClass?.ClassFees ?? 0m;
            decimal appFees = _applicationTypesDict[ApplicationTypes.RenewLicense].ApplicationTypeFees;

            lb_license_fees_renew.Text = licenseClassFees.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_application_fees_renew.Text = appFees.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_total_fees_renew.Text = (licenseClassFees + appFees).ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lb_created_by_renew.Text = CurrentUserProvider.CurrentUser.Username;
        }



        #endregion


        // Add New Local Driving License Application --------------------------------------------------------------------------------------
        private void pb_add_person_Click(object sender, EventArgs e)
        {
            btn_add_person.Enabled = false; // Disable the button to prevent multiple clicks
            try
            {
                Add_Edit_Person addPersonForm = new Add_Edit_Person(null);
                addPersonForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding new person: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_add_person.Enabled = true; // Re-enable the button
            }
        }

        private void btn_search_local_Click(object sender, EventArgs e)
        {
            if(ValidatePersonIdOrNationalNo())
            {
                switch(cb_filter_local.SelectedItem.ToString())
                {
                    case "Person ID":
                        int personId = int.Parse(txt_search_local.Text.Trim());
                        local_personDetailsCard.SetPerson(personId);
                        break;
                    case "National No.":
                        string nationalNo = txt_search_local.Text.Trim();
                        local_personDetailsCard.SetPerson(nationalNo);
                        break;
                }
            }
        }

        private void btn_add_local_Click(object sender, EventArgs e)
        {

        }

        // Add New International Driving License Application ------------------------------------------------------------------------------

        private void btn_search_inter_Click(object sender, EventArgs e)
        {
            if (ValidateLicenseId(txt_search_inter.Text.Trim()))
            {
                int licenseId = int.Parse(txt_search_inter.Text.Trim());
                driverLicenseCard_inter.SetDriverLicense(licenseId);
            }
        }


        // Release Detained License Application -------------------------------------------------------------------------------------------

        private async void btn_search_release_Click(object sender, EventArgs e)
        {
            int? licenseId = GetLicenseIdFrom(txt_search_release);
            if (!licenseId.HasValue)
            {
                return;
            }

            var detainedLicense = await _licenseDetainController.GetDetaineByLicenseIdAsync(licenseId.Value);

            if (detainedLicense == null || detainedLicense.IsReleased)
            {
                MessageBox.Show("No active detained license found for this ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PopulateReleaseUi(
                licenseId.Value,
                detainedLicense.DetainID,
                detainedLicense.DetainDate,
                detainedLicense.FineFees);
        }

        private async void btn_release_Click(object sender, EventArgs e)
        {
            btn_release.Enabled = false;

            License license = driverLicenseCard_release.GetLicenseDetails();

            if (license == null)
            {
                MessageBox.Show("No detained license selected!\nPlease search for a detained license to release", "No License Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_release.Enabled = true;
                return;
            }

            if (MessageBox.Show($"Are you want to release this detained licence [{license.LicenseId}]?", "Release License?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                btn_release.Enabled = true;
                return;
            }
            
            try
            {
                int personId = driverLicenseCard_release.GetPersonDetails().PersonId;
                int detainId = int.Parse(lb_detain_id_release.Text);

                decimal paidFees = decimal.Parse(lb_total_fees_release.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));

                bool result = await _applicationController.ReleaseDetainedDrivingLicenseAsync(_applicationTypesDict[ApplicationTypes.ReleaseLicense],detainId, personId, paidFees, CurrentUserProvider.CurrentUser.UserId);

                if (result)
                {
                    MessageBox.Show("License released successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeReleaseLicensePage();
                }
                else
                    MessageBox.Show("Failed to release license. Please check the data and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_release.Enabled = true;

            }
        }

        // Renew Expired License Application ----------------------------------------------------------------------------------------------

        private void btn_renew_search_Click(object sender, EventArgs e)
        {
            int? licenseId = GetLicenseIdFrom(txt_search_renew);
            if (!licenseId.HasValue)
            {
                return;
            }

            driverLicenseCard_renew.SetDriverLicense(licenseId.Value);

            License license = driverLicenseCard_renew.GetLicenseDetails();
            if (license == null)
            {
                MessageBox.Show("License details could not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PopulateRenewUi(license);
        }

        private async void btn_renew_Click(object sender, EventArgs e)
        {
            btn_renew.Enabled = false;

            License license = driverLicenseCard_renew.GetLicenseDetails();

            if (license == null || license.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("No expired license selected!\nPlease search for an EXPIRED license to renew", "No Expired License Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_renew.Enabled = true;
                return;
            }

            try
            {

                LicenseClass licenseClass = _licenseClassesList.FirstOrDefault(lc => lc.Id == license.ClassId);
                if (licenseClass == null)
                {
                    MessageBox.Show("License class could not be determined.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(lb_total_fees_renew.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out decimal paidFees))
                {
                    MessageBox.Show("Invalid fees amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ApplicationType appType = _applicationTypesDict[ApplicationTypes.RenewLicense];
                string notes = rtb_notes_renew.Text ?? string.Empty;


                int personId = driverLicenseCard_renew.GetPersonDetails().PersonId;

                DateTime newExpirationDate = DateTime.Now.AddYears(licenseClass.DefaultValidityLength);

                int newLicenseId = await _applicationController.RenewExpiredDrivingLicenseAsync(
                    appType,
                    license,
                    licenseClass,
                    notes,
                    personId,
                    paidFees,
                    CurrentUserProvider.CurrentUser.UserId);

                if (newLicenseId > 0)
                {
                    lb_renewed_license_id.Text = newLicenseId.ToString();
                    lb_expiration_date_renew.Text = newExpirationDate.ToString("yyyy-MM-dd");
                    MessageBox.Show("License renewed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeRenewLicensePage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_renew.Enabled = true;
            }
        }


        // Replace Damaged License Application ----------------------------------------------------------------------------------------------
        private void btn_search_damaged_Click(object sender, EventArgs e)
        {
            if (ValidateLicenseId(txt_search_damaged.Text.Trim()))
            {
                int licenseId = int.Parse(txt_search_damaged.Text.Trim());
                driverLicenseCard_damaged.SetDriverLicense(licenseId);
            }
        }


        // Replace Lost License Application -------------------------------------------------------------------------------------------------

        private void btn_search_lost_Click(object sender, EventArgs e)
        {
            if (ValidateLicenseId(txt_search_lost.Text.Trim()))
            {
                int licenseId = int.Parse(txt_search_lost.Text.Trim());
                driverLicenseCard_lost.SetDriverLicense(licenseId);
            }
        }

        #endregion




        #region Application List

        private List<Applications> _applications;
        private async Task LoadApplicationsAsync()
        {
            _applications = (await _applicationController.GetAllApplicationsAsync()).ToList();
            BindApplicationsToGrid(_applications);
        }
        private void BindApplicationsToGrid(IEnumerable<Applications> applications)
        {
            dgv_applications.Rows.Clear();

            foreach (Applications app in applications)
            {
                dgv_applications.Rows.Add(
                    app.ApplicationId,
                    app.ApplicantPersonId,
                    app.ApplicationType.ApplicationTypeName,
                    app.ApplicationDate.ToString(),
                    app.enApplicationStatus.ToString(),
                    app.LastStatusDate?.ToString() ?? "N/A",
                    app.PaidFees?.ToString("C", CultureInfo.GetCultureInfo("en-US")) ?? "N/A",
                    app.CreatedByUserId
                    );
            }
            lb_total_applications_number.Text = dgv_applications.RowCount.ToString();
        }
        private void Uc_application_list_topbar_FilterPerformed(object sender, FilterArgs e)
        {
            var filtered = _applications.Where(app =>
            {
                switch (e.FilterCriteria)
                {
                    case "Application ID":
                        return app.ApplicationId.ToString().Contains(e.SearchText);
                    case "Applicant Person ID":
                        return app.ApplicantPersonId.ToString().Contains(e.SearchText);
                    case "Application Date":
                        return app.ApplicationDate.ToString().ToLower().Contains(e.SearchText.ToLower());
                    case "Application Type":
                        return app.ApplicationType != null && app.ApplicationType.ApplicationTypeName.ToLower().Contains(e.SearchText.ToLower());
                    case "Application Status":
                        return app.enApplicationStatus.ToString().ToLower().Contains(e.SearchText.ToLower());
                    case "Last Status Date":
                        return (app.LastStatusDate?.ToString() ?? "N/A").ToLower().Contains(e.SearchText.ToLower());
                    case "Paid Fees":
                        return (app.PaidFees?.ToString("C", CultureInfo.GetCultureInfo("en-US")) ?? "N/A").ToLower().Contains(e.SearchText.ToLower());
                    case "Created By User ID":
                        return app.CreatedByUserId.ToString().Contains(e.SearchText);
                    default:
                        return true;
                }
            }).ToList();

            BindApplicationsToGrid(filtered);
        }


        #region Context Menu Actions
        private void tsmi_ViewAppDetails_Click(object sender, EventArgs e)
        {
            if (dgv_applications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an application to view details.", "No Application Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedAppId = Convert.ToInt32(dgv_applications.SelectedRows[0].Cells["application_id"].Value);
            Show_Application_Details applicationDetails = new Show_Application_Details(selectedAppId);
            applicationDetails.Show(this.FindForm());
        }
        private void tsmi_ViewPersonInfo_Click(object sender, EventArgs e)
        {
            if (dgv_applications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an application to view applicant details.", "No Application Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedPersonId = Convert.ToInt32(dgv_applications.SelectedRows[0].Cells["person_id"].Value);
            Show_Person_Details show_Person_Details = new Show_Person_Details(selectedPersonId);
            show_Person_Details.Show(this.FindForm());
        }
        private void tsmi_ShowLicenseHistory_Click(object sender, EventArgs e)
        {
            if (dgv_applications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an application to view license history.", "No Application Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedPersonId = Convert.ToInt32(dgv_applications.SelectedRows[0].Cells["person_id"].Value);
            Show_Person_License_History licenseHistoryForm = new Show_Person_License_History(selectedPersonId);
            licenseHistoryForm.Show(this.FindForm());
        }

        #endregion

        #endregion

        #region Application Types

        private List<ApplicationType> _applicationTypes;
        private async Task LoadApplicationTypesAsync()
        {
            _applicationTypes = (await _applicationTypeController.GetAllApplicationTypesAsync()).ToList();
            BindApplicationTypeToGrid(_applicationTypes);
        }
        private void BindApplicationTypeToGrid(IEnumerable<ApplicationType> appTypes)
        {
            dgv_application_types.Rows.Clear();

            foreach(ApplicationType type in appTypes)
            {
                dgv_application_types.Rows.Add(
                    type.ApplicationTypeId,
                    type.ApplicationTypeName,
                    type.ApplicationTypeFees.ToString("C", CultureInfo.GetCultureInfo("en-US"))
                    );
            }
            lb_total_application_types.Text = dgv_application_types.RowCount.ToString();
        }

        #endregion

        #region Tab Switching

        // Tab Switching Methods
        private void OnOperationsTabSelected()
        {
            htc_tab_nav.SelectedIndex = 0; // Select the "Operations" tab
        }
        private async void OnApplicationsListTabSelected()
        {
            htc_tab_nav.SelectedIndex = 1; // Select the "Applications List" tab
            await LoadApplicationsAsync();
        }
        private async void OnApplicationsTypesTabSelected()
        {
            htc_tab_nav.SelectedIndex = 2; // Select the "Applications Types" tab
            await LoadApplicationTypesAsync();
        }

        // Operation Options Click Handlers
        private void opt_NewLocalDrivingLicense_Clicked(object sender, MouseEventArgs e)
        {
            htc_operations_management.SelectedIndex = 1; // Select the "New Local Driving License" tab
        }
        private void opt_NewInterDrivingLicense_Clicked(object sender, MouseEventArgs e)
        {
            htc_operations_management.SelectedIndex = 2; // Select the "New International Driving License" tab
        }
        private void opt_ReleaseLicense_Clicked(object sender, MouseEventArgs e)
        {
            htc_operations_management.SelectedIndex = 3; // Select the "Release License" tab
        }
        private void opt_RenewLicense_Clicked(object sender, MouseEventArgs e)
        {
            htc_operations_management.SelectedIndex = 4; // Select the "Renew License" tab
        }
        private void opt_ReplaceDamagedLicense_Clicked(object sender, MouseEventArgs e)
        {
            htc_operations_management.SelectedIndex = 5; // Select the "Replace Damaged License" tab
        }
        private void opt_ReplaceLostLicense_Clicked(object sender, MouseEventArgs e)
        {
            htc_operations_management.SelectedIndex = 6; // Select the "Replace Lost License" tab
        }

        // Return to Operations Main 
        private void pb_page1_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back?\nUnsaved data will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InitializeLocalDrivingLicenseApplicationPage();
                htc_operations_management.SelectedIndex = 0; // Select the main operations tab
            }
        }
        private void pb_page2_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back?\nUnsaved data will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InitializeInternationalDrivingLicenseApplicationPage();
                htc_operations_management.SelectedIndex = 0; // Select the main operations tab
            }
        }
        private void pb_page3_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back?\nUnsaved data will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InitializeReleaseLicensePage();
                htc_operations_management.SelectedIndex = 0; // Select the main operations tab
            }
        }
        private void pb_page4_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back?\nUnsaved data will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InitializeRenewLicensePage();
                htc_operations_management.SelectedIndex = 0; // Select the main operations tab
            }
        }
        private void pb_page5_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back?\nUnsaved data will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InitializeReplaceDamagedLicensePage();
                htc_operations_management.SelectedIndex = 0; // Select the main operations tab
            }
        }
        private void pb_page6_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back?\nUnsaved data will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InitializeReplaceLostLicensePage();
                htc_operations_management.SelectedIndex = 0; // Select the main operations tab
            }
        }




        #endregion

        #region Input Validation

        public bool ValidatePersonIdOrNationalNo()
        {
            string input = txt_search_local.Text.Trim();
            switch(cb_filter_local.SelectedItem.ToString())
            {
                case "Person ID":
                    if (!InputValidation.IsNumber(input, out string errorMessage))
                    {
                        err_input_validation.SetError(txt_search_local, errorMessage);
                        return false;
                    }
                    break;
                case "National No.":
                    if (!InputValidation.IsAlphanumeric(input, out string errorMessage2))
                    {
                        err_input_validation.SetError(txt_search_local, errorMessage2);
                        return false;
                    }
                    break;
            }
            return true;
        }

        public bool ValidateLicenseId(string input)
        {
            if (!InputValidation.IsNumber(input, out string errorMessage))
            {
                err_input_validation.SetError(txt_search_inter, errorMessage);
                return false;
            }
            return true;
        }


        #endregion


    }
}
