using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary.CustomControls
{

    [DefaultEvent("Click")]
    public partial class FlatButton : Button
    {
        // Fields
        private Color _hoverColor = Color.FromArgb(243, 243, 243);
        private Color _defaultColor = Color.Transparent;
        private Color _pressedColor = Color.FromArgb(230, 230, 230);
        private bool _hovering;
        private bool _pressed;

        // Constructor
        public FlatButton()
        {
            InitializeComponent();

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = _defaultColor;
            this.ForeColor = Color.FromArgb(0, 102, 204);
            this.Cursor = Cursors.Hand;
            this.Padding = new Padding(10, 5, 10, 5);

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.UserPaint, true);
        }

        // Properties
        [Category("Appearance")]
        public Color HoverColor
        {
            get => _hoverColor;
            set { _hoverColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color PressedColor
        {
            get => _pressedColor;
            set { _pressedColor = value; Invalidate(); }
        }

        // Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color backColor;
            if (!Enabled) backColor = Color.Transparent;
            else if (_pressed) backColor = _pressedColor;
            else if (_hovering) backColor = _hoverColor;
            else backColor = _defaultColor;

            // Draw background
            using (var brush = new SolidBrush(backColor))
            {
                graphics.FillRectangle(brush, ClientRectangle);
            }

            // Draw text
            var textColor = Enabled ? ForeColor : Color.Gray;
            TextRenderer.DrawText(
                graphics,
                Text,
                Font,
                ClientRectangle,
                textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _hovering = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hovering = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                _pressed = true;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _pressed = false;
            Invalidate();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }
    }


}
