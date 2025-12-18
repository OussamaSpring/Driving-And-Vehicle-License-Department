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

        #region HelpFunctions

        public List<string> GetInternationalLicenseFilterCriteria()
        {
            return new List<string>
            {
                "International License ID",
                "Application ID",
                "Driver ID",
                "Local License ID",
                "Issue Date",
                "Expiration Date",
                "Status",
                "Issued By User ID"
            };
        }


        #endregion

        public Task<InternationalLicense> GetInternationalLicenseByIdAsync(int id)
        {
            return _internationalLicenseRepository.GetByIdAsync(id);
        }

        public Task<IEnumerable<InternationalLicense>> GetInternationalLicensesListAsync()
        {
            return _internationalLicenseRepository.GetAllAsync();
        }

        public Task<InternationalLicense> GetInternationalLicenseByDriverIdAsync(int driverId)
        {
            return _internationalLicenseRepository.GetInternationalLicenseByDriverIdAsync(driverId);
        }

        public Task<InternationalLicense> GetInternationalLicenseByPersonIdAsync(int personId)
        {
            return _internationalLicenseRepository.GetInternationalLicenseByPersonIdAsync(personId);
        }

        public Task<IEnumerable<InternationalLicense>> GetInternationalLicenseListByPersonIdAsync(int personId)
        {
            return _internationalLicenseRepository.GetInternationalLicenseListByPersonIdAsync(personId);
        }

        public Task<IEnumerable<InternationalLicense>> GetInternationalLicenseListByDriverIdAsync(int driverId)
        {
            return _internationalLicenseRepository.GetInternationalLicenseListByDriverIdAsync(driverId);
        }

        public Task<bool> DesactivateInternationalLicenseAsync(int licenseId)
        {
            return _internationalLicenseRepository.DesactivateInternationalLicenseAsync(licenseId);
        }
    }
}
