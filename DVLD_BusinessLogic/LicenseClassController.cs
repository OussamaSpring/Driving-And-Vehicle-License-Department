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

        public Task<LicenseClass> GetLicenseClassByIdAsync(int id)
        {
            return _licenseClassRepository.GetByIdAsync(id);
        }

        public Task<IEnumerable<LicenseClass>> GetLicenseClassesListAsync()
        {
            return _licenseClassRepository.GetAllAsync();
        }

    }
}
