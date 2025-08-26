namespace DVLD.Forms
{
    partial class ApplicationsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pl_Body = new System.Windows.Forms.Panel();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.htc_tab_nav = new DVLD.CustomControls.HeaderlessTabControl();
            this.tab_operations = new System.Windows.Forms.TabPage();
            this.tab_list = new System.Windows.Forms.TabPage();
            this.dgv_international_licenses = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.application_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.application_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBar2 = new DVLD.UserControls.SearchBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_text_driver = new System.Windows.Forms.Label();
            this.tab_types = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedDataGridView1 = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pl_Body.SuspendLayout();
            this.htc_tab_nav.SuspendLayout();
            this.tab_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_international_licenses)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tab_types.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(20, 20);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(167, 29);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Applications.";
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
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
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
            this.htc_tab_nav.Controls.Add(this.tab_operations);
            this.htc_tab_nav.Controls.Add(this.tab_list);
            this.htc_tab_nav.Controls.Add(this.tab_types);
            this.htc_tab_nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htc_tab_nav.ItemSize = new System.Drawing.Size(100, 24);
            this.htc_tab_nav.Location = new System.Drawing.Point(7, 10);
            this.htc_tab_nav.Name = "htc_tab_nav";
            this.htc_tab_nav.SelectedIndex = 0;
            this.htc_tab_nav.Size = new System.Drawing.Size(753, 371);
            this.htc_tab_nav.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.htc_tab_nav.TabIndex = 3;
            // 
            // tab_operations
            // 
            this.tab_operations.BackColor = System.Drawing.SystemColors.Control;
            this.tab_operations.Location = new System.Drawing.Point(4, 28);
            this.tab_operations.Name = "tab_operations";
            this.tab_operations.Padding = new System.Windows.Forms.Padding(3);
            this.tab_operations.Size = new System.Drawing.Size(745, 339);
            this.tab_operations.TabIndex = 0;
            this.tab_operations.Text = "Operations";
            // 
            // tab_list
            // 
            this.tab_list.BackColor = System.Drawing.SystemColors.Control;
            this.tab_list.Controls.Add(this.dgv_international_licenses);
            this.tab_list.Controls.Add(this.searchBar2);
            this.tab_list.Controls.Add(this.flowLayoutPanel1);
            this.tab_list.Location = new System.Drawing.Point(4, 28);
            this.tab_list.Name = "tab_list";
            this.tab_list.Padding = new System.Windows.Forms.Padding(3);
            this.tab_list.Size = new System.Drawing.Size(745, 339);
            this.tab_list.TabIndex = 1;
            this.tab_list.Text = "Applications List";
            // 
            // dgv_international_licenses
            // 
            this.dgv_international_licenses.AllowUserToAddRows = false;
            this.dgv_international_licenses.AllowUserToDeleteRows = false;
            this.dgv_international_licenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_international_licenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_international_licenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_international_licenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_international_licenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.application_id,
            this.person_id,
            this.application_type,
            this.date});
            this.dgv_international_licenses.CornerRadius = 15;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_international_licenses.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_international_licenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_international_licenses.EnableHeadersVisualStyles = false;
            this.dgv_international_licenses.Location = new System.Drawing.Point(3, 53);
            this.dgv_international_licenses.Name = "dgv_international_licenses";
            this.dgv_international_licenses.ReadOnly = true;
            this.dgv_international_licenses.Size = new System.Drawing.Size(739, 233);
            this.dgv_international_licenses.TabIndex = 4;
            // 
            // application_id
            // 
            this.application_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.application_id.HeaderText = "Application ID";
            this.application_id.Name = "application_id";
            this.application_id.ReadOnly = true;
            // 
            // person_id
            // 
            this.person_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.person_id.HeaderText = "Person ID";
            this.person_id.Name = "person_id";
            this.person_id.ReadOnly = true;
            // 
            // application_type
            // 
            this.application_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.application_type.HeaderText = "Application Type";
            this.application_type.Name = "application_type";
            this.application_type.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
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
            this.lb_footer_text_driver.Text = "Total Number of Applications:";
            this.lb_footer_text_driver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_types
            // 
            this.tab_types.BackColor = System.Drawing.SystemColors.Control;
            this.tab_types.Controls.Add(this.flowLayoutPanel2);
            this.tab_types.Controls.Add(this.roundedDataGridView1);
            this.tab_types.Location = new System.Drawing.Point(4, 28);
            this.tab_types.Name = "tab_types";
            this.tab_types.Size = new System.Drawing.Size(745, 339);
            this.tab_types.TabIndex = 2;
            this.tab_types.Text = "Applications Types";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 289);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(745, 50);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number of Applications Types:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedDataGridView1
            // 
            this.roundedDataGridView1.AllowUserToAddRows = false;
            this.roundedDataGridView1.AllowUserToDeleteRows = false;
            this.roundedDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.roundedDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roundedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.roundedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roundedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.fee});
            this.roundedDataGridView1.CornerRadius = 15;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roundedDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.roundedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedDataGridView1.EnableHeadersVisualStyles = false;
            this.roundedDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.roundedDataGridView1.Name = "roundedDataGridView1";
            this.roundedDataGridView1.ReadOnly = true;
            this.roundedDataGridView1.Size = new System.Drawing.Size(745, 339);
            this.roundedDataGridView1.TabIndex = 5;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // fee
            // 
            this.fee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fee.HeaderText = "Fee";
            this.fee.Name = "fee";
            this.fee.ReadOnly = true;
            // 
            // ApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pl_Body);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApplicationsForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Applications";
            this.Load += new System.EventHandler(this.ApplicationsForm_Load);
            this.pl_Body.ResumeLayout(false);
            this.pl_Body.PerformLayout();
            this.htc_tab_nav.ResumeLayout(false);
            this.tab_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_international_licenses)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tab_types.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel pl_Body;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private CustomControls.HeaderlessTabControl htc_tab_nav;
        private System.Windows.Forms.TabPage tab_operations;
        private System.Windows.Forms.TabPage tab_list;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_international_licenses;
        private UserControls.SearchBar searchBar2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_footer_text_driver;
        private System.Windows.Forms.TabPage tab_types;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView roundedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn application_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn person_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn application_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
    }
}
