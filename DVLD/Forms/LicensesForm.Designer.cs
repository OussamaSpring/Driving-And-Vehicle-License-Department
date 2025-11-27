namespace DVLD.Forms
{
    partial class LicensesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pl_Body = new System.Windows.Forms.Panel();
            this.htc_tab_nav = new DVLD.CustomControls.HeaderlessTabControl();
            this.tab_local = new System.Windows.Forms.TabPage();
            this.dgv_local_licenses = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.license_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.application_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiration_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.issue_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issued_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uc_local_topbar = new DVLD.UserControls.SearchBar();
            this.flp_footer = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_text_local = new System.Windows.Forms.Label();
            this.tab_international = new System.Windows.Forms.TabPage();
            this.dgv_international_licenses = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.international_license_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_application_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_driver_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.local_license_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_expiration_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.inter_issued_by_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uc_international_topbar = new DVLD.UserControls.SearchBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_text_inter = new System.Windows.Forms.Label();
            this.tab_classes = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_text_classes = new System.Windows.Forms.Label();
            this.dgv_license_classes = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimum_allowed_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.default_validity_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.pl_Body.SuspendLayout();
            this.htc_tab_nav.SuspendLayout();
            this.tab_local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local_licenses)).BeginInit();
            this.flp_footer.SuspendLayout();
            this.tab_international.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_international_licenses)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tab_classes.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_license_classes)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(20, 20);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(124, 29);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Licenses.";
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
            this.htc_tab_nav.Controls.Add(this.tab_local);
            this.htc_tab_nav.Controls.Add(this.tab_international);
            this.htc_tab_nav.Controls.Add(this.tab_classes);
            this.htc_tab_nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htc_tab_nav.ItemSize = new System.Drawing.Size(100, 24);
            this.htc_tab_nav.Location = new System.Drawing.Point(7, 10);
            this.htc_tab_nav.Name = "htc_tab_nav";
            this.htc_tab_nav.SelectedIndex = 0;
            this.htc_tab_nav.Size = new System.Drawing.Size(753, 371);
            this.htc_tab_nav.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.htc_tab_nav.TabIndex = 2;
            // 
            // tab_local
            // 
            this.tab_local.BackColor = System.Drawing.SystemColors.Control;
            this.tab_local.Controls.Add(this.dgv_local_licenses);
            this.tab_local.Controls.Add(this.uc_local_topbar);
            this.tab_local.Controls.Add(this.flp_footer);
            this.tab_local.Location = new System.Drawing.Point(4, 28);
            this.tab_local.Name = "tab_local";
            this.tab_local.Padding = new System.Windows.Forms.Padding(3);
            this.tab_local.Size = new System.Drawing.Size(745, 339);
            this.tab_local.TabIndex = 0;
            this.tab_local.Text = "Local";
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
            this.issue_reason,
            this.issued_by});
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
            this.dgv_local_licenses.Location = new System.Drawing.Point(3, 53);
            this.dgv_local_licenses.Name = "dgv_local_licenses";
            this.dgv_local_licenses.ReadOnly = true;
            this.dgv_local_licenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_local_licenses.Size = new System.Drawing.Size(739, 233);
            this.dgv_local_licenses.TabIndex = 2;
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
            // issued_by
            // 
            this.issued_by.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issued_by.HeaderText = "Issued by User";
            this.issued_by.Name = "issued_by";
            this.issued_by.ReadOnly = true;
            // 
            // uc_local_topbar
            // 
            this.uc_local_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_local_topbar.Location = new System.Drawing.Point(3, 3);
            this.uc_local_topbar.Name = "uc_local_topbar";
            this.uc_local_topbar.Size = new System.Drawing.Size(739, 50);
            this.uc_local_topbar.TabIndex = 1;
            // 
            // flp_footer
            // 
            this.flp_footer.Controls.Add(this.lb_footer_text_local);
            this.flp_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_footer.Location = new System.Drawing.Point(3, 286);
            this.flp_footer.Name = "flp_footer";
            this.flp_footer.Size = new System.Drawing.Size(739, 50);
            this.flp_footer.TabIndex = 0;
            // 
            // lb_footer_text_local
            // 
            this.lb_footer_text_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_text_local.Location = new System.Drawing.Point(3, 0);
            this.lb_footer_text_local.Name = "lb_footer_text_local";
            this.lb_footer_text_local.Size = new System.Drawing.Size(624, 50);
            this.lb_footer_text_local.TabIndex = 0;
            this.lb_footer_text_local.Text = "Total Number of Local Licenses: ";
            this.lb_footer_text_local.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_international
            // 
            this.tab_international.BackColor = System.Drawing.SystemColors.Control;
            this.tab_international.Controls.Add(this.dgv_international_licenses);
            this.tab_international.Controls.Add(this.uc_international_topbar);
            this.tab_international.Controls.Add(this.flowLayoutPanel1);
            this.tab_international.Location = new System.Drawing.Point(4, 28);
            this.tab_international.Name = "tab_international";
            this.tab_international.Padding = new System.Windows.Forms.Padding(3);
            this.tab_international.Size = new System.Drawing.Size(745, 339);
            this.tab_international.TabIndex = 1;
            this.tab_international.Text = "International";
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
            this.dataGridViewCheckBoxColumn1,
            this.inter_issued_by_user});
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
            this.dgv_international_licenses.Location = new System.Drawing.Point(3, 53);
            this.dgv_international_licenses.Name = "dgv_international_licenses";
            this.dgv_international_licenses.ReadOnly = true;
            this.dgv_international_licenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_international_licenses.Size = new System.Drawing.Size(739, 233);
            this.dgv_international_licenses.TabIndex = 4;
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
            // inter_issued_by_user
            // 
            this.inter_issued_by_user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inter_issued_by_user.HeaderText = "Issued by User";
            this.inter_issued_by_user.Name = "inter_issued_by_user";
            this.inter_issued_by_user.ReadOnly = true;
            // 
            // uc_international_topbar
            // 
            this.uc_international_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_international_topbar.Location = new System.Drawing.Point(3, 3);
            this.uc_international_topbar.Name = "uc_international_topbar";
            this.uc_international_topbar.Size = new System.Drawing.Size(739, 50);
            this.uc_international_topbar.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lb_footer_text_inter);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 286);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(739, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lb_footer_text_inter
            // 
            this.lb_footer_text_inter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_text_inter.Location = new System.Drawing.Point(3, 0);
            this.lb_footer_text_inter.Name = "lb_footer_text_inter";
            this.lb_footer_text_inter.Size = new System.Drawing.Size(624, 50);
            this.lb_footer_text_inter.TabIndex = 0;
            this.lb_footer_text_inter.Text = "Total Number of International Licenses: ";
            this.lb_footer_text_inter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_classes
            // 
            this.tab_classes.BackColor = System.Drawing.SystemColors.Control;
            this.tab_classes.Controls.Add(this.flowLayoutPanel2);
            this.tab_classes.Controls.Add(this.dgv_license_classes);
            this.tab_classes.Location = new System.Drawing.Point(4, 28);
            this.tab_classes.Name = "tab_classes";
            this.tab_classes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_classes.Size = new System.Drawing.Size(745, 339);
            this.tab_classes.TabIndex = 2;
            this.tab_classes.Text = "Classes";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lb_footer_text_classes);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 286);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(739, 50);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // lb_footer_text_classes
            // 
            this.lb_footer_text_classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_text_classes.Location = new System.Drawing.Point(3, 0);
            this.lb_footer_text_classes.Name = "lb_footer_text_classes";
            this.lb_footer_text_classes.Size = new System.Drawing.Size(624, 50);
            this.lb_footer_text_classes.TabIndex = 0;
            this.lb_footer_text_classes.Text = "Total Number of License Classes: ";
            this.lb_footer_text_classes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_license_classes
            // 
            this.dgv_license_classes.AllowUserToAddRows = false;
            this.dgv_license_classes.AllowUserToDeleteRows = false;
            this.dgv_license_classes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_license_classes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_license_classes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_license_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_license_classes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.class_full_name,
            this.description,
            this.minimum_allowed_age,
            this.default_validity_length,
            this.fees});
            this.dgv_license_classes.CornerRadius = 15;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_license_classes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_license_classes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_license_classes.EnableHeadersVisualStyles = false;
            this.dgv_license_classes.Location = new System.Drawing.Point(3, 3);
            this.dgv_license_classes.Name = "dgv_license_classes";
            this.dgv_license_classes.ReadOnly = true;
            this.dgv_license_classes.Size = new System.Drawing.Size(739, 333);
            this.dgv_license_classes.TabIndex = 3;
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
            // minimum_allowed_age
            // 
            this.minimum_allowed_age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.minimum_allowed_age.HeaderText = "Minimum Allowed Age";
            this.minimum_allowed_age.Name = "minimum_allowed_age";
            this.minimum_allowed_age.ReadOnly = true;
            // 
            // default_validity_length
            // 
            this.default_validity_length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.default_validity_length.HeaderText = "Default Validity Length";
            this.default_validity_length.Name = "default_validity_length";
            this.default_validity_length.ReadOnly = true;
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
            // LicensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pl_Body);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LicensesForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Licenses.";
            this.Load += new System.EventHandler(this.LicensesForm_Load);
            this.pl_Body.ResumeLayout(false);
            this.pl_Body.PerformLayout();
            this.htc_tab_nav.ResumeLayout(false);
            this.tab_local.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local_licenses)).EndInit();
            this.flp_footer.ResumeLayout(false);
            this.tab_international.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_international_licenses)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tab_classes.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_license_classes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel pl_Body;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private CustomControls.HeaderlessTabControl htc_tab_nav;
        private System.Windows.Forms.TabPage tab_local;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_local_licenses;
        private UserControls.SearchBar uc_local_topbar;
        private System.Windows.Forms.FlowLayoutPanel flp_footer;
        private System.Windows.Forms.Label lb_footer_text_local;
        private System.Windows.Forms.TabPage tab_international;
        private UserControls.SearchBar uc_international_topbar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_footer_text_inter;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_international_licenses;
        private System.Windows.Forms.TabPage tab_classes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lb_footer_text_classes;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_license_classes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimum_allowed_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn default_validity_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn application_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiration_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn issued_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn international_license_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_application_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_driver_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn local_license_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_expiration_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_issued_by_user;
    }
}
