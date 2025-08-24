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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pl_Body = new System.Windows.Forms.Panel();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.htc_tab_nav = new DVLD.CustomControls.HeaderlessTabControl();
            this.tab_local = new System.Windows.Forms.TabPage();
            this.roundedDataGridView2 = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.searchBar1 = new DVLD.UserControls.SearchBar();
            this.flp_footer = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_text = new System.Windows.Forms.Label();
            this.tab_international = new System.Windows.Forms.TabPage();
            this.searchBar2 = new DVLD.UserControls.SearchBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_text_driver = new System.Windows.Forms.Label();
            this.license_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.application_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiration_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pl_Body.SuspendLayout();
            this.htc_tab_nav.SuspendLayout();
            this.tab_local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedDataGridView2)).BeginInit();
            this.flp_footer.SuspendLayout();
            this.tab_international.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(20, 20);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(124, 29);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Licenses.";
            // 
            // pl_Body
            // 
            this.pl_Body.BackColor = System.Drawing.Color.Transparent;
            this.pl_Body.Controls.Add(this.htc_tab_nav);
            this.pl_Body.Controls.Add(this.tlp_header);
            this.pl_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Body.Location = new System.Drawing.Point(20, 49);
            this.pl_Body.Name = "pl_Body";
            this.pl_Body.Padding = new System.Windows.Forms.Padding(7, 10, 0, 0);
            this.pl_Body.Size = new System.Drawing.Size(760, 381);
            this.pl_Body.TabIndex = 3;
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
            // htc_tab_nav
            // 
            this.htc_tab_nav.Controls.Add(this.tab_local);
            this.htc_tab_nav.Controls.Add(this.tab_international);
            this.htc_tab_nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htc_tab_nav.ItemSize = new System.Drawing.Size(100, 24);
            this.htc_tab_nav.Location = new System.Drawing.Point(7, 10);
            this.htc_tab_nav.Name = "htc_tab_nav";
            this.htc_tab_nav.SelectedIndex = 0;
            this.htc_tab_nav.Size = new System.Drawing.Size(753, 371);
            this.htc_tab_nav.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.htc_tab_nav.TabIndex = 2;
            // 
            // tab_local
            // 
            this.tab_local.BackColor = System.Drawing.SystemColors.Control;
            this.tab_local.Controls.Add(this.roundedDataGridView2);
            this.tab_local.Controls.Add(this.searchBar1);
            this.tab_local.Controls.Add(this.flp_footer);
            this.tab_local.Location = new System.Drawing.Point(4, 28);
            this.tab_local.Name = "tab_local";
            this.tab_local.Padding = new System.Windows.Forms.Padding(3);
            this.tab_local.Size = new System.Drawing.Size(745, 339);
            this.tab_local.TabIndex = 0;
            this.tab_local.Text = "Local";
            // 
            // roundedDataGridView2
            // 
            this.roundedDataGridView2.AllowUserToAddRows = false;
            this.roundedDataGridView2.AllowUserToDeleteRows = false;
            this.roundedDataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.roundedDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roundedDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.roundedDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roundedDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.license_id,
            this.application_id,
            this.class_name,
            this.issue_date,
            this.expiration_date,
            this.is_active});
            this.roundedDataGridView2.CornerRadius = 15;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roundedDataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.roundedDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedDataGridView2.EnableHeadersVisualStyles = false;
            this.roundedDataGridView2.Location = new System.Drawing.Point(3, 53);
            this.roundedDataGridView2.Name = "roundedDataGridView2";
            this.roundedDataGridView2.ReadOnly = true;
            this.roundedDataGridView2.Size = new System.Drawing.Size(739, 233);
            this.roundedDataGridView2.TabIndex = 2;
            // 
            // searchBar1
            // 
            this.searchBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBar1.Location = new System.Drawing.Point(3, 3);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(739, 50);
            this.searchBar1.TabIndex = 1;
            // 
            // flp_footer
            // 
            this.flp_footer.Controls.Add(this.lb_footer_text);
            this.flp_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_footer.Location = new System.Drawing.Point(3, 286);
            this.flp_footer.Name = "flp_footer";
            this.flp_footer.Size = new System.Drawing.Size(739, 50);
            this.flp_footer.TabIndex = 0;
            // 
            // lb_footer_text
            // 
            this.lb_footer_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_text.Location = new System.Drawing.Point(3, 0);
            this.lb_footer_text.Name = "lb_footer_text";
            this.lb_footer_text.Size = new System.Drawing.Size(624, 50);
            this.lb_footer_text.TabIndex = 0;
            this.lb_footer_text.Text = "Total Number of People: ";
            this.lb_footer_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_international
            // 
            this.tab_international.BackColor = System.Drawing.SystemColors.Control;
            this.tab_international.Controls.Add(this.searchBar2);
            this.tab_international.Controls.Add(this.flowLayoutPanel1);
            this.tab_international.Location = new System.Drawing.Point(4, 28);
            this.tab_international.Name = "tab_international";
            this.tab_international.Padding = new System.Windows.Forms.Padding(3);
            this.tab_international.Size = new System.Drawing.Size(745, 339);
            this.tab_international.TabIndex = 1;
            this.tab_international.Text = "International";
            // 
            // searchBar2
            // 
            this.searchBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBar2.Location = new System.Drawing.Point(3, 3);
            this.searchBar2.Name = "searchBar2";
            this.searchBar2.Size = new System.Drawing.Size(739, 50);
            this.searchBar2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lb_footer_text_driver);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 286);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(739, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lb_footer_text_driver
            // 
            this.lb_footer_text_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_text_driver.Location = new System.Drawing.Point(3, 0);
            this.lb_footer_text_driver.Name = "lb_footer_text_driver";
            this.lb_footer_text_driver.Size = new System.Drawing.Size(624, 50);
            this.lb_footer_text_driver.TabIndex = 0;
            this.lb_footer_text_driver.Text = "Total Number of International Licenses: ";
            this.lb_footer_text_driver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // license_id
            // 
            this.license_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.license_id.HeaderText = "Licence ID";
            this.license_id.Name = "license_id";
            this.license_id.ReadOnly = true;
            // 
            // application_id
            // 
            this.application_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.application_id.HeaderText = "Application ID";
            this.application_id.Name = "application_id";
            this.application_id.ReadOnly = true;
            // 
            // class_name
            // 
            this.class_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.class_name.HeaderText = "Class Name";
            this.class_name.Name = "class_name";
            this.class_name.ReadOnly = true;
            // 
            // issue_date
            // 
            this.issue_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issue_date.HeaderText = "Issue Date";
            this.issue_date.Name = "issue_date";
            this.issue_date.ReadOnly = true;
            // 
            // expiration_date
            // 
            this.expiration_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expiration_date.HeaderText = "Expiration Date";
            this.expiration_date.Name = "expiration_date";
            this.expiration_date.ReadOnly = true;
            // 
            // is_active
            // 
            this.is_active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.is_active.HeaderText = "Is Active";
            this.is_active.Name = "is_active";
            this.is_active.ReadOnly = true;
            this.is_active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.Text = "Licenses.";
            this.pl_Body.ResumeLayout(false);
            this.pl_Body.PerformLayout();
            this.htc_tab_nav.ResumeLayout(false);
            this.tab_local.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundedDataGridView2)).EndInit();
            this.flp_footer.ResumeLayout(false);
            this.tab_international.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel pl_Body;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private CustomControls.HeaderlessTabControl htc_tab_nav;
        private System.Windows.Forms.TabPage tab_local;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView roundedDataGridView2;
        private UserControls.SearchBar searchBar1;
        private System.Windows.Forms.FlowLayoutPanel flp_footer;
        private System.Windows.Forms.Label lb_footer_text;
        private System.Windows.Forms.TabPage tab_international;
        private UserControls.SearchBar searchBar2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_footer_text_driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn application_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiration_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_active;
    }
}
