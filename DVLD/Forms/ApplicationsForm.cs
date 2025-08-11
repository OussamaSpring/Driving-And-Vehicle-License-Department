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
                Console.WriteLine($"Selected {tabs.SelectedIndex}: {tabs.SelectedTab}");
            };

            tlp_header.Controls.Add(tabs, 1, 0);


        }
    }
}
