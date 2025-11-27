namespace DVLD.Pop_Ups
{
    partial class Show_Driver_Card
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
            this.driverLicenseCard1 = new DVLD.UserControls.DriverLicenseCard();
            this.SuspendLayout();
            // 
            // driverLicenseCard1
            // 
            this.driverLicenseCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverLicenseCard1.Location = new System.Drawing.Point(0, 0);
            this.driverLicenseCard1.Name = "driverLicenseCard1";
            this.driverLicenseCard1.Size = new System.Drawing.Size(657, 374);
            this.driverLicenseCard1.TabIndex = 0;
            // 
            // Show_Driver_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 374);
            this.Controls.Add(this.driverLicenseCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Show_Driver_Card";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Show_Driver_Card";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.DriverLicenseCard driverLicenseCard1;
    }
}