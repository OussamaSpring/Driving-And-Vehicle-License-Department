using Core.Enums;
using Core.Models;
using DVLD.Views.Components;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Pop_Ups
{
    public partial class Add_Edit_User : RoundedBaseForm
    {
        public Action<int> ClosingEvent;

        private readonly PersonController _personController;
        private readonly UserController _userController;
        private enum State { Add = 1, Update = 2 }
        private State state;

        private Person _person;
        private User _user;

        public Add_Edit_User(int? id)
        {
            InitializeComponent();

            _personController = new PersonController(new PersonRepository());
            _userController = new UserController(new UserRepository());

            if (id == null)
            {
                state = State.Add;
                lb_title.Text = "Add New User";

            }
            else
            {
                state = State.Update;
                lb_title.Text = "Edit User Info";


            }
        }

        #region Help Functions


        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        #endregion


        #region UI Events

        private async void Add_Edit_Person_Load(object sender, EventArgs e)
        {

        }
        private void lb_upload_image_Click(object sender, EventArgs e)
        {
            //ofd_upload_image.Title = "Select Profile Image";
            //ofd_upload_image.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            //if (ofd_upload_image.ShowDialog() == DialogResult.OK)
            //{
            //    Image img = Image.FromFile(ofd_upload_image.FileName);
            //    rpb_profile_image.Image = img;
            //    lb_remove_image.Visible = true;
            //    HasImageChanged = true;
            //    IsImageEmpty = false;
            //}
        }
        private void lb_remove_image_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("Are you sure you want to remove the profile image?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            //    return;

            //rpb_profile_image.Image = img_list_default_profile.Images[cb_gender.SelectedIndex];
            //lb_remove_image.Visible = false;
            //HasImageChanged = true;
            //IsImageEmpty = true;
        }

        private void btn_save_MouseClick(object sender, MouseEventArgs e)
        {
            btn_save.Enabled = false; // Disable button to prevent multiple clicks

            //if ((!HasDataChanged || !HasImageChanged) && state == State.Update)
            //{
            //    this.Dispose();
            //    return;
            //}

            //if (!ValidateAllInputs())
            //{
            //    MessageBox.Show("Please correct the input fields errors before saving.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    btn_save.Enabled = true; // Re-enable button
            //    return;
            //}

            //switch (state)
            //{
            //    case State.Add:
            //        //_person = await MapPersonData();
            //        try
            //        {
            //            if(await _personController.IsPersonExistAsync(_person.NationalNumber))
            //            {
            //                MessageBox.Show("Failed to add the person. National number already exist!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }

            //            var newPersonId = await _personController.AddPersonAsync(_person);

            //            if (newPersonId.HasValue)
            //            {
            //                lb_person_id.Text = newPersonId.Value.ToString();

            //                MessageBox.Show($"Person added successfully with ID: {newPersonId.Value}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //                ClosingEvent?.Invoke(newPersonId.Value);
            //                this.Close();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Failed to add the person. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }

            //        } catch (Exception ex)
            //        {
            //            MessageBox.Show($"An error occurred while adding the person: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        finally
            //        {
            //            btn_save.Enabled = true; // Re-enable button
            //        }

            //        break;
                
            //    case State.Update:

            //        Person updatedPerson = MapPersonData().Result;
            //        updatedPerson.PersonId = _person.PersonId;

            //        try
            //        {
            //            bool isUpdated = await _personController.UpdatePersonInfoAsync(updatedPerson);
            //            if (isUpdated)
            //            {
            //                MessageBox.Show("Person details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //                ClosingEvent?.Invoke(_person.PersonId);
            //                this.Close();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Failed to update the person details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show($"An error occurred while updating the person details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        finally
            //        {
            //            btn_save.Enabled = true; // Re-enable button
            //        }
            //        break;
            //}
        }
        private void btn_Exit_Clicked(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit without saving?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            this.Dispose();
        }

        #endregion


        #region Input Validation

        // Each validation function checks a specific input field and sets an error message if validation fails.
        

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
