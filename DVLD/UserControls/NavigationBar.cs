using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UserControls
{
    public partial class NavigationBar : UserControl
    {
        public NavigationBar()
        {
            InitializeComponent();
        }

        public enum NavBarIems
        {
            enDashboard = 1,
            enIndividuals,
            enLicenses,
            enApplications,
            enTestManagement,
            enLicenseDetain,
            enSettings
        }

        public NavBarIems SelectedNavBarItem;
        public event EventHandler<NavBarIems> NavigationChanged;
        

        #region Navigation Button Click Events

        private Image getButtonImage(string buttonName)
        {
            // This method should return the appropriate black image based on the button name
            switch (buttonName)
            {
                case "Dashboard":
                    return Properties.Resources.Dashboard;
                case "Individuals":
                    return Properties.Resources.Users;
                case "Licenses":
                    return Properties.Resources.Credit_card;
                case "Applications":
                    return Properties.Resources.File_text;
                case "Test_Management":
                    return Properties.Resources.Edit;
                case "License_Detain":
                    return Properties.Resources.Paperclip;
                default:
                    return null;
            }
        }
        private Image getButtonBlackImage(string buttonName)
        {
            // This method should return the appropriate black image based on the button name
            switch (buttonName)
            {
                case "Dashboard":
                    return Properties.Resources.Dashboard_Black;
                case "Individuals":
                    return Properties.Resources.Users_Black;
                case "Licenses":
                    return Properties.Resources.Credit_card_Black;
                case "Applications":
                    return Properties.Resources.File_text_Black;
                case "Test_Management":
                    return Properties.Resources.Edit_Black;
                case "License_Detain":
                    return Properties.Resources.Paperclip_Black;
                default:
                    return null;
            }
        }


        private void setActiveButtonTheme(Button button)
        {
            button.BackColor = Color.FromArgb(212, 175, 55);
            button.ForeColor = Color.FromArgb(28, 28, 28);
            button.Image = getButtonBlackImage(button.Name);
            button.Font = new Font(button.Font, FontStyle.Bold);
        }

        private void setDefaultButtonTheme(Button button)
        {
            button.BackColor = Color.FromArgb(26, 62, 114);
            button.ForeColor = Color.White;
            button.Image = getButtonImage(button.Name);
            button.Font = new Font(button.Font, FontStyle.Regular);

        }

        private void setHoverButtonTheme(Button button)
        {
            button.BackColor = Color.FromArgb(59, 90, 134);
        }

        private void ResetAllNavbarButtonThemes()
        {
            // Reset all buttons inside tlp_navbar_buttons to default theme
            foreach (Control control in tlp_navbar_buttons.Controls)
            {
                if (control is Button button)
                {
                    setDefaultButtonTheme(button);
                }
            }
        }

        private void navbar_btn_Click(object sender, MouseEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                ResetAllNavbarButtonThemes();
                btn_settings.Font = new Font(btn_settings.Font, FontStyle.Regular);

                // Set the clicked button to active theme
                setActiveButtonTheme(clickedButton);

                // Raise the event with the index of the clicked button
                SelectedNavBarItem = (NavBarIems)Int16.Parse(clickedButton.Tag.ToString());
                NavigationChanged?.Invoke(this, SelectedNavBarItem);
            }
        }

        private void navbar_btn_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button && button.BackColor != Color.FromArgb(212, 175, 55))
                setDefaultButtonTheme(button);
        }
        private void navbar_btn_MouseEnter(object sender, EventArgs e)
        {
            if(sender is Button && (sender as Button).BackColor != Color.FromArgb(212, 175, 55))
                setHoverButtonTheme(sender as Button);
        }

        #endregion

        public void setInitialNavbar()
        {
            navbar_btn_Click(tlp_navbar_buttons.Controls["Dashboard"], null);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            ResetAllNavbarButtonThemes();
            btn_settings.Font = new Font(btn_settings.Font, FontStyle.Bold);
            NavigationChanged?.Invoke(this, NavBarIems.enSettings);
        }
    }
}
