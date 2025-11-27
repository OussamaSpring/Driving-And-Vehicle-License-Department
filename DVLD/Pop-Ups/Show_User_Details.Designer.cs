namespace DVLD.Pop_Ups
{
    partial class Show_User_Details
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
            this.personDetailsCard = new DVLD.UserControls.PersonDetailsCard();
            this.lb_is_active = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_user_id = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personDetailsCard
            // 
            this.personDetailsCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.personDetailsCard.Location = new System.Drawing.Point(0, 0);
            this.personDetailsCard.Name = "personDetailsCard";
            this.personDetailsCard.Size = new System.Drawing.Size(660, 348);
            this.personDetailsCard.TabIndex = 0;
            // 
            // lb_is_active
            // 
            this.lb_is_active.AutoSize = true;
            this.lb_is_active.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_is_active.ForeColor = System.Drawing.Color.Black;
            this.lb_is_active.Location = new System.Drawing.Point(518, 399);
            this.lb_is_active.Name = "lb_is_active";
            this.lb_is_active.Size = new System.Drawing.Size(34, 18);
            this.lb_is_active.TabIndex = 118;
            this.lb_is_active.Text = "N/A";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gray;
            this.label22.Location = new System.Drawing.Point(425, 399);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 18);
            this.label22.TabIndex = 117;
            this.label22.Text = "Is Active: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(24, 438);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 18);
            this.label16.TabIndex = 115;
            this.label16.Text = "Username:";
            // 
            // lb_user_id
            // 
            this.lb_user_id.AutoSize = true;
            this.lb_user_id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user_id.ForeColor = System.Drawing.Color.Black;
            this.lb_user_id.Location = new System.Drawing.Point(134, 399);
            this.lb_user_id.Name = "lb_user_id";
            this.lb_user_id.Size = new System.Drawing.Size(34, 18);
            this.lb_user_id.TabIndex = 114;
            this.lb_user_id.Text = "N/A";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(24, 399);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 18);
            this.label18.TabIndex = 113;
            this.label18.Text = "User ID: ";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.Black;
            this.lb_username.Location = new System.Drawing.Point(134, 438);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(34, 18);
            this.lb_username.TabIndex = 119;
            this.lb_username.Text = "N/A";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lb_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_title.Location = new System.Drawing.Point(271, 351);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(117, 25);
            this.lb_title.TabIndex = 121;
            this.lb_title.Text = "Login Info";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Show_User_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 482);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_is_active);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lb_user_id);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.personDetailsCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Show_User_Details";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_User_Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.PersonDetailsCard personDetailsCard;
        private System.Windows.Forms.Label lb_is_active;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_user_id;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_title;
    }
}