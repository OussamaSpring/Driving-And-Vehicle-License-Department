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
            tabs.SetTabs("Appointments", "Tests List");
            tabs.SelectedIndexChanged += (s, e) =>
            {
                Console.WriteLine($"Selected {tabs.SelectedIndex}: {tabs.SelectedTab}");
            };

            tlp_header.Controls.Add(tabs, 1, 0);
        }
    }
}
