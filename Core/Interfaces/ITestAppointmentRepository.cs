using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ITestAppointmentRepository : IRepository<TestAppointment>
    {
        Task<TestAppointment> GetLatestByLocalDrivingLicenseApplicationIdAsync(int localDrivingLicenseApplicationId);
        Task<IEnumerable<TestAppointment>> GetByLocalDrivingLicenseApplicationIdAsync(int localDrivingLicenseApplicationId);

    }
}
