namespace DVLD.Forms
{
    partial class LicensesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lb_Title = new System.Windows.Forms.Label();
            this.pl_Body = new System.Windows.Forms.Panel();
            this.headerlessTabControl1 = new iNKORE.UI.WinForms.Styler.Controls.HeaderlessTabControl();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.pl_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(20, 20);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(116, 29);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Licenses";
            // 
            // pl_Body
            // 
            this.pl_Body.BackColor = System.Drawing.Color.Transparent;
            this.pl_Body.Controls.Add(this.headerlessTabControl1);
            this.pl_Body.Controls.Add(this.tlp_header);
            this.pl_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Body.Location = new System.Drawing.Point(20, 49);
            this.pl_Body.Name = "pl_Body";
            this.pl_Body.Padding = new System.Windows.Forms.Padding(7, 10, 0, 0);
            this.pl_Body.Size = new System.Drawing.Size(760, 381);
            this.pl_Body.TabIndex = 3;
            // 
            // headerlessTabControl1
            // 
            this.headerlessTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerlessTabControl1.Location = new System.Drawing.Point(7, 10);
            this.headerlessTabControl1.Name = "headerlessTabControl1";
            this.headerlessTabControl1.SelectedIndex = -1;
            this.headerlessTabControl1.SelectedTab = null;
            this.headerlessTabControl1.Size = new System.Drawing.Size(753, 371);
            this.headerlessTabControl1.TabIndex = 1;
            this.headerlessTabControl1.Text = "headerlessTabControl1";
            // 
            // tlp_header
            // 
            this.tlp_header.AutoSize = true;
            this.tlp_header.ColumnCount = 3;
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlp_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_header.Location = new System.Drawing.Point(7, 10);
            this.tlp_header.Name = "tlp_header";
            this.tlp_header.RowCount = 1;
            this.tlp_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_header.Size = new System.Drawing.Size(753, 0);
            this.tlp_header.TabIndex = 0;
            // 
            // LicensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pl_Body);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LicensesForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Licenses";
            this.pl_Body.ResumeLayout(false);
            this.pl_Body.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel pl_Body;
        private iNKORE.UI.WinForms.Styler.Controls.HeaderlessTabControl headerlessTabControl1;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
    }
}
