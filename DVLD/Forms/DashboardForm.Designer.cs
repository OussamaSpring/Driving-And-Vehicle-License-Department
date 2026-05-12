namespace DVLD.Forms
{
    partial class DashboardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lb_Title = new System.Windows.Forms.Label();
            this.tlp_dashboard = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pl_recent_test_results = new System.Windows.Forms.Panel();
            this.dtg_recent_test_results = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.applicant_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seperator3 = new iNKORE.UI.WinForms.Styler.Controls.Seperator();
            this.pl_recent_test_results_header = new System.Windows.Forms.Panel();
            this.btn_manage_tests = new DVLD.Views.Controls.RoundedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pl_license_distribution_body = new System.Windows.Forms.Panel();
            this.seperator4 = new iNKORE.UI.WinForms.Styler.Controls.Seperator();
            this.flp_license_distribution_header = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tlp_cards = new System.Windows.Forms.TableLayoutPanel();
            this.card_ScheduledTests = new DVLD.UserControls.DashboardCard();
            this.card_PendingApplications = new DVLD.UserControls.DashboardCard();
            this.card_RegisteredDrivers = new DVLD.UserControls.DashboardCard();
            this.card_ActiveLicenses = new DVLD.UserControls.DashboardCard();
            this.tlp_charts = new System.Windows.Forms.TableLayoutPanel();
            this.pl_detained_license_revenue = new System.Windows.Forms.Panel();
            this.pl_detained_license_revenue_body = new System.Windows.Forms.Panel();
            this.chart_detained_license_revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.seperator2 = new iNKORE.UI.WinForms.Styler.Controls.Seperator();
            this.flp_detained_license_revenue_header = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pl_applications_by_type = new System.Windows.Forms.Panel();
            this.pl_applications_by_type_body = new System.Windows.Forms.Panel();
            this.chart_applications_by_type = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.seperator1 = new iNKORE.UI.WinForms.Styler.Controls.Seperator();
            this.flp_applications_by_type_header = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tlp_dashboard.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pl_recent_test_results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_recent_test_results)).BeginInit();
            this.pl_recent_test_results_header.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flp_license_distribution_header.SuspendLayout();
            this.tlp_cards.SuspendLayout();
            this.tlp_charts.SuspendLayout();
            this.pl_detained_license_revenue.SuspendLayout();
            this.pl_detained_license_revenue_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_detained_license_revenue)).BeginInit();
            this.flp_detained_license_revenue_header.SuspendLayout();
            this.pl_applications_by_type.SuspendLayout();
            this.pl_applications_by_type_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_applications_by_type)).BeginInit();
            this.flp_applications_by_type_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(20, 20);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(148, 29);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Dashboard.";
            // 
            // tlp_dashboard
            // 
            this.tlp_dashboard.AutoSize = true;
            this.tlp_dashboard.ColumnCount = 1;
            this.tlp_dashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_dashboard.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlp_dashboard.Controls.Add(this.tlp_cards, 0, 0);
            this.tlp_dashboard.Controls.Add(this.tlp_charts, 0, 1);
            this.tlp_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_dashboard.Location = new System.Drawing.Point(20, 49);
            this.tlp_dashboard.Name = "tlp_dashboard";
            this.tlp_dashboard.Padding = new System.Windows.Forms.Padding(0, 26, 0, 0);
            this.tlp_dashboard.RowCount = 3;
            this.tlp_dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_dashboard.Size = new System.Drawing.Size(900, 452);
            this.tlp_dashboard.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pl_recent_test_results, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 485);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(0, 480);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 330);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(894, 330);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pl_recent_test_results
            // 
            this.pl_recent_test_results.BackColor = System.Drawing.Color.White;
            this.pl_recent_test_results.Controls.Add(this.dtg_recent_test_results);
            this.pl_recent_test_results.Controls.Add(this.seperator3);
            this.pl_recent_test_results.Controls.Add(this.pl_recent_test_results_header);
            this.pl_recent_test_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_recent_test_results.Location = new System.Drawing.Point(457, 15);
            this.pl_recent_test_results.Margin = new System.Windows.Forms.Padding(10, 15, 0, 10);
            this.pl_recent_test_results.Name = "pl_recent_test_results";
            this.pl_recent_test_results.Size = new System.Drawing.Size(437, 305);
            this.pl_recent_test_results.TabIndex = 1;
            // 
            // dtg_recent_test_results
            // 
            this.dtg_recent_test_results.AllowUserToAddRows = false;
            this.dtg_recent_test_results.AllowUserToDeleteRows = false;
            this.dtg_recent_test_results.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dtg_recent_test_results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_recent_test_results.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_recent_test_results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_recent_test_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_recent_test_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.applicant_name,
            this.test_type,
            this.result,
            this.date});
            this.dtg_recent_test_results.CornerRadius = 1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_recent_test_results.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_recent_test_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_recent_test_results.EnableHeadersVisualStyles = false;
            this.dtg_recent_test_results.Location = new System.Drawing.Point(0, 73);
            this.dtg_recent_test_results.Name = "dtg_recent_test_results";
            this.dtg_recent_test_results.ReadOnly = true;
            this.dtg_recent_test_results.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_recent_test_results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_recent_test_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_recent_test_results.Size = new System.Drawing.Size(437, 232);
            this.dtg_recent_test_results.TabIndex = 4;
            // 
            // applicant_name
            // 
            this.applicant_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.applicant_name.HeaderText = "APPLICANT NAME";
            this.applicant_name.Name = "applicant_name";
            this.applicant_name.ReadOnly = true;
            // 
            // test_type
            // 
            this.test_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.test_type.HeaderText = "TEST TYPE";
            this.test_type.Name = "test_type";
            this.test_type.ReadOnly = true;
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.result.HeaderText = "RESULT";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "DATE";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // seperator3
            // 
            this.seperator3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.seperator3.Dock = System.Windows.Forms.DockStyle.Top;
            this.seperator3.Location = new System.Drawing.Point(0, 65);
            this.seperator3.Margin = new System.Windows.Forms.Padding(0);
            this.seperator3.Name = "seperator3";
            this.seperator3.Size = new System.Drawing.Size(437, 8);
            this.seperator3.TabIndex = 3;
            this.seperator3.TabStop = false;
            // 
            // pl_recent_test_results_header
            // 
            this.pl_recent_test_results_header.Controls.Add(this.btn_manage_tests);
            this.pl_recent_test_results_header.Controls.Add(this.label3);
            this.pl_recent_test_results_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_recent_test_results_header.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.pl_recent_test_results_header.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pl_recent_test_results_header.Location = new System.Drawing.Point(0, 0);
            this.pl_recent_test_results_header.Name = "pl_recent_test_results_header";
            this.pl_recent_test_results_header.Padding = new System.Windows.Forms.Padding(20);
            this.pl_recent_test_results_header.Size = new System.Drawing.Size(437, 65);
            this.pl_recent_test_results_header.TabIndex = 0;
            // 
            // btn_manage_tests
            // 
            this.btn_manage_tests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_manage_tests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btn_manage_tests.BorderColor = System.Drawing.Color.Black;
            this.btn_manage_tests.BorderRadius = 20;
            this.btn_manage_tests.BorderSize = 0;
            this.btn_manage_tests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manage_tests.FlatAppearance.BorderSize = 0;
            this.btn_manage_tests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manage_tests.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_tests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.btn_manage_tests.Location = new System.Drawing.Point(252, 14);
            this.btn_manage_tests.Name = "btn_manage_tests";
            this.btn_manage_tests.Size = new System.Drawing.Size(160, 40);
            this.btn_manage_tests.TabIndex = 1;
            this.btn_manage_tests.Text = "MANAGE TESTS ➡️";
            this.btn_manage_tests.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Recent Test Results";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pl_license_distribution_body);
            this.panel3.Controls.Add(this.seperator4);
            this.panel3.Controls.Add(this.flp_license_distribution_header);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 15, 10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 305);
            this.panel3.TabIndex = 0;
            // 
            // pl_license_distribution_body
            // 
            this.pl_license_distribution_body.BackColor = System.Drawing.Color.White;
            this.pl_license_distribution_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_license_distribution_body.Location = new System.Drawing.Point(0, 73);
            this.pl_license_distribution_body.Margin = new System.Windows.Forms.Padding(0);
            this.pl_license_distribution_body.Name = "pl_license_distribution_body";
            this.pl_license_distribution_body.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.pl_license_distribution_body.Size = new System.Drawing.Size(437, 232);
            this.pl_license_distribution_body.TabIndex = 4;
            // 
            // seperator4
            // 
            this.seperator4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.seperator4.Dock = System.Windows.Forms.DockStyle.Top;
            this.seperator4.Location = new System.Drawing.Point(0, 65);
            this.seperator4.Margin = new System.Windows.Forms.Padding(0);
            this.seperator4.Name = "seperator4";
            this.seperator4.Size = new System.Drawing.Size(437, 8);
            this.seperator4.TabIndex = 2;
            this.seperator4.TabStop = false;
            // 
            // flp_license_distribution_header
            // 
            this.flp_license_distribution_header.AutoSize = true;
            this.flp_license_distribution_header.BackColor = System.Drawing.Color.White;
            this.flp_license_distribution_header.Controls.Add(this.label4);
            this.flp_license_distribution_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.flp_license_distribution_header.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_license_distribution_header.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flp_license_distribution_header.Location = new System.Drawing.Point(0, 0);
            this.flp_license_distribution_header.Name = "flp_license_distribution_header";
            this.flp_license_distribution_header.Padding = new System.Windows.Forms.Padding(20);
            this.flp_license_distribution_header.Size = new System.Drawing.Size(437, 65);
            this.flp_license_distribution_header.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "License Distribution";
            // 
            // tlp_cards
            // 
            this.tlp_cards.ColumnCount = 4;
            this.tlp_cards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_cards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_cards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_cards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_cards.Controls.Add(this.card_ScheduledTests, 3, 0);
            this.tlp_cards.Controls.Add(this.card_PendingApplications, 2, 0);
            this.tlp_cards.Controls.Add(this.card_RegisteredDrivers, 0, 0);
            this.tlp_cards.Controls.Add(this.card_ActiveLicenses, 1, 0);
            this.tlp_cards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_cards.Location = new System.Drawing.Point(0, 26);
            this.tlp_cards.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_cards.Name = "tlp_cards";
            this.tlp_cards.RowCount = 1;
            this.tlp_cards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_cards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_cards.Size = new System.Drawing.Size(900, 120);
            this.tlp_cards.TabIndex = 0;
            // 
            // card_ScheduledTests
            // 
            this.card_ScheduledTests.BackColor = System.Drawing.Color.White;
            this.card_ScheduledTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card_ScheduledTests.Location = new System.Drawing.Point(695, 0);
            this.card_ScheduledTests.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.card_ScheduledTests.Name = "card_ScheduledTests";
            this.card_ScheduledTests.Size = new System.Drawing.Size(205, 120);
            this.card_ScheduledTests.TabIndex = 3;
            // 
            // card_PendingApplications
            // 
            this.card_PendingApplications.BackColor = System.Drawing.Color.White;
            this.card_PendingApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card_PendingApplications.Location = new System.Drawing.Point(470, 0);
            this.card_PendingApplications.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.card_PendingApplications.Name = "card_PendingApplications";
            this.card_PendingApplications.Size = new System.Drawing.Size(205, 120);
            this.card_PendingApplications.TabIndex = 2;
            // 
            // card_RegisteredDrivers
            // 
            this.card_RegisteredDrivers.BackColor = System.Drawing.Color.White;
            this.card_RegisteredDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card_RegisteredDrivers.Location = new System.Drawing.Point(0, 0);
            this.card_RegisteredDrivers.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.card_RegisteredDrivers.Name = "card_RegisteredDrivers";
            this.card_RegisteredDrivers.Size = new System.Drawing.Size(215, 120);
            this.card_RegisteredDrivers.TabIndex = 0;
            // 
            // card_ActiveLicenses
            // 
            this.card_ActiveLicenses.BackColor = System.Drawing.Color.White;
            this.card_ActiveLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card_ActiveLicenses.Location = new System.Drawing.Point(235, 0);
            this.card_ActiveLicenses.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.card_ActiveLicenses.Name = "card_ActiveLicenses";
            this.card_ActiveLicenses.Size = new System.Drawing.Size(210, 120);
            this.card_ActiveLicenses.TabIndex = 1;
            // 
            // tlp_charts
            // 
            this.tlp_charts.ColumnCount = 2;
            this.tlp_charts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_charts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_charts.Controls.Add(this.pl_detained_license_revenue, 1, 0);
            this.tlp_charts.Controls.Add(this.pl_applications_by_type, 0, 0);
            this.tlp_charts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_charts.Location = new System.Drawing.Point(3, 149);
            this.tlp_charts.MaximumSize = new System.Drawing.Size(0, 480);
            this.tlp_charts.MinimumSize = new System.Drawing.Size(0, 330);
            this.tlp_charts.Name = "tlp_charts";
            this.tlp_charts.RowCount = 1;
            this.tlp_charts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_charts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_charts.Size = new System.Drawing.Size(894, 330);
            this.tlp_charts.TabIndex = 1;
            // 
            // pl_detained_license_revenue
            // 
            this.pl_detained_license_revenue.Controls.Add(this.pl_detained_license_revenue_body);
            this.pl_detained_license_revenue.Controls.Add(this.seperator2);
            this.pl_detained_license_revenue.Controls.Add(this.flp_detained_license_revenue_header);
            this.pl_detained_license_revenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_detained_license_revenue.Location = new System.Drawing.Point(457, 30);
            this.pl_detained_license_revenue.Margin = new System.Windows.Forms.Padding(10, 30, 0, 10);
            this.pl_detained_license_revenue.Name = "pl_detained_license_revenue";
            this.pl_detained_license_revenue.Size = new System.Drawing.Size(437, 290);
            this.pl_detained_license_revenue.TabIndex = 1;
            // 
            // pl_detained_license_revenue_body
            // 
            this.pl_detained_license_revenue_body.BackColor = System.Drawing.Color.White;
            this.pl_detained_license_revenue_body.Controls.Add(this.chart_detained_license_revenue);
            this.pl_detained_license_revenue_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_detained_license_revenue_body.Location = new System.Drawing.Point(0, 73);
            this.pl_detained_license_revenue_body.Margin = new System.Windows.Forms.Padding(0);
            this.pl_detained_license_revenue_body.Name = "pl_detained_license_revenue_body";
            this.pl_detained_license_revenue_body.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.pl_detained_license_revenue_body.Size = new System.Drawing.Size(437, 217);
            this.pl_detained_license_revenue_body.TabIndex = 5;
            // 
            // chart_detained_license_revenue
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_detained_license_revenue.ChartAreas.Add(chartArea3);
            this.chart_detained_license_revenue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart_detained_license_revenue.Legends.Add(legend3);
            this.chart_detained_license_revenue.Location = new System.Drawing.Point(0, 15);
            this.chart_detained_license_revenue.Name = "chart_detained_license_revenue";
            this.chart_detained_license_revenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_detained_license_revenue.Series.Add(series3);
            this.chart_detained_license_revenue.Size = new System.Drawing.Size(437, 187);
            this.chart_detained_license_revenue.TabIndex = 0;
            this.chart_detained_license_revenue.Text = "chart2";
            // 
            // seperator2
            // 
            this.seperator2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.seperator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.seperator2.Location = new System.Drawing.Point(0, 65);
            this.seperator2.Margin = new System.Windows.Forms.Padding(0);
            this.seperator2.Name = "seperator2";
            this.seperator2.Size = new System.Drawing.Size(437, 8);
            this.seperator2.TabIndex = 3;
            this.seperator2.TabStop = false;
            // 
            // flp_detained_license_revenue_header
            // 
            this.flp_detained_license_revenue_header.AutoSize = true;
            this.flp_detained_license_revenue_header.BackColor = System.Drawing.Color.White;
            this.flp_detained_license_revenue_header.Controls.Add(this.label2);
            this.flp_detained_license_revenue_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.flp_detained_license_revenue_header.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_detained_license_revenue_header.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flp_detained_license_revenue_header.Location = new System.Drawing.Point(0, 0);
            this.flp_detained_license_revenue_header.Name = "flp_detained_license_revenue_header";
            this.flp_detained_license_revenue_header.Padding = new System.Windows.Forms.Padding(20);
            this.flp_detained_license_revenue_header.Size = new System.Drawing.Size(437, 65);
            this.flp_detained_license_revenue_header.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detained License & Revenue";
            // 
            // pl_applications_by_type
            // 
            this.pl_applications_by_type.BackColor = System.Drawing.Color.White;
            this.pl_applications_by_type.Controls.Add(this.pl_applications_by_type_body);
            this.pl_applications_by_type.Controls.Add(this.seperator1);
            this.pl_applications_by_type.Controls.Add(this.flp_applications_by_type_header);
            this.pl_applications_by_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_applications_by_type.Location = new System.Drawing.Point(0, 30);
            this.pl_applications_by_type.Margin = new System.Windows.Forms.Padding(0, 30, 10, 10);
            this.pl_applications_by_type.Name = "pl_applications_by_type";
            this.pl_applications_by_type.Size = new System.Drawing.Size(437, 290);
            this.pl_applications_by_type.TabIndex = 0;
            // 
            // pl_applications_by_type_body
            // 
            this.pl_applications_by_type_body.BackColor = System.Drawing.Color.White;
            this.pl_applications_by_type_body.Controls.Add(this.chart_applications_by_type);
            this.pl_applications_by_type_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_applications_by_type_body.Location = new System.Drawing.Point(0, 73);
            this.pl_applications_by_type_body.Margin = new System.Windows.Forms.Padding(0);
            this.pl_applications_by_type_body.Name = "pl_applications_by_type_body";
            this.pl_applications_by_type_body.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.pl_applications_by_type_body.Size = new System.Drawing.Size(437, 217);
            this.pl_applications_by_type_body.TabIndex = 4;
            // 
            // chart_applications_by_type
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_applications_by_type.ChartAreas.Add(chartArea4);
            this.chart_applications_by_type.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart_applications_by_type.Legends.Add(legend4);
            this.chart_applications_by_type.Location = new System.Drawing.Point(0, 15);
            this.chart_applications_by_type.Name = "chart_applications_by_type";
            this.chart_applications_by_type.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_applications_by_type.Series.Add(series4);
            this.chart_applications_by_type.Size = new System.Drawing.Size(437, 187);
            this.chart_applications_by_type.TabIndex = 0;
            this.chart_applications_by_type.Text = "chart1";
            // 
            // seperator1
            // 
            this.seperator1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.seperator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.seperator1.Location = new System.Drawing.Point(0, 65);
            this.seperator1.Margin = new System.Windows.Forms.Padding(0);
            this.seperator1.Name = "seperator1";
            this.seperator1.Size = new System.Drawing.Size(437, 8);
            this.seperator1.TabIndex = 2;
            this.seperator1.TabStop = false;
            // 
            // flp_applications_by_type_header
            // 
            this.flp_applications_by_type_header.AutoSize = true;
            this.flp_applications_by_type_header.BackColor = System.Drawing.Color.White;
            this.flp_applications_by_type_header.Controls.Add(this.label1);
            this.flp_applications_by_type_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.flp_applications_by_type_header.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_applications_by_type_header.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flp_applications_by_type_header.Location = new System.Drawing.Point(0, 0);
            this.flp_applications_by_type_header.Name = "flp_applications_by_type_header";
            this.flp_applications_by_type_header.Padding = new System.Windows.Forms.Padding(20);
            this.flp_applications_by_type_header.Size = new System.Drawing.Size(437, 65);
            this.flp_applications_by_type_header.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Applications by Type";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(940, 521);
            this.Controls.Add(this.tlp_dashboard);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tlp_dashboard.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pl_recent_test_results.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_recent_test_results)).EndInit();
            this.pl_recent_test_results_header.ResumeLayout(false);
            this.pl_recent_test_results_header.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flp_license_distribution_header.ResumeLayout(false);
            this.flp_license_distribution_header.PerformLayout();
            this.tlp_cards.ResumeLayout(false);
            this.tlp_charts.ResumeLayout(false);
            this.pl_detained_license_revenue.ResumeLayout(false);
            this.pl_detained_license_revenue.PerformLayout();
            this.pl_detained_license_revenue_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_detained_license_revenue)).EndInit();
            this.flp_detained_license_revenue_header.ResumeLayout(false);
            this.flp_detained_license_revenue_header.PerformLayout();
            this.pl_applications_by_type.ResumeLayout(false);
            this.pl_applications_by_type.PerformLayout();
            this.pl_applications_by_type_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_applications_by_type)).EndInit();
            this.flp_applications_by_type_header.ResumeLayout(false);
            this.flp_applications_by_type_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TableLayoutPanel tlp_dashboard;
        private System.Windows.Forms.TableLayoutPanel tlp_cards;
        private UserControls.DashboardCard card_RegisteredDrivers;
        private UserControls.DashboardCard card_ScheduledTests;
        private UserControls.DashboardCard card_PendingApplications;
        private UserControls.DashboardCard card_ActiveLicenses;
        private System.Windows.Forms.TableLayoutPanel tlp_charts;
        private System.Windows.Forms.Panel pl_applications_by_type;
        private System.Windows.Forms.Panel pl_detained_license_revenue;
        private System.Windows.Forms.FlowLayoutPanel flp_applications_by_type_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp_detained_license_revenue_header;
        private System.Windows.Forms.Label label2;
        private iNKORE.UI.WinForms.Styler.Controls.Seperator seperator1;
        private iNKORE.UI.WinForms.Styler.Controls.Seperator seperator2;
        private System.Windows.Forms.Panel pl_applications_by_type_body;
        private System.Windows.Forms.Panel pl_detained_license_revenue_body;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_detained_license_revenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_applications_by_type;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pl_recent_test_results;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pl_license_distribution_body;
        private iNKORE.UI.WinForms.Styler.Controls.Seperator seperator4;
        private System.Windows.Forms.FlowLayoutPanel flp_license_distribution_header;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pl_recent_test_results_header;
        private Views.Controls.RoundedButton btn_manage_tests;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dtg_recent_test_results;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicant_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private iNKORE.UI.WinForms.Styler.Controls.Seperator seperator3;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}