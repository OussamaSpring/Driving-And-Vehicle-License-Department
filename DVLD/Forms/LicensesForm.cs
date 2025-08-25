using DVLD.UserControls;
using System;
using System.Windows.Forms;

namespace DVLD.Forms
{
    public partial class LicensesForm : Form
    {
        public LicensesForm()
        {
            InitializeComponent();

            var tabs = new TabBar
            {
                Dock = DockStyle.Fill,
                Height = 50
            };
            tabs.SetTabs("Local", "International");
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
                }
            };

            tlp_header.Controls.Add(tabs, 1, 0);
        }

        private void OnLocalLicenseTabSelected()
        {
            htc_tab_nav.SelectedIndex = 0; // Select the "Local" tab
        }

        private void OnInternationalLicenseTabSelected()
        {
            htc_tab_nav.SelectedIndex = 1; // Select the "International" tab
        }

        private void LicensesForm_Load(object sender, EventArgs e)
        {
            OnLocalLicenseTabSelected();
        }
    }
}
