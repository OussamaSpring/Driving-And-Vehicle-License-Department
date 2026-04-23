using Core.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IApplicationsRepository : IReadOnlyRepository<Applications>
    {
        // Special get functions for L.D.L applications
        Task<LocalDrivingLicenseApplication> GetLocalDrivingLicenseApplicationByIdAsync(int id);
        Task<IEnumerable<LocalDrivingLicenseApplication>> GetAllLocalDrivingLicenseApplicationsAsync();
        // Task<bool> CancelLocalDrivingLicenseApplicationAsync(int appId);


        Task<int> AddNewLocalDrivingLicenseApplicationAsync(Applications application, int licenseClassId);
        Task<bool> ReleaseDetainedDrivingLicenseAsync(Applications application, int detainId, int userId);
        Task<int> RenewExpiredDrivingLicenseAsync(Applications application, License renewedLicense, int oldLicenseId);
        Task<int> ReplaceDamagedDrivingLicenseAsync(Applications application, License replacementLicense, int oldLicenseId);
        Task<int> ReplaceLostDrivingLicenseAsync(Applications application, License replacementLicense, int oldLicenseId);

    }
}
