namespace DVLD.Pop_Ups
{
    partial class Detain_License
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
            this.flp_actions = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_detain = new DVLD.Views.Controls.RoundedButton();
            this.btn_cancel = new DVLD.Views.Controls.RoundedButton();
            this.pl_header = new System.Windows.Forms.Panel();
            this.lb_exit = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.driverLicenseCard = new DVLD.UserControls.DriverLicenseCard();
            this.txt_fine_fees_detain = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_created_by_detain = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lb_detain_date = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btn_search_detain = new WindowsFormsControlLibrary.CustomControls.RoundedPictureBox();
            this.txt_search_detain = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.flp_actions.SuspendLayout();
            this.pl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search_detain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_actions
            // 
            this.flp_actions.BackColor = System.Drawing.SystemColors.Control;
            this.flp_actions.Controls.Add(this.btn_detain);
            this.flp_actions.Controls.Add(this.btn_cancel);
            this.flp_actions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_actions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp_actions.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flp_actions.Location = new System.Drawing.Point(0, 613);
            this.flp_actions.Name = "flp_actions";
            this.flp_actions.Padding = new System.Windows.Forms.Padding(10, 6, 20, 5);
            this.flp_actions.Size = new System.Drawing.Size(705, 50);
            this.flp_actions.TabIndex = 46;
            // 
            // btn_detain
            // 
            this.btn_detain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_detain.BorderColor = System.Drawing.Color.Gray;
            this.btn_detain.BorderRadius = 20;
            this.btn_detain.BorderSize = 2;
            this.btn_detain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detain.FlatAppearance.BorderSize = 0;
            this.btn_detain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detain.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_detain.Location = new System.Drawing.Point(557, 9);
            this.btn_detain.Name = "btn_detain";
            this.btn_detain.Size = new System.Drawing.Size(115, 30);
            this.btn_detain.TabIndex = 0;
            this.btn_detain.Text = "Detain";
            this.btn_detain.UseVisualStyleBackColor = false;
            this.btn_detain.Click += new System.EventHandler(this.btn_detain_Click);
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
            this.btn_cancel.Location = new System.Drawing.Point(436, 9);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 30);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pl_header
            // 
            this.pl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.pl_header.Controls.Add(this.lb_exit);
            this.pl_header.Controls.Add(this.lb_title);
            this.pl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_header.Location = new System.Drawing.Point(0, 0);
            this.pl_header.Name = "pl_header";
            this.pl_header.Size = new System.Drawing.Size(705, 85);
            this.pl_header.TabIndex = 45;
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
            this.lb_exit.Location = new System.Drawing.Point(646, 15);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(51, 58);
            this.lb_exit.TabIndex = 1;
            this.lb_exit.Text = "×";
            this.lb_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Roboto Lt", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(17, 26);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(220, 35);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Detain License";
            // 
            // driverLicenseCard
            // 
            this.driverLicenseCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverLicenseCard.Location = new System.Drawing.Point(19, 147);
            this.driverLicenseCard.Name = "driverLicenseCard";
            this.driverLicenseCard.Size = new System.Drawing.Size(671, 367);
            this.driverLicenseCard.TabIndex = 49;
            // 
            // txt_fine_fees_detain
            // 
            this.txt_fine_fees_detain.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fine_fees_detain.Location = new System.Drawing.Point(143, 536);
            this.txt_fine_fees_detain.MaxLength = 10;
            this.txt_fine_fees_detain.Name = "txt_fine_fees_detain";
            this.txt_fine_fees_detain.Size = new System.Drawing.Size(100, 23);
            this.txt_fine_fees_detain.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(41, 540);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 19);
            this.label17.TabIndex = 25;
            this.label17.Text = "Fine Fees:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_created_by_detain
            // 
            this.lb_created_by_detain.AutoSize = true;
            this.lb_created_by_detain.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_created_by_detain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_created_by_detain.Location = new System.Drawing.Point(144, 583);
            this.lb_created_by_detain.Name = "lb_created_by_detain";
            this.lb_created_by_detain.Size = new System.Drawing.Size(25, 19);
            this.lb_created_by_detain.TabIndex = 24;
            this.lb_created_by_detain.Text = "??";
            this.lb_created_by_detain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.Location = new System.Drawing.Point(42, 583);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 19);
            this.label23.TabIndex = 23;
            this.label23.Text = "Created By:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_detain_date
            // 
            this.lb_detain_date.AutoSize = true;
            this.lb_detain_date.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_detain_date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_detain_date.Location = new System.Drawing.Point(562, 540);
            this.lb_detain_date.Name = "lb_detain_date";
            this.lb_detain_date.Size = new System.Drawing.Size(25, 19);
            this.lb_detain_date.TabIndex = 20;
            this.lb_detain_date.Text = "??";
            this.lb_detain_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(456, 540);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 19);
            this.label27.TabIndex = 19;
            this.label27.Text = "Detain Date: ";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_search_detain
            // 
            this.btn_search_detain.BackColor = System.Drawing.Color.White;
            this.btn_search_detain.Image = global::DVLD.Properties.Resources.search;
            this.btn_search_detain.Location = new System.Drawing.Point(485, 101);
            this.btn_search_detain.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_search_detain.Name = "btn_search_detain";
            this.btn_search_detain.Radius = 4;
            this.btn_search_detain.Size = new System.Drawing.Size(30, 30);
            this.btn_search_detain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search_detain.TabIndex = 6;
            this.btn_search_detain.TabStop = false;
            this.btn_search_detain.Click += new System.EventHandler(this.btn_search_detain_Click);
            // 
            // txt_search_detain
            // 
            this.txt_search_detain.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_detain.Location = new System.Drawing.Point(264, 101);
            this.txt_search_detain.MaxLength = 30;
            this.txt_search_detain.Name = "txt_search_detain";
            this.txt_search_detain.Size = new System.Drawing.Size(208, 30);
            this.txt_search_detain.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(170, 108);
            this.label28.Margin = new System.Windows.Forms.Padding(3, 10, 6, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(87, 19);
            this.label28.TabIndex = 2;
            this.label28.Text = "License ID:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Detain_License
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(705, 663);
            this.Controls.Add(this.txt_fine_fees_detain);
            this.Controls.Add(this.btn_search_detain);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lb_created_by_detain);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txt_search_detain);
            this.Controls.Add(this.lb_detain_date);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.driverLicenseCard);
            this.Controls.Add(this.flp_actions);
            this.Controls.Add(this.pl_header);
            this.Name = "Detain_License";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.flp_actions.ResumeLayout(false);
            this.pl_header.ResumeLayout(false);
            this.pl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search_detain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_actions;
        private Views.Controls.RoundedButton btn_detain;
        private Views.Controls.RoundedButton btn_cancel;
        private System.Windows.Forms.Panel pl_header;
        private System.Windows.Forms.Label lb_exit;
        private System.Windows.Forms.Label lb_title;
        private UserControls.DriverLicenseCard driverLicenseCard;
        private System.Windows.Forms.TextBox txt_fine_fees_detain;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_created_by_detain;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lb_detain_date;
        private System.Windows.Forms.Label label27;
        private WindowsFormsControlLibrary.CustomControls.RoundedPictureBox btn_search_detain;
        private System.Windows.Forms.TextBox txt_search_detain;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
