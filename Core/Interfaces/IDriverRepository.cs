using Core.Models;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IDriverRepository : IRepository<Driver>
    {
        Task<Driver> GetByPersonIdAsync(int id);
        Task<Driver> GetByNationalNumberAsync(string nationalNumber);
        Task<bool> IsDriverExist(int id);
    }
}
