
using DVLD.Views.Controls;
using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

namespace DVLD.UserControls
{

    [DefaultEvent("SelectedIndexChanged")]
    public partial class TabBar : UserControl
    {
        private TableLayoutPanel _table;
        private readonly List<Button> _buttons = new List<Button>();
        private readonly List<string> _items = new List<string>();
        private int _selectedIndex = -1;

        // Colors (defaults from your request)
        private Color _panelBackColor = Color.FromArgb(235, 235, 235);   // #EBEBEB
        private Color _buttonDefaultColor = Color.FromArgb(235, 235, 235);
        private Color _buttonHoverColor = Color.FromArgb(202, 202, 202); // #CACACA
        private Color _buttonActiveColor = Color.FromArgb(245, 247, 250); // #F5F7FA

        public event EventHandler SelectedIndexChanged;

        [Category("Appearance"), Description("Background color of the tab container")]
        public Color PanelBackColor
        {
            get => _panelBackColor;
            set { _panelBackColor = value; this.BackColor = value; }
        }

        [Category("Appearance"), Description("Default button background color")]
        public Color ButtonDefaultColor { get => _buttonDefaultColor; set { _buttonDefaultColor = value; UpdateAllButtonColors(); } }

        [Category("Appearance"), Description("Button hover color")]
        public Color ButtonHoverColor { get => _buttonHoverColor; set => _buttonHoverColor = value; }

        [Category("Appearance"), Description("Button active color")]
        public Color ButtonActiveColor { get => _buttonActiveColor; set { _buttonActiveColor = value; UpdateAllButtonColors(); } }

        [Browsable(false)]
        public IReadOnlyList<string> Items => _items.AsReadOnly();

        [Browsable(false)]
        public int SelectedIndex
        {
            get => _selectedIndex;
            set => SetSelectedIndex(value);
        }

        [Browsable(false)]
        public string SelectedTab => (_selectedIndex >= 0 && _selectedIndex < _items.Count) ? _items[_selectedIndex] : null;

        public TabBar()
        {
            InitializeComponent();
            InitializeTableLayout();
            // defaults
            this.BackColor = _panelBackColor;
            this.Padding = new Padding(6);   // inner gutter like your design
            this.Height = 48;

            // try to set Roboto if available, but don't crash if not installed
            try { this.Font = new Font("Roboto", 10F, FontStyle.Regular); } catch { /* fallback to default */ }
        }

        private void InitializeTableLayout()
        {
            _table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                BackColor = Color.Transparent,
            };
            _table.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            this.Controls.Add(_table);
        }

        /// <summary>Provide tabs as strings and rebuild the UI (call from designer code or runtime)</summary>
        public void SetTabs(params string[] tabs)
        {
            _items.Clear();
            if (tabs != null) _items.AddRange(tabs);
            BuildButtons();
        }

        private void BuildButtons()
        {
            // cleanup
            foreach (var b in _buttons)
            {
                b.Click -= Tab_Click;
                b.MouseEnter -= Tab_MouseEnter;
                b.MouseLeave -= Tab_MouseLeave;
                b.Dispose();
            }
            _buttons.Clear();
            _table.Controls.Clear();
            _table.ColumnStyles.Clear();
            _table.ColumnCount = Math.Max(1, _items.Count);

            if (_items.Count == 0)
            {
                this.Visible = false;
                return;
            }
            this.Visible = true;

            float percent = 100f / _items.Count;
            for (int i = 0; i < _items.Count; i++)
            {
                _table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percent));
                var btn = CreateTabButton(_items[i], i);
                _buttons.Add(btn);
                _table.Controls.Add(btn, i, 0);
            }

            // keep selected index valid
            if (_selectedIndex >= _items.Count) _selectedIndex = -1;
            SetSelectedIndex(_selectedIndex >= 0 ? _selectedIndex : 0); // default select first
        }

        private Button CreateTabButton(string text, int index)
        {
            var btn = new RoundedButton
            {
                BorderRadius = 8,
                Text = text,
                Dock = DockStyle.Fill,
                Margin = new Padding(6, 3, 6, 3), // adjust spacing visually
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                BackColor = _buttonDefaultColor,
                ForeColor = Color.Black,
                Font = this.Font,
                TextAlign = ContentAlignment.MiddleCenter,
                Tag = index
            };

            btn.Click += Tab_Click;
            btn.MouseEnter += Tab_MouseEnter;
            btn.MouseLeave += Tab_MouseLeave;

            return btn;
        }

        private void Tab_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn && (int)btn.Tag != _selectedIndex)
                btn.BackColor = _buttonDefaultColor;
        }

        private void Tab_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn && (int)btn.Tag != _selectedIndex)
                btn.BackColor = _buttonHoverColor;
        }

        private void Tab_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                int idx = (int)btn.Tag;
                SetSelectedIndex(idx);
            }
        }

        private void SetSelectedIndex(int idx)
        {
            if (_items.Count == 0) return;

            if (idx < 0) idx = 0;
            if (idx >= _items.Count) idx = _items.Count - 1;

            _selectedIndex = idx;

            for (int i = 0; i < _buttons.Count; i++)
            {
                var b = _buttons[i];
                if (i == _selectedIndex)
                {
                    b.BackColor = _buttonActiveColor;
                    b.Font = new Font(this.Font, FontStyle.Bold);
                }
                else
                {
                    b.BackColor = _buttonDefaultColor;
                    b.Font = new Font(this.Font, FontStyle.Regular);
                }
            }

            SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateAllButtonColors()
        {
            foreach (var b in _buttons)
            {
                b.BackColor = _buttonDefaultColor;
            }

            if (_selectedIndex >= 0 && _selectedIndex < _buttons.Count)
                _buttons[_selectedIndex].BackColor = _buttonActiveColor;
        }
    }

}
