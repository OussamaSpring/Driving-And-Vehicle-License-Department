using DVLD.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            var tabs = new TabBar
            {
                Dock = DockStyle.Fill,
                Height = 50
            };
            tabs.SetTabs("Profile Settings", "Users Management");
            tabs.SelectedIndexChanged += (s, e) =>
            {
                switch (tabs.SelectedIndex)
                {
                    case 0:
                        OnProfileSettingsTabSelected();
                        break;
                    case 1:
                        OnUsersManagementTabSelected();
                        break;
                }
            };

            tlp_header.Controls.Add(tabs, 1, 0);
        }

        private void OnProfileSettingsTabSelected()
        {
            htc_tab_nav.SelectedIndex = 0;
        }

        private void OnUsersManagementTabSelected()
        {
            htc_tab_nav.SelectedIndex = 1;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            OnProfileSettingsTabSelected();
        }
    }
}
