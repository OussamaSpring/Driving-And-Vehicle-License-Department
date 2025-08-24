namespace DVLD.UserControls
{
    partial class SearchBar
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
            this.flp_body = new System.Windows.Forms.FlowLayoutPanel();
            this.txtB_search = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_filter_criteria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flp_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_body
            // 
            this.flp_body.Controls.Add(this.txtB_search);
            this.flp_body.Controls.Add(this.cb_filter_criteria);
            this.flp_body.Controls.Add(this.label1);
            this.flp_body.Controls.Add(this.btn_add);
            this.flp_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_body.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp_body.Location = new System.Drawing.Point(0, 0);
            this.flp_body.Name = "flp_body";
            this.flp_body.Padding = new System.Windows.Forms.Padding(10);
            this.flp_body.Size = new System.Drawing.Size(685, 50);
            this.flp_body.TabIndex = 0;
            // 
            // txtB_search
            // 
            this.txtB_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_search.Location = new System.Drawing.Point(415, 10);
            this.txtB_search.Margin = new System.Windows.Forms.Padding(0);
            this.txtB_search.MaxLength = 40;
            this.txtB_search.Multiline = true;
            this.txtB_search.Name = "txtB_search";
            this.txtB_search.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtB_search.Size = new System.Drawing.Size(250, 30);
            this.txtB_search.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Image = global::DVLD.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(136, 10);
            this.btn_add.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(30, 30);
            this.btn_add.TabIndex = 1;
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // cb_filter_criteria
            // 
            this.cb_filter_criteria.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filter_criteria.FormattingEnabled = true;
            this.cb_filter_criteria.Location = new System.Drawing.Point(254, 12);
            this.cb_filter_criteria.Margin = new System.Windows.Forms.Padding(0, 2, 10, 0);
            this.cb_filter_criteria.Name = "cb_filter_criteria";
            this.cb_filter_criteria.Size = new System.Drawing.Size(151, 27);
            this.cb_filter_criteria.TabIndex = 2;
            this.cb_filter_criteria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 6, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter By:";
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_body);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(685, 50);
            this.flp_body.ResumeLayout(false);
            this.flp_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_body;
        private System.Windows.Forms.TextBox txtB_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_filter_criteria;
        private System.Windows.Forms.Label label1;
    }
}
