namespace DVLD.Pop_Ups
{
    partial class Add_Edit_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Edit_User));
            this.lb_title = new System.Windows.Forms.Label();
            this.pl_header = new System.Windows.Forms.Panel();
            this.lb_exit = new System.Windows.Forms.Label();
            this.flp_actions = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_save = new DVLD.Views.Controls.RoundedButton();
            this.btn_cancel = new DVLD.Views.Controls.RoundedButton();
            this.err_input_validation = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofd_upload_image = new System.Windows.Forms.OpenFileDialog();
            this.img_list_default_profile = new System.Windows.Forms.ImageList(this.components);
            this.pl_main = new System.Windows.Forms.Panel();
            this.btn_search = new WindowsFormsControlLibrary.CustomControls.RoundedPictureBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.lb_text = new System.Windows.Forms.Label();
            this.personDetailsCard1 = new DVLD.UserControls.PersonDetailsCard();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_user_id = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.chk_is_active = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pl_header.SuspendLayout();
            this.flp_actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_input_validation)).BeginInit();
            this.pl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Roboto Lt", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_title.Location = new System.Drawing.Point(33, 26);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(223, 35);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Add / Edit User";
            // 
            // pl_header
            // 
            this.pl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
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
            this.lb_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_exit.Location = new System.Drawing.Point(830, 15);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(51, 58);
            this.lb_exit.TabIndex = 1;
            this.lb_exit.Text = "×";
            this.lb_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Exit_Clicked);
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
            // pl_main
            // 
            this.pl_main.AutoScroll = true;
            this.pl_main.BackColor = System.Drawing.SystemColors.Control;
            this.pl_main.Controls.Add(this.textBox2);
            this.pl_main.Controls.Add(this.label2);
            this.pl_main.Controls.Add(this.textBox1);
            this.pl_main.Controls.Add(this.label1);
            this.pl_main.Controls.Add(this.chk_is_active);
            this.pl_main.Controls.Add(this.label22);
            this.pl_main.Controls.Add(this.txt_username);
            this.pl_main.Controls.Add(this.label16);
            this.pl_main.Controls.Add(this.lb_user_id);
            this.pl_main.Controls.Add(this.label18);
            this.pl_main.Controls.Add(this.personDetailsCard1);
            this.pl_main.Controls.Add(this.btn_search);
            this.pl_main.Controls.Add(this.txt_search);
            this.pl_main.Controls.Add(this.cb_filter);
            this.pl_main.Controls.Add(this.lb_text);
            this.pl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_main.Location = new System.Drawing.Point(2, 87);
            this.pl_main.Name = "pl_main";
            this.pl_main.Size = new System.Drawing.Size(896, 446);
            this.pl_main.TabIndex = 43;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.Image = global::DVLD.Properties.Resources.search;
            this.btn_search.Location = new System.Drawing.Point(676, 20);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Radius = 4;
            this.btn_search.Size = new System.Drawing.Size(30, 30);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 72;
            this.btn_search.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(460, 20);
            this.txt_search.MaxLength = 30;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(208, 30);
            this.txt_search.TabIndex = 70;
            // 
            // cb_filter
            // 
            this.cb_filter.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filter.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "Person ID",
            "National No."});
            this.cb_filter.Location = new System.Drawing.Point(257, 20);
            this.cb_filter.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(190, 31);
            this.cb_filter.TabIndex = 69;
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_text.Location = new System.Drawing.Point(163, 27);
            this.lb_text.Margin = new System.Windows.Forms.Padding(3, 10, 6, 0);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(85, 19);
            this.lb_text.TabIndex = 71;
            this.lb_text.Text = "Search By:";
            // 
            // personDetailsCard1
            // 
            this.personDetailsCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personDetailsCard1.Location = new System.Drawing.Point(111, 73);
            this.personDetailsCard1.Name = "personDetailsCard1";
            this.personDetailsCard1.Size = new System.Drawing.Size(677, 367);
            this.personDetailsCard1.TabIndex = 73;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(509, 467);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 18);
            this.label22.TabIndex = 117;
            this.label22.Text = "Is Active: ";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Gray;
            this.txt_username.Location = new System.Drawing.Point(270, 511);
            this.txt_username.MaxLength = 20;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(284, 26);
            this.txt_username.TabIndex = 116;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(108, 516);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.label16.Size = new System.Drawing.Size(81, 48);
            this.label16.TabIndex = 115;
            this.label16.Text = "Username:";
            // 
            // lb_user_id
            // 
            this.lb_user_id.AutoSize = true;
            this.lb_user_id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user_id.ForeColor = System.Drawing.Color.Gray;
            this.lb_user_id.Location = new System.Drawing.Point(201, 467);
            this.lb_user_id.Name = "lb_user_id";
            this.lb_user_id.Size = new System.Drawing.Size(34, 18);
            this.lb_user_id.TabIndex = 114;
            this.lb_user_id.Text = "N/A";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(108, 467);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 18);
            this.label18.TabIndex = 113;
            this.label18.Text = "User ID: ";
            // 
            // chk_is_active
            // 
            this.chk_is_active.AutoSize = true;
            this.chk_is_active.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_is_active.Location = new System.Drawing.Point(602, 469);
            this.chk_is_active.Name = "chk_is_active";
            this.chk_is_active.Size = new System.Drawing.Size(15, 14);
            this.chk_is_active.TabIndex = 119;
            this.chk_is_active.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(270, 555);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 26);
            this.textBox1.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(108, 560);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.label1.Size = new System.Drawing.Size(80, 48);
            this.label1.TabIndex = 120;
            this.label1.Text = "Password:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(270, 601);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 26);
            this.textBox2.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(108, 606);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.label2.Size = new System.Drawing.Size(138, 48);
            this.label2.TabIndex = 122;
            this.label2.Text = "Confirm Password:";
            // 
            // Add_Edit_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(900, 585);
            this.Controls.Add(this.pl_main);
            this.Controls.Add(this.flp_actions);
            this.Controls.Add(this.pl_header);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Add_Edit_User";
            this.Text = "Add_Edit_Person";
            this.Load += new System.EventHandler(this.Add_Edit_Person_Load);
            this.pl_header.ResumeLayout(false);
            this.pl_header.PerformLayout();
            this.flp_actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err_input_validation)).EndInit();
            this.pl_main.ResumeLayout(false);
            this.pl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Panel pl_header;
        private System.Windows.Forms.FlowLayoutPanel flp_actions;
        private Views.Controls.RoundedButton btn_save;
        private Views.Controls.RoundedButton btn_cancel;
        private System.Windows.Forms.Label lb_exit;
        private System.Windows.Forms.ErrorProvider err_input_validation;
        private System.Windows.Forms.OpenFileDialog ofd_upload_image;
        private System.Windows.Forms.ImageList img_list_default_profile;
        private System.Windows.Forms.Panel pl_main;
        private UserControls.PersonDetailsCard personDetailsCard1;
        private WindowsFormsControlLibrary.CustomControls.RoundedPictureBox btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_is_active;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_user_id;
        private System.Windows.Forms.Label label18;
    }
}