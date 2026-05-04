namespace DVLD.Pop_Ups
{
    partial class Take_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Take_Test));
            this.gb_test_result = new System.Windows.Forms.GroupBox();
            this.rtb_notes = new System.Windows.Forms.RichTextBox();
            this.rb_fails = new System.Windows.Forms.RadioButton();
            this.rb_passes = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gb_test_info = new System.Windows.Forms.GroupBox();
            this.lb_test_date = new System.Windows.Forms.Label();
            this.lb_test_fees = new System.Windows.Forms.Label();
            this.lb_trial_number = new System.Windows.Forms.Label();
            this.lb_person_name = new System.Windows.Forms.Label();
            this.lb_ldl_app_id = new System.Windows.Forms.Label();
            this.lb_license_class = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pl_header = new System.Windows.Forms.Panel();
            this.lb_exit = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_test_type = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_save = new DVLD.Views.Controls.RoundedButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lb_warning = new System.Windows.Forms.Label();
            this.gb_test_result.SuspendLayout();
            this.gb_test_info.SuspendLayout();
            this.pl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_test_result
            // 
            this.gb_test_result.Controls.Add(this.rtb_notes);
            this.gb_test_result.Controls.Add(this.rb_fails);
            this.gb_test_result.Controls.Add(this.rb_passes);
            this.gb_test_result.Controls.Add(this.label22);
            this.gb_test_result.Controls.Add(this.label23);
            this.gb_test_result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_test_result.Location = new System.Drawing.Point(24, 508);
            this.gb_test_result.Name = "gb_test_result";
            this.gb_test_result.Size = new System.Drawing.Size(384, 167);
            this.gb_test_result.TabIndex = 20;
            this.gb_test_result.TabStop = false;
            this.gb_test_result.Text = "Test Result";
            // 
            // rtb_notes
            // 
            this.rtb_notes.Location = new System.Drawing.Point(20, 96);
            this.rtb_notes.MaxLength = 255;
            this.rtb_notes.Name = "rtb_notes";
            this.rtb_notes.Size = new System.Drawing.Size(346, 60);
            this.rtb_notes.TabIndex = 14;
            this.rtb_notes.Text = "";
            // 
            // rb_fails
            // 
            this.rb_fails.AutoSize = true;
            this.rb_fails.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_fails.Location = new System.Drawing.Point(249, 29);
            this.rb_fails.Name = "rb_fails";
            this.rb_fails.Size = new System.Drawing.Size(58, 22);
            this.rb_fails.TabIndex = 12;
            this.rb_fails.TabStop = true;
            this.rb_fails.Text = "Fails";
            this.rb_fails.UseVisualStyleBackColor = true;
            // 
            // rb_passes
            // 
            this.rb_passes.AutoSize = true;
            this.rb_passes.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_passes.Location = new System.Drawing.Point(144, 29);
            this.rb_passes.Name = "rb_passes";
            this.rb_passes.Size = new System.Drawing.Size(76, 22);
            this.rb_passes.TabIndex = 11;
            this.rb_passes.TabStop = true;
            this.rb_passes.Text = "Passes";
            this.rb_passes.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(17, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 18);
            this.label22.TabIndex = 2;
            this.label22.Text = "Test Result: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(17, 67);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 18);
            this.label23.TabIndex = 3;
            this.label23.Text = "Notes: ";
            // 
            // gb_test_info
            // 
            this.gb_test_info.Controls.Add(this.lb_test_date);
            this.gb_test_info.Controls.Add(this.lb_test_fees);
            this.gb_test_info.Controls.Add(this.lb_trial_number);
            this.gb_test_info.Controls.Add(this.lb_person_name);
            this.gb_test_info.Controls.Add(this.lb_ldl_app_id);
            this.gb_test_info.Controls.Add(this.lb_license_class);
            this.gb_test_info.Controls.Add(this.label7);
            this.gb_test_info.Controls.Add(this.label6);
            this.gb_test_info.Controls.Add(this.label5);
            this.gb_test_info.Controls.Add(this.label4);
            this.gb_test_info.Controls.Add(this.label2);
            this.gb_test_info.Controls.Add(this.label3);
            this.gb_test_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_test_info.Location = new System.Drawing.Point(24, 256);
            this.gb_test_info.Name = "gb_test_info";
            this.gb_test_info.Size = new System.Drawing.Size(384, 238);
            this.gb_test_info.TabIndex = 21;
            this.gb_test_info.TabStop = false;
            this.gb_test_info.Text = "Test Info";
            // 
            // lb_test_date
            // 
            this.lb_test_date.AutoSize = true;
            this.lb_test_date.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_test_date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_test_date.Location = new System.Drawing.Point(141, 169);
            this.lb_test_date.Name = "lb_test_date";
            this.lb_test_date.Size = new System.Drawing.Size(22, 18);
            this.lb_test_date.TabIndex = 14;
            this.lb_test_date.Text = "??";
            // 
            // lb_test_fees
            // 
            this.lb_test_fees.AutoSize = true;
            this.lb_test_fees.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_test_fees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_test_fees.Location = new System.Drawing.Point(141, 203);
            this.lb_test_fees.Name = "lb_test_fees";
            this.lb_test_fees.Size = new System.Drawing.Size(22, 18);
            this.lb_test_fees.TabIndex = 13;
            this.lb_test_fees.Text = "??";
            // 
            // lb_trial_number
            // 
            this.lb_trial_number.AutoSize = true;
            this.lb_trial_number.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trial_number.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_trial_number.Location = new System.Drawing.Point(141, 135);
            this.lb_trial_number.Name = "lb_trial_number";
            this.lb_trial_number.Size = new System.Drawing.Size(22, 18);
            this.lb_trial_number.TabIndex = 11;
            this.lb_trial_number.Text = "??";
            // 
            // lb_person_name
            // 
            this.lb_person_name.AutoSize = true;
            this.lb_person_name.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_person_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_person_name.Location = new System.Drawing.Point(141, 101);
            this.lb_person_name.Name = "lb_person_name";
            this.lb_person_name.Size = new System.Drawing.Size(22, 18);
            this.lb_person_name.TabIndex = 10;
            this.lb_person_name.Text = "??";
            // 
            // lb_ldl_app_id
            // 
            this.lb_ldl_app_id.AutoSize = true;
            this.lb_ldl_app_id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ldl_app_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_ldl_app_id.Location = new System.Drawing.Point(141, 33);
            this.lb_ldl_app_id.Name = "lb_ldl_app_id";
            this.lb_ldl_app_id.Size = new System.Drawing.Size(22, 18);
            this.lb_ldl_app_id.TabIndex = 8;
            this.lb_ldl_app_id.Text = "??";
            // 
            // lb_license_class
            // 
            this.lb_license_class.AutoSize = true;
            this.lb_license_class.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_license_class.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_license_class.Location = new System.Drawing.Point(141, 67);
            this.lb_license_class.Name = "lb_license_class";
            this.lb_license_class.Size = new System.Drawing.Size(22, 18);
            this.lb_license_class.TabIndex = 9;
            this.lb_license_class.Text = "??";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(17, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fees: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(17, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(17, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trial: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(17, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "L.D.L App. ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "L.D.L Class: ";
            // 
            // pl_header
            // 
            this.pl_header.BackColor = System.Drawing.Color.Orchid;
            this.pl_header.Controls.Add(this.lb_exit);
            this.pl_header.Controls.Add(this.lb_title);
            this.pl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_header.Location = new System.Drawing.Point(2, 2);
            this.pl_header.Name = "pl_header";
            this.pl_header.Size = new System.Drawing.Size(428, 85);
            this.pl_header.TabIndex = 30;
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
            this.lb_exit.Location = new System.Drawing.Point(370, 14);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(51, 58);
            this.lb_exit.TabIndex = 1;
            this.lb_exit.Text = "×";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Roboto Lt", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(22, 26);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(151, 35);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Take Test";
            // 
            // lb_test_type
            // 
            this.lb_test_type.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_test_type.Location = new System.Drawing.Point(141, 213);
            this.lb_test_type.Name = "lb_test_type";
            this.lb_test_type.Size = new System.Drawing.Size(151, 25);
            this.lb_test_type.TabIndex = 29;
            this.lb_test_type.Text = "Test Type";
            this.lb_test_type.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(114, 101);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(204, 99);
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
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
            this.btn_save.Location = new System.Drawing.Point(293, 688);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 30);
            this.btn_save.TabIndex = 31;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "eyetest.png");
            this.imageList.Images.SetKeyName(1, "exam.png");
            this.imageList.Images.SetKeyName(2, "driving-test.png");
            // 
            // lb_warning
            // 
            this.lb_warning.AutoSize = true;
            this.lb_warning.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_warning.ForeColor = System.Drawing.Color.Red;
            this.lb_warning.Location = new System.Drawing.Point(26, 692);
            this.lb_warning.Name = "lb_warning";
            this.lb_warning.Size = new System.Drawing.Size(153, 20);
            this.lb_warning.TabIndex = 15;
            this.lb_warning.Text = "Missed appointment!";
            this.lb_warning.Visible = false;
            // 
            // Take_Test
            // 
            this.ClientSize = new System.Drawing.Size(432, 728);
            this.Controls.Add(this.lb_warning);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pl_header);
            this.Controls.Add(this.lb_test_type);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.gb_test_info);
            this.Controls.Add(this.gb_test_result);
            this.Name = "Take_Test";
            this.gb_test_result.ResumeLayout(false);
            this.gb_test_result.PerformLayout();
            this.gb_test_info.ResumeLayout(false);
            this.gb_test_info.PerformLayout();
            this.pl_header.ResumeLayout(false);
            this.pl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_test_result;
        private System.Windows.Forms.RichTextBox rtb_notes;
        private System.Windows.Forms.RadioButton rb_fails;
        private System.Windows.Forms.RadioButton rb_passes;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox gb_test_info;
        private System.Windows.Forms.Label lb_test_date;
        private System.Windows.Forms.Label lb_test_fees;
        private System.Windows.Forms.Label lb_trial_number;
        private System.Windows.Forms.Label lb_person_name;
        private System.Windows.Forms.Label lb_ldl_app_id;
        private System.Windows.Forms.Label lb_license_class;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pl_header;
        private System.Windows.Forms.Label lb_exit;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_test_type;
        private System.Windows.Forms.PictureBox pictureBox;
        private Views.Controls.RoundedButton btn_save;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lb_warning;
    }
}
