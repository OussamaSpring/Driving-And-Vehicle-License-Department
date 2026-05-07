namespace DVLD.Forms
{
    partial class TestManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pl_Body = new System.Windows.Forms.Panel();
            this.htc_tab_nav = new DVLD.CustomControls.HeaderlessTabControl();
            this.tab_tests_list = new System.Windows.Forms.TabPage();
            this.dgv_tests_list = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.ldl_application_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.national_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.application_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passed_tests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_tests_management = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_show_app_details = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit_app = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_delete_app = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_cancel_app = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_test_management = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_issue_license = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_show_license = new System.Windows.Forms.ToolStripMenuItem();
            this.uc_tests_list_topbar = new DVLD.UserControls.SearchBar();
            this.flp_footer = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_text = new System.Windows.Forms.Label();
            this.lb_total_tests_number = new System.Windows.Forms.Label();
            this.tab_test_types = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_total_test_types_number = new System.Windows.Forms.Label();
            this.dgv_test_types = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.pl_Body.SuspendLayout();
            this.htc_tab_nav.SuspendLayout();
            this.tab_tests_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tests_list)).BeginInit();
            this.cms_tests_management.SuspendLayout();
            this.flp_footer.SuspendLayout();
            this.tab_test_types.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test_types)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(20, 20);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(233, 29);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Test Management.";
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
            this.pl_Body.TabIndex = 3;
            // 
            // htc_tab_nav
            // 
            this.htc_tab_nav.Controls.Add(this.tab_tests_list);
            this.htc_tab_nav.Controls.Add(this.tab_test_types);
            this.htc_tab_nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htc_tab_nav.ItemSize = new System.Drawing.Size(100, 24);
            this.htc_tab_nav.Location = new System.Drawing.Point(7, 10);
            this.htc_tab_nav.Name = "htc_tab_nav";
            this.htc_tab_nav.SelectedIndex = 0;
            this.htc_tab_nav.Size = new System.Drawing.Size(753, 371);
            this.htc_tab_nav.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.htc_tab_nav.TabIndex = 3;
            // 
            // tab_tests_list
            // 
            this.tab_tests_list.BackColor = System.Drawing.SystemColors.Control;
            this.tab_tests_list.Controls.Add(this.dgv_tests_list);
            this.tab_tests_list.Controls.Add(this.uc_tests_list_topbar);
            this.tab_tests_list.Controls.Add(this.flp_footer);
            this.tab_tests_list.Location = new System.Drawing.Point(4, 28);
            this.tab_tests_list.Name = "tab_tests_list";
            this.tab_tests_list.Padding = new System.Windows.Forms.Padding(3);
            this.tab_tests_list.Size = new System.Drawing.Size(745, 339);
            this.tab_tests_list.TabIndex = 0;
            this.tab_tests_list.Text = "Tests List";
            // 
            // dgv_tests_list
            // 
            this.dgv_tests_list.AllowUserToAddRows = false;
            this.dgv_tests_list.AllowUserToDeleteRows = false;
            this.dgv_tests_list.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_tests_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tests_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tests_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tests_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ldl_application_id,
            this.license_class,
            this.national_number,
            this.fullname,
            this.application_date,
            this.passed_tests,
            this.status});
            this.dgv_tests_list.ContextMenuStrip = this.cms_tests_management;
            this.dgv_tests_list.CornerRadius = 15;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tests_list.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tests_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tests_list.EnableHeadersVisualStyles = false;
            this.dgv_tests_list.Location = new System.Drawing.Point(3, 53);
            this.dgv_tests_list.Name = "dgv_tests_list";
            this.dgv_tests_list.ReadOnly = true;
            this.dgv_tests_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tests_list.Size = new System.Drawing.Size(739, 233);
            this.dgv_tests_list.TabIndex = 2;
            // 
            // ldl_application_id
            // 
            this.ldl_application_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ldl_application_id.HeaderText = "L.D.L Application ID";
            this.ldl_application_id.Name = "ldl_application_id";
            this.ldl_application_id.ReadOnly = true;
            // 
            // license_class
            // 
            this.license_class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.license_class.HeaderText = "License Class";
            this.license_class.Name = "license_class";
            this.license_class.ReadOnly = true;
            // 
            // national_number
            // 
            this.national_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.national_number.HeaderText = "National Number";
            this.national_number.Name = "national_number";
            this.national_number.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullname.HeaderText = "Full Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // application_date
            // 
            this.application_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.application_date.HeaderText = "Application Date";
            this.application_date.Name = "application_date";
            this.application_date.ReadOnly = true;
            // 
            // passed_tests
            // 
            this.passed_tests.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passed_tests.HeaderText = "Passed Tests";
            this.passed_tests.Name = "passed_tests";
            this.passed_tests.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // cms_tests_management
            // 
            this.cms_tests_management.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cms_tests_management.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_show_app_details,
            this.tsmi_edit_app,
            this.tsmi_delete_app,
            this.tsmi_cancel_app,
            this.toolStripSeparator1,
            this.tsmi_test_management,
            this.toolStripSeparator2,
            this.tsmi_issue_license,
            this.tsmi_show_license});
            this.cms_tests_management.Name = "cms_tests_management";
            this.cms_tests_management.Size = new System.Drawing.Size(293, 268);
            this.cms_tests_management.Opening += new System.ComponentModel.CancelEventHandler(this.cms_tests_management_Opening);
            // 
            // tsmi_show_app_details
            // 
            this.tsmi_show_app_details.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmi_show_app_details.Image = global::DVLD.Properties.Resources.File_text_Black;
            this.tsmi_show_app_details.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.tsmi_show_app_details.Name = "tsmi_show_app_details";
            this.tsmi_show_app_details.Size = new System.Drawing.Size(292, 24);
            this.tsmi_show_app_details.Text = "Show Application Details";
            this.tsmi_show_app_details.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmi_show_app_details.Click += new System.EventHandler(this.tsmi_show_app_details_Click);
            // 
            // tsmi_edit_app
            // 
            this.tsmi_edit_app.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmi_edit_app.Image = global::DVLD.Properties.Resources.Edit_Colored;
            this.tsmi_edit_app.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.tsmi_edit_app.Name = "tsmi_edit_app";
            this.tsmi_edit_app.Size = new System.Drawing.Size(292, 24);
            this.tsmi_edit_app.Text = "Edit Application";
            this.tsmi_edit_app.Click += new System.EventHandler(this.tsmi_edit_app_Click);
            // 
            // tsmi_delete_app
            // 
            this.tsmi_delete_app.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmi_delete_app.Image = global::DVLD.Properties.Resources.Delete;
            this.tsmi_delete_app.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.tsmi_delete_app.Name = "tsmi_delete_app";
            this.tsmi_delete_app.Size = new System.Drawing.Size(292, 24);
            this.tsmi_delete_app.Text = "Delete Application";
            // 
            // tsmi_cancel_app
            // 
            this.tsmi_cancel_app.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmi_cancel_app.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.tsmi_cancel_app.Name = "tsmi_cancel_app";
            this.tsmi_cancel_app.Size = new System.Drawing.Size(292, 24);
            this.tsmi_cancel_app.Text = "Cancel Application";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(289, 6);
            // 
            // tsmi_test_management
            // 
            this.tsmi_test_management.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmi_test_management.Image = global::DVLD.Properties.Resources.TakeTest;
            this.tsmi_test_management.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.tsmi_test_management.Name = "tsmi_test_management";
            this.tsmi_test_management.Size = new System.Drawing.Size(292, 24);
            this.tsmi_test_management.Text = "Test Management";
            this.tsmi_test_management.Click += new System.EventHandler(this.tsmi_test_management_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(289, 6);
            // 
            // tsmi_issue_license
            // 
            this.tsmi_issue_license.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmi_issue_license.Image = global::DVLD.Properties.Resources.license_release;
            this.tsmi_issue_license.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.tsmi_issue_license.Name = "tsmi_issue_license";
            this.tsmi_issue_license.Size = new System.Drawing.Size(292, 24);
            this.tsmi_issue_license.Text = "Issue Driving License (First Time)";
            this.tsmi_issue_license.Click += new System.EventHandler(this.tsmi_issue_license_Click);
            // 
            // tsmi_show_license
            // 
            this.tsmi_show_license.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmi_show_license.Image = global::DVLD.Properties.Resources.driving_license1;
            this.tsmi_show_license.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.tsmi_show_license.Name = "tsmi_show_license";
            this.tsmi_show_license.Size = new System.Drawing.Size(292, 24);
            this.tsmi_show_license.Text = "Show License";
            this.tsmi_show_license.Click += new System.EventHandler(this.tsmi_show_license_Click);
            // 
            // uc_tests_list_topbar
            // 
            this.uc_tests_list_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_tests_list_topbar.Location = new System.Drawing.Point(3, 3);
            this.uc_tests_list_topbar.Name = "uc_tests_list_topbar";
            this.uc_tests_list_topbar.Size = new System.Drawing.Size(739, 50);
            this.uc_tests_list_topbar.TabIndex = 1;
            // 
            // flp_footer
            // 
            this.flp_footer.Controls.Add(this.lb_footer_text);
            this.flp_footer.Controls.Add(this.lb_total_tests_number);
            this.flp_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_footer.Location = new System.Drawing.Point(3, 286);
            this.flp_footer.Name = "flp_footer";
            this.flp_footer.Size = new System.Drawing.Size(739, 50);
            this.flp_footer.TabIndex = 0;
            // 
            // lb_footer_text
            // 
            this.lb_footer_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_text.Location = new System.Drawing.Point(3, 0);
            this.lb_footer_text.Name = "lb_footer_text";
            this.lb_footer_text.Size = new System.Drawing.Size(172, 50);
            this.lb_footer_text.TabIndex = 0;
            this.lb_footer_text.Text = "Total Number of Tests: ";
            this.lb_footer_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_total_tests_number
            // 
            this.lb_total_tests_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_tests_number.Location = new System.Drawing.Point(181, 0);
            this.lb_total_tests_number.Name = "lb_total_tests_number";
            this.lb_total_tests_number.Size = new System.Drawing.Size(197, 50);
            this.lb_total_tests_number.TabIndex = 1;
            this.lb_total_tests_number.Text = "??";
            this.lb_total_tests_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_test_types
            // 
            this.tab_test_types.BackColor = System.Drawing.SystemColors.Control;
            this.tab_test_types.Controls.Add(this.flowLayoutPanel2);
            this.tab_test_types.Controls.Add(this.dgv_test_types);
            this.tab_test_types.Location = new System.Drawing.Point(4, 28);
            this.tab_test_types.Name = "tab_test_types";
            this.tab_test_types.Padding = new System.Windows.Forms.Padding(3);
            this.tab_test_types.Size = new System.Drawing.Size(745, 339);
            this.tab_test_types.TabIndex = 2;
            this.tab_test_types.Text = "Test Types";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.lb_total_test_types_number);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 286);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(739, 50);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number of Test Types: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_total_test_types_number
            // 
            this.lb_total_test_types_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_test_types_number.Location = new System.Drawing.Point(216, 0);
            this.lb_total_test_types_number.Name = "lb_total_test_types_number";
            this.lb_total_test_types_number.Size = new System.Drawing.Size(238, 50);
            this.lb_total_test_types_number.TabIndex = 1;
            this.lb_total_test_types_number.Text = "??";
            this.lb_total_test_types_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_test_types
            // 
            this.dgv_test_types.AllowUserToAddRows = false;
            this.dgv_test_types.AllowUserToDeleteRows = false;
            this.dgv_test_types.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_test_types.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_test_types.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_test_types.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_test_types.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.class_full_name,
            this.description,
            this.fees});
            this.dgv_test_types.CornerRadius = 15;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_test_types.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_test_types.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_test_types.EnableHeadersVisualStyles = false;
            this.dgv_test_types.Location = new System.Drawing.Point(3, 3);
            this.dgv_test_types.Name = "dgv_test_types";
            this.dgv_test_types.ReadOnly = true;
            this.dgv_test_types.Size = new System.Drawing.Size(739, 333);
            this.dgv_test_types.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // class_full_name
            // 
            this.class_full_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.class_full_name.HeaderText = "Name";
            this.class_full_name.Name = "class_full_name";
            this.class_full_name.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // fees
            // 
            this.fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fees.HeaderText = "Fees";
            this.fees.Name = "fees";
            this.fees.ReadOnly = true;
            // 
            // tlp_header
            // 
            this.tlp_header.AutoSize = true;
            this.tlp_header.ColumnCount = 3;
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
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
            // TestManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pl_Body);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestManagementForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "TestManagement";
            this.Load += new System.EventHandler(this.TestManagementForm_Load);
            this.pl_Body.ResumeLayout(false);
            this.pl_Body.PerformLayout();
            this.htc_tab_nav.ResumeLayout(false);
            this.tab_tests_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tests_list)).EndInit();
            this.cms_tests_management.ResumeLayout(false);
            this.flp_footer.ResumeLayout(false);
            this.tab_test_types.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test_types)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel pl_Body;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private CustomControls.HeaderlessTabControl htc_tab_nav;
        private System.Windows.Forms.TabPage tab_tests_list;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_tests_list;
        private UserControls.SearchBar uc_tests_list_topbar;
        private System.Windows.Forms.FlowLayoutPanel flp_footer;
        private System.Windows.Forms.Label lb_footer_text;
        private System.Windows.Forms.TabPage tab_test_types;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_test_types;
        private System.Windows.Forms.DataGridViewTextBoxColumn ldl_application_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn national_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn application_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn passed_tests;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn fees;
        private System.Windows.Forms.Label lb_total_tests_number;
        private System.Windows.Forms.Label lb_total_test_types_number;
        private System.Windows.Forms.ContextMenuStrip cms_tests_management;
        private System.Windows.Forms.ToolStripMenuItem tsmi_show_app_details;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit_app;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete_app;
        private System.Windows.Forms.ToolStripMenuItem tsmi_cancel_app;
        private System.Windows.Forms.ToolStripMenuItem tsmi_test_management;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_issue_license;
        private System.Windows.Forms.ToolStripMenuItem tsmi_show_license;
    }
}