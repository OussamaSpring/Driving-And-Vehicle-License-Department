using Core.Interfaces;
using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVLD_BusinessLogic
{
    public class LicenseClassController
    {
        private readonly ILicenseClassRepository _licenseClassRepository;

        public LicenseClassController(ILicenseClassRepository licenseClassRepository)
        {
            _licenseClassRepository = licenseClassRepository;
        }

        public Task<LicenseClass> GetByIdAsync(int id)
        {
            return _licenseClassRepository.GetByIdAsync(id);
        }

        public Task<IEnumerable<LicenseClass>> GetAllAsync()
        {
            return _licenseClassRepository.GetAllAsync();
        }

        public Task<int> AddAsync(LicenseClass licenseClass)
        {
            return _licenseClassRepository.AddAsync(licenseClass);
        }

        public Task<bool> UpdateAsync(LicenseClass licenseClass)
        {
            return _licenseClassRepository.UpdateAsync(licenseClass);
        }

        public Task<bool> DeleteAsync(int id)
        {
            return _licenseClassRepository.DeleteAsync(id);
        }
    }
}
