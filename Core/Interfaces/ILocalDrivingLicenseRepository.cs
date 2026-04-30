using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ILocalDrivingLicenseApplicationRepository : IReadOnlyRepository<LocalDrivingLicenseApplication>
    {
        Task<int> AddAsync(Applications application, int licenseClassId);
        Task<bool> DoesPassTestTypeAsync(int localDrivingLicenseApplicationId, int testTypeId);
        Task<int> GetTotalTrialsPerTestAsync(int localDrivingLicenseApplicationId, int testTypeId);
        Task<bool> IsThereActiveScheduledTestExistAsync(int localDrivingLicenseApplicationId, int testTypeId);
    }
}
