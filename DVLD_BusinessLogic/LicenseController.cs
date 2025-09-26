using Core.Interfaces;
using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVLD_BusinessLogic
{
    public class LicenseController
    {
        private readonly ILicenseRepository _licenseRepository;

        public LicenseController(ILicenseRepository licenseRepository)
        {
            _licenseRepository = licenseRepository;
        }

        public Task<License> GetLicenseByIdAsync(int id)
        {
            return _licenseRepository.GetByIdAsync(id);
        }

        public Task<IEnumerable<License>> GetLicensesListAsync()
        {
            return _licenseRepository.GetAllAsync();
        }

        public Task<int> AddLicenseAsync(License license)
        {
            return _licenseRepository.AddAsync(license);
        }

        public Task<bool> UpdateLicenseAsync(License license)
        {
            return _licenseRepository.UpdateAsync(license);
        }

        public Task<bool> DeleteLicenseAsync(int id)
        {
            return _licenseRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<License>> GetLicensesByDriverIdAsync(int driverId)
        {
            return _licenseRepository.GetLicensesByDriverIdAsync(driverId);
        }

        public Task<IEnumerable<License>> GetLicensesByPersonIdAsync(int personId)
        {
            return _licenseRepository.GetLicensesByPersonIdAsync(personId);
        }

        public Task<bool> DesactivateLicenseAsync(int licenseId)
        {
            return _licenseRepository.DesactivateLicenseAsync(licenseId);
        }
    }
}
