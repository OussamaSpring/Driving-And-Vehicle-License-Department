using Core.Interfaces;
using Core.Models;
using Core.Enums;
using System;
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

        private Driver PrepareDriver(int personId, string nationalNumber, string fullName, int createdByUserId)
        {
            return new Driver
            {
                DriverPersonId = personId,
                NationalNumber = nationalNumber,
                FullName = fullName,
                CreateDate = DateTime.Now,
                ActiveLicensesCount = 1,
                CreatedByUserId = createdByUserId
            };
        }
        private License PrepareLicense(int applicationId, LicenseClass lc, string notes, int issuedByUserId)
        {
            return new License
            {
                ApplicationId = applicationId,
                ClassId = lc.Id,
                IssueDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(lc.DefaultValidityLength),
                Notes = notes,
                PaidFees = (float)lc.ClassFees,
                IsActive = true,
                enIssueReason = LicenseIsssueReasons.FirstTime,
                IssuedByUserId = issuedByUserId
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
        public Task<IEnumerable<License>> GetLicensesByDriverIdAsync(int driverId)
        {
            return _licenseRepository.GetLicensesByDriverIdAsync(driverId);
        }
        public Task<IEnumerable<License>> GetLicensesByPersonIdAsync(int personId)
        {
            return _licenseRepository.GetLicensesByPersonIdAsync(personId);
        }

        public Task<bool> DoesLicenseExistAsync(int id)
        {
            return _licenseRepository.DoesLicenseExistAsync(id);
        }

        public Task<int> IssueLicenseFirstTime(LocalDrivingLicenseApplication localDrivingLicenseApplication, int personId, int userId, string notes = null)
        {
            var driver = PrepareDriver(
                personId,
                localDrivingLicenseApplication.NationalNumber,
                localDrivingLicenseApplication.FullName,
                userId
            );

            var license = PrepareLicense(
                localDrivingLicenseApplication.ApplicationId,
                localDrivingLicenseApplication.LicenseClass,
                notes,
                userId
            );

            return _licenseRepository.IssueLicenseFirstTime(license, driver);
        }
    }
}
