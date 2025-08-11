using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DVLD.UserControls; // Ensure this namespace matches your project structure

namespace DVLD.Forms
{
    public partial class IndividualsForm : Form
    {
        public IndividualsForm()
        {
            InitializeComponent();

            var tabs = new TabBar
            {
                Dock = DockStyle.Fill,
                Height = 50
            };
            tabs.SetTabs("People", "Drivers", "Users");
            tabs.SelectedIndexChanged += (s, e) =>
            {
                Console.WriteLine($"Selected {tabs.SelectedIndex}: {tabs.SelectedTab}");
            };

            tlp_header.Controls.Add(tabs, 1, 0);


        }
    }
}
