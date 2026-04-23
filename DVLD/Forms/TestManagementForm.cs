using DVLD.UserControls;
using System;
using System.Windows.Forms;

namespace DVLD.Forms
{
    public partial class TestManagementForm : Form
    {
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
        }


        private void OnTestsListSelected()
        {
            htc_tab_nav.SelectedIndex = 0;
        }

        private void OnTestTypesSelected()
        {
            htc_tab_nav.SelectedIndex = 1;
        }

        private void TestManagementForm_Load(object sender, EventArgs e)
        {
            OnTestsListSelected();
        }
    }
}
