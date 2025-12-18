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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pl_Body = new System.Windows.Forms.Panel();
            this.htc_tab_nav = new DVLD.CustomControls.HeaderlessTabControl();
            this.tab_tests_list = new System.Windows.Forms.TabPage();
            this.dgv_local_licenses = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.ldl_application_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.national_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.application_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passed_tests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBar1 = new DVLD.UserControls.SearchBar();
            this.flp_footer = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_text = new System.Windows.Forms.Label();
            this.tab_test_types = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_license_classes = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.lb_total_test_number = new System.Windows.Forms.Label();
            this.lb_total_test_types_number = new System.Windows.Forms.Label();
            this.pl_Body.SuspendLayout();
            this.htc_tab_nav.SuspendLayout();
            this.tab_tests_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local_licenses)).BeginInit();
            this.flp_footer.SuspendLayout();
            this.tab_test_types.SuspendLayout();
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
            this.tab_tests_list.Controls.Add(this.dgv_local_licenses);
            this.tab_tests_list.Controls.Add(this.searchBar1);
            this.tab_tests_list.Controls.Add(this.flp_footer);
            this.tab_tests_list.Location = new System.Drawing.Point(4, 28);
            this.tab_tests_list.Name = "tab_tests_list";
            this.tab_tests_list.Padding = new System.Windows.Forms.Padding(3);
            this.tab_tests_list.Size = new System.Drawing.Size(745, 339);
            this.tab_tests_list.TabIndex = 0;
            this.tab_tests_list.Text = "Tests List";
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
            this.ldl_application_id,
            this.license_class,
            this.national_number,
            this.fullname,
            this.application_date,
            this.passed_tests,
            this.status});
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
            this.dgv_local_licenses.Size = new System.Drawing.Size(739, 233);
            this.dgv_local_licenses.TabIndex = 2;
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
            // searchBar1
            // 
            this.searchBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBar1.Location = new System.Drawing.Point(3, 3);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(739, 50);
            this.searchBar1.TabIndex = 1;
            // 
            // flp_footer
            // 
            this.flp_footer.Controls.Add(this.lb_footer_text);
            this.flp_footer.Controls.Add(this.lb_total_test_number);
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
            // tab_test_types
            // 
            this.tab_test_types.BackColor = System.Drawing.SystemColors.Control;
            this.tab_test_types.Controls.Add(this.flowLayoutPanel2);
            this.tab_test_types.Controls.Add(this.dgv_license_classes);
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
            // dgv_license_classes
            // 
            this.dgv_license_classes.AllowUserToAddRows = false;
            this.dgv_license_classes.AllowUserToDeleteRows = false;
            this.dgv_license_classes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_license_classes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_license_classes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_license_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_license_classes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.class_full_name,
            this.description,
            this.fees});
            this.dgv_license_classes.CornerRadius = 15;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_license_classes.DefaultCellStyle = dataGridViewCellStyle4;
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
            // lb_total_test_number
            // 
            this.lb_total_test_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_test_number.Location = new System.Drawing.Point(181, 0);
            this.lb_total_test_number.Name = "lb_total_test_number";
            this.lb_total_test_number.Size = new System.Drawing.Size(197, 50);
            this.lb_total_test_number.TabIndex = 1;
            this.lb_total_test_number.Text = "??";
            this.lb_total_test_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local_licenses)).EndInit();
            this.flp_footer.ResumeLayout(false);
            this.tab_test_types.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tab_tests_list;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_local_licenses;
        private UserControls.SearchBar searchBar1;
        private System.Windows.Forms.FlowLayoutPanel flp_footer;
        private System.Windows.Forms.Label lb_footer_text;
        private System.Windows.Forms.TabPage tab_test_types;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_license_classes;
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
        private System.Windows.Forms.Label lb_total_test_number;
        private System.Windows.Forms.Label lb_total_test_types_number;
    }
}