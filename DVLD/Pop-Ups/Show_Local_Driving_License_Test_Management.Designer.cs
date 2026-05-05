namespace DVLD.Pop_Ups
{
    partial class Local_Driving_License_Test_Management
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tc_test_appointments = new System.Windows.Forms.TabControl();
            this.tp_vision_test = new System.Windows.Forms.TabPage();
            this.flp_footer_local = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_vision_text = new System.Windows.Forms.Label();
            this.lb_vision_test_number = new System.Windows.Forms.Label();
            this.dgv_vision_test = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.vision_appointment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vision_appointment_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vision_paid_fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vision_is_locked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tp_written_test = new System.Windows.Forms.TabPage();
            this.dgv_written_test = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.flp_footer_international = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_footer_written_text = new System.Windows.Forms.Label();
            this.lb_written_test_number = new System.Windows.Forms.Label();
            this.tp_street_test = new System.Windows.Forms.TabPage();
            this.dgv_street_test = new WindowsFormsControlLibrary.CustomControls.RoundedDataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_street_test_number = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personDetailsCard = new DVLD.UserControls.PersonDetailsCard();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_passed_tests = new System.Windows.Forms.Label();
            this.lb_app_status = new System.Windows.Forms.Label();
            this.lb_app_date = new System.Windows.Forms.Label();
            this.lb_app_class = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_license_fees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_schedule_test = new DVLD.Views.Controls.RoundedButton();
            this.cmsActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_take_test = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_test_appointments.SuspendLayout();
            this.tp_vision_test.SuspendLayout();
            this.flp_footer_local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vision_test)).BeginInit();
            this.tp_written_test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_written_test)).BeginInit();
            this.flp_footer_international.SuspendLayout();
            this.tp_street_test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_street_test)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_test_appointments
            // 
            this.tc_test_appointments.Controls.Add(this.tp_vision_test);
            this.tc_test_appointments.Controls.Add(this.tp_written_test);
            this.tc_test_appointments.Controls.Add(this.tp_street_test);
            this.tc_test_appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_test_appointments.Location = new System.Drawing.Point(22, 653);
            this.tc_test_appointments.Multiline = true;
            this.tc_test_appointments.Name = "tc_test_appointments";
            this.tc_test_appointments.SelectedIndex = 0;
            this.tc_test_appointments.Size = new System.Drawing.Size(920, 260);
            this.tc_test_appointments.TabIndex = 8;
            this.tc_test_appointments.SelectedIndexChanged += new System.EventHandler(this.tc_test_appointments_SelectedIndexChanged);
            this.tc_test_appointments.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tc_test_appointments_Selecting);
            // 
            // tp_vision_test
            // 
            this.tp_vision_test.BackColor = System.Drawing.SystemColors.Control;
            this.tp_vision_test.Controls.Add(this.flp_footer_local);
            this.tp_vision_test.Controls.Add(this.dgv_vision_test);
            this.tp_vision_test.Location = new System.Drawing.Point(4, 27);
            this.tp_vision_test.Name = "tp_vision_test";
            this.tp_vision_test.Padding = new System.Windows.Forms.Padding(3);
            this.tp_vision_test.Size = new System.Drawing.Size(912, 229);
            this.tp_vision_test.TabIndex = 0;
            this.tp_vision_test.Text = "Vision Test";
            // 
            // flp_footer_local
            // 
            this.flp_footer_local.Controls.Add(this.lb_footer_vision_text);
            this.flp_footer_local.Controls.Add(this.lb_vision_test_number);
            this.flp_footer_local.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_footer_local.Location = new System.Drawing.Point(3, 196);
            this.flp_footer_local.Name = "flp_footer_local";
            this.flp_footer_local.Padding = new System.Windows.Forms.Padding(5);
            this.flp_footer_local.Size = new System.Drawing.Size(906, 30);
            this.flp_footer_local.TabIndex = 4;
            // 
            // lb_footer_vision_text
            // 
            this.lb_footer_vision_text.AutoSize = true;
            this.lb_footer_vision_text.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_vision_text.Location = new System.Drawing.Point(8, 5);
            this.lb_footer_vision_text.Name = "lb_footer_vision_text";
            this.lb_footer_vision_text.Size = new System.Drawing.Size(284, 19);
            this.lb_footer_vision_text.TabIndex = 0;
            this.lb_footer_vision_text.Text = "Total Number of Vision Appointments: ";
            // 
            // lb_vision_test_number
            // 
            this.lb_vision_test_number.AutoSize = true;
            this.lb_vision_test_number.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vision_test_number.Location = new System.Drawing.Point(298, 5);
            this.lb_vision_test_number.Name = "lb_vision_test_number";
            this.lb_vision_test_number.Size = new System.Drawing.Size(27, 19);
            this.lb_vision_test_number.TabIndex = 1;
            this.lb_vision_test_number.Text = "??";
            // 
            // dgv_vision_test
            // 
            this.dgv_vision_test.AllowUserToAddRows = false;
            this.dgv_vision_test.AllowUserToDeleteRows = false;
            this.dgv_vision_test.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_vision_test.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vision_test.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_vision_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vision_test.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vision_appointment_id,
            this.vision_appointment_date,
            this.vision_paid_fees,
            this.vision_is_locked});
            this.dgv_vision_test.ContextMenuStrip = this.cmsActions;
            this.dgv_vision_test.CornerRadius = 15;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vision_test.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_vision_test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vision_test.EnableHeadersVisualStyles = false;
            this.dgv_vision_test.Location = new System.Drawing.Point(3, 3);
            this.dgv_vision_test.Name = "dgv_vision_test";
            this.dgv_vision_test.ReadOnly = true;
            this.dgv_vision_test.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vision_test.Size = new System.Drawing.Size(906, 223);
            this.dgv_vision_test.TabIndex = 3;
            // 
            // vision_appointment_id
            // 
            this.vision_appointment_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vision_appointment_id.HeaderText = "Appointment ID";
            this.vision_appointment_id.Name = "vision_appointment_id";
            this.vision_appointment_id.ReadOnly = true;
            // 
            // vision_appointment_date
            // 
            this.vision_appointment_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vision_appointment_date.HeaderText = "Appointment Date";
            this.vision_appointment_date.Name = "vision_appointment_date";
            this.vision_appointment_date.ReadOnly = true;
            // 
            // vision_paid_fees
            // 
            this.vision_paid_fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vision_paid_fees.HeaderText = "Paid Fees";
            this.vision_paid_fees.Name = "vision_paid_fees";
            this.vision_paid_fees.ReadOnly = true;
            // 
            // vision_is_locked
            // 
            this.vision_is_locked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vision_is_locked.HeaderText = "Is Locked";
            this.vision_is_locked.Name = "vision_is_locked";
            this.vision_is_locked.ReadOnly = true;
            this.vision_is_locked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vision_is_locked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tp_written_test
            // 
            this.tp_written_test.BackColor = System.Drawing.SystemColors.Control;
            this.tp_written_test.Controls.Add(this.dgv_written_test);
            this.tp_written_test.Controls.Add(this.flp_footer_international);
            this.tp_written_test.Location = new System.Drawing.Point(4, 27);
            this.tp_written_test.Name = "tp_written_test";
            this.tp_written_test.Padding = new System.Windows.Forms.Padding(3);
            this.tp_written_test.Size = new System.Drawing.Size(912, 229);
            this.tp_written_test.TabIndex = 1;
            this.tp_written_test.Text = "Written Test";
            // 
            // dgv_written_test
            // 
            this.dgv_written_test.AllowUserToAddRows = false;
            this.dgv_written_test.AllowUserToDeleteRows = false;
            this.dgv_written_test.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_written_test.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_written_test.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_written_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_written_test.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.dgv_written_test.ContextMenuStrip = this.cmsActions;
            this.dgv_written_test.CornerRadius = 15;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_written_test.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_written_test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_written_test.EnableHeadersVisualStyles = false;
            this.dgv_written_test.Location = new System.Drawing.Point(3, 3);
            this.dgv_written_test.Name = "dgv_written_test";
            this.dgv_written_test.ReadOnly = true;
            this.dgv_written_test.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_written_test.Size = new System.Drawing.Size(906, 193);
            this.dgv_written_test.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Appointment ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Appointment Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Paid Fees";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Is Locked";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // flp_footer_international
            // 
            this.flp_footer_international.Controls.Add(this.lb_footer_written_text);
            this.flp_footer_international.Controls.Add(this.lb_written_test_number);
            this.flp_footer_international.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_footer_international.Location = new System.Drawing.Point(3, 196);
            this.flp_footer_international.Name = "flp_footer_international";
            this.flp_footer_international.Padding = new System.Windows.Forms.Padding(5);
            this.flp_footer_international.Size = new System.Drawing.Size(906, 30);
            this.flp_footer_international.TabIndex = 6;
            // 
            // lb_footer_written_text
            // 
            this.lb_footer_written_text.AutoSize = true;
            this.lb_footer_written_text.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer_written_text.Location = new System.Drawing.Point(8, 5);
            this.lb_footer_written_text.Name = "lb_footer_written_text";
            this.lb_footer_written_text.Size = new System.Drawing.Size(291, 19);
            this.lb_footer_written_text.TabIndex = 0;
            this.lb_footer_written_text.Text = "Total Number of Written Appointments: ";
            // 
            // lb_written_test_number
            // 
            this.lb_written_test_number.AutoSize = true;
            this.lb_written_test_number.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_written_test_number.Location = new System.Drawing.Point(305, 5);
            this.lb_written_test_number.Name = "lb_written_test_number";
            this.lb_written_test_number.Size = new System.Drawing.Size(27, 19);
            this.lb_written_test_number.TabIndex = 1;
            this.lb_written_test_number.Text = "??";
            // 
            // tp_street_test
            // 
            this.tp_street_test.BackColor = System.Drawing.SystemColors.Control;
            this.tp_street_test.Controls.Add(this.dgv_street_test);
            this.tp_street_test.Controls.Add(this.flowLayoutPanel1);
            this.tp_street_test.Location = new System.Drawing.Point(4, 27);
            this.tp_street_test.Name = "tp_street_test";
            this.tp_street_test.Padding = new System.Windows.Forms.Padding(3);
            this.tp_street_test.Size = new System.Drawing.Size(912, 229);
            this.tp_street_test.TabIndex = 2;
            this.tp_street_test.Text = "Street Test";
            // 
            // dgv_street_test
            // 
            this.dgv_street_test.AllowUserToAddRows = false;
            this.dgv_street_test.AllowUserToDeleteRows = false;
            this.dgv_street_test.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_street_test.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_street_test.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_street_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_street_test.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn2});
            this.dgv_street_test.ContextMenuStrip = this.cmsActions;
            this.dgv_street_test.CornerRadius = 15;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_street_test.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_street_test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_street_test.EnableHeadersVisualStyles = false;
            this.dgv_street_test.Location = new System.Drawing.Point(3, 3);
            this.dgv_street_test.Name = "dgv_street_test";
            this.dgv_street_test.ReadOnly = true;
            this.dgv_street_test.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_street_test.Size = new System.Drawing.Size(906, 193);
            this.dgv_street_test.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Appointment ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Appointment Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Paid Fees";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Is Locked";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.lb_street_test_number);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 196);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(906, 30);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Number of Street Appointments: ";
            // 
            // lb_street_test_number
            // 
            this.lb_street_test_number.AutoSize = true;
            this.lb_street_test_number.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_street_test_number.Location = new System.Drawing.Point(296, 5);
            this.lb_street_test_number.Name = "lb_street_test_number";
            this.lb_street_test_number.Size = new System.Drawing.Size(27, 19);
            this.lb_street_test_number.TabIndex = 1;
            this.lb_street_test_number.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Test Appointments:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.TakeTest;
            this.pictureBox1.Location = new System.Drawing.Point(22, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // personDetailsCard
            // 
            this.personDetailsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personDetailsCard.Location = new System.Drawing.Point(265, 86);
            this.personDetailsCard.Name = "personDetailsCard";
            this.personDetailsCard.Size = new System.Drawing.Size(677, 367);
            this.personDetailsCard.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(67, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "L.D.L Class: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(67, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "L.D.L Application Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(67, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "L.D.L Application Status: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(618, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Passed Tests: ";
            // 
            // lb_passed_tests
            // 
            this.lb_passed_tests.AutoSize = true;
            this.lb_passed_tests.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_passed_tests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_passed_tests.Location = new System.Drawing.Point(770, 535);
            this.lb_passed_tests.Name = "lb_passed_tests";
            this.lb_passed_tests.Size = new System.Drawing.Size(16, 18);
            this.lb_passed_tests.TabIndex = 13;
            this.lb_passed_tests.Text = "?";
            // 
            // lb_app_status
            // 
            this.lb_app_status.AutoSize = true;
            this.lb_app_status.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_app_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_app_status.Location = new System.Drawing.Point(272, 571);
            this.lb_app_status.Name = "lb_app_status";
            this.lb_app_status.Size = new System.Drawing.Size(16, 18);
            this.lb_app_status.TabIndex = 14;
            this.lb_app_status.Text = "?";
            // 
            // lb_app_date
            // 
            this.lb_app_date.AutoSize = true;
            this.lb_app_date.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_app_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_app_date.Location = new System.Drawing.Point(272, 535);
            this.lb_app_date.Name = "lb_app_date";
            this.lb_app_date.Size = new System.Drawing.Size(16, 18);
            this.lb_app_date.TabIndex = 15;
            this.lb_app_date.Text = "?";
            // 
            // lb_app_class
            // 
            this.lb_app_class.AutoSize = true;
            this.lb_app_class.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_app_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_app_class.Location = new System.Drawing.Point(272, 499);
            this.lb_app_class.Name = "lb_app_class";
            this.lb_app_class.Size = new System.Drawing.Size(16, 18);
            this.lb_app_class.TabIndex = 16;
            this.lb_app_class.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orchid;
            this.label6.Location = new System.Drawing.Point(227, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(523, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Local Driving License Test Management";
            // 
            // lb_license_fees
            // 
            this.lb_license_fees.AutoSize = true;
            this.lb_license_fees.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_license_fees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_license_fees.Location = new System.Drawing.Point(770, 499);
            this.lb_license_fees.Name = "lb_license_fees";
            this.lb_license_fees.Size = new System.Drawing.Size(16, 18);
            this.lb_license_fees.TabIndex = 19;
            this.lb_license_fees.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(618, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "License Fees: ";
            // 
            // btn_schedule_test
            // 
            this.btn_schedule_test.BackColor = System.Drawing.Color.Transparent;
            this.btn_schedule_test.BorderColor = System.Drawing.Color.Silver;
            this.btn_schedule_test.BorderRadius = 15;
            this.btn_schedule_test.BorderSize = 1;
            this.btn_schedule_test.FlatAppearance.BorderSize = 0;
            this.btn_schedule_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_schedule_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_schedule_test.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.btn_schedule_test.Image = global::DVLD.Properties.Resources.add;
            this.btn_schedule_test.Location = new System.Drawing.Point(899, 643);
            this.btn_schedule_test.Name = "btn_schedule_test";
            this.btn_schedule_test.Size = new System.Drawing.Size(36, 32);
            this.btn_schedule_test.TabIndex = 20;
            this.btn_schedule_test.UseVisualStyleBackColor = false;
            this.btn_schedule_test.Click += new System.EventHandler(this.btn_schedule_test_Click);
            // 
            // cmsActions
            // 
            this.cmsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_edit,
            this.tsmi_take_test});
            this.cmsActions.Name = "cmsActions";
            this.cmsActions.ShowImageMargin = false;
            this.cmsActions.Size = new System.Drawing.Size(113, 76);
            // 
            // tsmi_edit
            // 
            this.tsmi_edit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmi_edit.Name = "tsmi_edit";
            this.tsmi_edit.Padding = new System.Windows.Forms.Padding(6);
            this.tsmi_edit.Size = new System.Drawing.Size(124, 36);
            this.tsmi_edit.Text = "Edit";
            this.tsmi_edit.Click += new System.EventHandler(this.tsmi_edit_Click);
            // 
            // tsmi_take_test
            // 
            this.tsmi_take_test.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmi_take_test.Name = "tsmi_take_test";
            this.tsmi_take_test.Padding = new System.Windows.Forms.Padding(6);
            this.tsmi_take_test.Size = new System.Drawing.Size(124, 36);
            this.tsmi_take_test.Text = "Take Test";
            this.tsmi_take_test.Click += new System.EventHandler(this.tsmi_take_test_Click);
            // 
            // Local_Driving_License_Test_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 925);
            this.Controls.Add(this.btn_schedule_test);
            this.Controls.Add(this.lb_license_fees);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_app_class);
            this.Controls.Add(this.lb_app_date);
            this.Controls.Add(this.lb_app_status);
            this.Controls.Add(this.lb_passed_tests);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tc_test_appointments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.personDetailsCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Local_Driving_License_Test_Management";
            this.Text = "Local Driving License Test Management";
            this.Load += new System.EventHandler(this.Local_Driving_License_Test_Management_Load);
            this.tc_test_appointments.ResumeLayout(false);
            this.tp_vision_test.ResumeLayout(false);
            this.flp_footer_local.ResumeLayout(false);
            this.flp_footer_local.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vision_test)).EndInit();
            this.tp_written_test.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_written_test)).EndInit();
            this.flp_footer_international.ResumeLayout(false);
            this.flp_footer_international.PerformLayout();
            this.tp_street_test.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_street_test)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc_test_appointments;
        private System.Windows.Forms.TabPage tp_vision_test;
        private System.Windows.Forms.FlowLayoutPanel flp_footer_local;
        private System.Windows.Forms.Label lb_footer_vision_text;
        private System.Windows.Forms.Label lb_vision_test_number;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_vision_test;
        private System.Windows.Forms.TabPage tp_written_test;
        private System.Windows.Forms.FlowLayoutPanel flp_footer_international;
        private System.Windows.Forms.Label lb_footer_written_text;
        private System.Windows.Forms.Label lb_written_test_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.PersonDetailsCard personDetailsCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_passed_tests;
        private System.Windows.Forms.Label lb_app_status;
        private System.Windows.Forms.Label lb_app_date;
        private System.Windows.Forms.Label lb_app_class;
        private System.Windows.Forms.TabPage tp_street_test;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_license_fees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn vision_appointment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vision_appointment_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn vision_paid_fees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vision_is_locked;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_written_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private WindowsFormsControlLibrary.CustomControls.RoundedDataGridView dgv_street_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_street_test_number;
        private Views.Controls.RoundedButton btn_schedule_test;
        private System.Windows.Forms.ContextMenuStrip cmsActions;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_take_test;
    }
}