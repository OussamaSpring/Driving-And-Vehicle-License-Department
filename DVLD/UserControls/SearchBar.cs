using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DVLD.UserControls
{
    public class FilterArgs : EventArgs
    {
        public string FilterCriteria { get; }
        public string SearchText { get; }

        public FilterArgs(string filterCriteria, string searchText)
        {
            FilterCriteria = filterCriteria;
            SearchText = searchText;
        }
    }


    public partial class SearchBar : UserControl
    {
        public delegate void ButtonEvent();
        public ButtonEvent AddButtonClicked;

        public EventHandler<FilterArgs> FilterPerformed;

        public SearchBar()
        {
            InitializeComponent();
            cb_filter_criteria.SelectedIndexChanged += cb_filter_criteria_SelectedIndexChanged;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false; // Disable button to prevent multiple clicks
            try
            {
                AddButtonClicked?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the add action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_add.Enabled = true;
            }
        }
        public void btn_add_Hide()
        {
            btn_add.Visible = false;
        }
        public void FillFilterCriteria(List<string> list)
        {
            cb_filter_criteria.Items.Clear();
            cb_filter_criteria.Items.Add("None");
            cb_filter_criteria.SelectedIndex = 0;

            if (list == null)
                return;

            foreach (var item in list)
            {
                cb_filter_criteria.Items.Add(item);
            }
        }
        private void cb_filter_criteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnFilterChanged();
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            OnFilterChanged();
        }
        protected virtual void OnFilterChanged()
        {
            string filterCriteria = cb_filter_criteria.SelectedItem?.ToString() ?? "None";
            string searchText = txt_search.Text;

            FilterPerformed?.Invoke(this, new FilterArgs(filterCriteria, searchText));
        }
    }
}
