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
        // Task<bool> CancelLocalDrivingLicenseApplicationAsync(int id);


        //Task<bool> AddNewLocalDrivingLicenseApplicationAsync();
        //Task<int> IssueNewInternationalDrivingLicenseAsync();
        Task<bool> ReleaseDetainedDrivingLicenseAsync(Applications application, DetainedLicense detainedLicense);
        Task<int> RenewExpiredDrivingLicenseAsync(Applications application, License renewedLicnese);
        Task<int> ReplaceDamagedDrivingLicenseAsync(Applications application, License damagedLicnese);
        Task<int> ReplaceLostDrivingLicenseAsync(Applications application, License lostLicnese);

    }
}
