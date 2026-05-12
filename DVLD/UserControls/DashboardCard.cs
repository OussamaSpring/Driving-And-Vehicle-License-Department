using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DVLD.UserControls
{
    public partial class DashboardCard : UserControl
    {
        public enum CardType
        {
            RegisteredDrivers,
            ActiveLicenses,
            PendingApplications,
            ScheduledTests
        }

        private CardType _cardType;
        private int _cardValue;

        // Define card configurations
        private static readonly CardConfiguration[] CardConfigurations = new CardConfiguration[]
        {
            new CardConfiguration
            {
                Type = CardType.RegisteredDrivers,
                Title = "Registered Drivers",
                IconResourceName = "group",
                AccentColor = Color.FromArgb(212, 175, 55)
            },
            new CardConfiguration
            {
                Type = CardType.ActiveLicenses,
                Title = "Active Licenses",
                IconResourceName = "license",
                AccentColor = Color.FromArgb(26, 62, 114)
            },
            new CardConfiguration
            {
                Type = CardType.PendingApplications,
                Title = "Pending Applications",
                IconResourceName = "pending",
                AccentColor = Color.FromArgb(200, 100, 100)
            },
            new CardConfiguration
            {
                Type = CardType.ScheduledTests,
                Title = "Scheduled Tests",
                IconResourceName = "calendar_1",
                AccentColor = Color.FromArgb(100, 180, 100)
            }
        };

        public DashboardCard()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
            this.DoubleBuffered = true;
            SetRoundedRegion();
        }
        
        public void SetupCard(CardType cardType, int value)
        {
            _cardType = cardType;
            _cardValue = value;

            var config = GetCardConfiguration(cardType);
            if (config != null)
            {
                lb_title.Text = config.Title;
                lb_value.Text = value.ToString("N0");
                panel2.BackColor = config.AccentColor;

                // Set icon from resources
                try
                {
                    var resourceImage = Properties.Resources.ResourceManager.GetObject(config.IconResourceName);
                    if (resourceImage is Image img)
                    {
                        pb_icon.Image = img;
                    }
                }
                catch
                {
                    // Fallback to default image if resource not found
                    pb_icon.Image = Properties.Resources.AddPerson;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetRoundedRegion();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedRegion();
        }

        private void SetRoundedRegion()
        {
            if (this.Width > 0 && this.Height > 0)
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 18;

                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    this.Region = new Region(path);
                }
            }
        }


        private CardConfiguration GetCardConfiguration(CardType cardType)
        {
            foreach (var config in CardConfigurations)
            {
                if (config.Type == cardType)
                    return config;
            }
            return null;
        }

        // Override the OnPaint method to create rounded corners
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0214: // WM_SIZING
                case 0x0215: // WM_SIZE
                    SetRoundedRegion();
                    break;
            }
            base.WndProc(ref m);
        }

        private class CardConfiguration
        {
            public CardType Type { get; set; }
            public string Title { get; set; }
            public string IconResourceName { get; set; }
            public Color AccentColor { get; set; }
        }
    }
}
