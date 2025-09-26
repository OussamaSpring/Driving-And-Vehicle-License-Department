using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVLD_BusinessLogic
{
    public class InternationalLicenseController
    {
        private readonly IInternationalLicenseRepository _internationalLicenseRepository;

        public InternationalLicenseController(IInternationalLicenseRepository internationalLicenseRepository)
        {
            _internationalLicenseRepository = internationalLicenseRepository;
        }

        public Task<InternationalLicense> GetInternationalLicenseByIdAsync(int id)
        {
            return _internationalLicenseRepository.GetByIdAsync(id);
        }

        public Task<IEnumerable<InternationalLicense>> GetInternationalLicensesListAsync()
        {
            return _internationalLicenseRepository.GetAllAsync();
        }

        public Task<int> AddInternationalLicenseAsync(InternationalLicense license)
        {
            return _internationalLicenseRepository.AddAsync(license);
        }

        public Task<bool> UpdateInternationalLicenseAsync(InternationalLicense license)
        {
            return _internationalLicenseRepository.UpdateAsync(license);
        }

        public Task<bool> DeleteInternationalLicenseAsync(int id)
        {
            return _internationalLicenseRepository.DeleteAsync(id);
        }

        public Task<InternationalLicense> GetInternationalLicenseByDriverIdAsync(int driverId)
        {
            return _internationalLicenseRepository.GetInternationalLicenseByDriverIdAsync(driverId);
        }

        public Task<InternationalLicense> GetInternationalLicenseByPersonIdAsync(int personId)
        {
            return _internationalLicenseRepository.GetInternationalLicenseByPersonIdAsync(personId);
        }

        public Task<bool> DesactivateInternationalLicenseAsync(int licenseId)
        {
            return _internationalLicenseRepository.DesactivateInternationalLicenseAsync(licenseId);
        }
    }
}
