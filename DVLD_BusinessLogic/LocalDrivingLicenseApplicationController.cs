using Core.Interfaces;
using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Enums;

namespace DVLD_BusinessLogic
{
    public class LocalDrivingLicenseApplicationController
    {
        private readonly ILocalDrivingLicenseApplicationRepository _localDrivingLicenseApplicationRepository;
        private readonly ILicenseRepository _licenseRepository;


        #region Help Functions

        public List<string> GetLocalDrivingLicenseApplicationFilterCriteria()
        {
            return new List<string>
            {
                "L.D.L Application ID",
                "License Class.",
                "National Number",
                "Full Name",
                "Application Date",
                "Passed Tests",
                "Status"
            };
        }

        #endregion

        public LocalDrivingLicenseApplicationController(ILocalDrivingLicenseApplicationRepository localDrivingLicenseApplicationRepository, ILicenseRepository licenseRepository)
        {
            _localDrivingLicenseApplicationRepository = localDrivingLicenseApplicationRepository;
            _licenseRepository = licenseRepository;
        }

        public async Task<LocalDrivingLicenseApplication> GetLocalDrivingLicenseApplicationByIdAsync(int LDLAppId)
        {
            return await _localDrivingLicenseApplicationRepository.GetByIdAsync(LDLAppId);
        }

        public async Task<IEnumerable<LocalDrivingLicenseApplication>> GetAllLocalDrivingLicenseApplicationsAsync()
        {
            return await _localDrivingLicenseApplicationRepository.GetAllAsync();
        }

        public async Task<int> AddNewLocalDrivingLicenseApplicationAsync(ApplicationType at, LicenseClass licenseClass, int personId, int userId)
        {
            var application = new Applications
            {
                ApplicantPersonId = personId,
                ApplicationDate = System.DateTime.Now,
                ApplicationType = at,
                enApplicationStatus = ApplicationStatus.Completed,
                LastStatusDate = System.DateTime.Now,
                PaidFees = at.ApplicationTypeFees,
                CreatedByUserId = userId
            };

            if (await _licenseRepository.HasLicenseTypeAsync(personId, licenseClass.Id))
            {
                return -1;
            }

            return await _localDrivingLicenseApplicationRepository.AddAsync(application, licenseClass.Id);
        }

        public async Task<bool> DoesPassTestTypeAsync(int localDrivingLicenseApplicationId, int testTypeId)
        {
            return await _localDrivingLicenseApplicationRepository.DoesPassTestTypeAsync(localDrivingLicenseApplicationId, testTypeId);
        }

        public async Task<int> GetTotalTrialsPerTestAsync(int localDrivingLicenseApplicationId, int testTypeId)
        {
            return await _localDrivingLicenseApplicationRepository.GetTotalTrialsPerTestAsync(localDrivingLicenseApplicationId, testTypeId);
        }

        public async Task<bool> IsThereActiveScheduledTestExistAsync(int localDrivingLicenseApplicationId, int testTypeId)
        {
            return await _localDrivingLicenseApplicationRepository.IsThereActiveScheduledTestExistAsync(localDrivingLicenseApplicationId, testTypeId);
        }
    }
}
