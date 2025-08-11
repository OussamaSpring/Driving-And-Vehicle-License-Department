namespace DVLD.UserControls
{
    partial class Header
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_username = new System.Windows.Forms.Label();
            this.pb_profileImage = new WindowsFormsControlLibrary.CustomControls.RoundedPictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lb_username);
            this.flowLayoutPanel1.Controls.Add(this.pb_profileImage);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1024, 60);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lb_username
            // 
            this.lb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lb_username.Location = new System.Drawing.Point(896, 16);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(85, 23);
            this.lb_username.TabIndex = 3;
            this.lb_username.Text = "Username";
            // 
            // pb_profileImage
            // 
            this.pb_profileImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_profileImage.BackColor = System.Drawing.Color.Transparent;
            this.pb_profileImage.Location = new System.Drawing.Point(850, 8);
            this.pb_profileImage.Name = "pb_profileImage";
            this.pb_profileImage.Radius = 50;
            this.pb_profileImage.Size = new System.Drawing.Size(40, 40);
            this.pb_profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_profileImage.TabIndex = 4;
            this.pb_profileImage.TabStop = false;
            this.pb_profileImage.Text = "roundedPictureBox1";
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(1024, 60);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profileImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_username;
        private WindowsFormsControlLibrary.CustomControls.RoundedPictureBox pb_profileImage;
    }
}
