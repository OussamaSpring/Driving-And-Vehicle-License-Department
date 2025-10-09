namespace DVLD.Pop_Ups
{
    partial class Add_Edit_Person
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Edit_Person));
            this.lb_title = new System.Windows.Forms.Label();
            this.pl_header = new System.Windows.Forms.Panel();
            this.lb_exit = new System.Windows.Forms.Label();
            this.pl_main = new System.Windows.Forms.Panel();
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
            this.flp_actions = new System.Windows.Forms.FlowLayoutPanel();
            this.err_input_validation = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofd_upload_image = new System.Windows.Forms.OpenFileDialog();
            this.img_list_default_profile = new System.Windows.Forms.ImageList(this.components);
            this.rpb_profile_image = new WindowsFormsControlLibrary.CustomControls.RoundedPictureBox();
            this.btn_save = new DVLD.Views.Controls.RoundedButton();
            this.btn_cancel = new DVLD.Views.Controls.RoundedButton();
            this.pl_header.SuspendLayout();
            this.pl_main.SuspendLayout();
            this.flp_actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_input_validation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpb_profile_image)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Roboto Lt", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(33, 26);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(255, 35);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Add / Edit Person";
            // 
            // pl_header
            // 
            this.pl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.pl_header.Controls.Add(this.lb_exit);
            this.pl_header.Controls.Add(this.lb_title);
            this.pl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_header.Location = new System.Drawing.Point(2, 2);
            this.pl_header.Name = "pl_header";
            this.pl_header.Size = new System.Drawing.Size(896, 85);
            this.pl_header.TabIndex = 26;
            this.pl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_header_MouseDown);
            this.pl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pl_header_MouseMove);
            this.pl_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pl_header_MouseUp);
            // 
            // lb_exit
            // 
            this.lb_exit.AutoSize = true;
            this.lb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_exit.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exit.ForeColor = System.Drawing.Color.White;
            this.lb_exit.Location = new System.Drawing.Point(830, 15);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(51, 58);
            this.lb_exit.TabIndex = 1;
            this.lb_exit.Text = "×";
            this.lb_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Exit_Clicked);
            // 
            // pl_main
            // 
            this.pl_main.AutoScroll = true;
            this.pl_main.BackColor = System.Drawing.SystemColors.Control;
            this.pl_main.Controls.Add(this.lb_remove_image);
            this.pl_main.Controls.Add(this.lb_max_length);
            this.pl_main.Controls.Add(this.rtb_address);
            this.pl_main.Controls.Add(this.label14);
            this.pl_main.Controls.Add(this.cb_country);
            this.pl_main.Controls.Add(this.label15);
            this.pl_main.Controls.Add(this.tb_phone);
            this.pl_main.Controls.Add(this.label12);
            this.pl_main.Controls.Add(this.tb_email);
            this.pl_main.Controls.Add(this.label13);
            this.pl_main.Controls.Add(this.cb_gender);
            this.pl_main.Controls.Add(this.label11);
            this.pl_main.Controls.Add(this.dtp_date_of_birth);
            this.pl_main.Controls.Add(this.label10);
            this.pl_main.Controls.Add(this.tb_last_name);
            this.pl_main.Controls.Add(this.label9);
            this.pl_main.Controls.Add(this.tb_second_name);
            this.pl_main.Controls.Add(this.label8);
            this.pl_main.Controls.Add(this.tb_third_name);
            this.pl_main.Controls.Add(this.label7);
            this.pl_main.Controls.Add(this.tb_first_name);
            this.pl_main.Controls.Add(this.label6);
            this.pl_main.Controls.Add(this.tb_national_no);
            this.pl_main.Controls.Add(this.label5);
            this.pl_main.Controls.Add(this.lb_person_id);
            this.pl_main.Controls.Add(this.label3);
            this.pl_main.Controls.Add(this.lb_upload_image);
            this.pl_main.Controls.Add(this.rpb_profile_image);
            this.pl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_main.Location = new System.Drawing.Point(2, 87);
            this.pl_main.Name = "pl_main";
            this.pl_main.Size = new System.Drawing.Size(896, 446);
            this.pl_main.TabIndex = 43;
            // 
            // lb_remove_image
            // 
            this.lb_remove_image.AutoSize = true;
            this.lb_remove_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_remove_image.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_remove_image.ForeColor = System.Drawing.Color.MediumPurple;
            this.lb_remove_image.Location = new System.Drawing.Point(64, 225);
            this.lb_remove_image.Name = "lb_remove_image";
            this.lb_remove_image.Size = new System.Drawing.Size(86, 14);
            this.lb_remove_image.TabIndex = 69;
            this.lb_remove_image.Text = "Remove Image";
            this.lb_remove_image.Click += new System.EventHandler(this.lb_remove_image_Click);
            // 
            // lb_max_length
            // 
            this.lb_max_length.AutoSize = true;
            this.lb_max_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_max_length.ForeColor = System.Drawing.Color.Gray;
            this.lb_max_length.Location = new System.Drawing.Point(786, 647);
            this.lb_max_length.Name = "lb_max_length";
            this.lb_max_length.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.lb_max_length.Size = new System.Drawing.Size(58, 43);
            this.lb_max_length.TabIndex = 68;
            this.lb_max_length.Text = "max. 255";
            // 
            // rtb_address
            // 
            this.rtb_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_address.ForeColor = System.Drawing.Color.Gray;
            this.rtb_address.Location = new System.Drawing.Point(256, 565);
            this.rtb_address.MaxLength = 255;
            this.rtb_address.Name = "rtb_address";
            this.rtb_address.Size = new System.Drawing.Size(590, 75);
            this.rtb_address.TabIndex = 67;
            this.rtb_address.Text = "";
            this.rtb_address.TextChanged += new System.EventHandler(this.txt_input_fields_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(253, 531);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 18);
            this.label14.TabIndex = 66;
            this.label14.Text = "Address";
            // 
            // cb_country
            // 
            this.cb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_country.ForeColor = System.Drawing.Color.Gray;
            this.cb_country.FormattingEnabled = true;
            this.cb_country.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_country.Location = new System.Drawing.Point(256, 487);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(284, 28);
            this.cb_country.TabIndex = 65;
            this.cb_country.SelectedIndexChanged += new System.EventHandler(this.cb_gender_country_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(253, 453);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 18);
            this.label15.TabIndex = 64;
            this.label15.Text = "Country";
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.ForeColor = System.Drawing.Color.Gray;
            this.tb_phone.Location = new System.Drawing.Point(562, 411);
            this.tb_phone.MaxLength = 20;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(284, 26);
            this.tb_phone.TabIndex = 63;
            this.tb_phone.TextChanged += new System.EventHandler(this.txt_input_fields_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(559, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 62;
            this.label12.Text = "Phone";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.Color.Gray;
            this.tb_email.Location = new System.Drawing.Point(256, 411);
            this.tb_email.MaxLength = 50;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(284, 26);
            this.tb_email.TabIndex = 61;
            this.tb_email.TextChanged += new System.EventHandler(this.txt_input_fields_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(253, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 18);
            this.label13.TabIndex = 60;
            this.label13.Text = "Email";
            // 
            // cb_gender
            // 
            this.cb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.ForeColor = System.Drawing.Color.Gray;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(562, 333);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(284, 28);
            this.cb_gender.TabIndex = 59;
            this.cb_gender.SelectedIndexChanged += new System.EventHandler(this.cb_gender_country_SelectedIndexChanged);
            this.cb_gender.SelectionChangeCommitted += new System.EventHandler(this.cb_gender_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(559, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 58;
            this.label11.Text = "Gender";
            // 
            // dtp_date_of_birth
            // 
            this.dtp_date_of_birth.CalendarForeColor = System.Drawing.Color.Gray;
            this.dtp_date_of_birth.CustomFormat = "yyyy/MM/dd";
            this.dtp_date_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date_of_birth.Location = new System.Drawing.Point(256, 335);
            this.dtp_date_of_birth.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtp_date_of_birth.Name = "dtp_date_of_birth";
            this.dtp_date_of_birth.Size = new System.Drawing.Size(284, 26);
            this.dtp_date_of_birth.TabIndex = 57;
            this.dtp_date_of_birth.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(253, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 18);
            this.label10.TabIndex = 56;
            this.label10.Text = "Date of Birth";
            // 
            // tb_last_name
            // 
            this.tb_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_last_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_last_name.Location = new System.Drawing.Point(562, 259);
            this.tb_last_name.MaxLength = 20;
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(284, 26);
            this.tb_last_name.TabIndex = 55;
            this.tb_last_name.TextChanged += new System.EventHandler(this.txt_input_fields_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(559, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 54;
            this.label9.Text = "Last Name";
            // 
            // tb_second_name
            // 
            this.tb_second_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_second_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_second_name.Location = new System.Drawing.Point(562, 183);
            this.tb_second_name.MaxLength = 20;
            this.tb_second_name.Name = "tb_second_name";
            this.tb_second_name.Size = new System.Drawing.Size(284, 26);
            this.tb_second_name.TabIndex = 53;
            this.tb_second_name.TextChanged += new System.EventHandler(this.txt_input_fields_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(559, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 52;
            this.label8.Text = "Second Name";
            // 
            // tb_third_name
            // 
            this.tb_third_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_third_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_third_name.Location = new System.Drawing.Point(256, 259);
            this.tb_third_name.MaxLength = 20;
            this.tb_third_name.Name = "tb_third_name";
            this.tb_third_name.Size = new System.Drawing.Size(284, 26);
            this.tb_third_name.TabIndex = 51;
            this.tb_third_name.TextChanged += new System.EventHandler(this.txt_input_fields_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(253, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Third Name";
            // 
            // tb_first_name
            // 
            this.tb_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_first_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_first_name.Location = new System.Drawing.Point(256, 183);
            this.tb_first_name.MaxLength = 20;
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(284, 26);
            this.tb_first_name.TabIndex = 49;
            this.tb_first_name.TextChanged += new System.EventHandler(this.txt_input_fields_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(253, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "First Name";
            // 
            // tb_national_no
            // 
            this.tb_national_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_national_no.ForeColor = System.Drawing.Color.Gray;
            this.tb_national_no.Location = new System.Drawing.Point(256, 107);
            this.tb_national_no.MaxLength = 20;
            this.tb_national_no.Name = "tb_national_no";
            this.tb_national_no.Size = new System.Drawing.Size(284, 26);
            this.tb_national_no.TabIndex = 47;
            this.tb_national_no.TextChanged += new System.EventHandler(this.txt_input_fields_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(253, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "National Number:";
            // 
            // lb_person_id
            // 
            this.lb_person_id.AutoSize = true;
            this.lb_person_id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_person_id.ForeColor = System.Drawing.Color.Gray;
            this.lb_person_id.Location = new System.Drawing.Point(346, 34);
            this.lb_person_id.Name = "lb_person_id";
            this.lb_person_id.Size = new System.Drawing.Size(34, 18);
            this.lb_person_id.TabIndex = 45;
            this.lb_person_id.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(253, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Person ID: ";
            // 
            // lb_upload_image
            // 
            this.lb_upload_image.AutoSize = true;
            this.lb_upload_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_upload_image.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_upload_image.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_upload_image.Location = new System.Drawing.Point(56, 199);
            this.lb_upload_image.Name = "lb_upload_image";
            this.lb_upload_image.Size = new System.Drawing.Size(103, 18);
            this.lb_upload_image.TabIndex = 43;
            this.lb_upload_image.Text = "Upload Image";
            this.lb_upload_image.Click += new System.EventHandler(this.lb_upload_image_Click);
            // 
            // flp_actions
            // 
            this.flp_actions.BackColor = System.Drawing.SystemColors.Control;
            this.flp_actions.Controls.Add(this.btn_save);
            this.flp_actions.Controls.Add(this.btn_cancel);
            this.flp_actions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_actions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp_actions.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flp_actions.Location = new System.Drawing.Point(2, 533);
            this.flp_actions.Name = "flp_actions";
            this.flp_actions.Padding = new System.Windows.Forms.Padding(10, 6, 30, 5);
            this.flp_actions.Size = new System.Drawing.Size(896, 50);
            this.flp_actions.TabIndex = 44;
            // 
            // err_input_validation
            // 
            this.err_input_validation.ContainerControl = this;
            // 
            // ofd_upload_image
            // 
            this.ofd_upload_image.FileName = "Upload Image";
            // 
            // img_list_default_profile
            // 
            this.img_list_default_profile.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_list_default_profile.ImageStream")));
            this.img_list_default_profile.TransparentColor = System.Drawing.Color.Transparent;
            this.img_list_default_profile.Images.SetKeyName(0, "Male.png");
            this.img_list_default_profile.Images.SetKeyName(1, "Female.png");
            // 
            // rpb_profile_image
            // 
            this.rpb_profile_image.BackColor = System.Drawing.Color.Transparent;
            this.rpb_profile_image.Location = new System.Drawing.Point(30, 34);
            this.rpb_profile_image.Name = "rpb_profile_image";
            this.rpb_profile_image.Radius = 30;
            this.rpb_profile_image.Size = new System.Drawing.Size(150, 150);
            this.rpb_profile_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rpb_profile_image.TabIndex = 42;
            this.rpb_profile_image.TabStop = false;
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
            this.btn_save.Location = new System.Drawing.Point(738, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 30);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_save_MouseClick);
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
            this.btn_cancel.Location = new System.Drawing.Point(617, 9);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 30);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Exit_Clicked);
            // 
            // Add_Edit_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(900, 585);
            this.Controls.Add(this.pl_main);
            this.Controls.Add(this.flp_actions);
            this.Controls.Add(this.pl_header);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Add_Edit_Person";
            this.Text = "Add_Edit_Person";
            this.Load += new System.EventHandler(this.Add_Edit_Person_Load);
            this.pl_header.ResumeLayout(false);
            this.pl_header.PerformLayout();
            this.pl_main.ResumeLayout(false);
            this.pl_main.PerformLayout();
            this.flp_actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err_input_validation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpb_profile_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Panel pl_header;
        private System.Windows.Forms.Panel pl_main;
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
        private System.Windows.Forms.RichTextBox rtb_address;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel flp_actions;
        private Views.Controls.RoundedButton btn_save;
        private Views.Controls.RoundedButton btn_cancel;
        private System.Windows.Forms.Label lb_max_length;
        private System.Windows.Forms.Label lb_exit;
        private System.Windows.Forms.ErrorProvider err_input_validation;
        private System.Windows.Forms.OpenFileDialog ofd_upload_image;
        private System.Windows.Forms.ImageList img_list_default_profile;
        private System.Windows.Forms.Label lb_remove_image;
    }
}