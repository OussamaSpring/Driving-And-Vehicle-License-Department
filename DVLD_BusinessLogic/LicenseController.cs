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

        #region HelpFunctions

        public string GetLicenseClassNameById(short id)
        {
            switch (id)
            {
                case 1:
                    return "Small Motorcycle";
                case 2:
                    return "Heavy Motorcycle License";
                case 3:
                    return "Ordinary driving license";
                case 4:
                    return "Commercial";
                case 5:
                    return "Agricultural";
                case 6:
                    return "Small and medium bus";
                case 7:
                    return "Truck and heavy vehicle";
                default:
                    return "Unknown";
            }
        }

        public List<string> GetLicenseFilterCriteria()
        {
            return new List<string>
            {
                "License ID",
                "Application ID",
                "Driver ID",
                "Class ID",
                "Issue Date",
                "Expiration Date",
                "Paid Fees",
                "Status",
                "Issued By User ID"
            };
        }


        #endregion

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
