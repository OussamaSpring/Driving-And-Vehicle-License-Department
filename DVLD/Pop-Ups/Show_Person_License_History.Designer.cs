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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tc_dirver_licenses = new System.Windows.Forms.TabControl();
            this.tp_local = new System.Windows.Forms.TabPage();
            this.dgv_local_licenses = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.license_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.application_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiration_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.issue_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_international = new System.Windows.Forms.TabPage();
            this.dgv_international_licenses = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.international_license_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_application_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_driver_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.local_license_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_expiration_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.personDetailsCard = new DVLD.UserControls.PersonDetailsCard();
            this.flp_footer_local = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_local_text = new System.Windows.Forms.Label();
            this.flp_footer_international = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_international_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tc_dirver_licenses.SuspendLayout();
            this.tp_local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local_licenses)).BeginInit();
            this.tp_international.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_international_licenses)).BeginInit();
            this.flp_footer_local.SuspendLayout();
            this.flp_footer_international.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
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
            this.label2.Location = new System.Drawing.Point(24, 512);
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
            this.tc_dirver_licenses.Location = new System.Drawing.Point(29, 556);
            this.tc_dirver_licenses.Multiline = true;
            this.tc_dirver_licenses.Name = "tc_dirver_licenses";
            this.tc_dirver_licenses.SelectedIndex = 0;
            this.tc_dirver_licenses.Size = new System.Drawing.Size(920, 213);
            this.tc_dirver_licenses.TabIndex = 4;
            // 
            // tp_local
            // 
            this.tp_local.BackColor = System.Drawing.SystemColors.Control;
            this.tp_local.Controls.Add(this.flp_footer_local);
            this.tp_local.Controls.Add(this.dgv_local_licenses);
            this.tp_local.Location = new System.Drawing.Point(23, 4);
            this.tp_local.Name = "tp_local";
            this.tp_local.Padding = new System.Windows.Forms.Padding(3);
            this.tp_local.Size = new System.Drawing.Size(893, 205);
            this.tp_local.TabIndex = 0;
            this.tp_local.Text = "Local";
            // 
            // dgv_local_licenses
            // 
            this.dgv_local_licenses.AllowUserToAddRows = false;
            this.dgv_local_licenses.AllowUserToDeleteRows = false;
            this.dgv_local_licenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_local_licenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_local_licenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_local_licenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_local_licenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.license_id,
            this.application_id,
            this.driver_id,
            this.class_name,
            this.issue_date,
            this.expiration_date,
            this.is_active,
            this.issue_reason});
            this.dgv_local_licenses.CornerRadius = 15;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_local_licenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_local_licenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_local_licenses.EnableHeadersVisualStyles = false;
            this.dgv_local_licenses.Location = new System.Drawing.Point(3, 3);
            this.dgv_local_licenses.Name = "dgv_local_licenses";
            this.dgv_local_licenses.ReadOnly = true;
            this.dgv_local_licenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_local_licenses.Size = new System.Drawing.Size(887, 199);
            this.dgv_local_licenses.TabIndex = 3;
            // 
            // license_id
            // 
            this.license_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.license_id.HeaderText = "Licence ID";
            this.license_id.Name = "license_id";
            this.license_id.ReadOnly = true;
            // 
            // application_id
            // 
            this.application_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.application_id.HeaderText = "Application ID";
            this.application_id.Name = "application_id";
            this.application_id.ReadOnly = true;
            // 
            // driver_id
            // 
            this.driver_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.driver_id.HeaderText = "Driver\'s ID";
            this.driver_id.Name = "driver_id";
            this.driver_id.ReadOnly = true;
            // 
            // class_name
            // 
            this.class_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.class_name.HeaderText = "Class Name";
            this.class_name.Name = "class_name";
            this.class_name.ReadOnly = true;
            // 
            // issue_date
            // 
            this.issue_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issue_date.HeaderText = "Issue Date";
            this.issue_date.Name = "issue_date";
            this.issue_date.ReadOnly = true;
            // 
            // expiration_date
            // 
            this.expiration_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expiration_date.HeaderText = "Expiration Date";
            this.expiration_date.Name = "expiration_date";
            this.expiration_date.ReadOnly = true;
            // 
            // is_active
            // 
            this.is_active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.is_active.HeaderText = "Is Active";
            this.is_active.Name = "is_active";
            this.is_active.ReadOnly = true;
            this.is_active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // issue_reason
            // 
            this.issue_reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issue_reason.HeaderText = "Issue Reason";
            this.issue_reason.Name = "issue_reason";
            this.issue_reason.ReadOnly = true;
            // 
            // tp_international
            // 
            this.tp_international.BackColor = System.Drawing.SystemColors.Control;
            this.tp_international.Controls.Add(this.flp_footer_international);
            this.tp_international.Controls.Add(this.dgv_international_licenses);
            this.tp_international.Location = new System.Drawing.Point(23, 4);
            this.tp_international.Name = "tp_international";
            this.tp_international.Padding = new System.Windows.Forms.Padding(3);
            this.tp_international.Size = new System.Drawing.Size(893, 205);
            this.tp_international.TabIndex = 1;
            this.tp_international.Text = "International";
            // 
            // dgv_international_licenses
            // 
            this.dgv_international_licenses.AllowUserToAddRows = false;
            this.dgv_international_licenses.AllowUserToDeleteRows = false;
            this.dgv_international_licenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_international_licenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_international_licenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_international_licenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_international_licenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.international_license_id,
            this.inter_application_id,
            this.inter_driver_id,
            this.local_license_id,
            this.inter_issue_date,
            this.inter_expiration_date,
            this.dataGridViewCheckBoxColumn1});
            this.dgv_international_licenses.CornerRadius = 15;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_international_licenses.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_international_licenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_international_licenses.EnableHeadersVisualStyles = false;
            this.dgv_international_licenses.Location = new System.Drawing.Point(3, 3);
            this.dgv_international_licenses.Name = "dgv_international_licenses";
            this.dgv_international_licenses.ReadOnly = true;
            this.dgv_international_licenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_international_licenses.Size = new System.Drawing.Size(887, 199);
            this.dgv_international_licenses.TabIndex = 5;
            // 
            // international_license_id
            // 
            this.international_license_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.international_license_id.HeaderText = "International Licence ID";
            this.international_license_id.Name = "international_license_id";
            this.international_license_id.ReadOnly = true;
            // 
            // inter_application_id
            // 
            this.inter_application_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inter_application_id.HeaderText = "Application ID";
            this.inter_application_id.Name = "inter_application_id";
            this.inter_application_id.ReadOnly = true;
            // 
            // inter_driver_id
            // 
            this.inter_driver_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inter_driver_id.HeaderText = "Driver\'s ID";
            this.inter_driver_id.Name = "inter_driver_id";
            this.inter_driver_id.ReadOnly = true;
            // 
            // local_license_id
            // 
            this.local_license_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.local_license_id.HeaderText = "Issued Using Local License ID";
            this.local_license_id.Name = "local_license_id";
            this.local_license_id.ReadOnly = true;
            // 
            // inter_issue_date
            // 
            this.inter_issue_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inter_issue_date.HeaderText = "Issue Date";
            this.inter_issue_date.Name = "inter_issue_date";
            this.inter_issue_date.ReadOnly = true;
            // 
            // inter_expiration_date
            // 
            this.inter_expiration_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inter_expiration_date.HeaderText = "Expiration Date";
            this.inter_expiration_date.Name = "inter_expiration_date";
            this.inter_expiration_date.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Is Active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // personDetailsCard
            // 
            this.personDetailsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personDetailsCard.Location = new System.Drawing.Point(272, 100);
            this.personDetailsCard.Name = "personDetailsCard";
            this.personDetailsCard.Size = new System.Drawing.Size(677, 367);
            this.personDetailsCard.TabIndex = 0;
            // 
            // flp_footer_local
            // 
            this.flp_footer_local.Controls.Add(this.lb_footer_local_text);
            this.flp_footer_local.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_footer_local.Location = new System.Drawing.Point(3, 172);
            this.flp_footer_local.Name = "flp_footer_local";
            this.flp_footer_local.Padding = new System.Windows.Forms.Padding(5);
            this.flp_footer_local.Size = new System.Drawing.Size(887, 30);
            this.flp_footer_local.TabIndex = 4;
            // 
            // lb_footer_local_text
            // 
            this.lb_footer_local_text.AutoSize = true;
            this.lb_footer_local_text.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_local_text.Location = new System.Drawing.Point(8, 5);
            this.lb_footer_local_text.Name = "lb_footer_local_text";
            this.lb_footer_local_text.Size = new System.Drawing.Size(242, 19);
            this.lb_footer_local_text.TabIndex = 0;
            this.lb_footer_local_text.Text = "Total Number of Local Licenses: ";
            // 
            // flp_footer_international
            // 
            this.flp_footer_international.Controls.Add(this.lb_footer_international_text);
            this.flp_footer_international.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_footer_international.Location = new System.Drawing.Point(3, 172);
            this.flp_footer_international.Name = "flp_footer_international";
            this.flp_footer_international.Padding = new System.Windows.Forms.Padding(5);
            this.flp_footer_international.Size = new System.Drawing.Size(887, 30);
            this.flp_footer_international.TabIndex = 6;
            // 
            // lb_footer_international_text
            // 
            this.lb_footer_international_text.AutoSize = true;
            this.lb_footer_international_text.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_international_text.Location = new System.Drawing.Point(8, 5);
            this.lb_footer_international_text.Name = "lb_footer_international_text";
            this.lb_footer_international_text.Size = new System.Drawing.Size(294, 19);
            this.lb_footer_international_text.TabIndex = 0;
            this.lb_footer_international_text.Text = "Total Number of International Licenses: ";
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
            this.tp_local.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local_licenses)).EndInit();
            this.tp_international.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_international_licenses)).EndInit();
            this.flp_footer_local.ResumeLayout(false);
            this.flp_footer_local.PerformLayout();
            this.flp_footer_international.ResumeLayout(false);
            this.flp_footer_international.PerformLayout();
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
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_local_licenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn application_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiration_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_reason;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_international_licenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn international_license_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_application_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_driver_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn local_license_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_expiration_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.FlowLayoutPanel flp_footer_local;
        private System.Windows.Forms.Label lb_footer_local_text;
        private System.Windows.Forms.FlowLayoutPanel flp_footer_international;
        private System.Windows.Forms.Label lb_footer_international_text;
    }
}