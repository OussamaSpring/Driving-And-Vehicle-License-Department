namespace DVLD.Pop_Ups
{
    partial class Show_Person_Details
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
            this.personDetailsCard = new DVLD.UserControls.PersonDetailsCard();
            this.SuspendLayout();
            // 
            // personDetailsCard
            // 
            this.personDetailsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personDetailsCard.Location = new System.Drawing.Point(0, 0);
            this.personDetailsCard.Name = "personDetailsCard";
            this.personDetailsCard.Size = new System.Drawing.Size(670, 369);
            this.personDetailsCard.TabIndex = 0;
            // 
            // Show_Person_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 369);
            this.Controls.Add(this.personDetailsCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Show_Person_Details";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Show_Person_Details";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.PersonDetailsCard personDetailsCard;
    }
}