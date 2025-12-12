namespace DVLD.Pop_Ups
{
    partial class Show_Application_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.applicationDetails = new DVLD.UserControls.ApplicationDetails();
            this.SuspendLayout();
            // 
            // applicationDetails
            // 
            this.applicationDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationDetails.Location = new System.Drawing.Point(0, 0);
            this.applicationDetails.Margin = new System.Windows.Forms.Padding(0);
            this.applicationDetails.Name = "applicationDetails";
            this.applicationDetails.Size = new System.Drawing.Size(646, 300);
            this.applicationDetails.TabIndex = 0;
            // 
            // Show_Application_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 300);
            this.Controls.Add(this.applicationDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Show_Application_Details";
            this.Text = "Show_Application_Details";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ApplicationDetails applicationDetails;
    }
}