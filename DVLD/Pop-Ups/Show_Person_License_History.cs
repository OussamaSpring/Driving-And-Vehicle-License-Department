using Core.Models;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DVLD.Pop_Ups
{
    public partial class Show_Person_License_History : Form
    {
        private readonly LicenseController _licenseController;
        private readonly InternationalLicenseController _internationalLicenseController;

        private int _personId;
        private List<License> _licenseList = new List<License>();
        private List<InternationalLicense> _internationalLicenseList = new List<InternationalLicense>();

        public Show_Person_License_History(int personId)
        {
            InitializeComponent();
            _personId = personId;

            _licenseController = new LicenseController(new LicenseRepository());
            _internationalLicenseController = new InternationalLicenseController(new InternationalLicenseRepository());

        }
        private void Show_Person_License_History_Load(object sender, EventArgs e)
        {
            LoadPersonHistoryData(_personId);
            LoadLicenseData(_personId);
            LoadInternationalLicenseData(_personId);
        }

        private void LoadPersonHistoryData(int personId)
        {
            personDetailsCard.SetPerson(personId);
        }

        private async void LoadLicenseData(int personId)
        {
            _licenseList = (await _licenseController.GetLicensesByPersonIdAsync(personId)).ToList();
            BindLicenseDataToGrid(_licenseList);
        }
        private async void LoadInternationalLicenseData(int personId)
        {
            _internationalLicenseList = (await _internationalLicenseController.GetInternationalLicenseListByPersonIdAsync(personId)).ToList();
            BindInternationalLicenseDataToGrid(_internationalLicenseList);
        }
        private void BindLicenseDataToGrid(IEnumerable<License> licenseList)
        {
            dgv_local_licenses.Rows.Clear();

            foreach(License license in licenseList)
            {
                dgv_local_licenses.Rows.Add(
                    license.LicenseId,
                    license.ApplicationId,
                    license.DriverId,
                    _licenseController.GetLicenseClassNameById(license.ClassId),
                    license.IssueDate.ToShortDateString(),
                    license.ExpirationDate.ToShortDateString(),
                    license.IsActive,
                    license.ExpirationDate.ToShortDateString()
                    );
            }
            lb_total_license_number.Text = dgv_local_licenses.RowCount.ToString();
        }
        private void BindInternationalLicenseDataToGrid(IEnumerable<InternationalLicense> internationalLicenseList)
        {
            dgv_international_licenses.Rows.Clear();

            foreach(InternationalLicense inter in internationalLicenseList)
            {
                dgv_international_licenses.Rows.Add(
                    inter.InternationalLicenseId,
                    inter.ApplicationId,
                    inter.DriverId,
                    inter.LocalLicenseId,
                    inter.IssueDate.ToShortDateString(),
                    inter.ExpirationDate.ToShortDateString(),
                    inter.IsActive
                    );
            }
            lb_inter_total_number.Text = dgv_international_licenses.RowCount.ToString();
        }

    }
}
