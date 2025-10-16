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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pl_Body = new System.Windows.Forms.Panel();
            this.htc_tab_nav = new DVLD.CustomControls.HeaderlessTabControl();
            this.tab_profile = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pl_user_profile = new System.Windows.Forms.Panel();
            this.txt_confirm_password = new System.Windows.Forms.TextBox();
            this.txt_confirm_new_password = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btn_change_password = new DVLD.Views.Controls.RoundedButton();
            this.btn_save_user = new DVLD.Views.Controls.RoundedButton();
            this.btn_discard_user = new DVLD.Views.Controls.RoundedButton();
            this.btn_save_person = new DVLD.Views.Controls.RoundedButton();
            this.btn_discard_person = new DVLD.Views.Controls.RoundedButton();
            this.txt_current_password = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.seperator3 = new iNKORE.UI.WinForms.Styler.Controls.Seperator();
            this.label19 = new System.Windows.Forms.Label();
            this.lb_is_active = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lb_edit_user_details = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_user_id = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.seperator2 = new iNKORE.UI.WinForms.Styler.Controls.Seperator();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_edit_person_details = new System.Windows.Forms.Label();
            this.seperator1 = new iNKORE.UI.WinForms.Styler.Controls.Seperator();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_remove_image = new System.Windows.Forms.Label();
            this.lb_max_length = new System.Windows.Forms.Label();
            this.rtb_address = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_date_of_birth = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_last_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_second_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_third_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_first_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_national_no = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_person_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_upload_image = new System.Windows.Forms.Label();
            this.rpb_profile_image = new WindowsFormsControlLibrary.CustomControls.RoundedPictureBox();
            this.tab_users_management = new System.Windows.Forms.TabPage();
            this.dgv_users = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_person_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uc_users_topbar = new DVLD.UserControls.SearchBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_text_users = new System.Windows.Forms.Label();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pl_Body.SuspendLayout();
            this.htc_tab_nav.SuspendLayout();
            this.tab_profile.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pl_user_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpb_profile_image)).BeginInit();
            this.tab_users_management.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.pl_Body.Size = new System.Drawing.Size(998, 502);
            this.pl_Body.TabIndex = 4;
            // 
            // htc_tab_nav
            // 
            this.htc_tab_nav.Controls.Add(this.tab_profile);
            this.htc_tab_nav.Controls.Add(this.tab_users_management);
            this.htc_tab_nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htc_tab_nav.ItemSize = new System.Drawing.Size(100, 24);
            this.htc_tab_nav.Location = new System.Drawing.Point(7, 10);
            this.htc_tab_nav.Name = "htc_tab_nav";
            this.htc_tab_nav.SelectedIndex = 0;
            this.htc_tab_nav.Size = new System.Drawing.Size(991, 492);
            this.htc_tab_nav.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.htc_tab_nav.TabIndex = 1;
            // 
            // tab_profile
            // 
            this.tab_profile.AutoScroll = true;
            this.tab_profile.BackColor = System.Drawing.SystemColors.Control;
            this.tab_profile.Controls.Add(this.tableLayoutPanel1);
            this.tab_profile.Location = new System.Drawing.Point(4, 28);
            this.tab_profile.Name = "tab_profile";
            this.tab_profile.Padding = new System.Windows.Forms.Padding(3);
            this.tab_profile.Size = new System.Drawing.Size(983, 460);
            this.tab_profile.TabIndex = 0;
            this.tab_profile.Text = "Profile";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 900F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pl_user_profile, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pl_user_profile
            // 
            this.pl_user_profile.AutoScroll = true;
            this.pl_user_profile.BackColor = System.Drawing.SystemColors.Control;
            this.pl_user_profile.Controls.Add(this.txt_confirm_password);
            this.pl_user_profile.Controls.Add(this.txt_confirm_new_password);
            this.pl_user_profile.Controls.Add(this.label25);
            this.pl_user_profile.Controls.Add(this.label24);
            this.pl_user_profile.Controls.Add(this.btn_change_password);
            this.pl_user_profile.Controls.Add(this.btn_save_user);
            this.pl_user_profile.Controls.Add(this.btn_discard_user);
            this.pl_user_profile.Controls.Add(this.btn_save_person);
            this.pl_user_profile.Controls.Add(this.btn_discard_person);
            this.pl_user_profile.Controls.Add(this.txt_current_password);
            this.pl_user_profile.Controls.Add(this.label23);
            this.pl_user_profile.Controls.Add(this.seperator3);
            this.pl_user_profile.Controls.Add(this.label19);
            this.pl_user_profile.Controls.Add(this.lb_is_active);
            this.pl_user_profile.Controls.Add(this.label22);
            this.pl_user_profile.Controls.Add(this.lb_edit_user_details);
            this.pl_user_profile.Controls.Add(this.txt_username);
            this.pl_user_profile.Controls.Add(this.label16);
            this.pl_user_profile.Controls.Add(this.lb_user_id);
            this.pl_user_profile.Controls.Add(this.label18);
            this.pl_user_profile.Controls.Add(this.seperator2);
            this.pl_user_profile.Controls.Add(this.label4);
            this.pl_user_profile.Controls.Add(this.label2);
            this.pl_user_profile.Controls.Add(this.lb_edit_person_details);
            this.pl_user_profile.Controls.Add(this.seperator1);
            this.pl_user_profile.Controls.Add(this.label1);
            this.pl_user_profile.Controls.Add(this.lb_remove_image);
            this.pl_user_profile.Controls.Add(this.lb_max_length);
            this.pl_user_profile.Controls.Add(this.rtb_address);
            this.pl_user_profile.Controls.Add(this.label14);
            this.pl_user_profile.Controls.Add(this.cb_country);
            this.pl_user_profile.Controls.Add(this.label15);
            this.pl_user_profile.Controls.Add(this.tb_phone);
            this.pl_user_profile.Controls.Add(this.label12);
            this.pl_user_profile.Controls.Add(this.tb_email);
            this.pl_user_profile.Controls.Add(this.label13);
            this.pl_user_profile.Controls.Add(this.cb_gender);
            this.pl_user_profile.Controls.Add(this.label11);
            this.pl_user_profile.Controls.Add(this.dtp_date_of_birth);
            this.pl_user_profile.Controls.Add(this.label10);
            this.pl_user_profile.Controls.Add(this.tb_last_name);
            this.pl_user_profile.Controls.Add(this.label9);
            this.pl_user_profile.Controls.Add(this.tb_second_name);
            this.pl_user_profile.Controls.Add(this.label8);
            this.pl_user_profile.Controls.Add(this.tb_third_name);
            this.pl_user_profile.Controls.Add(this.label7);
            this.pl_user_profile.Controls.Add(this.tb_first_name);
            this.pl_user_profile.Controls.Add(this.label6);
            this.pl_user_profile.Controls.Add(this.tb_national_no);
            this.pl_user_profile.Controls.Add(this.label5);
            this.pl_user_profile.Controls.Add(this.lb_person_id);
            this.pl_user_profile.Controls.Add(this.label3);
            this.pl_user_profile.Controls.Add(this.lb_upload_image);
            this.pl_user_profile.Controls.Add(this.rpb_profile_image);
            this.pl_user_profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_user_profile.Location = new System.Drawing.Point(41, 3);
            this.pl_user_profile.Name = "pl_user_profile";
            this.pl_user_profile.Size = new System.Drawing.Size(894, 448);
            this.pl_user_profile.TabIndex = 0;
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm_password.ForeColor = System.Drawing.Color.Gray;
            this.txt_confirm_password.Location = new System.Drawing.Point(370, 1136);
            this.txt_confirm_password.MaxLength = 20;
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.PasswordChar = '*';
            this.txt_confirm_password.Size = new System.Drawing.Size(236, 26);
            this.txt_confirm_password.TabIndex = 127;
            // 
            // txt_confirm_new_password
            // 
            this.txt_confirm_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm_new_password.ForeColor = System.Drawing.Color.Gray;
            this.txt_confirm_new_password.Location = new System.Drawing.Point(612, 1136);
            this.txt_confirm_new_password.MaxLength = 20;
            this.txt_confirm_new_password.Name = "txt_confirm_new_password";
            this.txt_confirm_new_password.PasswordChar = '*';
            this.txt_confirm_new_password.Size = new System.Drawing.Size(236, 26);
            this.txt_confirm_new_password.TabIndex = 126;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(609, 1102);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(172, 18);
            this.label25.TabIndex = 125;
            this.label25.Text = "Confirm New Password:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(367, 1102);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(114, 18);
            this.label24.TabIndex = 123;
            this.label24.Text = "New Password:";
            // 
            // btn_change_password
            // 
            this.btn_change_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_change_password.BorderColor = System.Drawing.Color.Gray;
            this.btn_change_password.BorderRadius = 20;
            this.btn_change_password.BorderSize = 2;
            this.btn_change_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_change_password.FlatAppearance.BorderSize = 0;
            this.btn_change_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_change_password.Location = new System.Drawing.Point(680, 1189);
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.Size = new System.Drawing.Size(168, 30);
            this.btn_change_password.TabIndex = 121;
            this.btn_change_password.Text = "Change Password";
            this.btn_change_password.UseVisualStyleBackColor = false;
            this.btn_change_password.Visible = false;
            // 
            // btn_save_user
            // 
            this.btn_save_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_save_user.BorderColor = System.Drawing.Color.Gray;
            this.btn_save_user.BorderRadius = 20;
            this.btn_save_user.BorderSize = 2;
            this.btn_save_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_user.FlatAppearance.BorderSize = 0;
            this.btn_save_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_user.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_save_user.Location = new System.Drawing.Point(733, 979);
            this.btn_save_user.Name = "btn_save_user";
            this.btn_save_user.Size = new System.Drawing.Size(115, 30);
            this.btn_save_user.TabIndex = 119;
            this.btn_save_user.Text = "Save";
            this.btn_save_user.UseVisualStyleBackColor = false;
            this.btn_save_user.Visible = false;
            // 
            // btn_discard_user
            // 
            this.btn_discard_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_discard_user.BorderColor = System.Drawing.Color.Gray;
            this.btn_discard_user.BorderRadius = 20;
            this.btn_discard_user.BorderSize = 2;
            this.btn_discard_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_discard_user.FlatAppearance.BorderSize = 0;
            this.btn_discard_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_discard_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_discard_user.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_discard_user.Location = new System.Drawing.Point(612, 979);
            this.btn_discard_user.Name = "btn_discard_user";
            this.btn_discard_user.Size = new System.Drawing.Size(115, 30);
            this.btn_discard_user.TabIndex = 120;
            this.btn_discard_user.Text = "Discard";
            this.btn_discard_user.UseVisualStyleBackColor = false;
            this.btn_discard_user.Visible = false;
            // 
            // btn_save_person
            // 
            this.btn_save_person.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_save_person.BorderColor = System.Drawing.Color.Gray;
            this.btn_save_person.BorderRadius = 20;
            this.btn_save_person.BorderSize = 2;
            this.btn_save_person.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_person.FlatAppearance.BorderSize = 0;
            this.btn_save_person.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_person.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_save_person.Location = new System.Drawing.Point(733, 725);
            this.btn_save_person.Name = "btn_save_person";
            this.btn_save_person.Size = new System.Drawing.Size(115, 30);
            this.btn_save_person.TabIndex = 117;
            this.btn_save_person.Text = "Save";
            this.btn_save_person.UseVisualStyleBackColor = false;
            this.btn_save_person.Visible = false;
            // 
            // btn_discard_person
            // 
            this.btn_discard_person.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_discard_person.BorderColor = System.Drawing.Color.Gray;
            this.btn_discard_person.BorderRadius = 20;
            this.btn_discard_person.BorderSize = 2;
            this.btn_discard_person.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_discard_person.FlatAppearance.BorderSize = 0;
            this.btn_discard_person.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_discard_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_discard_person.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_discard_person.Location = new System.Drawing.Point(612, 725);
            this.btn_discard_person.Name = "btn_discard_person";
            this.btn_discard_person.Size = new System.Drawing.Size(115, 30);
            this.btn_discard_person.TabIndex = 118;
            this.btn_discard_person.Text = "Discard";
            this.btn_discard_person.UseVisualStyleBackColor = false;
            this.btn_discard_person.Visible = false;
            // 
            // txt_current_password
            // 
            this.txt_current_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_current_password.ForeColor = System.Drawing.Color.Gray;
            this.txt_current_password.Location = new System.Drawing.Point(42, 1136);
            this.txt_current_password.MaxLength = 20;
            this.txt_current_password.Name = "txt_current_password";
            this.txt_current_password.PasswordChar = '*';
            this.txt_current_password.Size = new System.Drawing.Size(284, 26);
            this.txt_current_password.TabIndex = 116;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(39, 1102);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 18);
            this.label23.TabIndex = 115;
            this.label23.Text = "Current Password:";
            // 
            // seperator3
            // 
            this.seperator3.Location = new System.Drawing.Point(38, 1078);
            this.seperator3.Name = "seperator3";
            this.seperator3.Size = new System.Drawing.Size(810, 2);
            this.seperator3.TabIndex = 114;
            this.seperator3.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Roboto Lt", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(38, 1048);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(180, 23);
            this.label19.TabIndex = 113;
            this.label19.Text = "Change Password";
            // 
            // lb_is_active
            // 
            this.lb_is_active.AutoSize = true;
            this.lb_is_active.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_is_active.ForeColor = System.Drawing.Color.Gray;
            this.lb_is_active.Location = new System.Drawing.Point(533, 855);
            this.lb_is_active.Name = "lb_is_active";
            this.lb_is_active.Size = new System.Drawing.Size(34, 18);
            this.lb_is_active.TabIndex = 112;
            this.lb_is_active.Text = "N/A";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(440, 855);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 18);
            this.label22.TabIndex = 111;
            this.label22.Text = "Is Active: ";
            // 
            // lb_edit_user_details
            // 
            this.lb_edit_user_details.AutoSize = true;
            this.lb_edit_user_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_edit_user_details.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_edit_user_details.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_edit_user_details.Location = new System.Drawing.Point(746, 809);
            this.lb_edit_user_details.Name = "lb_edit_user_details";
            this.lb_edit_user_details.Size = new System.Drawing.Size(102, 15);
            this.lb_edit_user_details.TabIndex = 110;
            this.lb_edit_user_details.Text = "Edit User Details";
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Gray;
            this.txt_username.Location = new System.Drawing.Point(42, 928);
            this.txt_username.MaxLength = 20;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(284, 26);
            this.txt_username.TabIndex = 107;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(39, 894);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 18);
            this.label16.TabIndex = 106;
            this.label16.Text = "Username:";
            // 
            // lb_user_id
            // 
            this.lb_user_id.AutoSize = true;
            this.lb_user_id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user_id.ForeColor = System.Drawing.Color.Gray;
            this.lb_user_id.Location = new System.Drawing.Point(132, 855);
            this.lb_user_id.Name = "lb_user_id";
            this.lb_user_id.Size = new System.Drawing.Size(34, 18);
            this.lb_user_id.TabIndex = 105;
            this.lb_user_id.Text = "N/A";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(39, 855);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 18);
            this.label18.TabIndex = 104;
            this.label18.Text = "User ID: ";
            // 
            // seperator2
            // 
            this.seperator2.Location = new System.Drawing.Point(38, 833);
            this.seperator2.Name = "seperator2";
            this.seperator2.Size = new System.Drawing.Size(810, 2);
            this.seperator2.TabIndex = 103;
            this.seperator2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Lt", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 803);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 23);
            this.label4.TabIndex = 102;
            this.label4.Text = "User Infromation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(399, 1217);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.label2.Size = new System.Drawing.Size(0, 43);
            this.label2.TabIndex = 101;
            // 
            // lb_edit_person_details
            // 
            this.lb_edit_person_details.AutoSize = true;
            this.lb_edit_person_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_edit_person_details.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_edit_person_details.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_edit_person_details.Location = new System.Drawing.Point(727, 26);
            this.lb_edit_person_details.Name = "lb_edit_person_details";
            this.lb_edit_person_details.Size = new System.Drawing.Size(115, 15);
            this.lb_edit_person_details.TabIndex = 100;
            this.lb_edit_person_details.Text = "Edit Person Details";
            // 
            // seperator1
            // 
            this.seperator1.Location = new System.Drawing.Point(32, 50);
            this.seperator1.Name = "seperator1";
            this.seperator1.Size = new System.Drawing.Size(810, 2);
            this.seperator1.TabIndex = 99;
            this.seperator1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 98;
            this.label1.Text = "Person Details";
            // 
            // lb_remove_image
            // 
            this.lb_remove_image.AutoSize = true;
            this.lb_remove_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_remove_image.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_remove_image.ForeColor = System.Drawing.Color.MediumPurple;
            this.lb_remove_image.Location = new System.Drawing.Point(66, 261);
            this.lb_remove_image.Name = "lb_remove_image";
            this.lb_remove_image.Size = new System.Drawing.Size(86, 14);
            this.lb_remove_image.TabIndex = 97;
            this.lb_remove_image.Text = "Remove Image";
            this.lb_remove_image.Visible = false;
            // 
            // lb_max_length
            // 
            this.lb_max_length.AutoSize = true;
            this.lb_max_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_max_length.ForeColor = System.Drawing.Color.Gray;
            this.lb_max_length.Location = new System.Drawing.Point(790, 679);
            this.lb_max_length.Name = "lb_max_length";
            this.lb_max_length.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.lb_max_length.Size = new System.Drawing.Size(58, 43);
            this.lb_max_length.TabIndex = 96;
            this.lb_max_length.Text = "max. 255";
            // 
            // rtb_address
            // 
            this.rtb_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtb_address.Enabled = false;
            this.rtb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_address.ForeColor = System.Drawing.Color.Gray;
            this.rtb_address.Location = new System.Drawing.Point(258, 601);
            this.rtb_address.MaxLength = 255;
            this.rtb_address.Name = "rtb_address";
            this.rtb_address.Size = new System.Drawing.Size(590, 75);
            this.rtb_address.TabIndex = 95;
            this.rtb_address.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(255, 567);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 18);
            this.label14.TabIndex = 94;
            this.label14.Text = "Address";
            // 
            // cb_country
            // 
            this.cb_country.Enabled = false;
            this.cb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_country.ForeColor = System.Drawing.Color.Gray;
            this.cb_country.FormattingEnabled = true;
            this.cb_country.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_country.Location = new System.Drawing.Point(258, 523);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(284, 28);
            this.cb_country.TabIndex = 93;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(255, 489);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 18);
            this.label15.TabIndex = 92;
            this.label15.Text = "Country";
            // 
            // tb_phone
            // 
            this.tb_phone.Enabled = false;
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.ForeColor = System.Drawing.Color.Gray;
            this.tb_phone.Location = new System.Drawing.Point(564, 447);
            this.tb_phone.MaxLength = 20;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(284, 26);
            this.tb_phone.TabIndex = 91;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(561, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 90;
            this.label12.Text = "Phone";
            // 
            // tb_email
            // 
            this.tb_email.Enabled = false;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.Color.Gray;
            this.tb_email.Location = new System.Drawing.Point(258, 447);
            this.tb_email.MaxLength = 50;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(284, 26);
            this.tb_email.TabIndex = 89;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(255, 413);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 18);
            this.label13.TabIndex = 88;
            this.label13.Text = "Email";
            // 
            // cb_gender
            // 
            this.cb_gender.Enabled = false;
            this.cb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.ForeColor = System.Drawing.Color.Gray;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(564, 369);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(284, 28);
            this.cb_gender.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(561, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 86;
            this.label11.Text = "Gender";
            // 
            // dtp_date_of_birth
            // 
            this.dtp_date_of_birth.CalendarForeColor = System.Drawing.Color.Gray;
            this.dtp_date_of_birth.CustomFormat = "yyyy/MM/dd";
            this.dtp_date_of_birth.Enabled = false;
            this.dtp_date_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date_of_birth.Location = new System.Drawing.Point(258, 371);
            this.dtp_date_of_birth.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtp_date_of_birth.Name = "dtp_date_of_birth";
            this.dtp_date_of_birth.Size = new System.Drawing.Size(284, 26);
            this.dtp_date_of_birth.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(255, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 18);
            this.label10.TabIndex = 84;
            this.label10.Text = "Date of Birth";
            // 
            // tb_last_name
            // 
            this.tb_last_name.Enabled = false;
            this.tb_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_last_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_last_name.Location = new System.Drawing.Point(564, 295);
            this.tb_last_name.MaxLength = 20;
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(284, 26);
            this.tb_last_name.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(561, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 82;
            this.label9.Text = "Last Name";
            // 
            // tb_second_name
            // 
            this.tb_second_name.Enabled = false;
            this.tb_second_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_second_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_second_name.Location = new System.Drawing.Point(564, 219);
            this.tb_second_name.MaxLength = 20;
            this.tb_second_name.Name = "tb_second_name";
            this.tb_second_name.Size = new System.Drawing.Size(284, 26);
            this.tb_second_name.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(561, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 80;
            this.label8.Text = "Second Name";
            // 
            // tb_third_name
            // 
            this.tb_third_name.Enabled = false;
            this.tb_third_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_third_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_third_name.Location = new System.Drawing.Point(258, 295);
            this.tb_third_name.MaxLength = 20;
            this.tb_third_name.Name = "tb_third_name";
            this.tb_third_name.Size = new System.Drawing.Size(284, 26);
            this.tb_third_name.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(255, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 78;
            this.label7.Text = "Third Name";
            // 
            // tb_first_name
            // 
            this.tb_first_name.Enabled = false;
            this.tb_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_first_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_first_name.Location = new System.Drawing.Point(258, 219);
            this.tb_first_name.MaxLength = 20;
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(284, 26);
            this.tb_first_name.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(255, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 76;
            this.label6.Text = "First Name";
            // 
            // tb_national_no
            // 
            this.tb_national_no.Enabled = false;
            this.tb_national_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_national_no.ForeColor = System.Drawing.Color.Gray;
            this.tb_national_no.Location = new System.Drawing.Point(258, 143);
            this.tb_national_no.MaxLength = 20;
            this.tb_national_no.Name = "tb_national_no";
            this.tb_national_no.Size = new System.Drawing.Size(284, 26);
            this.tb_national_no.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(255, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "National Number:";
            // 
            // lb_person_id
            // 
            this.lb_person_id.AutoSize = true;
            this.lb_person_id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_person_id.ForeColor = System.Drawing.Color.Gray;
            this.lb_person_id.Location = new System.Drawing.Point(348, 70);
            this.lb_person_id.Name = "lb_person_id";
            this.lb_person_id.Size = new System.Drawing.Size(34, 18);
            this.lb_person_id.TabIndex = 73;
            this.lb_person_id.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(255, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "Person ID: ";
            // 
            // lb_upload_image
            // 
            this.lb_upload_image.AutoSize = true;
            this.lb_upload_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_upload_image.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_upload_image.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_upload_image.Location = new System.Drawing.Point(58, 235);
            this.lb_upload_image.Name = "lb_upload_image";
            this.lb_upload_image.Size = new System.Drawing.Size(103, 18);
            this.lb_upload_image.TabIndex = 71;
            this.lb_upload_image.Text = "Upload Image";
            this.lb_upload_image.Visible = false;
            // 
            // rpb_profile_image
            // 
            this.rpb_profile_image.BackColor = System.Drawing.Color.Transparent;
            this.rpb_profile_image.Location = new System.Drawing.Point(32, 70);
            this.rpb_profile_image.Name = "rpb_profile_image";
            this.rpb_profile_image.Radius = 30;
            this.rpb_profile_image.Size = new System.Drawing.Size(150, 150);
            this.rpb_profile_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rpb_profile_image.TabIndex = 70;
            this.rpb_profile_image.TabStop = false;
            // 
            // tab_users_management
            // 
            this.tab_users_management.BackColor = System.Drawing.SystemColors.Control;
            this.tab_users_management.Controls.Add(this.dgv_users);
            this.tab_users_management.Controls.Add(this.uc_users_topbar);
            this.tab_users_management.Controls.Add(this.flowLayoutPanel1);
            this.tab_users_management.Location = new System.Drawing.Point(4, 28);
            this.tab_users_management.Name = "tab_users_management";
            this.tab_users_management.Padding = new System.Windows.Forms.Padding(3);
            this.tab_users_management.Size = new System.Drawing.Size(983, 460);
            this.tab_users_management.TabIndex = 1;
            this.tab_users_management.Text = "Users Management";
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.driver_person_id,
            this.fullname,
            this.username,
            this.is_active});
            this.dgv_users.CornerRadius = 15;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_users.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_users.EnableHeadersVisualStyles = false;
            this.dgv_users.Location = new System.Drawing.Point(3, 53);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.Size = new System.Drawing.Size(977, 354);
            this.dgv_users.TabIndex = 4;
            // 
            // user_id
            // 
            this.user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_id.HeaderText = "User ID";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // driver_person_id
            // 
            this.driver_person_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.driver_person_id.HeaderText = "Person ID";
            this.driver_person_id.Name = "driver_person_id";
            this.driver_person_id.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullname.HeaderText = "Full Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // is_active
            // 
            this.is_active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.is_active.HeaderText = "Is Active";
            this.is_active.Name = "is_active";
            this.is_active.ReadOnly = true;
            // 
            // uc_users_topbar
            // 
            this.uc_users_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_users_topbar.Location = new System.Drawing.Point(3, 3);
            this.uc_users_topbar.Name = "uc_users_topbar";
            this.uc_users_topbar.Size = new System.Drawing.Size(977, 50);
            this.uc_users_topbar.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lb_footer_text_users);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 407);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(977, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lb_footer_text_users
            // 
            this.lb_footer_text_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_text_users.Location = new System.Drawing.Point(3, 0);
            this.lb_footer_text_users.Name = "lb_footer_text_users";
            this.lb_footer_text_users.Size = new System.Drawing.Size(624, 50);
            this.lb_footer_text_users.TabIndex = 0;
            this.lb_footer_text_users.Text = "Total Number of Users: ";
            this.lb_footer_text_users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tlp_header.Size = new System.Drawing.Size(991, 0);
            this.tlp_header.TabIndex = 0;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(20, 20);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(111, 29);
            this.lb_Title.TabIndex = 3;
            this.lb_Title.Text = "Settings";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1038, 571);
            this.Controls.Add(this.pl_Body);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.pl_Body.ResumeLayout(false);
            this.pl_Body.PerformLayout();
            this.htc_tab_nav.ResumeLayout(false);
            this.tab_profile.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pl_user_profile.ResumeLayout(false);
            this.pl_user_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpb_profile_image)).EndInit();
            this.tab_users_management.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_Body;
        private CustomControls.HeaderlessTabControl htc_tab_nav;
        private System.Windows.Forms.TabPage tab_profile;
        private System.Windows.Forms.TabPage tab_users_management;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_users;
        private UserControls.SearchBar uc_users_topbar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_footer_text_users;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pl_user_profile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_edit_person_details;
        private iNKORE.UI.WinForms.Styler.Controls.Seperator seperator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_remove_image;
        private System.Windows.Forms.Label lb_max_length;
        private System.Windows.Forms.RichTextBox rtb_address;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_date_of_birth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_last_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_second_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_third_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_first_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_national_no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_person_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_upload_image;
        private WindowsFormsControlLibrary.CustomControls.RoundedPictureBox rpb_profile_image;
        private System.Windows.Forms.Label lb_edit_user_details;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_user_id;
        private System.Windows.Forms.Label label18;
        private iNKORE.UI.WinForms.Styler.Controls.Seperator seperator2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_current_password;
        private System.Windows.Forms.Label label23;
        private iNKORE.UI.WinForms.Styler.Controls.Seperator seperator3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lb_is_active;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private Views.Controls.RoundedButton btn_change_password;
        private Views.Controls.RoundedButton btn_save_user;
        private Views.Controls.RoundedButton btn_discard_user;
        private Views.Controls.RoundedButton btn_save_person;
        private Views.Controls.RoundedButton btn_discard_person;
        private System.Windows.Forms.TextBox txt_confirm_password;
        private System.Windows.Forms.TextBox txt_confirm_new_password;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_person_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_active;
    }
}