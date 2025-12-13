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
    public partial class DetainedLicenses : Form
    {
        private LicenseDetainController _licenseDetainController;

        private List<DetainedLicense> _detainedLicensesList = new List<DetainedLicense>();
        public DetainedLicenses()
        {
            InitializeComponent();

            _licenseDetainController = new LicenseDetainController(new LicenseDetainRepository());
        }

        private void LicenseDetainForm_Load(object sender, EventArgs e)
        {
            uc_license_detain_topbar.btn_add_Hide();
            uc_license_detain_topbar.FillFilterCriteria(_licenseDetainController.GetDetainFilterCriteria());
            LoadDetainedLicensesAsync();
        }
        private async void LoadDetainedLicensesAsync()
        {
            _detainedLicensesList = new List<DetainedLicense>(await _licenseDetainController.GetDetainsListAsync());
            BindDetainedLicensesToGrid(_detainedLicensesList);
            uc_license_detain_topbar.FilterPerformed = Uc_license_detain_topbar_FilterPerformed;
        }
        private void BindDetainedLicensesToGrid(IEnumerable<DetainedLicense> detainedLicenses)
        {
            dgv_Detained_Licenses.Rows.Clear();

            foreach (var detain in detainedLicenses)
            {
                dgv_Detained_Licenses.Rows.Add(
                    detain.DetainID,
                    detain.LicenseID,
                    detain.DetainDate.ToString("yyyy-MM-dd"),
                    detain.FineFees.ToString("F2"),
                    detain.CreatedByUserID,
                    detain.IsReleased,
                    detain.ReleaseDate?.ToString("yyyy-MM-dd") ?? "N/A",
                    detain.ReleasedByUserID?.ToString() ?? "N/A",
                    detain.ReleaseApplicationID?.ToString() ?? "N/A"
                );
            }
            lb_total_detain_number.Text = dgv_Detained_Licenses.RowCount.ToString();
        }
        private void Uc_license_detain_topbar_FilterPerformed(object sender, FilterArgs e)
        {
            var filtered = _detainedLicensesList.Where(detain =>
            {
                switch (e.FilterCriteria)
                {
                    case "Detain ID":
                        return detain.DetainID.ToString().Contains(e.SearchText);
                    case "License ID":
                        return detain.LicenseID.ToString().Contains(e.SearchText);
                    case "Detain Date":
                        return detain.DetainDate.ToString("yyyy-MM-dd").Contains(e.SearchText);
                    case "Fine Fees":
                        return detain.FineFees.ToString("F2").Contains(e.SearchText);
                    case "Created By User ID":
                        return detain.CreatedByUserID.ToString().Contains(e.SearchText);
                    case "Is Released":
                        var releasedStr = detain.IsReleased ? "Yes" : "No";
                        return releasedStr.ToLower().Contains(e.SearchText.ToLower());
                    case "Release Date":
                        return (detain.ReleaseDate?.ToString("yyyy-MM-dd") ?? "N/A").Contains(e.SearchText);
                    case "Released By User ID":
                        return (detain.ReleasedByUserID?.ToString() ?? "N/A").Contains(e.SearchText);
                    case "Release Application ID":
                        return (detain.ReleaseApplicationID?.ToString() ?? "N/A").Contains(e.SearchText);
                    default:
                        return true;
                }
            }).ToList();

            BindDetainedLicensesToGrid(filtered);
        }
        private void tsmi_ViewLicenseCard_Click(object sender, EventArgs e)
        {
            if (dgv_Detained_Licenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a license to view.", "No License Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedLicenseId = Convert.ToInt32(dgv_Detained_Licenses.SelectedRows[0].Cells["license_id"].Value);
            Show_Driver_Card showDriverCardForm = new Show_Driver_Card(selectedLicenseId);
            showDriverCardForm.Show(this.FindForm());
        }
    }
}
