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

        public Task<IEnumerable<DetainedRevenueDto>> GetDetainedRevenueAsync()
        {
            return _dashboardRepository.GetDetainedRevenueByMonthAsync();
        }

        public Task<IEnumerable<LicenseDistributionDto>> GetLicenseDistributionAsync()
        {
            return _dashboardRepository.GetLicenseDistributionAsync();
        }

        public Task<IEnumerable<RecentTestResultDto>> GetRecentTestResultsAsync()
        {
            return _dashboardRepository.GetRecentTestResultsAsync();
        }
    }
}
