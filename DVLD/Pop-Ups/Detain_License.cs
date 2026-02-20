using Core.Models;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;
using System.Windows.Forms;

namespace DVLD.Pop_Ups
{
    public partial class Detain_License : DVLD.Views.Components.RoundedBaseForm
    {
        public Action<int> ClosingEvent;

        private DetainedLicense _detainedLicense;
        private int _licenseId;

        private readonly LicenseDetainController _licenseDetainController;
        private readonly LicenseController _licenseController;
        public Detain_License()
        {
            InitializeComponent();

            lb_detain_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lb_created_by_detain.Text = Session.CurrentUserProvider.CurrentUser.Username;

            _licenseId = -1;
            _licenseDetainController = new LicenseDetainController(new LicenseDetainRepository());
            _licenseController = new LicenseController(new LicenseRepository());
        }

        #region UI Events
        private async void btn_search_detain_Click(object sender, EventArgs e)
        {
            btn_cancel.Enabled = false;

            if (!ValidateLicenseIdInput())
            {
                btn_cancel.Enabled = true;
                return;
            }

            try
            {
                int licenseId = Convert.ToInt32(txt_search_detain.Text.Trim());
                bool licenseExists = await _licenseController.DoesLicenseExistAsync(licenseId);

                if (!licenseExists)
                {
                    MessageBox.Show("License ID does not exist.");
                    btn_cancel.Enabled = true;
                    return;
                }

                bool isDetained = await _licenseDetainController.IsLicenseDetainedAsync(licenseId);
                if (isDetained)
                {
                    MessageBox.Show("This license is already detained.");
                    btn_cancel.Enabled = true;
                    return;
                }
                _licenseId = licenseId;
                driverLicenseCard.SetDriverLicense(licenseId);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for license: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TODO: Log exception
            }
            finally
            {
                btn_cancel.Enabled = true;
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit without saving?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            this.Dispose();
        }
        private void btn_detain_Click(object sender, EventArgs e)
        {
            btn_detain.Enabled = false;

            if (_licenseId == -1 || !ValidateFeesInput())
            {
                btn_detain.Enabled = true;
                return;
            }

            if(MessageBox.Show("Are you sure you want to detain this license?", "Confirm Detain", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                btn_detain.Enabled = true;
                return;
            }

            try
            {
                _detainedLicense = new DetainedLicense
                {
                    LicenseID = _licenseId,
                    DetainDate = DateTime.Now,
                    FineFees = decimal.Parse(txt_fine_fees_detain.Text.Trim()),
                    CreatedByUserID = Session.CurrentUserProvider.CurrentUser.UserId,
                    IsReleased = false
                };
                var result = _licenseDetainController.DetainLicenseAsync(_detainedLicense).GetAwaiter().GetResult();
                if (result)
                {
                    MessageBox.Show("License detained successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClosingEvent?.Invoke(_licenseId);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Failed to detain license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error detaining license: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Input Validation
        private bool ValidateLicenseIdInput()
        {
            errorProvider.SetError(txt_search_detain, string.Empty);

            if (string.IsNullOrWhiteSpace(txt_search_detain.Text))
            {
                errorProvider.SetError(txt_search_detain, "Please enter a License ID.");
                return false;
            }
            if (!int.TryParse(txt_search_detain.Text.Trim(), out _))
            {
                errorProvider.SetError(txt_search_detain, "License ID must be a valid number.");
                return false;
            }
            return true;
        }

        private bool ValidateFeesInput()
        {
            errorProvider.SetError(txt_fine_fees_detain, string.Empty);

            if (string.IsNullOrWhiteSpace(txt_fine_fees_detain.Text))
            {
                errorProvider.SetError(txt_fine_fees_detain, "Please enter Fine Fees.");
                return false;
            }
            if (!float.TryParse(txt_fine_fees_detain.Text.Trim(), out _))
            {
                errorProvider.SetError(txt_fine_fees_detain, "Fine Fees must be a valid number.");
                return false;
            }
            return true;
        }

        #endregion


        #region Mouse Events for Dragging the Form

        /* These events are linked to the header panel to allow dragging the form by the header.
         * They call the base class methods to handle the dragging logic.
         */

        private void pl_header_MouseDown(object sender, MouseEventArgs e)
        {
            base.RoundedBaseForm_MouseDown(sender, e);
        }

        private void pl_header_MouseMove(object sender, MouseEventArgs e)
        {
            base.RoundedBaseForm_MouseMove(sender, e);
        }

        private void pl_header_MouseUp(object sender, MouseEventArgs e)
        {
            base.RoundedBaseForm_MouseUp(sender, e);
        }

        #endregion
    }
}
