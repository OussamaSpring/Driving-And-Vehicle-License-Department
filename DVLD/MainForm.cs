using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DVLD.Forms;

using WindowsFormsControlLibrary.CustomControls;

namespace DVLD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DashboardForm child = new DashboardForm();
            child.MdiParent = this; // 'this' refers to the parent form
            child.Dock = DockStyle.Fill; // Fill the parent form
            child.Show();

        }
    }
}
