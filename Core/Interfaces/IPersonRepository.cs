using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Models;

namespace Core.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<Person> GetByNationalNumberAsync(string nationalNumber);
        Task<bool> IsPersonExist(int id);
        Task<bool> IsPersonExist(string nationalNumber);
        Task<byte[]> GetPhotoByIdAsync(int id);
        Task<bool> UpdatePhotoAsync(int id, byte[] photo);

        Task<IEnumerable<Country>> GetAllCountriesAsync();
        Task<Country> GetCountryByNameAsync(string countryName);
    }
}
