using DVLD.UserControls;
using DVLD.CustomControls;
using DVLD_BusinessLogic;
using DVLD_DataAccess.Repositories;
using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DVLD.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly DashboardController _dashboardController;

        private static readonly Color[] LicenseClassColors =
        {
            Color.FromArgb(26, 62, 114),   // Class 1 - deep blue
            Color.FromArgb(212, 175, 55),  // Class 2 - gold
            Color.FromArgb(46, 134, 171),  // Class 3 - teal blue
            Color.FromArgb(100, 180, 100), // Class 4 - green
            Color.FromArgb(255, 140, 0),   // Class 5 - orange
            Color.FromArgb(123, 104, 238), // Class 6 - purple
            Color.FromArgb(220, 20, 60)    // Class 7 - crimson
        };

        public DashboardForm()
        {
            InitializeComponent();
            _dashboardController = new DashboardController(new DashboardRepository());
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            await LoadDashboardStatistics();
            await LoadApplicationsByType();
            await LoadDetainedLicenseRevenue();
            await LoadLicenseDistribution();
            await LoadRecentTestResults();
            ConfigureResponsiveness();
        }

        private async Task LoadDashboardStatistics()
        {
            try
            {
                var statistics = await _dashboardController.GetStatisticsAsync();

                card_RegisteredDrivers.SetupCard(
                    DashboardCard.CardType.RegisteredDrivers,
                    statistics.RegisteredDrivers);

                card_ActiveLicenses.SetupCard(
                    DashboardCard.CardType.ActiveLicenses,
                    statistics.ActiveLicenses);

                card_PendingApplications.SetupCard(
                    DashboardCard.CardType.PendingApplications,
                    statistics.PendingApplications);

                card_ScheduledTests.SetupCard(
                    DashboardCard.CardType.ScheduledTests,
                    statistics.ScheduledTests);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading statistics: {ex.Message}");
            }
        }

        private async Task LoadApplicationsByType()
        {
            try
            {
                var applications = await _dashboardController.GetApplicationsByServiceTypeAsync();
                ConfigureApplicationsChart(applications);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading applications by type: {ex.Message}");
            }
        }

        private async Task LoadDetainedLicenseRevenue()
        {
            try
            {
                var revenueData = await _dashboardController.GetDetainedRevenueAsync();
                ConfigureDetainedLicenseRevenueChart(revenueData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading detained license revenue: {ex.Message}");
            }
        }

        private async Task LoadLicenseDistribution()
        {
            try
            {
                var licenseDistribution = await _dashboardController.GetLicenseDistributionAsync();
                ConfigureLicenseDistribution(licenseDistribution);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading license distribution: {ex.Message}");
            }
        }

        private async Task LoadRecentTestResults()
        {
            try
            {
                var testResults = await _dashboardController.GetRecentTestResultsAsync();
                PopulateRecentTestResultsDataGrid(testResults);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading recent test results: {ex.Message}");
            }
        }

        private void btn_manage_tests_Click(object sender, EventArgs e)
        {
            // Get the main form (parent MDI container)
            MainForm mainForm = this.MdiParent as MainForm;

            if (mainForm != null)
            {
                // Navigate to Test Management using the new public method
                mainForm.NavigateTo(NavigationBar.NavBarIems.enTestManagement);
            }
        }

        #region Chart Configuration

        private void ConfigureApplicationsChart(IEnumerable<ApplicationTypeDto> applications)
        {
            chart_applications_by_type.Series.Clear();
            chart_applications_by_type.ChartAreas.Clear();
            chart_applications_by_type.Legends.Clear();
            chart_applications_by_type.Annotations.Clear();

            ChartArea area = new ChartArea();
            area.BackColor = Color.White;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            chart_applications_by_type.ChartAreas.Add(area);

            Legend legend = new Legend();
            legend.Docking = Docking.Right;
            legend.BackColor = Color.White;
            legend.Font = new Font("Segoe UI", 10);
            legend.BorderColor = Color.LightGray;
            legend.BorderWidth = 1;

            chart_applications_by_type.Legends.Add(legend);

            Series series = new Series();
            series.ChartType = SeriesChartType.Doughnut;

            int totalApplications = 0;
            var applicationsList = applications.ToList();

            // Add data points without labels on pie
            foreach (var app in applicationsList)
            {
                series.Points.AddXY(app.ApplicationTypeName, app.TotalApplications);
                totalApplications += app.TotalApplications;
            }

            // Configure series
            series.IsValueShownAsLabel = false;  // Don't show values on pie
            series["PieLabelStyle"] = "Disabled"; // Disable labels on pie
            series["DoughnutRadius"] = "40";
            series.BorderWidth = 2;
            series.BorderColor = Color.White;
            series.Palette = ChartColorPalette.None;

            // Set custom colors for points and create legend labels with names and values
            int colorIndex = 0;
            Color[] colors = new Color[] {
                Color.FromArgb(26, 62, 114),      // Dark Blue
                Color.FromArgb(212, 175, 55),     // Gold
                Color.FromArgb(200, 210, 230),    // Light Blue
                Color.FromArgb(130, 130, 130),    // Gray
                Color.FromArgb(100, 180, 100),    // Green
                Color.FromArgb(255, 140, 0),      // Orange
                Color.FromArgb(220, 20, 60)       // Crimson
            };

            int pointIndex = 0;
            foreach (var point in series.Points)
            {
                point.Color = colors[colorIndex % colors.Length];
                // Set the legend label to include both name and value
                point.LegendText = $"{applicationsList[pointIndex].ApplicationTypeName}: {point.YValues[0]:N0}";
                colorIndex++;
                pointIndex++;
            }

            chart_applications_by_type.Series.Add(series);
            chart_applications_by_type.BackColor = Color.White;

            // Add total in center of doughnut - Fixed positioning
            TextAnnotation annotation = new TextAnnotation();
            annotation.Text = $"Total\n{totalApplications:N0}";
            annotation.X = 50;
            annotation.Y = 50;
            annotation.Alignment = ContentAlignment.MiddleCenter;
            annotation.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            annotation.ForeColor = Color.FromArgb(26, 62, 114);
            annotation.AnchorAlignment = ContentAlignment.MiddleCenter;
            annotation.ClipToChartArea = "ChartArea1";

            chart_applications_by_type.Annotations.Add(annotation);
        }

        private void ConfigureDetainedLicenseRevenueChart(IEnumerable<Core.DTOs.DetainedRevenueDto> revenueData)
        {
            chart_detained_license_revenue.Series.Clear();
            chart_detained_license_revenue.ChartAreas.Clear();
            chart_detained_license_revenue.Legends.Clear();

            ChartArea area = new ChartArea();
            area.BackColor = Color.White;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.Title = "Month";
            area.AxisY.Title = "Revenue ($)";
            area.AxisX.TitleFont = new Font("Segoe UI", 10);
            area.AxisY.TitleFont = new Font("Segoe UI", 10);

            chart_detained_license_revenue.ChartAreas.Add(area);

            Legend legend = new Legend();
            legend.Docking = Docking.Bottom;
            legend.BackColor = Color.White;
            legend.Font = new Font("Segoe UI", 10);

            chart_detained_license_revenue.Legends.Add(legend);

            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Name = "Revenue";

            // Get current month and go back 6 months
            DateTime now = DateTime.Now;
            var monthsData = new Dictionary<string, decimal>();

            // Initialize all 6 months with 0
            for (int i = 5; i >= 0; i--)
            {
                DateTime monthDate = now.AddMonths(-i);
                string monthName = monthDate.ToString("MMMM");
                monthsData[monthName] = 0;
            }

            // Update with actual data
            foreach (var revenue in revenueData)
            {
                if (monthsData.ContainsKey(revenue.MonthName))
                {
                    monthsData[revenue.MonthName] = revenue.Revenue;
                }
            }

            // Add points to series in order
            foreach (var month in monthsData)
            {
                series.Points.AddXY(month.Key, month.Value);
            }

            series.IsValueShownAsLabel = true;
            series.BorderWidth = 1;
            series.BorderColor = Color.White;
            series.Color = Color.FromArgb(212, 175, 55);

            chart_detained_license_revenue.Series.Add(series);
            chart_detained_license_revenue.BackColor = Color.White;
        }

        #endregion

        #region DataGrid Configuration

        private void PopulateRecentTestResultsDataGrid(IEnumerable<Core.DTOs.RecentTestResultDto> testResults)
        {
            dtg_recent_test_results.Rows.Clear();

            foreach (var testResult in testResults)
            {
                int rowIndex = dtg_recent_test_results.Rows.Add();
                DataGridViewRow row = dtg_recent_test_results.Rows[rowIndex];

                row.Cells[0].Value = testResult.ApplicantName;
                row.Cells[1].Value = testResult.TestType;
                row.Cells[2].Value = testResult.Result == "1" ? "PASSED" : "FAILED";
                row.Cells[3].Value = testResult.TestDate.ToString("yyyy-MM-dd HH:mm");

                // Color the result cell
                if (testResult.Result == "1")
                {
                    row.Cells[2].Style.BackColor = Color.FromArgb(144, 238, 144); // Light Green
                    row.Cells[2].Style.ForeColor = Color.FromArgb(0, 100, 0);     // Dark Green
                    row.Cells[2].Style.Font = new Font("Roboto", 11, FontStyle.Bold);
                }
                else
                {
                    row.Cells[2].Style.BackColor = Color.FromArgb(255, 182, 182); // Light Red
                    row.Cells[2].Style.ForeColor = Color.FromArgb(139, 0, 0);     // Dark Red
                    row.Cells[2].Style.Font = new Font("Roboto", 11, FontStyle.Bold);
                }
            }
        }

        #endregion

        #region License Distribution Configuration

        private void ConfigureLicenseDistribution(IEnumerable<LicenseDistributionDto> licenseDistribution)
        {
            var itemsByClass = (licenseDistribution ?? Enumerable.Empty<LicenseDistributionDto>())
                .Select(ParseLicenseDistributionItem)
                .Where(item => item.ClassNumber >= 1 && item.ClassNumber <= 7)
                .GroupBy(item => item.ClassNumber)
                .ToDictionary(group => group.Key, group => group.First());

            int totalLicenses = itemsByClass.Values.Sum(item => item.TotalLicenses);

            ConfigureLicenseClassSlot(pb_class1, lb_class1, lb_value1, GetLicenseClassSlotData(itemsByClass, 1), totalLicenses);
            ConfigureLicenseClassSlot(pb_class2, lb_class2, lb_value2, GetLicenseClassSlotData(itemsByClass, 2), totalLicenses);
            ConfigureLicenseClassSlot(pb_class3, lb_class3, lb_value3, GetLicenseClassSlotData(itemsByClass, 3), totalLicenses);
            ConfigureLicenseClassSlot(pb_class4, lb_class4, lb_value4, GetLicenseClassSlotData(itemsByClass, 4), totalLicenses);
            ConfigureLicenseClassSlot(pb_class5, lb_class5, lb_value5, GetLicenseClassSlotData(itemsByClass, 5), totalLicenses);
            ConfigureLicenseClassSlot(pb_class6, lb_class6, lb_value6, GetLicenseClassSlotData(itemsByClass, 6), totalLicenses);
            ConfigureLicenseClassSlot(pb_class7, lb_class7, lb_value7, GetLicenseClassSlotData(itemsByClass, 7), totalLicenses);
        }

        private void ConfigureLicenseClassSlot(SmoothProgressBar progressBar, Label classLabel, Label valueLabel, LicenseDistributionItem item, int totalLicenses)
        {
            progressBar.Maximum = 100;
            progressBar.Minimum = 0;
            progressBar.BarColor = GetLicenseClassColor(item.ClassNumber);
            progressBar.Value = totalLicenses > 0
                ? (item.TotalLicenses * 100.0) / totalLicenses
                : 0;

            classLabel.Text = string.IsNullOrWhiteSpace(item.DisplayName)
                ? $"Class {item.ClassNumber}"
                : item.DisplayName;

            valueLabel.Text = item.TotalLicenses.ToString("N0");
        }

        private static LicenseDistributionItem ParseLicenseDistributionItem(LicenseDistributionDto dto)
        {
            if (dto == null)
            {
                return new LicenseDistributionItem();
            }

            int classNumber = 0;
            string displayName = dto.LicenseClassName ?? string.Empty;

            const string prefix = "Class ";
            const string separator = " - ";

            if (!string.IsNullOrWhiteSpace(displayName) && displayName.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                int separatorIndex = displayName.IndexOf(separator, StringComparison.Ordinal);
                if (separatorIndex > prefix.Length)
                {
                    string classNumberText = displayName.Substring(prefix.Length, separatorIndex - prefix.Length).Trim();
                    int.TryParse(classNumberText, out classNumber);
                    displayName = displayName.Substring(separatorIndex + separator.Length).Trim();
                }
            }

            return new LicenseDistributionItem
            {
                ClassNumber = classNumber,
                DisplayName = displayName,
                TotalLicenses = dto.TotalLicenses
            };
        }

        private static LicenseDistributionItem GetLicenseClassSlotData(Dictionary<int, LicenseDistributionItem> itemsByClass, int classNumber)
        {
            if (itemsByClass != null && itemsByClass.TryGetValue(classNumber, out var item))
            {
                return item;
            }

            return new LicenseDistributionItem
            {
                ClassNumber = classNumber,
                DisplayName = string.Empty,
                TotalLicenses = 0
            };
        }

        private static Color GetLicenseClassColor(int classNumber)
        {
            int index = Math.Max(1, Math.Min(7, classNumber)) - 1;
            return LicenseClassColors[index];
        }

        private sealed class LicenseDistributionItem
        {
            public int ClassNumber { get; set; }
            public string DisplayName { get; set; } = string.Empty;
            public int TotalLicenses { get; set; }
        }

        #endregion

        #region Responsiveness Configuration

        private void ConfigureResponsiveness()
        {
            // Configure minimum and maximum sizes for charts section
            tlp_charts.MinimumSize = new Size(0, 330);
            tlp_charts.MaximumSize = new Size(0, 480);
            tlp_charts.AutoSize = false;
            tlp_charts.Height = 360;

            // Configure minimum and maximum sizes for bottom section (recent tests + license distribution)
            tlp_chart2.MinimumSize = new Size(0, 330);
            tlp_chart2.MaximumSize = new Size(0, 480);
            tlp_chart2.AutoSize = false;
            tlp_chart2.Height = 410;

            // Ensure panels adjust properly
            pl_applications_by_type.AutoSize = false;
            pl_applications_by_type.Dock = DockStyle.Fill;

            pl_detained_license_revenue.AutoSize = false;
            pl_detained_license_revenue.Dock = DockStyle.Fill;

            pl_license_distribution_body.AutoSize = false;
            pl_license_distribution_body.Dock = DockStyle.Fill;

            pl_recent_test_results.AutoSize = false;
            pl_recent_test_results.Dock = DockStyle.Fill;

            // Ensure DataGridView adjusts to available space
            dtg_recent_test_results.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Subscribe to form resize events for dynamic responsiveness
            this.Resize += DashboardForm_Resize;
        }

        private void DashboardForm_Resize(object sender, EventArgs e)
        {
            // Dynamically adjust sizes based on window size
            if (this.Width < 1024)
            {
                // Small screens
                tlp_charts.MinimumSize = new Size(0, 330);
                tlp_charts.Height = 360;
                tlp_chart2.MinimumSize = new Size(0, 330);
                tlp_chart2.Height = 410;
            }
            else if (this.Width >= 1024 && this.Width < 1280)
            {
                // Medium screens
                tlp_charts.MinimumSize = new Size(0, 360);
                tlp_charts.Height = 400;
                tlp_chart2.MinimumSize = new Size(0, 360);
                tlp_chart2.Height = 450;
            }
            else
            {
                // Large screens
                tlp_charts.MinimumSize = new Size(0, 380);
                tlp_charts.Height = 420;
                tlp_chart2.MinimumSize = new Size(0, 380);
                tlp_chart2.Height = 470;
            }
        }

        #endregion


    }
}