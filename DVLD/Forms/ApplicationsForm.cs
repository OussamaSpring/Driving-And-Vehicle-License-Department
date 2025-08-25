using DVLD.UserControls;
using System;
using System.Windows.Forms;

namespace DVLD.Forms
{
    public partial class ApplicationsForm : Form
    {
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


        }


        private void OnOperationsTabSelected()
        {
            htc_tab_nav.SelectedIndex = 0; // Select the "Operations" tab
        }

        private void OnApplicationsListTabSelected()
        {
            htc_tab_nav.SelectedIndex = 1; // Select the "Applications List" tab
        }

        private void OnApplicationsTypesTabSelected()
        {
            htc_tab_nav.SelectedIndex = 2; // Select the "Applications Types" tab
        }

        private void ApplicationsForm_Load(object sender, EventArgs e)
        {
            OnOperationsTabSelected();
        }
    }
}
