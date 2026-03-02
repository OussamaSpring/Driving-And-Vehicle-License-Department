using DVLD.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Models;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using DVLD.Pop_Ups;

namespace DVLD.Forms
{
    public partial class LicensesForm : Form
    {
        private LicenseController _licenseController;
        private InternationalLicenseController _internationalLicenseController;
        private LicenseClassController _licenseClassController;

        private List<License> _licensesList = new List<License>();
        private List<InternationalLicense> _internationalLicensesList = new List<InternationalLicense>();
        private List<LicenseClass> _licenseClassesList = new List<LicenseClass>();

        public LicensesForm()
        {
            InitializeComponent();

            var tabs = new TabBar
            {
                Dock = DockStyle.Fill,
                Height = 50
            };
            tabs.SetTabs("Local", "International", "Classes");
            tabs.SelectedIndexChanged += (s, e) =>
            {
                switch (tabs.SelectedIndex)
                {
                    case 0:
                        OnLocalLicenseTabSelected();
                        break;
                    case 1:
                        OnInternationalLicenseTabSelected();
                        break;
                    case 2:
                        OnLicenseClassesTabSelected();
                        break;
                }
            };

            tlp_header.Controls.Add(tabs, 1, 0);

            _licenseController = new LicenseController(new LicenseRepository());
            _internationalLicenseController = new InternationalLicenseController(new InternationalLicenseRepository());
            _licenseClassController = new LicenseClassController(new LicenseClassRepository());
        }

        private void LicensesForm_Load(object sender, EventArgs e)
        {
            OnLocalLicenseTabSelected();

            // Local License top bar settings
            uc_local_topbar.FillFilterCriteria(_licenseController.GetLicenseFilterCriteria());
            uc_local_topbar.FilterPerformed = Uc_license_topbar_FilterPerformed;
            uc_local_topbar.btn_add_Hide();

            // International License top bar settings
            uc_international_topbar.FillFilterCriteria(_internationalLicenseController.GetInternationalLicenseFilterCriteria());
            uc_international_topbar.FilterPerformed = Uc_international_license_topbar_FilterPerformed;
            uc_international_topbar.btn_add_Hide();
        }
        private async void OnLocalLicenseTabSelected()
        {
            htc_tab_nav.SelectedIndex = 0;
            await LoadLicensesAsync();
        }
        private async void OnInternationalLicenseTabSelected()
        {
            htc_tab_nav.SelectedIndex = 1;
            await LoadInternationalLicensesAsync();
        }
        private async void OnLicenseClassesTabSelected()
        {
            htc_tab_nav.SelectedIndex = 2;
            await LoadLicenseClassesAsync();
        }

        #region Local License Functions
       
        private async Task LoadLicensesAsync()
        {
            _licensesList = (await _licenseController.GetLicensesListAsync()).ToList();
            BindLicensesToGrid(_licensesList);
        }
        private void BindLicensesToGrid(IEnumerable<License> licenses)
        {
            dgv_local_licenses.Rows.Clear();
            foreach (var license in licenses)
            {
                dgv_local_licenses.Rows.Add(
                    license.LicenseId,
                    license.ApplicationId,
                    license.DriverId,
                    _licenseController.GetLicenseClassNameById(license.ClassId),
                    license.IssueDate.ToString("yyyy/M/dd"),
                    license.ExpirationDate.ToString("yyyy/M/dd"),
                    license.IsActive,
                    license.enIssueReason.ToString(),
                    license.IssuedByUserId
                );
            }
            lb_footer_text_local.Text = "Total Number of Licenses: " + dgv_local_licenses.RowCount.ToString();
        }
        private void Uc_license_topbar_FilterPerformed(object sender, FilterArgs e)
        {
            var filtered = _licensesList.Where(license =>
            {
                switch (e.FilterCriteria)
                {
                    case "License ID":
                        return license.LicenseId.ToString().Contains(e.SearchText);
                    case "Application ID":
                        return license.ApplicationId.ToString().Contains(e.SearchText);
                    case "Driver ID":
                        return license.DriverId.ToString().Contains(e.SearchText);
                    case "Class ID":
                        return license.ClassId.ToString().Contains(e.SearchText);
                    case "Issue Date":
                        return license.IssueDate.ToString("yyyy/M/dd").Contains(e.SearchText);
                    case "Expiration Date":
                        return license.ExpirationDate.ToString("yyyy/M/dd").Contains(e.SearchText);
                    case "Paid Fees":
                        return license.PaidFees.ToString().Contains(e.SearchText);
                    case "Status":
                        var statusStr = license.IsActive ? "Active" : "Inactive";
                        return statusStr.ToLower().Contains(e.SearchText.ToLower());
                    case "Issued By User ID":
                        return license.IssuedByUserId.ToString().Contains(e.SearchText);
                    default:
                        return true;
                }
            }).ToList();
            BindLicensesToGrid(filtered);
        }

        #endregion

        #region International License Functions

        private async Task LoadInternationalLicensesAsync()
        {
            _internationalLicensesList = (await _internationalLicenseController.GetInternationalLicensesListAsync()).ToList();
            BindInternationalLicensesToGrid(_internationalLicensesList);
        }
        private void BindInternationalLicensesToGrid(IEnumerable<InternationalLicense> licenses)
        {
            dgv_international_licenses.Rows.Clear();
            foreach (var license in licenses)
            {
                dgv_international_licenses.Rows.Add(
                    license.InternationalLicenseId,
                    license.ApplicationId,
                    license.DriverId,
                    license.LocalLicenseId,
                    license.IssueDate.ToString("yyyy/M/dd"),
                    license.ExpirationDate.ToString("yyyy/M/dd"),
                    license.IsActive,
                    license.IssuedByUserId
                );
            }
            lb_footer_text_inter.Text = "Total Number of International Licenses: " + dgv_international_licenses.RowCount.ToString();
        }
        private void Uc_international_license_topbar_FilterPerformed(object sender, FilterArgs e)
        {
            var filtered = _internationalLicensesList.Where(license =>
            {
                switch (e.FilterCriteria)
                {
                    case "International License ID":
                        return license.InternationalLicenseId.ToString().Contains(e.SearchText);
                    case "Application ID":
                        return license.ApplicationId.ToString().Contains(e.SearchText);
                    case "Driver ID":
                        return license.DriverId.ToString().Contains(e.SearchText);
                    case "Local License ID":
                        return license.LocalLicenseId.ToString().Contains(e.SearchText);
                    case "Issue Date":
                        return license.IssueDate.ToString("yyyy/M/dd").Contains(e.SearchText);
                    case "Expiration Date":
                        return license.ExpirationDate.ToString("yyyy/M/dd").Contains(e.SearchText);
                    case "Status":
                        var statusStr = license.IsActive ? "Active" : "Inactive";
                        return statusStr.ToLower().Contains(e.SearchText.ToLower());
                    case "Issued By User ID":
                        return license.IssuedByUserId.ToString().Contains(e.SearchText);
                    default:
                        return true;
                }
            }).ToList();
            BindInternationalLicensesToGrid(filtered);
        }
        
        #endregion

        #region License Classes Functions
        private async Task LoadLicenseClassesAsync()
        {
            _licenseClassesList = (await _licenseClassController.GetLicenseClassesListAsync()).ToList();
            BindLicenseClassesToGrid(_licenseClassesList);
        }
        private void BindLicenseClassesToGrid(IEnumerable<LicenseClass> classes)
        {
            dgv_license_classes.Rows.Clear();
            foreach (LicenseClass licenseClass in classes)
            {
                dgv_license_classes.Rows.Add(
                    licenseClass.Id,
                    licenseClass.Name,
                    licenseClass.Description,
                    licenseClass.MiminumAllowedAge,
                    licenseClass.DefaultValidityLength,
                    licenseClass.ClassFees
                );
            }
            lb_footer_text_classes.Text = "Total Number of License Classes: " + dgv_license_classes.RowCount.ToString();
        }

        #endregion

        private void tsmi_ViewLicenseCard_Click(object sender, EventArgs e)
        {
            if (dgv_local_licenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a license to view.", "No License Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedLicenseId = Convert.ToInt32(dgv_local_licenses.SelectedRows[0].Cells["license_id"].Value);
            Show_Driver_Card showDriverCardForm = new Show_Driver_Card(selectedLicenseId);
            showDriverCardForm.Show(this.FindForm());
        }

    }
}