using DVLD.Forms;
using DVLD.UserControls;
using System;
using System.Windows.Forms;


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
            NavBar.NavigationChanged += NavBar_NavigationChanged;
            NavBar.setInitialNavbar();
        }

        private void NavBar_NavigationChanged(object sender, NavigationBar.NavBarIems SelectedNavBarItem)
        {
            switch (SelectedNavBarItem)
            {
                case NavigationBar.NavBarIems.enDashboard:
                    CloseAllMdiChildren();
                    ShowDashboard();
                    break;
                case NavigationBar.NavBarIems.enIndividuals:
                    CloseAllMdiChildren();
                    ShowIndividuals();
                    break;
                case NavigationBar.NavBarIems.enLicenses:
                    CloseAllMdiChildren();
                    ShowLicenses();
                    break;
                case NavigationBar.NavBarIems.enApplications:
                    CloseAllMdiChildren();
                    ShowApplications();
                    break;
                case NavigationBar.NavBarIems.enTestManagement:
                    CloseAllMdiChildren();
                    ShowTestManagement();
                    break;
                case NavigationBar.NavBarIems.enLicenseDetain:
                    CloseAllMdiChildren();
                    ShowLicenseDetain();
                    break;
                case NavigationBar.NavBarIems.enSettings:
                    CloseAllMdiChildren();
                    ShowSettings(sender, EventArgs.Empty);
                    break;
                default:
                    Console.WriteLine("Not Expected Error In Navigation Bar");
                    break;
            }
        }

        private void CloseAllMdiChildren()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
                child.Dispose();
            }
        }

        private void ShowDashboard()
        {
            DashboardForm form = new DashboardForm();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void ShowIndividuals()
        {
            IndividualsForm form = new IndividualsForm();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void ShowLicenses()
        {
            LicensesForm form = new LicensesForm();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void ShowApplications()
        {
            ApplicationsForm form = new ApplicationsForm();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void ShowTestManagement()
        {
            TestManagementForm form = new TestManagementForm();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void ShowLicenseDetain()
        {
            LicenseDetainForm form = new LicenseDetainForm();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }


        private void ShowSettings(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }


    }
}
