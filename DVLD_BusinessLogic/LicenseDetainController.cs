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

        public Task<DetainedLicense> GetDetainByIdAsync(int id)
        {
            return _licenseDetainRepository.GetByIdAsync(id);
        }

        public Task<IEnumerable<DetainedLicense>> GetDetainsListAsync()
        {
            return _licenseDetainRepository.GetAllAsync();
        }

        public Task<bool> IsLicenseDetainedAsync(int licenseId)
        {
            return _licenseDetainRepository.IsLicenseDetainedAsync(licenseId);
        }
    }
}
