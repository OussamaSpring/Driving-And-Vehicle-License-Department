namespace DVLD.UserControls
{
    partial class DashboardCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlp_grid = new System.Windows.Forms.TableLayoutPanel();
            this.flp_data = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_value = new System.Windows.Forms.Label();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tlp_grid.SuspendLayout();
            this.flp_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlp_grid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 114);
            this.panel1.TabIndex = 0;
            // 
            // tlp_grid
            // 
            this.tlp_grid.ColumnCount = 2;
            this.tlp_grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlp_grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_grid.Controls.Add(this.flp_data, 1, 1);
            this.tlp_grid.Controls.Add(this.pb_icon, 0, 1);
            this.tlp_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_grid.Location = new System.Drawing.Point(0, 0);
            this.tlp_grid.Name = "tlp_grid";
            this.tlp_grid.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.tlp_grid.RowCount = 3;
            this.tlp_grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_grid.Size = new System.Drawing.Size(261, 114);
            this.tlp_grid.TabIndex = 4;
            // 
            // flp_data
            // 
            this.flp_data.Controls.Add(this.lb_title);
            this.flp_data.Controls.Add(this.lb_value);
            this.flp_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_data.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_data.Location = new System.Drawing.Point(87, 25);
            this.flp_data.Name = "flp_data";
            this.flp_data.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.flp_data.Size = new System.Drawing.Size(155, 62);
            this.flp_data.TabIndex = 7;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.DimGray;
            this.lb_title.Location = new System.Drawing.Point(18, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(60, 24);
            this.lb_title.TabIndex = 5;
            this.lb_title.Text = "label1";
            // 
            // lb_value
            // 
            this.lb_value.AutoSize = true;
            this.lb_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.lb_value.Location = new System.Drawing.Point(18, 32);
            this.lb_value.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lb_value.Name = "lb_value";
            this.lb_value.Size = new System.Drawing.Size(76, 29);
            this.lb_value.TabIndex = 6;
            this.lb_value.Text = "1,232";
            // 
            // pb_icon
            // 
            this.pb_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_icon.Location = new System.Drawing.Point(23, 25);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(58, 62);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon.TabIndex = 4;
            this.pb_icon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(261, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 114);
            this.panel2.TabIndex = 0;
            // 
            // DashboardCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "DashboardCard";
            this.Size = new System.Drawing.Size(273, 114);
            this.panel1.ResumeLayout(false);
            this.tlp_grid.ResumeLayout(false);
            this.flp_data.ResumeLayout(false);
            this.flp_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tlp_grid;
        private System.Windows.Forms.FlowLayoutPanel flp_data;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_value;
        private System.Windows.Forms.PictureBox pb_icon;
    }
}
