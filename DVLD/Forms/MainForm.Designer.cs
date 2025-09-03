namespace DVLD
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.header1 = new DVLD.UserControls.Header();
            this.NavBar = new DVLD.UserControls.NavigationBar();
            this.headerlessTabPage1 = new iNKORE.UI.WinForms.Styler.Controls.HeaderlessTabPage();
            this.headerlessTabPage2 = new iNKORE.UI.WinForms.Styler.Controls.HeaderlessTabPage();
            this.headerlessTabPage4 = new iNKORE.UI.WinForms.Styler.Controls.HeaderlessTabPage();
            this.dragDropSign1 = new iNKORE.UI.WinForms.Styler.Controls.DragDropSign();
            this.headerlessTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(297, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(967, 60);
            this.header1.TabIndex = 1;
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.MaximumSize = new System.Drawing.Size(300, 0);
            this.NavBar.MinimumSize = new System.Drawing.Size(240, 720);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(297, 720);
            this.NavBar.TabIndex = 0;
            // 
            // headerlessTabPage1
            // 
            this.headerlessTabPage1.BackColor = System.Drawing.Color.Gold;
            this.headerlessTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.headerlessTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerlessTabPage1.Location = new System.Drawing.Point(0, 0);
            this.headerlessTabPage1.Name = "headerlessTabPage1";
            this.headerlessTabPage1.Size = new System.Drawing.Size(365, 282);
            this.headerlessTabPage1.TabIndex = 0;
            // 
            // headerlessTabPage2
            // 
            this.headerlessTabPage2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.headerlessTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerlessTabPage2.Location = new System.Drawing.Point(0, 0);
            this.headerlessTabPage2.Name = "headerlessTabPage2";
            this.headerlessTabPage2.Size = new System.Drawing.Size(365, 282);
            this.headerlessTabPage2.TabIndex = 0;
            // 
            // headerlessTabPage4
            // 
            this.headerlessTabPage4.Controls.Add(this.dragDropSign1);
            this.headerlessTabPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerlessTabPage4.Location = new System.Drawing.Point(0, 0);
            this.headerlessTabPage4.Name = "headerlessTabPage4";
            this.headerlessTabPage4.Size = new System.Drawing.Size(365, 282);
            this.headerlessTabPage4.TabIndex = 0;
            // 
            // dragDropSign1
            // 
            this.dragDropSign1.Location = new System.Drawing.Point(170, 114);
            this.dragDropSign1.Name = "dragDropSign1";
            this.dragDropSign1.Size = new System.Drawing.Size(25, 25);
            this.dragDropSign1.Style = iNKORE.UI.WinForms.Styler.Controls.DragDropSignStyle.Copy;
            this.dragDropSign1.TabIndex = 0;
            this.dragDropSign1.Text = "dragDropSign1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.NavBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "DVLD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.headerlessTabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.NavigationBar NavBar;
        private UserControls.Header header1;
        private iNKORE.UI.WinForms.Styler.Controls.HeaderlessTabPage headerlessTabPage1;
        private iNKORE.UI.WinForms.Styler.Controls.HeaderlessTabPage headerlessTabPage2;
        private iNKORE.UI.WinForms.Styler.Controls.HeaderlessTabPage headerlessTabPage4;
        private iNKORE.UI.WinForms.Styler.Controls.DragDropSign dragDropSign1;
    }
}

