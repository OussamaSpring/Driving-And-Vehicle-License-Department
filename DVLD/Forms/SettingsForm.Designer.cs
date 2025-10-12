namespace DVLD.Forms
{
    partial class SettingsForm
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_users_management = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.htc_settings_tabs = new DVLD.CustomControls.HeaderlessTabControl();
            this.tab_profile = new System.Windows.Forms.TabPage();
            this.tab_users_management = new System.Windows.Forms.TabPage();
            this.lb_remove_image = new System.Windows.Forms.Label();
            this.lb_upload_image = new System.Windows.Forms.Label();
            this.rpb_profile_image = new WindowsFormsControlLibrary.CustomControls.RoundedPictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.htc_settings_tabs.SuspendLayout();
            this.tab_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpb_profile_image)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(20, 20);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(119, 29);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "Settings.";
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.SystemColors.Control;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.Color.Black;
            this.btn_profile.Location = new System.Drawing.Point(0, 20);
            this.btn_profile.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(200, 39);
            this.btn_profile.TabIndex = 2;
            this.btn_profile.Text = "    Profile Settings";
            this.btn_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.UseVisualStyleBackColor = false;
            // 
            // btn_users_management
            // 
            this.btn_users_management.BackColor = System.Drawing.SystemColors.Control;
            this.btn_users_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users_management.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users_management.ForeColor = System.Drawing.Color.Black;
            this.btn_users_management.Location = new System.Drawing.Point(0, 67);
            this.btn_users_management.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_users_management.Name = "btn_users_management";
            this.btn_users_management.Size = new System.Drawing.Size(200, 39);
            this.btn_users_management.TabIndex = 3;
            this.btn_users_management.Text = "    Users Management";
            this.btn_users_management.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_users_management.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_profile);
            this.flowLayoutPanel1.Controls.Add(this.btn_users_management);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 49);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(200, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(200, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 651);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // htc_settings_tabs
            // 
            this.htc_settings_tabs.Controls.Add(this.tab_profile);
            this.htc_settings_tabs.Controls.Add(this.tab_users_management);
            this.htc_settings_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htc_settings_tabs.ItemSize = new System.Drawing.Size(100, 24);
            this.htc_settings_tabs.Location = new System.Drawing.Point(220, 49);
            this.htc_settings_tabs.Name = "htc_settings_tabs";
            this.htc_settings_tabs.SelectedIndex = 0;
            this.htc_settings_tabs.Size = new System.Drawing.Size(1040, 651);
            this.htc_settings_tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.htc_settings_tabs.TabIndex = 2;
            // 
            // tab_profile
            // 
            this.tab_profile.BackColor = System.Drawing.SystemColors.Control;
            this.tab_profile.Controls.Add(this.lb_remove_image);
            this.tab_profile.Controls.Add(this.lb_upload_image);
            this.tab_profile.Controls.Add(this.rpb_profile_image);
            this.tab_profile.Location = new System.Drawing.Point(4, 28);
            this.tab_profile.Name = "tab_profile";
            this.tab_profile.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.tab_profile.Size = new System.Drawing.Size(1032, 619);
            this.tab_profile.TabIndex = 0;
            this.tab_profile.Text = "Profile Settings";
            // 
            // tab_users_management
            // 
            this.tab_users_management.BackColor = System.Drawing.SystemColors.Control;
            this.tab_users_management.Location = new System.Drawing.Point(4, 28);
            this.tab_users_management.Name = "tab_users_management";
            this.tab_users_management.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.tab_users_management.Size = new System.Drawing.Size(1032, 619);
            this.tab_users_management.TabIndex = 1;
            this.tab_users_management.Text = "Users Management";
            // 
            // lb_remove_image
            // 
            this.lb_remove_image.AutoSize = true;
            this.lb_remove_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_remove_image.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_remove_image.ForeColor = System.Drawing.Color.MediumPurple;
            this.lb_remove_image.Location = new System.Drawing.Point(97, 230);
            this.lb_remove_image.Name = "lb_remove_image";
            this.lb_remove_image.Size = new System.Drawing.Size(86, 14);
            this.lb_remove_image.TabIndex = 72;
            this.lb_remove_image.Text = "Remove Image";
            // 
            // lb_upload_image
            // 
            this.lb_upload_image.AutoSize = true;
            this.lb_upload_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_upload_image.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_upload_image.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_upload_image.Location = new System.Drawing.Point(89, 204);
            this.lb_upload_image.Name = "lb_upload_image";
            this.lb_upload_image.Size = new System.Drawing.Size(103, 18);
            this.lb_upload_image.TabIndex = 71;
            this.lb_upload_image.Text = "Upload Image";
            // 
            // rpb_profile_image
            // 
            this.rpb_profile_image.BackColor = System.Drawing.Color.Transparent;
            this.rpb_profile_image.Location = new System.Drawing.Point(63, 39);
            this.rpb_profile_image.Name = "rpb_profile_image";
            this.rpb_profile_image.Radius = 30;
            this.rpb_profile_image.Size = new System.Drawing.Size(150, 150);
            this.rpb_profile_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rpb_profile_image.TabIndex = 70;
            this.rpb_profile_image.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.htc_settings_tabs);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Settings";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.htc_settings_tabs.ResumeLayout(false);
            this.tab_profile.ResumeLayout(false);
            this.tab_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpb_profile_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_users_management;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.HeaderlessTabControl htc_settings_tabs;
        private System.Windows.Forms.TabPage tab_profile;
        private System.Windows.Forms.TabPage tab_users_management;
        private System.Windows.Forms.Label lb_remove_image;
        private System.Windows.Forms.Label lb_upload_image;
        private WindowsFormsControlLibrary.CustomControls.RoundedPictureBox rpb_profile_image;
    }
}