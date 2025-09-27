
using Core.Models;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ILicenseDetainRepository : IRepository<DetainedLicense>
    {
        Task<bool> IsLicenseDetainedAsync(int licenseId);
        Task<bool> ReleaseDetainedLicenseAsync(int detainId, int releasedByUserId, int releaseApplicationId);
    }
}
