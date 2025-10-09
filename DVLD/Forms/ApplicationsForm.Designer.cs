namespace DVLD.Forms
{
    partial class ApplicationsForm
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.pl_Body = new System.Windows.Forms.Panel();
            this.htc_tab_nav = new DVLD.CustomControls.HeaderlessTabControl();
            this.tab_operations = new System.Windows.Forms.TabPage();
            this.htc_operations_management = new DVLD.CustomControls.HeaderlessTabControl();
            this.tab_actions = new System.Windows.Forms.TabPage();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.flp_container = new System.Windows.Forms.FlowLayoutPanel();
            this.pl_new_local_license = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.roundedPanel10 = new WindowsFormsControlLibrary.CustomControls.RoundedPanel();
            this.pl_new_inter_license = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.roundedPanel8 = new WindowsFormsControlLibrary.CustomControls.RoundedPanel();
            this.pl_detain_license = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.roundedPanel7 = new WindowsFormsControlLibrary.CustomControls.RoundedPanel();
            this.pl_release_license = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.roundedPanel9 = new WindowsFormsControlLibrary.CustomControls.RoundedPanel();
            this.pl_renew_expired_license = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roundedPanel6 = new WindowsFormsControlLibrary.CustomControls.RoundedPanel();
            this.pl_replace_damaged_license = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.roundedPanel11 = new WindowsFormsControlLibrary.CustomControls.RoundedPanel();
            this.pl_replace_lost_license = new System.Windows.Forms.Panel();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.roundedPanel12 = new WindowsFormsControlLibrary.CustomControls.RoundedPanel();
            this.tab_add_new_local_license = new System.Windows.Forms.TabPage();
            this.tlp_page1 = new System.Windows.Forms.TableLayoutPanel();
            this.pl_page1_body = new System.Windows.Forms.Panel();
            this.pl_main = new System.Windows.Forms.Panel();
            this.pl_details = new System.Windows.Forms.Panel();
            this.personDetailsCard1 = new DVLD.UserControls.PersonDetailsCard();
            this.pl_local_license_application_details = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_created_by = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_application_fees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_date_of_birth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flp_page1_footer = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_save = new DVLD.Views.Controls.RoundedButton();
            this.btn_cancel = new DVLD.Views.Controls.RoundedButton();
            this.flp_search_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_add_person = new WindowsFormsControlLibrary.CustomControls.RoundedPictureBox();
            this.pb_search = new WindowsFormsControlLibrary.CustomControls.RoundedPictureBox();
            this.txt_search_word = new System.Windows.Forms.TextBox();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.lb_text = new System.Windows.Forms.Label();
            this.flp_page1_header = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_page1_back = new System.Windows.Forms.PictureBox();
            this.lb_page1_title = new System.Windows.Forms.Label();
            this.tab_add_new_inter_license = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tab_detain_license = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tab_release_license = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_renew_license = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tab_replace_damaged_license = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tab_replace_lost_license = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tab_list = new System.Windows.Forms.TabPage();
            this.dgv_international_licenses = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.application_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.application_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_status_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid_fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_by_user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBar2 = new DVLD.UserControls.SearchBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_text_driver = new System.Windows.Forms.Label();
            this.tab_types = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedDataGridView1 = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.window_operations = new iNKORE.UI.WinForms.Styler.Controls.HeaderlessTabPage();
            this.pl_Body.SuspendLayout();
            this.htc_tab_nav.SuspendLayout();
            this.tab_operations.SuspendLayout();
            this.htc_operations_management.SuspendLayout();
            this.tab_actions.SuspendLayout();
            this.layout.SuspendLayout();
            this.flp_container.SuspendLayout();
            this.pl_new_local_license.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.pl_new_inter_license.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.pl_detain_license.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.pl_release_license.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.pl_renew_expired_license.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pl_replace_damaged_license.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.pl_replace_lost_license.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.tab_add_new_local_license.SuspendLayout();
            this.tlp_page1.SuspendLayout();
            this.pl_page1_body.SuspendLayout();
            this.pl_main.SuspendLayout();
            this.pl_details.SuspendLayout();
            this.pl_local_license_application_details.SuspendLayout();
            this.flp_page1_footer.SuspendLayout();
            this.flp_search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).BeginInit();
            this.flp_page1_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_page1_back)).BeginInit();
            this.tab_add_new_inter_license.SuspendLayout();
            this.tab_detain_license.SuspendLayout();
            this.tab_release_license.SuspendLayout();
            this.tab_renew_license.SuspendLayout();
            this.tab_replace_damaged_license.SuspendLayout();
            this.tab_replace_lost_license.SuspendLayout();
            this.tab_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_international_licenses)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tab_types.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(20, 20);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(167, 29);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Applications.";
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
            this.pl_Body.Size = new System.Drawing.Size(978, 494);
            this.pl_Body.TabIndex = 3;
            // 
            // htc_tab_nav
            // 
            this.htc_tab_nav.Controls.Add(this.tab_operations);
            this.htc_tab_nav.Controls.Add(this.tab_list);
            this.htc_tab_nav.Controls.Add(this.tab_types);
            this.htc_tab_nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htc_tab_nav.ItemSize = new System.Drawing.Size(100, 24);
            this.htc_tab_nav.Location = new System.Drawing.Point(7, 10);
            this.htc_tab_nav.Name = "htc_tab_nav";
            this.htc_tab_nav.SelectedIndex = 0;
            this.htc_tab_nav.Size = new System.Drawing.Size(971, 484);
            this.htc_tab_nav.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.htc_tab_nav.TabIndex = 3;
            // 
            // tab_operations
            // 
            this.tab_operations.BackColor = System.Drawing.SystemColors.Control;
            this.tab_operations.Controls.Add(this.htc_operations_management);
            this.tab_operations.Location = new System.Drawing.Point(4, 28);
            this.tab_operations.Name = "tab_operations";
            this.tab_operations.Padding = new System.Windows.Forms.Padding(3);
            this.tab_operations.Size = new System.Drawing.Size(963, 452);
            this.tab_operations.TabIndex = 0;
            this.tab_operations.Text = "Operations";
            // 
            // htc_operations_management
            // 
            this.htc_operations_management.Controls.Add(this.tab_actions);
            this.htc_operations_management.Controls.Add(this.tab_add_new_local_license);
            this.htc_operations_management.Controls.Add(this.tab_add_new_inter_license);
            this.htc_operations_management.Controls.Add(this.tab_detain_license);
            this.htc_operations_management.Controls.Add(this.tab_release_license);
            this.htc_operations_management.Controls.Add(this.tab_renew_license);
            this.htc_operations_management.Controls.Add(this.tab_replace_damaged_license);
            this.htc_operations_management.Controls.Add(this.tab_replace_lost_license);
            this.htc_operations_management.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htc_operations_management.ItemSize = new System.Drawing.Size(100, 24);
            this.htc_operations_management.Location = new System.Drawing.Point(3, 3);
            this.htc_operations_management.Name = "htc_operations_management";
            this.htc_operations_management.SelectedIndex = 0;
            this.htc_operations_management.Size = new System.Drawing.Size(957, 446);
            this.htc_operations_management.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.htc_operations_management.TabIndex = 4;
            // 
            // tab_actions
            // 
            this.tab_actions.BackColor = System.Drawing.SystemColors.Control;
            this.tab_actions.Controls.Add(this.layout);
            this.tab_actions.Location = new System.Drawing.Point(4, 28);
            this.tab_actions.Name = "tab_actions";
            this.tab_actions.Padding = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tab_actions.Size = new System.Drawing.Size(949, 414);
            this.tab_actions.TabIndex = 0;
            this.tab_actions.Text = "Actions";
            // 
            // layout
            // 
            this.layout.ColumnCount = 3;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layout.Controls.Add(this.flp_container, 1, 0);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(3, 20);
            this.layout.Name = "layout";
            this.layout.RowCount = 1;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Size = new System.Drawing.Size(943, 391);
            this.layout.TabIndex = 31;
            // 
            // flp_container
            // 
            this.flp_container.AutoScroll = true;
            this.flp_container.Controls.Add(this.pl_new_local_license);
            this.flp_container.Controls.Add(this.pl_new_inter_license);
            this.flp_container.Controls.Add(this.pl_detain_license);
            this.flp_container.Controls.Add(this.pl_release_license);
            this.flp_container.Controls.Add(this.pl_renew_expired_license);
            this.flp_container.Controls.Add(this.pl_replace_damaged_license);
            this.flp_container.Controls.Add(this.pl_replace_lost_license);
            this.flp_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_container.Location = new System.Drawing.Point(144, 3);
            this.flp_container.Name = "flp_container";
            this.flp_container.Size = new System.Drawing.Size(654, 385);
            this.flp_container.TabIndex = 0;
            // 
            // pl_new_local_license
            // 
            this.pl_new_local_license.Controls.Add(this.pictureBox11);
            this.pl_new_local_license.Controls.Add(this.label11);
            this.pl_new_local_license.Controls.Add(this.roundedPanel10);
            this.pl_new_local_license.Location = new System.Drawing.Point(0, 20);
            this.pl_new_local_license.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.pl_new_local_license.Name = "pl_new_local_license";
            this.pl_new_local_license.Size = new System.Drawing.Size(180, 137);
            this.pl_new_local_license.TabIndex = 31;
            this.pl_new_local_license.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_NewLocalDrivingLicense_Clicked);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.HotPink;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = global::DVLD.Properties.Resources.driving_license;
            this.pictureBox11.Location = new System.Drawing.Point(20, 10);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(141, 68);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_NewLocalDrivingLicense_Clicked);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.HotPink;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(15, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 44);
            this.label11.TabIndex = 10;
            this.label11.Text = "New Local Driving License";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_NewLocalDrivingLicense_Clicked);
            // 
            // roundedPanel10
            // 
            this.roundedPanel10.BackColor = System.Drawing.Color.HotPink;
            this.roundedPanel10.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel10.BorderRadius = 20;
            this.roundedPanel10.BorderWidth = 1;
            this.roundedPanel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel10.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel10.Name = "roundedPanel10";
            this.roundedPanel10.Size = new System.Drawing.Size(180, 137);
            this.roundedPanel10.TabIndex = 9;
            this.roundedPanel10.Text = "roundedPanel2";
            // 
            // pl_new_inter_license
            // 
            this.pl_new_inter_license.Controls.Add(this.pictureBox9);
            this.pl_new_inter_license.Controls.Add(this.label9);
            this.pl_new_inter_license.Controls.Add(this.roundedPanel8);
            this.pl_new_inter_license.Location = new System.Drawing.Point(200, 20);
            this.pl_new_inter_license.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.pl_new_inter_license.Name = "pl_new_inter_license";
            this.pl_new_inter_license.Size = new System.Drawing.Size(180, 137);
            this.pl_new_inter_license.TabIndex = 41;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Teal;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::DVLD.Properties.Resources.inter_driver_license;
            this.pictureBox9.Location = new System.Drawing.Point(20, 10);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(141, 68);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_NewInterDrivingLicense_Clicked);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(15, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 44);
            this.label9.TabIndex = 13;
            this.label9.Text = "New Inter. Driving License";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_NewInterDrivingLicense_Clicked);
            // 
            // roundedPanel8
            // 
            this.roundedPanel8.BackColor = System.Drawing.Color.Teal;
            this.roundedPanel8.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel8.BorderRadius = 20;
            this.roundedPanel8.BorderWidth = 1;
            this.roundedPanel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel8.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.Size = new System.Drawing.Size(180, 137);
            this.roundedPanel8.TabIndex = 12;
            this.roundedPanel8.Text = "roundedPanel8";
            this.roundedPanel8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_NewInterDrivingLicense_Clicked);
            // 
            // pl_detain_license
            // 
            this.pl_detain_license.Controls.Add(this.pictureBox8);
            this.pl_detain_license.Controls.Add(this.label8);
            this.pl_detain_license.Controls.Add(this.roundedPanel7);
            this.pl_detain_license.Location = new System.Drawing.Point(400, 20);
            this.pl_detain_license.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.pl_detain_license.Name = "pl_detain_license";
            this.pl_detain_license.Size = new System.Drawing.Size(180, 137);
            this.pl_detain_license.TabIndex = 42;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::DVLD.Properties.Resources.license_detain;
            this.pictureBox8.Location = new System.Drawing.Point(20, 10);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(141, 68);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_DetainLicense_Clicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Detain License";
            this.label8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_DetainLicense_Clicked);
            // 
            // roundedPanel7
            // 
            this.roundedPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.roundedPanel7.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel7.BorderRadius = 20;
            this.roundedPanel7.BorderWidth = 1;
            this.roundedPanel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel7.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel7.Name = "roundedPanel7";
            this.roundedPanel7.Size = new System.Drawing.Size(180, 137);
            this.roundedPanel7.TabIndex = 3;
            this.roundedPanel7.Text = "roundedPanel1";
            this.roundedPanel7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_DetainLicense_Clicked);
            // 
            // pl_release_license
            // 
            this.pl_release_license.Controls.Add(this.pictureBox10);
            this.pl_release_license.Controls.Add(this.label10);
            this.pl_release_license.Controls.Add(this.roundedPanel9);
            this.pl_release_license.Location = new System.Drawing.Point(0, 197);
            this.pl_release_license.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.pl_release_license.Name = "pl_release_license";
            this.pl_release_license.Size = new System.Drawing.Size(180, 137);
            this.pl_release_license.TabIndex = 43;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::DVLD.Properties.Resources.license_release;
            this.pictureBox10.Location = new System.Drawing.Point(20, 10);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(141, 68);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_ReleaseLicense_Clicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Release License";
            this.label10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_ReleaseLicense_Clicked);
            // 
            // roundedPanel9
            // 
            this.roundedPanel9.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.roundedPanel9.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel9.BorderRadius = 20;
            this.roundedPanel9.BorderWidth = 1;
            this.roundedPanel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel9.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel9.Name = "roundedPanel9";
            this.roundedPanel9.Size = new System.Drawing.Size(180, 137);
            this.roundedPanel9.TabIndex = 6;
            this.roundedPanel9.Text = "roundedPanel2";
            this.roundedPanel9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_ReleaseLicense_Clicked);
            // 
            // pl_renew_expired_license
            // 
            this.pl_renew_expired_license.Controls.Add(this.pictureBox7);
            this.pl_renew_expired_license.Controls.Add(this.label7);
            this.pl_renew_expired_license.Controls.Add(this.roundedPanel6);
            this.pl_renew_expired_license.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pl_renew_expired_license.Location = new System.Drawing.Point(200, 197);
            this.pl_renew_expired_license.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.pl_renew_expired_license.Name = "pl_renew_expired_license";
            this.pl_renew_expired_license.Size = new System.Drawing.Size(180, 137);
            this.pl_renew_expired_license.TabIndex = 44;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::DVLD.Properties.Resources.renew_license;
            this.pictureBox7.Location = new System.Drawing.Point(20, 10);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(141, 68);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_RenewLicense_Clicked);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(15, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 44);
            this.label7.TabIndex = 23;
            this.label7.Text = "Renew Expired License";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_RenewLicense_Clicked);
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.BackColor = System.Drawing.Color.SkyBlue;
            this.roundedPanel6.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel6.BorderRadius = 20;
            this.roundedPanel6.BorderWidth = 1;
            this.roundedPanel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel6.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(180, 137);
            this.roundedPanel6.TabIndex = 22;
            this.roundedPanel6.Text = "roundedPanel6";
            this.roundedPanel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_RenewLicense_Clicked);
            // 
            // pl_replace_damaged_license
            // 
            this.pl_replace_damaged_license.Controls.Add(this.pictureBox12);
            this.pl_replace_damaged_license.Controls.Add(this.label12);
            this.pl_replace_damaged_license.Controls.Add(this.roundedPanel11);
            this.pl_replace_damaged_license.Location = new System.Drawing.Point(400, 197);
            this.pl_replace_damaged_license.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.pl_replace_damaged_license.Name = "pl_replace_damaged_license";
            this.pl_replace_damaged_license.Size = new System.Drawing.Size(180, 137);
            this.pl_replace_damaged_license.TabIndex = 45;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox12.Image = global::DVLD.Properties.Resources.damaged_license;
            this.pictureBox12.Location = new System.Drawing.Point(20, 10);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(141, 68);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 20;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_ReplaceDamagedLicense_Clicked);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.SlateGray;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Location = new System.Drawing.Point(9, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 44);
            this.label12.TabIndex = 19;
            this.label12.Text = "Replace Damaged License";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_ReplaceDamagedLicense_Clicked);
            // 
            // roundedPanel11
            // 
            this.roundedPanel11.BackColor = System.Drawing.Color.SlateGray;
            this.roundedPanel11.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel11.BorderRadius = 20;
            this.roundedPanel11.BorderWidth = 1;
            this.roundedPanel11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel11.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel11.Name = "roundedPanel11";
            this.roundedPanel11.Size = new System.Drawing.Size(180, 137);
            this.roundedPanel11.TabIndex = 18;
            this.roundedPanel11.Text = "roundedPanel11";
            this.roundedPanel11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_ReplaceDamagedLicense_Clicked);
            // 
            // pl_replace_lost_license
            // 
            this.pl_replace_lost_license.Controls.Add(this.pictureBox13);
            this.pl_replace_lost_license.Controls.Add(this.label13);
            this.pl_replace_lost_license.Controls.Add(this.roundedPanel12);
            this.pl_replace_lost_license.Location = new System.Drawing.Point(0, 374);
            this.pl_replace_lost_license.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.pl_replace_lost_license.Name = "pl_replace_lost_license";
            this.pl_replace_lost_license.Size = new System.Drawing.Size(180, 137);
            this.pl_replace_lost_license.TabIndex = 46;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox13.Image = global::DVLD.Properties.Resources.question_mark;
            this.pictureBox13.Location = new System.Drawing.Point(20, 10);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(141, 68);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 23;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_ReplaceLostLicense_Clicked);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.BlueViolet;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Location = new System.Drawing.Point(15, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 44);
            this.label13.TabIndex = 22;
            this.label13.Text = "Replace Lost License";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_ReplaceLostLicense_Clicked);
            // 
            // roundedPanel12
            // 
            this.roundedPanel12.BackColor = System.Drawing.Color.BlueViolet;
            this.roundedPanel12.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel12.BorderRadius = 20;
            this.roundedPanel12.BorderWidth = 1;
            this.roundedPanel12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel12.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel12.Name = "roundedPanel12";
            this.roundedPanel12.Size = new System.Drawing.Size(180, 137);
            this.roundedPanel12.TabIndex = 21;
            this.roundedPanel12.Text = "roundedPanel12";
            this.roundedPanel12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opt_ReplaceLostLicense_Clicked);
            // 
            // tab_add_new_local_license
            // 
            this.tab_add_new_local_license.BackColor = System.Drawing.SystemColors.Control;
            this.tab_add_new_local_license.Controls.Add(this.tlp_page1);
            this.tab_add_new_local_license.Location = new System.Drawing.Point(4, 28);
            this.tab_add_new_local_license.Name = "tab_add_new_local_license";
            this.tab_add_new_local_license.Padding = new System.Windows.Forms.Padding(80, 20, 80, 3);
            this.tab_add_new_local_license.Size = new System.Drawing.Size(949, 414);
            this.tab_add_new_local_license.TabIndex = 1;
            this.tab_add_new_local_license.Text = "Add Local License";
            // 
            // tlp_page1
            // 
            this.tlp_page1.ColumnCount = 3;
            this.tlp_page1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_page1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 677F));
            this.tlp_page1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_page1.Controls.Add(this.pl_page1_body, 1, 0);
            this.tlp_page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_page1.Location = new System.Drawing.Point(80, 20);
            this.tlp_page1.Name = "tlp_page1";
            this.tlp_page1.RowCount = 1;
            this.tlp_page1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_page1.Size = new System.Drawing.Size(789, 391);
            this.tlp_page1.TabIndex = 8;
            // 
            // pl_page1_body
            // 
            this.pl_page1_body.BackColor = System.Drawing.SystemColors.Control;
            this.pl_page1_body.Controls.Add(this.pl_main);
            this.pl_page1_body.Controls.Add(this.flp_page1_header);
            this.pl_page1_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_page1_body.Location = new System.Drawing.Point(59, 3);
            this.pl_page1_body.Name = "pl_page1_body";
            this.pl_page1_body.Size = new System.Drawing.Size(671, 385);
            this.pl_page1_body.TabIndex = 8;
            // 
            // pl_main
            // 
            this.pl_main.AutoScroll = true;
            this.pl_main.Controls.Add(this.pl_details);
            this.pl_main.Controls.Add(this.flp_page1_footer);
            this.pl_main.Controls.Add(this.flp_search_panel);
            this.pl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_main.Location = new System.Drawing.Point(0, 29);
            this.pl_main.Name = "pl_main";
            this.pl_main.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pl_main.Size = new System.Drawing.Size(671, 356);
            this.pl_main.TabIndex = 6;
            // 
            // pl_details
            // 
            this.pl_details.AutoScroll = true;
            this.pl_details.BackColor = System.Drawing.SystemColors.Control;
            this.pl_details.Controls.Add(this.personDetailsCard1);
            this.pl_details.Controls.Add(this.pl_local_license_application_details);
            this.pl_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_details.Location = new System.Drawing.Point(0, 75);
            this.pl_details.Name = "pl_details";
            this.pl_details.Size = new System.Drawing.Size(671, 231);
            this.pl_details.TabIndex = 46;
            // 
            // personDetailsCard1
            // 
            this.personDetailsCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.personDetailsCard1.Location = new System.Drawing.Point(0, 0);
            this.personDetailsCard1.Name = "personDetailsCard1";
            this.personDetailsCard1.Size = new System.Drawing.Size(671, 371);
            this.personDetailsCard1.TabIndex = 2;
            // 
            // pl_local_license_application_details
            // 
            this.pl_local_license_application_details.Controls.Add(this.label16);
            this.pl_local_license_application_details.Controls.Add(this.lb_created_by);
            this.pl_local_license_application_details.Controls.Add(this.comboBox2);
            this.pl_local_license_application_details.Controls.Add(this.label14);
            this.pl_local_license_application_details.Controls.Add(this.lb_application_fees);
            this.pl_local_license_application_details.Controls.Add(this.label4);
            this.pl_local_license_application_details.Controls.Add(this.lb_date_of_birth);
            this.pl_local_license_application_details.Controls.Add(this.label5);
            this.pl_local_license_application_details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_local_license_application_details.Location = new System.Drawing.Point(0, 371);
            this.pl_local_license_application_details.Name = "pl_local_license_application_details";
            this.pl_local_license_application_details.Size = new System.Drawing.Size(671, 105);
            this.pl_local_license_application_details.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(24, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 19);
            this.label16.TabIndex = 25;
            this.label16.Text = "License Class:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_created_by
            // 
            this.lb_created_by.AutoSize = true;
            this.lb_created_by.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_created_by.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_created_by.Location = new System.Drawing.Point(143, 64);
            this.lb_created_by.Name = "lb_created_by";
            this.lb_created_by.Size = new System.Drawing.Size(25, 19);
            this.lb_created_by.TabIndex = 24;
            this.lb_created_by.Text = "??";
            this.lb_created_by.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Person ID",
            "National No."});
            this.comboBox2.Location = new System.Drawing.Point(147, 17);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(190, 23);
            this.comboBox2.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(24, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 19);
            this.label14.TabIndex = 23;
            this.label14.Text = "Created By:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_application_fees
            // 
            this.lb_application_fees.AutoSize = true;
            this.lb_application_fees.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_application_fees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_application_fees.Location = new System.Drawing.Point(539, 21);
            this.lb_application_fees.Name = "lb_application_fees";
            this.lb_application_fees.Size = new System.Drawing.Size(25, 19);
            this.lb_application_fees.TabIndex = 22;
            this.lb_application_fees.Text = "??";
            this.lb_application_fees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(393, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Application Fees:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_date_of_birth
            // 
            this.lb_date_of_birth.AutoSize = true;
            this.lb_date_of_birth.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date_of_birth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_date_of_birth.Location = new System.Drawing.Point(539, 64);
            this.lb_date_of_birth.Name = "lb_date_of_birth";
            this.lb_date_of_birth.Size = new System.Drawing.Size(25, 19);
            this.lb_date_of_birth.TabIndex = 20;
            this.lb_date_of_birth.Text = "??";
            this.lb_date_of_birth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(393, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Application Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flp_page1_footer
            // 
            this.flp_page1_footer.BackColor = System.Drawing.SystemColors.Control;
            this.flp_page1_footer.Controls.Add(this.btn_save);
            this.flp_page1_footer.Controls.Add(this.btn_cancel);
            this.flp_page1_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_page1_footer.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp_page1_footer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flp_page1_footer.Location = new System.Drawing.Point(0, 306);
            this.flp_page1_footer.Name = "flp_page1_footer";
            this.flp_page1_footer.Padding = new System.Windows.Forms.Padding(10, 6, 0, 5);
            this.flp_page1_footer.Size = new System.Drawing.Size(671, 50);
            this.flp_page1_footer.TabIndex = 45;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_save.BorderColor = System.Drawing.Color.Gray;
            this.btn_save.BorderRadius = 20;
            this.btn_save.BorderSize = 2;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_save.Location = new System.Drawing.Point(543, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 30);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cancel.BorderColor = System.Drawing.Color.Gray;
            this.btn_cancel.BorderRadius = 20;
            this.btn_cancel.BorderSize = 2;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_cancel.Location = new System.Drawing.Point(422, 9);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 30);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // flp_search_panel
            // 
            this.flp_search_panel.Controls.Add(this.pb_add_person);
            this.flp_search_panel.Controls.Add(this.pb_search);
            this.flp_search_panel.Controls.Add(this.txt_search_word);
            this.flp_search_panel.Controls.Add(this.cb_filter);
            this.flp_search_panel.Controls.Add(this.lb_text);
            this.flp_search_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flp_search_panel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp_search_panel.Location = new System.Drawing.Point(0, 20);
            this.flp_search_panel.Name = "flp_search_panel";
            this.flp_search_panel.Size = new System.Drawing.Size(671, 55);
            this.flp_search_panel.TabIndex = 0;
            // 
            // pb_add_person
            // 
            this.pb_add_person.BackColor = System.Drawing.Color.White;
            this.pb_add_person.Image = global::DVLD.Properties.Resources.AddPerson;
            this.pb_add_person.Location = new System.Drawing.Point(638, 3);
            this.pb_add_person.Name = "pb_add_person";
            this.pb_add_person.Radius = 4;
            this.pb_add_person.Size = new System.Drawing.Size(30, 30);
            this.pb_add_person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_add_person.TabIndex = 5;
            this.pb_add_person.TabStop = false;
            this.pb_add_person.Click += new System.EventHandler(this.pb_add_person_Click);
            // 
            // pb_search
            // 
            this.pb_search.BackColor = System.Drawing.Color.White;
            this.pb_search.Image = global::DVLD.Properties.Resources.search;
            this.pb_search.Location = new System.Drawing.Point(600, 3);
            this.pb_search.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pb_search.Name = "pb_search";
            this.pb_search.Radius = 4;
            this.pb_search.Size = new System.Drawing.Size(30, 30);
            this.pb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_search.TabIndex = 6;
            this.pb_search.TabStop = false;
            // 
            // txt_search_word
            // 
            this.txt_search_word.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_word.Location = new System.Drawing.Point(384, 3);
            this.txt_search_word.MaxLength = 30;
            this.txt_search_word.Name = "txt_search_word";
            this.txt_search_word.Size = new System.Drawing.Size(208, 30);
            this.txt_search_word.TabIndex = 1;
            // 
            // cb_filter
            // 
            this.cb_filter.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filter.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "Person ID",
            "National No."});
            this.cb_filter.Location = new System.Drawing.Point(181, 3);
            this.cb_filter.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(190, 31);
            this.cb_filter.TabIndex = 0;
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_text.Location = new System.Drawing.Point(87, 10);
            this.lb_text.Margin = new System.Windows.Forms.Padding(3, 10, 6, 0);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(85, 19);
            this.lb_text.TabIndex = 2;
            this.lb_text.Text = "Search By:";
            // 
            // flp_page1_header
            // 
            this.flp_page1_header.Controls.Add(this.pb_page1_back);
            this.flp_page1_header.Controls.Add(this.lb_page1_title);
            this.flp_page1_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.flp_page1_header.Location = new System.Drawing.Point(0, 0);
            this.flp_page1_header.Name = "flp_page1_header";
            this.flp_page1_header.Size = new System.Drawing.Size(671, 29);
            this.flp_page1_header.TabIndex = 6;
            // 
            // pb_page1_back
            // 
            this.pb_page1_back.Image = global::DVLD.Properties.Resources.arrow;
            this.pb_page1_back.Location = new System.Drawing.Point(3, 0);
            this.pb_page1_back.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pb_page1_back.Name = "pb_page1_back";
            this.pb_page1_back.Size = new System.Drawing.Size(25, 25);
            this.pb_page1_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_page1_back.TabIndex = 2;
            this.pb_page1_back.TabStop = false;
            // 
            // lb_page1_title
            // 
            this.lb_page1_title.AutoSize = true;
            this.lb_page1_title.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_page1_title.ForeColor = System.Drawing.Color.Gray;
            this.lb_page1_title.Location = new System.Drawing.Point(34, 0);
            this.lb_page1_title.Name = "lb_page1_title";
            this.lb_page1_title.Size = new System.Drawing.Size(300, 25);
            this.lb_page1_title.TabIndex = 1;
            this.lb_page1_title.Text = "Add New Local License Application";
            this.lb_page1_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_add_new_inter_license
            // 
            this.tab_add_new_inter_license.BackColor = System.Drawing.SystemColors.Control;
            this.tab_add_new_inter_license.Controls.Add(this.checkBox1);
            this.tab_add_new_inter_license.Location = new System.Drawing.Point(4, 28);
            this.tab_add_new_inter_license.Name = "tab_add_new_inter_license";
            this.tab_add_new_inter_license.Size = new System.Drawing.Size(949, 414);
            this.tab_add_new_inter_license.TabIndex = 2;
            this.tab_add_new_inter_license.Text = "Add Inter License";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(336, 178);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tab_detain_license
            // 
            this.tab_detain_license.BackColor = System.Drawing.SystemColors.Control;
            this.tab_detain_license.Controls.Add(this.comboBox1);
            this.tab_detain_license.Location = new System.Drawing.Point(4, 28);
            this.tab_detain_license.Name = "tab_detain_license";
            this.tab_detain_license.Size = new System.Drawing.Size(949, 414);
            this.tab_detain_license.TabIndex = 3;
            this.tab_detain_license.Text = "Detain License";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tab_release_license
            // 
            this.tab_release_license.BackColor = System.Drawing.SystemColors.Control;
            this.tab_release_license.Controls.Add(this.label2);
            this.tab_release_license.Location = new System.Drawing.Point(4, 28);
            this.tab_release_license.Name = "tab_release_license";
            this.tab_release_license.Size = new System.Drawing.Size(949, 414);
            this.tab_release_license.TabIndex = 4;
            this.tab_release_license.Text = "Release License";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // tab_renew_license
            // 
            this.tab_renew_license.BackColor = System.Drawing.SystemColors.Control;
            this.tab_renew_license.Controls.Add(this.linkLabel1);
            this.tab_renew_license.Location = new System.Drawing.Point(4, 28);
            this.tab_renew_license.Name = "tab_renew_license";
            this.tab_renew_license.Size = new System.Drawing.Size(949, 414);
            this.tab_renew_license.TabIndex = 5;
            this.tab_renew_license.Text = "Renew License";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(302, 164);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // tab_replace_damaged_license
            // 
            this.tab_replace_damaged_license.BackColor = System.Drawing.SystemColors.Control;
            this.tab_replace_damaged_license.Controls.Add(this.progressBar1);
            this.tab_replace_damaged_license.Location = new System.Drawing.Point(4, 28);
            this.tab_replace_damaged_license.Name = "tab_replace_damaged_license";
            this.tab_replace_damaged_license.Size = new System.Drawing.Size(949, 414);
            this.tab_replace_damaged_license.TabIndex = 6;
            this.tab_replace_damaged_license.Text = "Replace Damaged License";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(274, 149);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(251, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // tab_replace_lost_license
            // 
            this.tab_replace_lost_license.BackColor = System.Drawing.SystemColors.Control;
            this.tab_replace_lost_license.Controls.Add(this.radioButton1);
            this.tab_replace_lost_license.Location = new System.Drawing.Point(4, 28);
            this.tab_replace_lost_license.Name = "tab_replace_lost_license";
            this.tab_replace_lost_license.Size = new System.Drawing.Size(949, 414);
            this.tab_replace_lost_license.TabIndex = 7;
            this.tab_replace_lost_license.Text = "Replace Lost License";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(288, 159);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tab_list
            // 
            this.tab_list.BackColor = System.Drawing.SystemColors.Control;
            this.tab_list.Controls.Add(this.dgv_international_licenses);
            this.tab_list.Controls.Add(this.searchBar2);
            this.tab_list.Controls.Add(this.flowLayoutPanel1);
            this.tab_list.Location = new System.Drawing.Point(4, 28);
            this.tab_list.Name = "tab_list";
            this.tab_list.Padding = new System.Windows.Forms.Padding(3);
            this.tab_list.Size = new System.Drawing.Size(963, 452);
            this.tab_list.TabIndex = 1;
            this.tab_list.Text = "Applications List";
            // 
            // dgv_international_licenses
            // 
            this.dgv_international_licenses.AllowUserToAddRows = false;
            this.dgv_international_licenses.AllowUserToDeleteRows = false;
            this.dgv_international_licenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_international_licenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_international_licenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_international_licenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_international_licenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.application_id,
            this.person_id,
            this.application_type,
            this.date,
            this.status,
            this.last_status_date,
            this.paid_fees,
            this.created_by_user_id});
            this.dgv_international_licenses.CornerRadius = 15;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_international_licenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_international_licenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_international_licenses.EnableHeadersVisualStyles = false;
            this.dgv_international_licenses.Location = new System.Drawing.Point(3, 53);
            this.dgv_international_licenses.Name = "dgv_international_licenses";
            this.dgv_international_licenses.ReadOnly = true;
            this.dgv_international_licenses.Size = new System.Drawing.Size(957, 346);
            this.dgv_international_licenses.TabIndex = 4;
            // 
            // application_id
            // 
            this.application_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.application_id.HeaderText = "Application ID";
            this.application_id.Name = "application_id";
            this.application_id.ReadOnly = true;
            // 
            // person_id
            // 
            this.person_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.person_id.HeaderText = "Person ID";
            this.person_id.Name = "person_id";
            this.person_id.ReadOnly = true;
            // 
            // application_type
            // 
            this.application_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.application_type.HeaderText = "Application Type";
            this.application_type.Name = "application_type";
            this.application_type.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // last_status_date
            // 
            this.last_status_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_status_date.HeaderText = "Last Status Date";
            this.last_status_date.Name = "last_status_date";
            this.last_status_date.ReadOnly = true;
            // 
            // paid_fees
            // 
            this.paid_fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paid_fees.HeaderText = "Paid Fees";
            this.paid_fees.Name = "paid_fees";
            this.paid_fees.ReadOnly = true;
            // 
            // created_by_user_id
            // 
            this.created_by_user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.created_by_user_id.HeaderText = "Create By User ID";
            this.created_by_user_id.Name = "created_by_user_id";
            this.created_by_user_id.ReadOnly = true;
            // 
            // searchBar2
            // 
            this.searchBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBar2.Location = new System.Drawing.Point(3, 3);
            this.searchBar2.Name = "searchBar2";
            this.searchBar2.Size = new System.Drawing.Size(957, 50);
            this.searchBar2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lb_footer_text_driver);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 399);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(957, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lb_footer_text_driver
            // 
            this.lb_footer_text_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_text_driver.Location = new System.Drawing.Point(3, 0);
            this.lb_footer_text_driver.Name = "lb_footer_text_driver";
            this.lb_footer_text_driver.Size = new System.Drawing.Size(624, 50);
            this.lb_footer_text_driver.TabIndex = 0;
            this.lb_footer_text_driver.Text = "Total Number of Applications:";
            this.lb_footer_text_driver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_types
            // 
            this.tab_types.BackColor = System.Drawing.SystemColors.Control;
            this.tab_types.Controls.Add(this.flowLayoutPanel2);
            this.tab_types.Controls.Add(this.roundedDataGridView1);
            this.tab_types.Location = new System.Drawing.Point(4, 28);
            this.tab_types.Name = "tab_types";
            this.tab_types.Size = new System.Drawing.Size(963, 452);
            this.tab_types.TabIndex = 2;
            this.tab_types.Text = "Applications Types";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 402);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(963, 50);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number of Applications Types:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedDataGridView1
            // 
            this.roundedDataGridView1.AllowUserToAddRows = false;
            this.roundedDataGridView1.AllowUserToDeleteRows = false;
            this.roundedDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.roundedDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roundedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.roundedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roundedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.fee});
            this.roundedDataGridView1.CornerRadius = 15;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roundedDataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.roundedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedDataGridView1.EnableHeadersVisualStyles = false;
            this.roundedDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.roundedDataGridView1.Name = "roundedDataGridView1";
            this.roundedDataGridView1.ReadOnly = true;
            this.roundedDataGridView1.Size = new System.Drawing.Size(963, 452);
            this.roundedDataGridView1.TabIndex = 5;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // fee
            // 
            this.fee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fee.HeaderText = "Fee";
            this.fee.Name = "fee";
            this.fee.ReadOnly = true;
            // 
            // tlp_header
            // 
            this.tlp_header.AutoSize = true;
            this.tlp_header.ColumnCount = 3;
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlp_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_header.Location = new System.Drawing.Point(7, 10);
            this.tlp_header.Name = "tlp_header";
            this.tlp_header.RowCount = 1;
            this.tlp_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_header.Size = new System.Drawing.Size(971, 0);
            this.tlp_header.TabIndex = 0;
            // 
            // window_operations
            // 
            this.window_operations.Location = new System.Drawing.Point(0, 0);
            this.window_operations.Name = "window_operations";
            this.window_operations.Size = new System.Drawing.Size(200, 100);
            this.window_operations.TabIndex = 0;
            // 
            // ApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 563);
            this.Controls.Add(this.pl_Body);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApplicationsForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Applications";
            this.Load += new System.EventHandler(this.ApplicationsForm_Load);
            this.pl_Body.ResumeLayout(false);
            this.pl_Body.PerformLayout();
            this.htc_tab_nav.ResumeLayout(false);
            this.tab_operations.ResumeLayout(false);
            this.htc_operations_management.ResumeLayout(false);
            this.tab_actions.ResumeLayout(false);
            this.layout.ResumeLayout(false);
            this.flp_container.ResumeLayout(false);
            this.pl_new_local_license.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.pl_new_inter_license.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.pl_detain_license.ResumeLayout(false);
            this.pl_detain_license.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.pl_release_license.ResumeLayout(false);
            this.pl_release_license.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.pl_renew_expired_license.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pl_replace_damaged_license.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.pl_replace_lost_license.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.tab_add_new_local_license.ResumeLayout(false);
            this.tlp_page1.ResumeLayout(false);
            this.pl_page1_body.ResumeLayout(false);
            this.pl_main.ResumeLayout(false);
            this.pl_details.ResumeLayout(false);
            this.pl_local_license_application_details.ResumeLayout(false);
            this.pl_local_license_application_details.PerformLayout();
            this.flp_page1_footer.ResumeLayout(false);
            this.flp_search_panel.ResumeLayout(false);
            this.flp_search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_person)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).EndInit();
            this.flp_page1_header.ResumeLayout(false);
            this.flp_page1_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_page1_back)).EndInit();
            this.tab_add_new_inter_license.ResumeLayout(false);
            this.tab_add_new_inter_license.PerformLayout();
            this.tab_detain_license.ResumeLayout(false);
            this.tab_release_license.ResumeLayout(false);
            this.tab_release_license.PerformLayout();
            this.tab_renew_license.ResumeLayout(false);
            this.tab_renew_license.PerformLayout();
            this.tab_replace_damaged_license.ResumeLayout(false);
            this.tab_replace_lost_license.ResumeLayout(false);
            this.tab_replace_lost_license.PerformLayout();
            this.tab_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_international_licenses)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tab_types.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel pl_Body;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private CustomControls.HeaderlessTabControl htc_tab_nav;
        private System.Windows.Forms.TabPage tab_operations;
        private System.Windows.Forms.TabPage tab_list;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_international_licenses;
        private UserControls.SearchBar searchBar2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_footer_text_driver;
        private System.Windows.Forms.TabPage tab_types;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView roundedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private CustomControls.HeaderlessTabControl htc_operations_management;
        private System.Windows.Forms.TabPage tab_actions;
        private System.Windows.Forms.TabPage tab_add_new_local_license;
        private System.Windows.Forms.TabPage tab_add_new_inter_license;
        private iNKORE.UI.WinForms.Styler.Controls.HeaderlessTabPage window_operations;
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.FlowLayoutPanel flp_container;
        private System.Windows.Forms.Panel pl_new_local_license;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label11;
        private WindowsFormsControlLibrary.CustomControls.RoundedPanel roundedPanel10;
        private System.Windows.Forms.Panel pl_new_inter_license;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label9;
        private WindowsFormsControlLibrary.CustomControls.RoundedPanel roundedPanel8;
        private System.Windows.Forms.Panel pl_detain_license;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label8;
        private WindowsFormsControlLibrary.CustomControls.RoundedPanel roundedPanel7;
        private System.Windows.Forms.Panel pl_release_license;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label10;
        private WindowsFormsControlLibrary.CustomControls.RoundedPanel roundedPanel9;
        private System.Windows.Forms.Panel pl_renew_expired_license;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label7;
        private WindowsFormsControlLibrary.CustomControls.RoundedPanel roundedPanel6;
        private System.Windows.Forms.Panel pl_replace_damaged_license;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label12;
        private WindowsFormsControlLibrary.CustomControls.RoundedPanel roundedPanel11;
        private System.Windows.Forms.Panel pl_replace_lost_license;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label label13;
        private WindowsFormsControlLibrary.CustomControls.RoundedPanel roundedPanel12;
        private System.Windows.Forms.TabPage tab_detain_license;
        private System.Windows.Forms.TabPage tab_release_license;
        private System.Windows.Forms.TabPage tab_renew_license;
        private System.Windows.Forms.TabPage tab_replace_damaged_license;
        private System.Windows.Forms.TabPage tab_replace_lost_license;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn application_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn person_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn application_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_status_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid_fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_by_user_id;
        private System.Windows.Forms.TableLayoutPanel tlp_page1;
        private System.Windows.Forms.Panel pl_page1_body;
        private System.Windows.Forms.Panel pl_main;
        private System.Windows.Forms.Panel pl_details;
        private UserControls.PersonDetailsCard personDetailsCard1;
        private System.Windows.Forms.Panel pl_local_license_application_details;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_created_by;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_application_fees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_date_of_birth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flp_page1_footer;
        private Views.Controls.RoundedButton btn_save;
        private Views.Controls.RoundedButton btn_cancel;
        private System.Windows.Forms.FlowLayoutPanel flp_search_panel;
        private System.Windows.Forms.TextBox txt_search_word;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.FlowLayoutPanel flp_page1_header;
        private System.Windows.Forms.PictureBox pb_page1_back;
        private System.Windows.Forms.Label lb_page1_title;
        private WindowsFormsControlLibrary.CustomControls.RoundedPictureBox pb_add_person;
        private WindowsFormsControlLibrary.CustomControls.RoundedPictureBox pb_search;
    }
}
