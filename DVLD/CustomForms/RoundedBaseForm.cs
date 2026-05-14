using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DVLD.CustomForms
{
    public partial class RoundedBaseForm : Form
    {
        private int borderRadius = 30;
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        private bool _enableDragging = true;

        public RoundedBaseForm()
        {
            // No border, so we control the shape
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;
            this.Padding = new Padding(2);

            // Center on screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Apply rounded region on resize
            this.Resize += RoundedBaseForm_Resize;

            // Add mouse event handlers for dragging
            this.MouseDown += RoundedBaseForm_MouseDown;
            this.MouseUp += RoundedBaseForm_MouseUp;
            this.MouseMove += RoundedBaseForm_MouseMove;
        }

        protected void RoundedBaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (_enableDragging && e.Button == MouseButtons.Left)
            {
                _dragging = true;
                _startPoint = new Point(e.X, e.Y);
            }
        }

        protected void RoundedBaseForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        protected void RoundedBaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_enableDragging && _dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
            }
        }

        private void RoundedBaseForm_Resize(object sender, EventArgs e)
        {
            ApplyRoundedRegion();
        }

        private void ApplyRoundedRegion()
        {
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            using (GraphicsPath path = GetRoundedRectanglePath(bounds, borderRadius))
            {
                this.Region?.Dispose();
                this.Region = new Region(path);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            if (radius > 0)
            {
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();
            }
            else
            {
                path.AddRectangle(rect);
            }

            return path;
        }

        [Category("Appearance")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                ApplyRoundedRegion();
            }
        }

        [Category("Behavior")]
        [DefaultValue(true)]
        [Description("Determines whether the form can be dragged by the user")]
        public bool EnableDragging
        {
            get => _enableDragging;
            set => _enableDragging = value;
        }
    }
}