using Core.Interfaces;
using Core.Models;
using DVLD.Pop_Ups;
using DVLD.UserControls;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Forms
{
    public partial class ApplicationsForm : Form
    {
        private readonly ApplicationTypeController _applicationTypeController;
        private readonly ApplicationsController _applicationController;
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
        }

        private void ApplicationsForm_Load(object sender, EventArgs e)
        {
            OnOperationsTabSelected();
            

            uc_application_list_topbar.btn_add_Hide();
            uc_application_list_topbar.FillFilterCriteria(_applicationController.GetApplicationFilterCriteria());
            uc_application_list_topbar.FilterPerformed += Uc_application_list_topbar_FilterPerformed;
        }



        #region Application Operations
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
                    app.PaidFees?.ToString("C") ?? "N/A",
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
                        return (app.PaidFees?.ToString("C") ?? "N/A").ToLower().Contains(e.SearchText.ToLower());
                    case "Created By User ID":
                        return app.CreatedByUserId.ToString().Contains(e.SearchText);
                    default:
                        return true;
                }
            }).ToList();

            BindApplicationsToGrid(filtered);
        }

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
                    type.ApplicationTypeFees
                    );
            }
            lb_total_application_types.Text = dgv_application_types.RowCount.ToString();
        }

        #endregion


        #region Tab Switching Methods

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

        #endregion
    }
}
