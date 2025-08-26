namespace DVLD.Forms
{
    partial class LicenseDetainForm
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.pl_Body = new System.Windows.Forms.Panel();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.htc_tab_nav = new DVLD.CustomControls.HeaderlessTabControl();
            this.tab_operations = new System.Windows.Forms.TabPage();
            this.tab_detain_list = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar2 = new DVLD.UserControls.SearchBar();
            this.roundedDataGridView1 = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.detain_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detain_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fine_fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_by_user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_released = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.release_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.released_by_user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.release_application_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pl_Body.SuspendLayout();
            this.htc_tab_nav.SuspendLayout();
            this.tab_detain_list.SuspendLayout();
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
            this.lb_Title.Size = new System.Drawing.Size(194, 29);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "License Detain.";
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
            this.htc_tab_nav.Controls.Add(this.tab_operations);
            this.htc_tab_nav.Controls.Add(this.tab_detain_list);
            this.htc_tab_nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htc_tab_nav.ItemSize = new System.Drawing.Size(100, 24);
            this.htc_tab_nav.Location = new System.Drawing.Point(7, 10);
            this.htc_tab_nav.Name = "htc_tab_nav";
            this.htc_tab_nav.SelectedIndex = 0;
            this.htc_tab_nav.Size = new System.Drawing.Size(753, 371);
            this.htc_tab_nav.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.htc_tab_nav.TabIndex = 4;
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
            // tab_detain_list
            // 
            this.tab_detain_list.BackColor = System.Drawing.SystemColors.Control;
            this.tab_detain_list.Controls.Add(this.roundedDataGridView1);
            this.tab_detain_list.Controls.Add(this.searchBar2);
            this.tab_detain_list.Controls.Add(this.flowLayoutPanel2);
            this.tab_detain_list.Location = new System.Drawing.Point(4, 28);
            this.tab_detain_list.Name = "tab_detain_list";
            this.tab_detain_list.Padding = new System.Windows.Forms.Padding(3);
            this.tab_detain_list.Size = new System.Drawing.Size(745, 339);
            this.tab_detain_list.TabIndex = 2;
            this.tab_detain_list.Text = "Detain List";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 286);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(739, 50);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number of Detains: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchBar2
            // 
            this.searchBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBar2.Location = new System.Drawing.Point(3, 3);
            this.searchBar2.Name = "searchBar2";
            this.searchBar2.Size = new System.Drawing.Size(739, 50);
            this.searchBar2.TabIndex = 5;
            // 
            // roundedDataGridView1
            // 
            this.roundedDataGridView1.AllowUserToAddRows = false;
            this.roundedDataGridView1.AllowUserToDeleteRows = false;
            this.roundedDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.roundedDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roundedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.roundedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roundedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detain_id,
            this.license_id,
            this.detain_date,
            this.fine_fees,
            this.created_by_user_id,
            this.is_released,
            this.release_date,
            this.released_by_user_id,
            this.release_application_id});
            this.roundedDataGridView1.CornerRadius = 15;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roundedDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.roundedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedDataGridView1.EnableHeadersVisualStyles = false;
            this.roundedDataGridView1.Location = new System.Drawing.Point(3, 53);
            this.roundedDataGridView1.Name = "roundedDataGridView1";
            this.roundedDataGridView1.ReadOnly = true;
            this.roundedDataGridView1.Size = new System.Drawing.Size(739, 233);
            this.roundedDataGridView1.TabIndex = 6;
            // 
            // detain_id
            // 
            this.detain_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detain_id.HeaderText = "Detain ID";
            this.detain_id.Name = "detain_id";
            this.detain_id.ReadOnly = true;
            // 
            // license_id
            // 
            this.license_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.license_id.HeaderText = "License ID";
            this.license_id.Name = "license_id";
            this.license_id.ReadOnly = true;
            // 
            // detain_date
            // 
            this.detain_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detain_date.HeaderText = "Detain Date";
            this.detain_date.Name = "detain_date";
            this.detain_date.ReadOnly = true;
            // 
            // fine_fees
            // 
            this.fine_fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fine_fees.HeaderText = "Fine Fees";
            this.fine_fees.Name = "fine_fees";
            this.fine_fees.ReadOnly = true;
            // 
            // created_by_user_id
            // 
            this.created_by_user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.created_by_user_id.HeaderText = "Created by User ID";
            this.created_by_user_id.Name = "created_by_user_id";
            this.created_by_user_id.ReadOnly = true;
            // 
            // is_released
            // 
            this.is_released.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.is_released.HeaderText = "Is Released";
            this.is_released.Name = "is_released";
            this.is_released.ReadOnly = true;
            this.is_released.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_released.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // release_date
            // 
            this.release_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.release_date.HeaderText = "Release Date";
            this.release_date.Name = "release_date";
            this.release_date.ReadOnly = true;
            // 
            // released_by_user_id
            // 
            this.released_by_user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.released_by_user_id.HeaderText = "Released by User ID";
            this.released_by_user_id.Name = "released_by_user_id";
            this.released_by_user_id.ReadOnly = true;
            // 
            // release_application_id
            // 
            this.release_application_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.release_application_id.HeaderText = "Release Application ID";
            this.release_application_id.Name = "release_application_id";
            this.release_application_id.ReadOnly = true;
            // 
            // LicenseDetainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pl_Body);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LicenseDetainForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "License Detain";
            this.Load += new System.EventHandler(this.LicenseDetainForm_Load);
            this.pl_Body.ResumeLayout(false);
            this.pl_Body.PerformLayout();
            this.htc_tab_nav.ResumeLayout(false);
            this.tab_detain_list.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tab_detain_list;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView roundedDataGridView1;
        private UserControls.SearchBar searchBar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn detain_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn detain_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine_fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_by_user_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_released;
        private System.Windows.Forms.DataGridViewTextBoxColumn release_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn released_by_user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn release_application_id;
    }
}
