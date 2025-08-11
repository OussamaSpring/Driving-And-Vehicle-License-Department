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
                Console.WriteLine($"Selected {tabs.SelectedIndex}: {tabs.SelectedTab}");
            };

            tlp_header.Controls.Add(tabs, 1, 0);
        }
    }
}
