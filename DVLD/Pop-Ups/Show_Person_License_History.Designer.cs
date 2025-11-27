namespace DVLD.Pop_Ups
{
    partial class Show_Person_License_History
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tc_dirver_licenses = new System.Windows.Forms.TabControl();
            this.tp_local = new System.Windows.Forms.TabPage();
            this.tp_international = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tc_dirver_licenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // personDetailsCard
            // 
            this.personDetailsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personDetailsCard.Location = new System.Drawing.Point(272, 100);
            this.personDetailsCard.Name = "personDetailsCard";
            this.personDetailsCard.Size = new System.Drawing.Size(677, 367);
            this.personDetailsCard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(349, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person License History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.license_history;
            this.pictureBox1.Location = new System.Drawing.Point(29, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(24, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Driver\'s Licenses:";
            // 
            // tc_dirver_licenses
            // 
            this.tc_dirver_licenses.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tc_dirver_licenses.Controls.Add(this.tp_local);
            this.tc_dirver_licenses.Controls.Add(this.tp_international);
            this.tc_dirver_licenses.Location = new System.Drawing.Point(29, 555);
            this.tc_dirver_licenses.Multiline = true;
            this.tc_dirver_licenses.Name = "tc_dirver_licenses";
            this.tc_dirver_licenses.SelectedIndex = 0;
            this.tc_dirver_licenses.Size = new System.Drawing.Size(920, 213);
            this.tc_dirver_licenses.TabIndex = 4;
            // 
            // tp_local
            // 
            this.tp_local.BackColor = System.Drawing.SystemColors.Control;
            this.tp_local.Location = new System.Drawing.Point(23, 4);
            this.tp_local.Name = "tp_local";
            this.tp_local.Padding = new System.Windows.Forms.Padding(3);
            this.tp_local.Size = new System.Drawing.Size(893, 205);
            this.tp_local.TabIndex = 0;
            this.tp_local.Text = "Local";
            // 
            // tp_international
            // 
            this.tp_international.BackColor = System.Drawing.SystemColors.Control;
            this.tp_international.Location = new System.Drawing.Point(23, 4);
            this.tp_international.Name = "tp_international";
            this.tp_international.Padding = new System.Windows.Forms.Padding(3);
            this.tp_international.Size = new System.Drawing.Size(893, 205);
            this.tp_international.TabIndex = 1;
            this.tp_international.Text = "International";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(35, 772);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = " ";
            // 
            // Show_Person_License_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 798);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tc_dirver_licenses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personDetailsCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Show_Person_License_History";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person License History";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tc_dirver_licenses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.PersonDetailsCard personDetailsCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tc_dirver_licenses;
        private System.Windows.Forms.TabPage tp_local;
        private System.Windows.Forms.TabPage tp_international;
        private System.Windows.Forms.Label label3;
    }
}