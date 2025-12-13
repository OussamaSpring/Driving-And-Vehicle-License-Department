
using Core.Models;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ILicenseDetainRepository : IReadOnlyRepository<DetainedLicense>
    {
        Task<bool> IsLicenseDetainedAsync(int licenseId);
    }
}
