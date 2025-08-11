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
            // Default settings
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10F, FontStyle.Bold);

            this.DefaultCellStyle.BackColor = Color.White;
            this.DefaultCellStyle.ForeColor = Color.Black;
            this.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            this.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.DefaultCellStyle.Font = new Font("Roboto", 10F, FontStyle.Regular);

            this.BorderStyle = BorderStyle.None;
            this.BackgroundColor = Color.White;

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
