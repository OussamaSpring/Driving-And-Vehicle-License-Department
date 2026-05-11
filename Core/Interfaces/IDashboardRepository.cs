using Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IDashboardRepository
    {
        Task<DashboardStatisticsDto> GetStatisticsAsync();
        Task<IEnumerable<ApplicationTypeDto>> GetApplicationsByServiceTypeAsync();
        Task<IEnumerable<DetainedRevenueDto>> GetDetainedRevenueByMonthAsync();
        Task<IEnumerable<LicenseDistributionDto>> GetLicenseDistributionAsync();
        Task<IEnumerable<RecentTestResultDto>> GetRecentTestResultsAsync();
    }
}
