using DVLD.UserControls;
using System;
using System.Windows.Forms;

namespace DVLD.Forms
{
    public partial class LicenseDetainForm : Form
    {
        public LicenseDetainForm()
        {
            InitializeComponent();

            var tabs = new TabBar
            {
                Dock = DockStyle.Fill,
                Height = 50
            };
            tabs.SetTabs("Operations", "Detains List");
            tabs.SelectedIndexChanged += (s, e) =>
            {
                switch (tabs.SelectedIndex)
                {
                    case 0:
                        OnOperationsTabSelected();
                        break;
                    case 1:
                        OnDetainsListTabSelected();
                        break;
                }
            };

            tlp_header.Controls.Add(tabs, 1, 0);
        }


        private void OnOperationsTabSelected()
        {
            htc_tab_nav.SelectedIndex = 0; // Select the "Operations" tab
        }

        private void OnDetainsListTabSelected()
        {
            htc_tab_nav.SelectedIndex = 1; // Select the "Detains List" tab
        }

        private void LicenseDetainForm_Load(object sender, EventArgs e)
        {
            OnOperationsTabSelected();
        }
    }
}
