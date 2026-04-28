using Core.Models;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ILocalDrivingLicenseRepository : IReadOnlyRepository<LocalDrivingLicenseApplication>
    {
        Task<int> AddNewLocalDrivingLicenseApplicationAsync(Applications application, int licenseClassId);
    }
}
