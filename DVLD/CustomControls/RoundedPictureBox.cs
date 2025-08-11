using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace WindowsFormsControlLibrary.CustomControls
{

    public partial class RoundedPictureBox : PictureBox
    {
        private int _radius = 50; // Default

        [Category("Appearance"), Description("Corner radius for rounded edges.")]
        public int Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                this.Invalidate(); // Redraw control
            }
        }

        public RoundedPictureBox()
        {
            InitializeComponent();
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = GetRoundedPath(new Rectangle(0, 0, this.Width, this.Height), _radius))
            {
                this.Region = new Region(path);
                base.OnPaint(pe);

                // Optional: Border
                using (Pen borderPen = new Pen(Color.Gray, 2))
                {
                    pe.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }
            if (diameter > rect.Width) diameter = rect.Width;
            if (diameter > rect.Height) diameter = rect.Height;

            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));

            // Top-left corner
            path.AddArc(arcRect, 180, 90);

            // Top-right corner
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // Bottom-right corner
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // Bottom-left corner
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();
            return path;
        }
    }

}
