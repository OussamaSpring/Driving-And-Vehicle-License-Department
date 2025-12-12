namespace DVLD.Forms
{
    partial class IndividualsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pl_Body = new System.Windows.Forms.Panel();
            this.htc_tab_nav = new DVLD.CustomControls.HeaderlessTabControl();
            this.tab_people = new System.Windows.Forms.TabPage();
            this.dgv_people = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.person_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.national_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_PersonManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_View = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.uc_person_topbar = new DVLD.UserControls.SearchBar();
            this.flp_footer = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_text = new System.Windows.Forms.Label();
            this.tab_drivers = new System.Windows.Forms.TabPage();
            this.dgv_drivers = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.driver_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_person_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_national_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active_licenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_DriverManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_ViewPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ShowLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_IssueInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.uc_driver_topbar = new DVLD.UserControls.SearchBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_text_driver = new System.Windows.Forms.Label();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.pl_Body.SuspendLayout();
            this.htc_tab_nav.SuspendLayout();
            this.tab_people.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_people)).BeginInit();
            this.cms_PersonManagement.SuspendLayout();
            this.flp_footer.SuspendLayout();
            this.tab_drivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drivers)).BeginInit();
            this.cms_DriverManagement.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(20, 20);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(150, 29);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Individuals.";
            // 
            // pl_Body
            // 
            this.pl_Body.BackColor = System.Drawing.Color.Transparent;
            this.pl_Body.Controls.Add(this.htc_tab_nav);
            this.pl_Body.Controls.Add(this.tlp_header);
            this.pl_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Body.Location = new System.Drawing.Point(20, 49);
            this.pl_Body.Name = "pl_Body";
            this.pl_Body.Padding = new System.Windows.Forms.Padding(7, 10, 0, 0);
            this.pl_Body.Size = new System.Drawing.Size(760, 381);
            this.pl_Body.TabIndex = 2;
            // 
            // htc_tab_nav
            // 
            this.htc_tab_nav.Controls.Add(this.tab_people);
            this.htc_tab_nav.Controls.Add(this.tab_drivers);
            this.htc_tab_nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htc_tab_nav.ItemSize = new System.Drawing.Size(100, 24);
            this.htc_tab_nav.Location = new System.Drawing.Point(7, 10);
            this.htc_tab_nav.Name = "htc_tab_nav";
            this.htc_tab_nav.SelectedIndex = 0;
            this.htc_tab_nav.Size = new System.Drawing.Size(753, 371);
            this.htc_tab_nav.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.htc_tab_nav.TabIndex = 1;
            // 
            // tab_people
            // 
            this.tab_people.BackColor = System.Drawing.SystemColors.Control;
            this.tab_people.Controls.Add(this.dgv_people);
            this.tab_people.Controls.Add(this.uc_person_topbar);
            this.tab_people.Controls.Add(this.flp_footer);
            this.tab_people.Location = new System.Drawing.Point(4, 28);
            this.tab_people.Name = "tab_people";
            this.tab_people.Padding = new System.Windows.Forms.Padding(3);
            this.tab_people.Size = new System.Drawing.Size(745, 339);
            this.tab_people.TabIndex = 0;
            this.tab_people.Text = "People";
            // 
            // dgv_people
            // 
            this.dgv_people.AllowUserToAddRows = false;
            this.dgv_people.AllowUserToDeleteRows = false;
            this.dgv_people.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_people.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_people.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_people.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_people.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.person_id,
            this.national_number,
            this.firstname,
            this.secondname,
            this.thirdname,
            this.lastname,
            this.gender,
            this.date_of_birth,
            this.nationality,
            this.phone,
            this.email});
            this.dgv_people.ContextMenuStrip = this.cms_PersonManagement;
            this.dgv_people.CornerRadius = 15;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_people.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_people.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_people.EnableHeadersVisualStyles = false;
            this.dgv_people.Location = new System.Drawing.Point(3, 53);
            this.dgv_people.Name = "dgv_people";
            this.dgv_people.ReadOnly = true;
            this.dgv_people.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_people.Size = new System.Drawing.Size(739, 233);
            this.dgv_people.TabIndex = 2;
            // 
            // person_id
            // 
            this.person_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.person_id.HeaderText = "Person ID";
            this.person_id.Name = "person_id";
            this.person_id.ReadOnly = true;
            // 
            // national_number
            // 
            this.national_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.national_number.HeaderText = "National No.";
            this.national_number.Name = "national_number";
            this.national_number.ReadOnly = true;
            // 
            // firstname
            // 
            this.firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            // 
            // secondname
            // 
            this.secondname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.secondname.HeaderText = "Second Name";
            this.secondname.Name = "secondname";
            this.secondname.ReadOnly = true;
            // 
            // thirdname
            // 
            this.thirdname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thirdname.HeaderText = "Third Name";
            this.thirdname.Name = "thirdname";
            this.thirdname.ReadOnly = true;
            // 
            // lastname
            // 
            this.lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // date_of_birth
            // 
            this.date_of_birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_of_birth.HeaderText = "Date of Birth";
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.ReadOnly = true;
            // 
            // nationality
            // 
            this.nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nationality.HeaderText = "Nationality";
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // cms_PersonManagement
            // 
            this.cms_PersonManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_View,
            this.tsmi_Edit,
            this.tsmi_Delete});
            this.cms_PersonManagement.Name = "cms_UserManagement";
            this.cms_PersonManagement.Size = new System.Drawing.Size(163, 91);
            this.cms_PersonManagement.Text = "People Management";
            // 
            // tsmi_View
            // 
            this.tsmi_View.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_View.Image = global::DVLD.Properties.Resources.driving_license;
            this.tsmi_View.Name = "tsmi_View";
            this.tsmi_View.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.tsmi_View.Size = new System.Drawing.Size(162, 29);
            this.tsmi_View.Text = "Show Details";
            this.tsmi_View.Click += new System.EventHandler(this.tsmi_View_Click);
            // 
            // tsmi_Edit
            // 
            this.tsmi_Edit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_Edit.Image = global::DVLD.Properties.Resources.Edit_Colored;
            this.tsmi_Edit.Name = "tsmi_Edit";
            this.tsmi_Edit.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.tsmi_Edit.Size = new System.Drawing.Size(162, 29);
            this.tsmi_Edit.Text = "Edit";
            this.tsmi_Edit.Click += new System.EventHandler(this.tsmi_Edit_Click);
            // 
            // tsmi_Delete
            // 
            this.tsmi_Delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_Delete.Image = global::DVLD.Properties.Resources.Delete;
            this.tsmi_Delete.Name = "tsmi_Delete";
            this.tsmi_Delete.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.tsmi_Delete.Size = new System.Drawing.Size(162, 29);
            this.tsmi_Delete.Text = "Delete";
            this.tsmi_Delete.Click += new System.EventHandler(this.tsmi_Delete_Click);
            // 
            // uc_person_topbar
            // 
            this.uc_person_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_person_topbar.Location = new System.Drawing.Point(3, 3);
            this.uc_person_topbar.Name = "uc_person_topbar";
            this.uc_person_topbar.Size = new System.Drawing.Size(739, 50);
            this.uc_person_topbar.TabIndex = 1;
            // 
            // flp_footer
            // 
            this.flp_footer.Controls.Add(this.lb_footer_text);
            this.flp_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_footer.Location = new System.Drawing.Point(3, 286);
            this.flp_footer.Name = "flp_footer";
            this.flp_footer.Size = new System.Drawing.Size(739, 50);
            this.flp_footer.TabIndex = 0;
            // 
            // lb_footer_text
            // 
            this.lb_footer_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_text.Location = new System.Drawing.Point(3, 0);
            this.lb_footer_text.Name = "lb_footer_text";
            this.lb_footer_text.Size = new System.Drawing.Size(624, 50);
            this.lb_footer_text.TabIndex = 0;
            this.lb_footer_text.Text = "Total Number of People: ";
            this.lb_footer_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_drivers
            // 
            this.tab_drivers.BackColor = System.Drawing.SystemColors.Control;
            this.tab_drivers.Controls.Add(this.dgv_drivers);
            this.tab_drivers.Controls.Add(this.uc_driver_topbar);
            this.tab_drivers.Controls.Add(this.flowLayoutPanel1);
            this.tab_drivers.Location = new System.Drawing.Point(4, 28);
            this.tab_drivers.Name = "tab_drivers";
            this.tab_drivers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_drivers.Size = new System.Drawing.Size(745, 339);
            this.tab_drivers.TabIndex = 1;
            this.tab_drivers.Text = "Drivers";
            // 
            // dgv_drivers
            // 
            this.dgv_drivers.AllowUserToAddRows = false;
            this.dgv_drivers.AllowUserToDeleteRows = false;
            this.dgv_drivers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_drivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_drivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_drivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driver_id,
            this.driver_person_id,
            this.driver_national_number,
            this.fullname,
            this.date,
            this.active_licenses});
            this.dgv_drivers.ContextMenuStrip = this.cms_DriverManagement;
            this.dgv_drivers.CornerRadius = 15;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_drivers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_drivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_drivers.EnableHeadersVisualStyles = false;
            this.dgv_drivers.Location = new System.Drawing.Point(3, 53);
            this.dgv_drivers.Name = "dgv_drivers";
            this.dgv_drivers.ReadOnly = true;
            this.dgv_drivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_drivers.Size = new System.Drawing.Size(739, 233);
            this.dgv_drivers.TabIndex = 4;
            // 
            // driver_id
            // 
            this.driver_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.driver_id.HeaderText = "Driver ID";
            this.driver_id.Name = "driver_id";
            this.driver_id.ReadOnly = true;
            // 
            // driver_person_id
            // 
            this.driver_person_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.driver_person_id.HeaderText = "Person ID";
            this.driver_person_id.Name = "driver_person_id";
            this.driver_person_id.ReadOnly = true;
            // 
            // driver_national_number
            // 
            this.driver_national_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.driver_national_number.HeaderText = "National No.";
            this.driver_national_number.Name = "driver_national_number";
            this.driver_national_number.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullname.HeaderText = "Full Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // active_licenses
            // 
            this.active_licenses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.active_licenses.HeaderText = "Active Licenses";
            this.active_licenses.Name = "active_licenses";
            this.active_licenses.ReadOnly = true;
            // 
            // cms_DriverManagement
            // 
            this.cms_DriverManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ViewPersonInfo,
            this.tsmi_ShowLicenseHistory,
            this.toolStripSeparator1,
            this.tsmi_IssueInternationalLicense});
            this.cms_DriverManagement.Name = "cms_UserManagement";
            this.cms_DriverManagement.Size = new System.Drawing.Size(249, 97);
            this.cms_DriverManagement.Text = "Drivers Management";
            // 
            // tsmi_ViewPersonInfo
            // 
            this.tsmi_ViewPersonInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_ViewPersonInfo.Image = global::DVLD.Properties.Resources.driving_license;
            this.tsmi_ViewPersonInfo.Name = "tsmi_ViewPersonInfo";
            this.tsmi_ViewPersonInfo.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.tsmi_ViewPersonInfo.Size = new System.Drawing.Size(248, 29);
            this.tsmi_ViewPersonInfo.Text = "Show Person Info";
            this.tsmi_ViewPersonInfo.Click += new System.EventHandler(this.tsmi_ViewPersonInfo_Click);
            // 
            // tsmi_ShowLicenseHistory
            // 
            this.tsmi_ShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_ShowLicenseHistory.Image = global::DVLD.Properties.Resources.Edit_Colored;
            this.tsmi_ShowLicenseHistory.Name = "tsmi_ShowLicenseHistory";
            this.tsmi_ShowLicenseHistory.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.tsmi_ShowLicenseHistory.Size = new System.Drawing.Size(248, 29);
            this.tsmi_ShowLicenseHistory.Text = "Show License History";
            this.tsmi_ShowLicenseHistory.Click += new System.EventHandler(this.tsmi_ShowLicenseHistory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // tsmi_IssueInternationalLicense
            // 
            this.tsmi_IssueInternationalLicense.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tsmi_IssueInternationalLicense.Image = global::DVLD.Properties.Resources.Country;
            this.tsmi_IssueInternationalLicense.Name = "tsmi_IssueInternationalLicense";
            this.tsmi_IssueInternationalLicense.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.tsmi_IssueInternationalLicense.Size = new System.Drawing.Size(248, 29);
            this.tsmi_IssueInternationalLicense.Text = "Issue International License";
            this.tsmi_IssueInternationalLicense.Click += new System.EventHandler(this.tsmi_IssueInternationalLicense_Click);
            // 
            // uc_driver_topbar
            // 
            this.uc_driver_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_driver_topbar.Location = new System.Drawing.Point(3, 3);
            this.uc_driver_topbar.Name = "uc_driver_topbar";
            this.uc_driver_topbar.Size = new System.Drawing.Size(739, 50);
            this.uc_driver_topbar.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lb_footer_text_driver);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 286);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(739, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lb_footer_text_driver
            // 
            this.lb_footer_text_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_text_driver.Location = new System.Drawing.Point(3, 0);
            this.lb_footer_text_driver.Name = "lb_footer_text_driver";
            this.lb_footer_text_driver.Size = new System.Drawing.Size(624, 50);
            this.lb_footer_text_driver.TabIndex = 0;
            this.lb_footer_text_driver.Text = "Total Number of Drivers: ";
            this.lb_footer_text_driver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlp_header
            // 
            this.tlp_header.AutoSize = true;
            this.tlp_header.ColumnCount = 3;
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlp_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_header.Location = new System.Drawing.Point(7, 10);
            this.tlp_header.Name = "tlp_header";
            this.tlp_header.RowCount = 1;
            this.tlp_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_header.Size = new System.Drawing.Size(753, 0);
            this.tlp_header.TabIndex = 0;
            // 
            // IndividualsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pl_Body);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IndividualsForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Individuals.";
            this.Load += new System.EventHandler(this.IndividualsForm_Load);
            this.pl_Body.ResumeLayout(false);
            this.pl_Body.PerformLayout();
            this.htc_tab_nav.ResumeLayout(false);
            this.tab_people.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_people)).EndInit();
            this.cms_PersonManagement.ResumeLayout(false);
            this.flp_footer.ResumeLayout(false);
            this.tab_drivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drivers)).EndInit();
            this.cms_DriverManagement.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel pl_Body;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private CustomControls.HeaderlessTabControl htc_tab_nav;
        private System.Windows.Forms.TabPage tab_people;
        private System.Windows.Forms.TabPage tab_drivers;
        private System.Windows.Forms.FlowLayoutPanel flp_footer;
        private System.Windows.Forms.Label lb_footer_text;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_footer_text_driver;
        private UserControls.SearchBar uc_person_topbar;
        private UserControls.SearchBar uc_driver_topbar;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_drivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_person_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_national_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn active_licenses;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_people;
        private System.Windows.Forms.DataGridViewTextBoxColumn person_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn national_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondname;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.ContextMenuStrip cms_PersonManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmi_View;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Delete;
        private System.Windows.Forms.ContextMenuStrip cms_DriverManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ViewPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ShowLicenseHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_IssueInternationalLicense;
    }
}