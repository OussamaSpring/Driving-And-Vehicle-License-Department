using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IInternationalLicenseRepository : IReadOnlyRepository<InternationalLicense>
    {

        Task<InternationalLicense> GetInternationalLicenseByDriverIdAsync(int id);
        Task<InternationalLicense> GetInternationalLicenseByPersonIdAsync(int id);
        Task<IEnumerable<InternationalLicense>> GetInternationalLicenseListByPersonIdAsync(int id);
        Task<IEnumerable<InternationalLicense>> GetInternationalLicenseListByDriverIdAsync(int id);
        Task<bool> DesactivateInternationalLicenseAsync(int id);

    }
}
