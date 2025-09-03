namespace DVLD.Dialogs
{
    partial class LoginDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDialog));
            this.label4 = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.chk_remember_me = new System.Windows.Forms.CheckBox();
            this.lb_exit = new System.Windows.Forms.Label();
            this.err_login_credential = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_login = new DVLD.Views.Controls.RoundedButton();
            this.main_panel = new WindowsFormsControlLibrary.CustomControls.RoundedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_login_credential)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Bk", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(32, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 48);
            this.label4.TabIndex = 16;
            this.label4.Text = "DVLD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_title
            // 
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.lb_title.Location = new System.Drawing.Point(34, 125);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(323, 70);
            this.lb_title.TabIndex = 17;
            this.lb_title.Text = "DRIVING LICENSE MANAGEMENT SYSTEM";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.Image = global::DVLD.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(94, 7);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(202, 99);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 18;
            this.logo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(151, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 35);
            this.label3.TabIndex = 21;
            this.label3.Text = "Log In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(67, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(67, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Username";
            // 
            // txt_password
            // 
            this.txt_password.AcceptsReturn = true;
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_password.Location = new System.Drawing.Point(70, 356);
            this.txt_password.MaxLength = 50;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(250, 27);
            this.txt_password.TabIndex = 23;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.AcceptsReturn = true;
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.Location = new System.Drawing.Point(70, 289);
            this.txt_username.MaxLength = 50;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(250, 27);
            this.txt_username.TabIndex = 22;
            // 
            // chk_remember_me
            // 
            this.chk_remember_me.AutoSize = true;
            this.chk_remember_me.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.chk_remember_me.Location = new System.Drawing.Point(226, 395);
            this.chk_remember_me.Name = "chk_remember_me";
            this.chk_remember_me.Size = new System.Drawing.Size(95, 17);
            this.chk_remember_me.TabIndex = 25;
            this.chk_remember_me.Text = "Remember Me";
            this.chk_remember_me.UseVisualStyleBackColor = false;
            // 
            // lb_exit
            // 
            this.lb_exit.AutoSize = true;
            this.lb_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.lb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_exit.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_exit.Location = new System.Drawing.Point(175, 479);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(41, 21);
            this.lb_exit.TabIndex = 26;
            this.lb_exit.Text = "Exit";
            this.lb_exit.Click += new System.EventHandler(this.lb_exit_Click);
            // 
            // err_login_credential
            // 
            this.err_login_credential.ContainerControl = this;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btn_login.BorderColor = System.Drawing.Color.Black;
            this.btn_login.BorderRadius = 20;
            this.btn_login.BorderSize = 0;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.btn_login.Location = new System.Drawing.Point(70, 430);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(250, 40);
            this.btn_login.TabIndex = 27;
            this.btn_login.Text = "LOG IN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.main_panel.BorderColor = System.Drawing.Color.Black;
            this.main_panel.BorderRadius = 15;
            this.main_panel.BorderWidth = 1;
            this.main_panel.Location = new System.Drawing.Point(34, 195);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(323, 310);
            this.main_panel.TabIndex = 24;
            this.main_panel.Text = "roundedPanel1";
            // 
            // LoginDialog
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.BorderRadius = 15;
            this.ClientSize = new System.Drawing.Size(390, 530);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_exit);
            this.Controls.Add(this.chk_remember_me);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.main_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(390, 530);
            this.MinimumSize = new System.Drawing.Size(390, 530);
            this.Name = "LoginDialog";
            this.Load += new System.EventHandler(this.LoginDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_login_credential)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private WindowsFormsControlLibrary.CustomControls.RoundedPanel main_panel;
        private System.Windows.Forms.CheckBox chk_remember_me;
        private System.Windows.Forms.Label lb_exit;
        private Views.Controls.RoundedButton btn_login;
        private System.Windows.Forms.ErrorProvider err_login_credential;
    }
}
