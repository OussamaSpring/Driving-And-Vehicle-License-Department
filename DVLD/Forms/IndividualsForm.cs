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
            tabs.SetTabs("People", "Drivers");
            tabs.SelectedIndexChanged += (s, e) =>
            {
                switch (tabs.SelectedIndex)
                {
                    case 0:
                        OnPeopleTabSelected();
                        break;
                    case 1:
                        OnDriversTabSelected();
                        break;
                }
            };

            tlp_header.Controls.Add(tabs, 1, 0);


        }


        private void OnPeopleTabSelected()
        {
            htc_tab_nav.SelectedIndex = 0; // Select the "People" tab
        }

        private void OnDriversTabSelected()
        {
            htc_tab_nav.SelectedIndex = 1; // Select the "Drivers" tab
        }

        private void IndividualsForm_Load(object sender, EventArgs e)
        {
            OnPeopleTabSelected();
        }
    }
}
