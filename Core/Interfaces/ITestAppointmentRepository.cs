using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ITestAppointmentRepository : IRepository<TestAppointment>
    {
        Task<TestAppointment> GetLatestAppointmentByLDAndTestTypeIdAsync(int localDrivingLicenseApplicationId, int testTypeId);
        Task<IEnumerable<TestAppointment>> GetByLocalDrivingLicenseApplicationIdAsync(int localDrivingLicenseApplicationId);

    }
}
