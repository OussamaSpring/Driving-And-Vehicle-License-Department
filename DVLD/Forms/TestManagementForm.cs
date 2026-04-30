using Core.Models;
using DVLD.Pop_Ups;
using DVLD.UserControls;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Forms
{
    public partial class TestManagementForm : Form
    {
        private LocalDrivingLicenseApplicationController _localDrivingLicenseApplicationController;
        private TestTypeController _testTypeController;
        private List<LocalDrivingLicenseApplication> _testsList;

        public TestManagementForm()
        {
            InitializeComponent();

            var tabs = new TabBar
            {
                Dock = DockStyle.Fill,
                Height = 50
            };
            tabs.SetTabs("Test List", "Test Types");
            tabs.SelectedIndexChanged += (s, e) =>
            {
                switch (tabs.SelectedIndex)
                {
                    case 0:
                        OnTestsListSelected();
                        break;
                    case 1:
                        OnTestTypesSelected();
                        break;
                }
            };

            tlp_header.Controls.Add(tabs, 1, 0);


            _testTypeController = new TestTypeController(new TestTypeRepository());
            _localDrivingLicenseApplicationController = new LocalDrivingLicenseApplicationController(new LocalDrivingLicenseApplicationRepository(), new LicenseRepository());
        }


        private async void TestManagementForm_Load(object sender, EventArgs e)
        {
            await OnTestsListSelected();

            uc_tests_list_topbar.btn_add_Hide();
            //uc_tests_list_topbar.FillFilterCriteria
        }





        #region Tests List

        private async Task LoadTestsListAsync()
        {
            _testsList = new List<LocalDrivingLicenseApplication>(await _localDrivingLicenseApplicationController.GetAllLocalDrivingLicenseApplicationsAsync());
            BindTestsList(_testsList);
        }
        private void BindTestsList(IEnumerable<LocalDrivingLicenseApplication> tests)
        {
            dgv_tests_list.Rows.Clear();

            foreach (var test in tests)
            {
                dgv_tests_list.Rows.Add(
                    test.LDL_ApplicationId,
                    test.LicenseClass.Name.ToString(),
                    test.NationalNumber,
                    test.FullName,
                    test.ApplicationDate.ToShortDateString(),
                    test.PassedTest,
                    test.Status.ToString()
                );
            }

            lb_total_tests_number.Text = dgv_tests_list.Rows.Count.ToString();
        }



        #endregion

        #region Context Menu Actions

        private void cms_tests_management_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(dgv_tests_list.SelectedRows.Count == 0)
            {
                tsmi_show_app_details.Enabled = false;
                tsmi_edit_app.Enabled = false;
                tsmi_issue_license.Enabled = false;
                tsmi_show_license.Enabled = false;
                tsmi_schedule_test.Enabled = false;
                tsmi_issue_license.Enabled = false;
                tsmi_show_license.Enabled = false;
            }
            else
            {
                tsmi_show_app_details.Enabled = true;
                tsmi_edit_app.Enabled = true;
                tsmi_issue_license.Enabled = true;
                tsmi_show_license.Enabled = true;

                int LDL_ApplicationId = (int)dgv_tests_list.SelectedRows[0].Cells[0].Value;

                var application = _testsList.Find(a => a.LDL_ApplicationId == LDL_ApplicationId);
                int passendTest = application.PassedTest;

                //tsmi_issue_license.Enabled = (passendTest ==3) && ;


            }


        }

        private void tsmi_show_app_details_Click(object sender, EventArgs e)
        {
            if (dgv_tests_list.SelectedRows.Count > 0)
            {
                int applicationId = (int)dgv_tests_list.SelectedRows[0].Cells[0].Value;
                var application = _testsList.Find(a => a.LDL_ApplicationId == applicationId);
                if (application != null)
                {
                    Show_Application_Details show_Application_Details = new Show_Application_Details(application.ApplicationId);
                    show_Application_Details.Show(this.FindForm());
                }
            }
        }


        private void tsmi_edit_app_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Application functionality is not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmi_issue_license_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Issue License functionality is not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmi_show_license_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show License functionality is not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmi_schedule_test_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Test Types

        private List<TestType> _testTypes;
        private async Task LoadTestTypesListAsync()
        {
            _testTypes = new List<TestType>(await _testTypeController.GetAllTestTypesAsync());
            BindTestTypesList(_testTypes);
        }
        private void BindTestTypesList(IEnumerable<TestType> testTypes)
        {
            dgv_test_types.Rows.Clear();
            foreach (var testType in testTypes)
            {
                dgv_test_types.Rows.Add(
                    testType.TypeId,
                    testType.TypeTitle,
                    testType.TypeDescription,
                    testType.TypeFee.ToString("C", CultureInfo.GetCultureInfo("en-US")));
            }
            lb_total_test_types_number.Text = dgv_test_types.Rows.Count.ToString();
        }

        #endregion


        #region Tab Switching
        private async Task OnTestsListSelected()
        {
            htc_tab_nav.SelectedIndex = 0;
            await LoadTestsListAsync();
        }
        private async void OnTestTypesSelected()
        {
            htc_tab_nav.SelectedIndex = 1;
            await LoadTestTypesListAsync();
        }



        #endregion


    }
}
