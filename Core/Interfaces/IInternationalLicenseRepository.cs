using Core.Models;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IInternationalLicenseRepository : IRepository<InternationalLicense>
    {

        Task<InternationalLicense> GetInternationalLicenseByDriverIdAsync(int id);
        Task<InternationalLicense> GetInternationalLicenseByPersonIdAsync(int id);
        Task<bool> DesactivateInternationalLicenseAsync(int id);

    }
}
