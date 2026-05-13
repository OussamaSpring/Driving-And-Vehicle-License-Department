

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DVLD.CustomControls
{

    public partial class SmoothProgressBar : Control
    {
        // ── Fields ──────────────────────────────────────────────
        private int _maximum = 100;
        private int _minimum = 0;
        private double _value = 0;
        private double _animatedValue = 0;
        private Color _barColor = Color.FromArgb(10, 36, 99);
        private Color _trackColor = Color.FromArgb(220, 228, 240);
        private int _cornerRadius = 6;
        private Timer _animTimer;
        private const double AnimSpeed = 0.08;

        // ── Constructor ─────────────────────────────────────────
        public SmoothProgressBar()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor,
                true);

            Height = 12;
            BackColor = Color.Transparent;

            _animTimer = new Timer { Interval = 16 }; // ~60 fps
            _animTimer.Tick += (s, e) =>
            {
                double target = NormalizedValue;
                _animatedValue += (target - _animatedValue) * AnimSpeed;

                if (Math.Abs(_animatedValue - target) < 0.001)
                {
                    _animatedValue = target;
                    _animTimer.Stop();
                }
                Invalidate();
            };
        }

        // ── Properties ──────────────────────────────────────────
        public int Maximum
        {
            get => _maximum;
            set { _maximum = value; Invalidate(); }
        }

        public int Minimum
        {
            get => _minimum;
            set { _minimum = value; Invalidate(); }
        }

        public double Value
        {
            get => _value;
            set
            {
                _value = Math.Max(_minimum, Math.Min(_maximum, value));
                _animTimer.Stop();
                _animTimer.Start();
            }
        }

        public Color BarColor
        {
            get => _barColor;
            set { _barColor = value; Invalidate(); }
        }

        public Color TrackColor
        {
            get => _trackColor;
            set { _trackColor = value; Invalidate(); }
        }

        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        private double NormalizedValue =>
            _maximum == _minimum ? 0 : (_value - _minimum) / (double)(_maximum - _minimum);

        // ── Paint ────────────────────────────────────────────────
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var bounds = new Rectangle(0, 0, Width - 1, Height - 1);

            // Track
            using (var trackBrush = new SolidBrush(_trackColor))
            using (var trackPath = RoundedRect(bounds, _cornerRadius))
                g.FillPath(trackBrush, trackPath);

            // Bar
            int barWidth = (int)(bounds.Width * _animatedValue);
            if (barWidth > _cornerRadius * 2)
            {
                var barRect = new Rectangle(bounds.X, bounds.Y, barWidth, bounds.Height);

                using (var barPath = RoundedRect(barRect, _cornerRadius))
                using (var barBrush = new LinearGradientBrush(
                    barRect,
                    LightenColor(_barColor, 20),
                    _barColor,
                    LinearGradientMode.Vertical))
                {
                    g.FillPath(barBrush, barPath);
                }

                // Subtle highlight shimmer on top edge
                using (var shimmerPath = RoundedRect(
                    new Rectangle(barRect.X + 2, barRect.Y + 1, barRect.Width - 4, barRect.Height / 2),
                    _cornerRadius - 1))
                using (var shimmer = new LinearGradientBrush(
                    new Rectangle(barRect.X, barRect.Y, barRect.Width, barRect.Height / 2),
                    Color.FromArgb(40, 255, 255, 255),
                    Color.Transparent,
                    LinearGradientMode.Vertical))
                {
                    g.FillPath(shimmer, shimmerPath);
                }
            }
        }

        // ── Helpers ─────────────────────────────────────────────
        private static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            radius = Math.Min(radius, Math.Min(bounds.Width, bounds.Height) / 2);
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private static Color LightenColor(Color color, int amount)
        {
            return Color.FromArgb(
                color.A,
                Math.Min(255, color.R + amount),
                Math.Min(255, color.G + amount),
                Math.Min(255, color.B + amount));
        }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing) _animTimer?.Dispose();
        //        base.Dispose(disposing);
        //    }
        //}


        // ──────────────────────────────────────────────────────────
        // 2. LicenseDistributionPanel
        // ──────────────────────────────────────────────────────────

        /// <summary>
        /// Represents a single row: label, count, and progress bar.
        /// </summary>
        public class LicenseRow
        {
            public string Label { get; set; } = "";
            public int Value { get; set; }
            public Color BarColor { get; set; } = Color.FromArgb(10, 36, 99);
        }

        /// <summary>
        /// The full "License Distribution" card control.
        /// Drop it on a form, set its Rows collection, and call Refresh().
        /// </summary>
        public class LicenseDistributionPanel : Panel
        {
            // ── Palette ─────────────────────────────────────────────
            private static readonly Color CardBackground = Color.White;
            private static readonly Color CardBorder = Color.FromArgb(220, 228, 240);
            private static readonly Color TitleColor = Color.FromArgb(10, 36, 99);
            private static readonly Color LabelColor = Color.FromArgb(30, 50, 90);
            private static readonly Color ValueColor = Color.FromArgb(10, 36, 99);
            private static readonly Color TrackColor = Color.FromArgb(220, 228, 240);
            private static readonly Color DividerColor = Color.FromArgb(230, 235, 245);

            // ── Default color set cycling for bars ──────────────────
            private static readonly Color[] DefaultBarColors =
            {
            Color.FromArgb(10,  36,  99),   // dark navy
            Color.FromArgb(133, 109,  0),   // olive/gold
            Color.FromArgb(20,  70, 160),   // medium blue
            Color.FromArgb(100,  82,  0),   // darker olive
        };

            // ── State ────────────────────────────────────────────────
            private List<LicenseRow> _rows = new();
            private string _title = "License Distribution";

            // ── Constructor ─────────────────────────────────────────
            public LicenseDistributionPanel()
            {
                SetStyle(
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw,
                    true);

                Padding = new Padding(0);
                BackColor = Color.Transparent;
                Size = new Size(420, 320);
            }

            // ── Public API ──────────────────────────────────────────
            public string Title
            {
                get => _title;
                set { _title = value; RebuildRows(); }
            }

            public List<LicenseRow> Rows
            {
                get => _rows;
                set { _rows = value ?? new(); RebuildRows(); }
            }

            /// <summary>Call after changing Rows to rebuild internal controls.</summary>
            public new void Refresh()
            {
                RebuildRows();
                base.Refresh();
            }

            // ── Internal rebuild ─────────────────────────────────────
            private void RebuildRows()
            {
                SuspendLayout();
                Controls.Clear();

                int maxValue = 1;
                foreach (var r in _rows)
                    if (r.Value > maxValue) maxValue = r.Value;

                int cardPadH = 24;
                int cardPadTop = 20;
                int titleHeight = 44;       // area for title + divider
                int rowHeight = 60;
                int barHeight = 10;

                int totalHeight = cardPadTop + titleHeight + _rows.Count * rowHeight + cardPadH;
                Height = totalHeight;

                int y = cardPadTop + titleHeight;

                for (int i = 0; i < _rows.Count; i++)
                {
                    var row = _rows[i];
                    Color barColor = row.BarColor != Color.Empty
                        ? row.BarColor
                        : DefaultBarColors[i % DefaultBarColors.Length];

                    // Label
                    var lbl = new Label
                    {
                        Text = row.Label,
                        Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                        ForeColor = LabelColor,
                        BackColor = Color.Transparent,
                        AutoSize = false,
                        Left = cardPadH,
                        Top = y,
                        Width = Width - cardPadH * 2 - 80,
                        Height = 20,
                        TextAlign = ContentAlignment.MiddleLeft
                    };
                    Controls.Add(lbl);

                    // Value
                    var val = new Label
                    {
                        Text = row.Value.ToString("N0"),
                        Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                        ForeColor = ValueColor,
                        BackColor = Color.Transparent,
                        AutoSize = false,
                        Left = Width - cardPadH - 75,
                        Top = y,
                        Width = 75,
                        Height = 20,
                        TextAlign = ContentAlignment.MiddleRight
                    };
                    Controls.Add(val);

                    // Progress bar
                    var bar = new SmoothProgressBar
                    {
                        Left = cardPadH,
                        Top = y + 24,
                        Width = Width - cardPadH * 2,
                        Height = barHeight,
                        Minimum = 0,
                        Maximum = maxValue,
                        BarColor = barColor,
                        TrackColor = TrackColor,
                        CornerRadius = barHeight / 2,
                        Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
                    };
                    Controls.Add(bar);

                    // Animate in with a small delay per row
                    int capturedValue = row.Value;
                    var t = new Timer { Interval = 80 + i * 120 };
                    t.Tick += (s, e) =>
                    {
                        bar.Value = capturedValue;
                        t.Stop();
                        t.Dispose();
                    };
                    t.Start();

                    y += rowHeight;
                }

                ResumeLayout(true);
            }

            // ── Paint the card shell ─────────────────────────────────
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                var cardRect = new Rectangle(0, 0, Width - 1, Height - 1);
                int r = 14;

                // Drop shadow (layered semi-transparent rectangles)
                for (int s = 4; s >= 1; s--)
                {
                    using var shadowBrush = new SolidBrush(Color.FromArgb(12 * s, 0, 30, 80));
                    using var shadowPath = RoundedRect(
                        new Rectangle(cardRect.X + s, cardRect.Y + s, cardRect.Width, cardRect.Height), r);
                    g.FillPath(shadowBrush, shadowPath);
                }

                // Card fill
                using var bgBrush = new SolidBrush(CardBackground);
                using var cardPath = RoundedRect(cardRect, r);
                g.FillPath(bgBrush, cardPath);

                // Card border
                using var borderPen = new Pen(CardBorder, 1);
                g.DrawPath(borderPen, cardPath);

                // Title
                int padH = 24;
                int titleY = 20;
                using var titleFont = new Font("Segoe UI", 12f, FontStyle.Bold);
                g.DrawString(_title, titleFont, new SolidBrush(TitleColor),
                    new RectangleF(padH, titleY, Width - padH * 2, 28));

                // Divider
                int divY = titleY + 36;
                using var divPen = new Pen(DividerColor, 1);
                g.DrawLine(divPen, padH - 4, divY, Width - padH + 4, divY);
            }

            protected override void OnResize(EventArgs e)
            {
                base.OnResize(e);
                RebuildRows();
            }

            // ── Helper ───────────────────────────────────────────────
            private static GraphicsPath RoundedRect(Rectangle bounds, int radius)
            {
                int d = radius * 2;
                radius = Math.Min(radius, Math.Min(bounds.Width / 2, bounds.Height / 2));
                d = radius * 2;
                var path = new GraphicsPath();
                path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
                path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
                path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
                path.CloseFigure();
                return path;
            }
        }
    }
}