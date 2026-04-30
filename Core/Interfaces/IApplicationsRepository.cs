using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IApplicationsRepository : IReadOnlyRepository<Applications>
    {

        Task<int> AddNewInternationalLicenseApplicationAsync(Applications application, InternationalLicense localLicense);
        Task<bool> ReleaseDetainedDrivingLicenseAsync(Applications application, int detainId, int userId);
        Task<int> RenewExpiredDrivingLicenseAsync(Applications application, License renewedLicense, int oldLicenseId);
        Task<int> ReplaceDamagedDrivingLicenseAsync(Applications application, License replacementLicense, int oldLicenseId);
        Task<int> ReplaceLostDrivingLicenseAsync(Applications application, License replacementLicense, int oldLicenseId);

    }
}
