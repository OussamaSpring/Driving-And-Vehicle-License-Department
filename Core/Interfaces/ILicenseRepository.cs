

using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ILicenseRepository : IRepository<License>
    {
        Task<IEnumerable<License>> GetLicensesByDriverIdAsync(int id);
        Task<IEnumerable<License>> GetLicensesByPersonIdAsync(int id);
        Task<bool> DesactivateLicenseAsync(int id);

    }
}
