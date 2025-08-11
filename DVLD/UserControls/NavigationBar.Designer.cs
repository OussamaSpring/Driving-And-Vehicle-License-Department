namespace DVLD.UserControls
{
    partial class NavigationBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationBar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlp_navbar_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.License_Detain = new System.Windows.Forms.Button();
            this.Test_Management = new System.Windows.Forms.Button();
            this.Applications = new System.Windows.Forms.Button();
            this.Licenses = new System.Windows.Forms.Button();
            this.Individuals = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.seperator1 = new iNKORE.UI.WinForms.Styler.Controls.Seperator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlp_navbar_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 135);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(0, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Driving and Vehicle License Department";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 660);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 60);
            this.panel2.TabIndex = 1;
            // 
            // tlp_navbar_buttons
            // 
            this.tlp_navbar_buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_navbar_buttons.ColumnCount = 1;
            this.tlp_navbar_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_navbar_buttons.Controls.Add(this.License_Detain, 0, 5);
            this.tlp_navbar_buttons.Controls.Add(this.Test_Management, 0, 4);
            this.tlp_navbar_buttons.Controls.Add(this.Applications, 0, 3);
            this.tlp_navbar_buttons.Controls.Add(this.Licenses, 0, 2);
            this.tlp_navbar_buttons.Controls.Add(this.Individuals, 0, 1);
            this.tlp_navbar_buttons.Controls.Add(this.Dashboard, 0, 0);
            this.tlp_navbar_buttons.Location = new System.Drawing.Point(3, 225);
            this.tlp_navbar_buttons.Name = "tlp_navbar_buttons";
            this.tlp_navbar_buttons.RowCount = 6;
            this.tlp_navbar_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_navbar_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_navbar_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_navbar_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_navbar_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_navbar_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_navbar_buttons.Size = new System.Drawing.Size(294, 368);
            this.tlp_navbar_buttons.TabIndex = 2;
            // 
            // License_Detain
            // 
            this.License_Detain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.License_Detain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.License_Detain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.License_Detain.FlatAppearance.BorderSize = 0;
            this.License_Detain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.License_Detain.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.License_Detain.ForeColor = System.Drawing.Color.White;
            this.License_Detain.Image = ((System.Drawing.Image)(resources.GetObject("License_Detain.Image")));
            this.License_Detain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.License_Detain.Location = new System.Drawing.Point(10, 310);
            this.License_Detain.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.License_Detain.Name = "License_Detain";
            this.License_Detain.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.License_Detain.Size = new System.Drawing.Size(274, 53);
            this.License_Detain.TabIndex = 6;
            this.License_Detain.Tag = "6";
            this.License_Detain.Text = "   License Detain";
            this.License_Detain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.License_Detain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.License_Detain.UseVisualStyleBackColor = false;
            this.License_Detain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.navbar_btn_Click);
            this.License_Detain.MouseEnter += new System.EventHandler(this.navbar_btn_MouseEnter);
            this.License_Detain.MouseLeave += new System.EventHandler(this.navbar_btn_MouseLeave);
            // 
            // Test_Management
            // 
            this.Test_Management.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Test_Management.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Test_Management.FlatAppearance.BorderSize = 0;
            this.Test_Management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test_Management.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_Management.ForeColor = System.Drawing.Color.White;
            this.Test_Management.Image = ((System.Drawing.Image)(resources.GetObject("Test_Management.Image")));
            this.Test_Management.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Test_Management.Location = new System.Drawing.Point(10, 249);
            this.Test_Management.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Test_Management.Name = "Test_Management";
            this.Test_Management.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Test_Management.Size = new System.Drawing.Size(274, 51);
            this.Test_Management.TabIndex = 5;
            this.Test_Management.Tag = "5";
            this.Test_Management.Text = "   Test Management";
            this.Test_Management.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Test_Management.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Test_Management.UseVisualStyleBackColor = true;
            this.Test_Management.MouseClick += new System.Windows.Forms.MouseEventHandler(this.navbar_btn_Click);
            this.Test_Management.MouseEnter += new System.EventHandler(this.navbar_btn_MouseEnter);
            this.Test_Management.MouseLeave += new System.EventHandler(this.navbar_btn_MouseLeave);
            // 
            // Applications
            // 
            this.Applications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Applications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Applications.FlatAppearance.BorderSize = 0;
            this.Applications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Applications.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applications.ForeColor = System.Drawing.Color.White;
            this.Applications.Image = ((System.Drawing.Image)(resources.GetObject("Applications.Image")));
            this.Applications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Applications.Location = new System.Drawing.Point(10, 188);
            this.Applications.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Applications.Name = "Applications";
            this.Applications.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Applications.Size = new System.Drawing.Size(274, 51);
            this.Applications.TabIndex = 4;
            this.Applications.Tag = "4";
            this.Applications.Text = "   Applications";
            this.Applications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Applications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Applications.UseVisualStyleBackColor = true;
            this.Applications.MouseClick += new System.Windows.Forms.MouseEventHandler(this.navbar_btn_Click);
            this.Applications.MouseEnter += new System.EventHandler(this.navbar_btn_MouseEnter);
            this.Applications.MouseLeave += new System.EventHandler(this.navbar_btn_MouseLeave);
            // 
            // Licenses
            // 
            this.Licenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Licenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Licenses.FlatAppearance.BorderSize = 0;
            this.Licenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Licenses.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Licenses.ForeColor = System.Drawing.Color.White;
            this.Licenses.Image = ((System.Drawing.Image)(resources.GetObject("Licenses.Image")));
            this.Licenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Licenses.Location = new System.Drawing.Point(10, 127);
            this.Licenses.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Licenses.Name = "Licenses";
            this.Licenses.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Licenses.Size = new System.Drawing.Size(274, 51);
            this.Licenses.TabIndex = 3;
            this.Licenses.Tag = "3";
            this.Licenses.Text = "   Licenses";
            this.Licenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Licenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Licenses.UseVisualStyleBackColor = true;
            this.Licenses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.navbar_btn_Click);
            this.Licenses.MouseEnter += new System.EventHandler(this.navbar_btn_MouseEnter);
            this.Licenses.MouseLeave += new System.EventHandler(this.navbar_btn_MouseLeave);
            // 
            // Individuals
            // 
            this.Individuals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Individuals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Individuals.FlatAppearance.BorderSize = 0;
            this.Individuals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Individuals.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Individuals.ForeColor = System.Drawing.Color.White;
            this.Individuals.Image = ((System.Drawing.Image)(resources.GetObject("Individuals.Image")));
            this.Individuals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Individuals.Location = new System.Drawing.Point(10, 66);
            this.Individuals.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Individuals.Name = "Individuals";
            this.Individuals.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Individuals.Size = new System.Drawing.Size(274, 51);
            this.Individuals.TabIndex = 2;
            this.Individuals.Tag = "2";
            this.Individuals.Text = "   Individuals";
            this.Individuals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Individuals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Individuals.UseVisualStyleBackColor = true;
            this.Individuals.MouseClick += new System.Windows.Forms.MouseEventHandler(this.navbar_btn_Click);
            this.Individuals.MouseEnter += new System.EventHandler(this.navbar_btn_MouseEnter);
            this.Individuals.MouseLeave += new System.EventHandler(this.navbar_btn_MouseLeave);
            // 
            // Dashboard
            // 
            this.Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.White;
            this.Dashboard.Image = global::DVLD.Properties.Resources.Dashboard;
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(10, 5);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Dashboard.Size = new System.Drawing.Size(274, 51);
            this.Dashboard.TabIndex = 1;
            this.Dashboard.Tag = "1";
            this.Dashboard.Text = "   Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.navbar_btn_Click);
            this.Dashboard.MouseEnter += new System.EventHandler(this.navbar_btn_MouseEnter);
            this.Dashboard.MouseLeave += new System.EventHandler(this.navbar_btn_MouseLeave);
            // 
            // seperator1
            // 
            this.seperator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seperator1.Location = new System.Drawing.Point(50, 152);
            this.seperator1.Name = "seperator1";
            this.seperator1.Size = new System.Drawing.Size(200, 2);
            this.seperator1.TabIndex = 3;
            this.seperator1.TabStop = false;
            // 
            // NavigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.Controls.Add(this.seperator1);
            this.Controls.Add(this.tlp_navbar_buttons);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(300, 0);
            this.MinimumSize = new System.Drawing.Size(240, 720);
            this.Name = "NavigationBar";
            this.Size = new System.Drawing.Size(300, 720);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tlp_navbar_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tlp_navbar_buttons;
        private System.Windows.Forms.Button License_Detain;
        private System.Windows.Forms.Button Test_Management;
        private System.Windows.Forms.Button Applications;
        private System.Windows.Forms.Button Licenses;
        private System.Windows.Forms.Button Individuals;
        private System.Windows.Forms.Button Dashboard;
        private iNKORE.UI.WinForms.Styler.Controls.Seperator seperator1;
    }
}
