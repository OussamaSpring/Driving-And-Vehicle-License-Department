using Core.Models;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ITestRepository : IRepository<Test>
    {
        Task<int> GetTotalPassedTestCountAsync(int localDrivingLicenseApplicationId);
    }
}
