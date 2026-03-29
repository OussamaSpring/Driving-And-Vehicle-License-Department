using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.CustomControls
{
    public partial class HeaderlessTabControl : TabControl
    {
        private bool _showTabHeaders = false;

        [Category("Appearance")]
        [Description("Show or hide tab headers (useful for design-time navigation).")]
        [DefaultValue(false)]
        public bool ShowTabHeaders
        {
            get => _showTabHeaders;
            set
            {
                _showTabHeaders = value;
                UpdateHeaderVisibility();
            }
        }

        public HeaderlessTabControl()
        {
            InitializeComponent();
            this.Multiline = false;
            this.SizeMode = TabSizeMode.Fixed;
            this.ItemSize = new Size(0, 1);
            UpdateHeaderVisibility();
        }

        private void UpdateHeaderVisibility()
        {
            if (_showTabHeaders || this.DesignMode)
            {
                this.ItemSize = new Size(100, 24); // Show headers
            }
            else
            {
                this.ItemSize = new Size(0, 1); // Hide headers
            }
        }

        protected override void WndProc(ref Message m)
        {
            // Hide the tab headers by skipping their paint message
            if (m.Msg == 0x1328 && !ShowTabHeaders && !this.DesignMode) // TCM_ADJUSTRECT
            {
                m.Result = (IntPtr)1;
                return;
            }
            base.WndProc(ref m);
        }
    }
}
