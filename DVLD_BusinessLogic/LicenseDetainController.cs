using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;

namespace DVLD_BusinessLogic
{
    public class LicenseDetainController
    {
        private readonly ILicenseDetainRepository _licenseDetainRepository;

        public LicenseDetainController(ILicenseDetainRepository licenseDetainRepository)
        {
            _licenseDetainRepository = licenseDetainRepository;
        }

        #region HelpFunctions
        public List<string> GetDetainFilterCriteria()
        {
            return new List<string>
            {
                "Detain ID",
                "License ID",
                "Detain Date",
                "Fine Fees",
                "Created By User ID",
                "Is Released",
                "Release Date",
                "Released By User ID",
            };
        }
        #endregion

        public async Task<DetainedLicense> GetDetainByIdAsync(int id)
        {
            return await _licenseDetainRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<DetainedLicense>> GetDetainsListAsync()
        {
            return await _licenseDetainRepository.GetAllAsync();
        }

        public async Task<bool> IsLicenseDetainedAsync(int licenseId)
        {
            return await _licenseDetainRepository.IsLicenseDetainedAsync(licenseId);
        }

        public async Task<bool> DetainLicenseAsync(DetainedLicense detainedLicense)
        {
            return await _licenseDetainRepository.DetainLicenseAsync(detainedLicense);
        }
    }
}
