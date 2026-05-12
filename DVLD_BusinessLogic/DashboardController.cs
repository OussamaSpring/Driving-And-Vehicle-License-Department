using Core.DTOs;
using Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVLD_BusinessLogic
{
    public class DashboardController
    {
        private readonly IDashboardRepository _dashboardRepository;

        public DashboardController(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }

        public Task<DashboardStatisticsDto> GetStatisticsAsync()
        {
            return _dashboardRepository.GetStatisticsAsync();
        }

        public Task<IEnumerable<ApplicationTypeDto>> GetApplicationsByServiceTypeAsync()
        {
            return _dashboardRepository.GetApplicationsByServiceTypeAsync();
        }

        // This method retrieves the detained revenue data for the dashboard, which includes the month name, count of detained licenses, and the associated revenue (last 6 months).
        public Task<IEnumerable<DetainedRevenueDto>> GetDetainedRevenueAsync()
        {
            return _dashboardRepository.GetDetainedRevenueByMonthAsync();
        }

        public Task<IEnumerable<LicenseDistributionDto>> GetLicenseDistributionAsync()
        {
            return _dashboardRepository.GetLicenseDistributionAsync();
        }

        // This method retrieves the recent test results for the dashboard, which includes the application name, test result, and test date (last 10 results).
        public Task<IEnumerable<RecentTestResultDto>> GetRecentTestResultsAsync()
        {
            return _dashboardRepository.GetRecentTestResultsAsync();
        }
    }
}
