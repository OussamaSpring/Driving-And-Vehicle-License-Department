namespace DVLD.UserControls
{
    partial class Header
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_username = new System.Windows.Forms.Label();
            this.pb_profileImage = new WindowsFormsControlLibrary.CustomControls.RoundedPictureBox();
            this.pl_user = new System.Windows.Forms.Panel();
            this.cms_user_properties = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.profile = new System.Windows.Forms.ToolStripMenuItem();
            this.log_out = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profileImage)).BeginInit();
            this.pl_user.SuspendLayout();
            this.cms_user_properties.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lb_username.Location = new System.Drawing.Point(56, 13);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(85, 23);
            this.lb_username.TabIndex = 5;
            this.lb_username.Text = "Username";
            // 
            // pb_profileImage
            // 
            this.pb_profileImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_profileImage.BackColor = System.Drawing.Color.Transparent;
            this.pb_profileImage.Location = new System.Drawing.Point(10, 3);
            this.pb_profileImage.Name = "pb_profileImage";
            this.pb_profileImage.Radius = 50;
            this.pb_profileImage.Size = new System.Drawing.Size(40, 40);
            this.pb_profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_profileImage.TabIndex = 6;
            this.pb_profileImage.TabStop = false;
            this.pb_profileImage.Text = "roundedPictureBox1";
            // 
            // pl_user
            // 
            this.pl_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_user.Controls.Add(this.pb_profileImage);
            this.pl_user.Controls.Add(this.lb_username);
            this.pl_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pl_user.Location = new System.Drawing.Point(860, 6);
            this.pl_user.Name = "pl_user";
            this.pl_user.Size = new System.Drawing.Size(154, 47);
            this.pl_user.TabIndex = 7;
            this.pl_user.Click += new System.EventHandler(this.pl_user_Click);
            // 
            // cms_user_properties
            // 
            this.cms_user_properties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profile,
            this.log_out});
            this.cms_user_properties.Name = "cms_user_properties";
            this.cms_user_properties.Size = new System.Drawing.Size(134, 56);
            // 
            // profile
            // 
            this.profile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.Image = global::DVLD.Properties.Resources.Users_Black;
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(133, 26);
            this.profile.Text = "Profile";
            // 
            // log_out
            // 
            this.log_out.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(133, 26);
            this.log_out.Text = "Log Out";
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.pl_user);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(1024, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pb_profileImage)).EndInit();
            this.pl_user.ResumeLayout(false);
            this.pl_user.PerformLayout();
            this.cms_user_properties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private WindowsFormsControlLibrary.CustomControls.RoundedPictureBox pb_profileImage;
        private System.Windows.Forms.Panel pl_user;
        private System.Windows.Forms.ContextMenuStrip cms_user_properties;
        private System.Windows.Forms.ToolStripMenuItem profile;
        private System.Windows.Forms.ToolStripMenuItem log_out;
    }
}
