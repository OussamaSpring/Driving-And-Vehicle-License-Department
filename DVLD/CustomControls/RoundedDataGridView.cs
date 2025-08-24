using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary.CustomControls
{

    public partial class RoundedDataGridView : DataGridView
    {
        private int _cornerRadius = 15;

        [Category("Appearance")]
        [Description("Corner radius for rounded edges.")]
        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                _cornerRadius = value;
                UpdateRegion();
                Invalidate();
            }
        }

        public RoundedDataGridView()
        {
            InitializeComponent();
            // Windows 11-like theme: very light gray, smooth, no blue
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // Very light gray
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 60);    // Soft dark gray
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12F, FontStyle.Bold);
            this.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);

            this.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);              // Slightly lighter gray
            this.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);                 // Smooth dark gray
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 230);     // Light gray for selection
            this.DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40);        // Smooth dark gray
            this.DefaultCellStyle.Font = new Font("Roboto", 11F, FontStyle.Regular);

            this.BorderStyle = BorderStyle.None;
            this.BackgroundColor = Color.FromArgb(250, 250, 250);                         // Match background to cells


            // Set default column autosize mode to Fill for all columns
            foreach (DataGridViewColumn col in this.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.ColumnAdded += (s, e) => e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            // Make edges round
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            using (GraphicsPath path = GetRoundedRectanglePath(this.ClientRectangle, _cornerRadius))
            {
                this.Region = new Region(path);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateRegion();
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();
            Rectangle arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            // top left arc
            path.AddArc(arc, 180, 90);

            // top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }

}
