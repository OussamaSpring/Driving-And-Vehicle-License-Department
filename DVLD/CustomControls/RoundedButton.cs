using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Views.Controls
{
    public partial class RoundedButton: Button
    {
        private int borderRadius = 20;
        private int borderSize = 0;
        private Color borderColor = Color.Black;

        public RoundedButton()
        {
            InitializeComponent();
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = ColorTranslator.FromHtml("#D4AF37");
            this.ForeColor = ColorTranslator.FromHtml("#1A3E72");
            this.Size = new Size(150, 40);
            this.Resize += (s, e) => this.Invalidate();
            this.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }


        [Category("Appearance")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);

            using (GraphicsPath pathSurface = GetRoundedRectanglePath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetRoundedRectanglePath(rectBorder, borderRadius - borderSize))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                // Set button region (true rounded button)
                this.Region = new Region(pathSurface);

                // Draw surface
                pevent.Graphics.FillPath(new SolidBrush(this.BackColor), pathSurface);

                // Draw border if borderSize >= 1
                if (borderSize >= 1)
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
            }

            // Draw text
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, rectSurface, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
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
    }
}
