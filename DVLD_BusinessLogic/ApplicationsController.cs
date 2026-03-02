using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Enums;

namespace DVLD_BusinessLogic
{
    public class ApplicationsController
    {
        private readonly IApplicationsRepository _applicationsRepository;

        public ApplicationsController(IApplicationsRepository applicationsRepository)
        {
            _applicationsRepository = applicationsRepository;
        }

        #region HelpFunctions

        public List<string> GetApplicationFilterCriteria()
        {
            var filterCriteria = new List<string>
            {
                "Application ID",
                "Applicant Person ID",
                "Application Date",
                "Application Type",
                "Application Status",
                "Last Status Date",
                "Paid Fees",
                "Created By User ID"
            };
            return filterCriteria;
        }

        private Applications PrepareApplication(
            int applicantPersonId,
            ApplicationType applicationType,
            decimal paidFees,
            int userId,
            ApplicationStatus status = ApplicationStatus.Completed)
        {
            return new Applications
            {
                ApplicantPersonId = applicantPersonId,
                ApplicationDate = DateTime.Now,
                ApplicationType = applicationType,
                enApplicationStatus = status,
                LastStatusDate = DateTime.Now,
                PaidFees = paidFees,
                CreatedByUserId = userId
            };
        }

        private License PrepareReplacementLicense(License currentLicense, LicenseClass licenseClass, decimal paidFees, int userId, LicenseIsssueReasons enIssueReason, string notes)
        {
            DateTime issueDate = DateTime.Now;
            short classId = licenseClass?.Id ?? currentLicense.ClassId;
            int validityYears = licenseClass?.DefaultValidityLength ?? 0;

            return new License
            {
                DriverId = currentLicense.DriverId,
                ClassId = classId,
                IssueDate = issueDate,
                ExpirationDate = issueDate.AddYears(validityYears),
                Notes = notes ?? string.Empty,
                PaidFees = (float)paidFees,
                IsActive = true,
                enIssueReason = enIssueReason,
                IssuedByUserId = userId
            };
        }
        #endregion

        public async Task<Applications> GetApplicationById(int appId)
        {
            return await _applicationsRepository.GetByIdAsync(appId);
        }
        public async Task<IEnumerable<Applications>> GetAllApplicationsAsync()
        {
            return await _applicationsRepository.GetAllAsync();
        }


        public async Task<LocalDrivingLicenseApplication> GetLocalDrivingLicenseApplicationByIdAsync(int LDLAppId)
        {
            return await _applicationsRepository.GetLocalDrivingLicenseApplicationByIdAsync(LDLAppId);
        }
        public async Task<IEnumerable<LocalDrivingLicenseApplication>> GetAllLocalDrivingLicenseApplicationsAsync()
        {
            return await _applicationsRepository.GetAllLocalDrivingLicenseApplicationsAsync();
        }

        public async Task<bool> ReleaseDetainedDrivingLicenseAsync(ApplicationType at, int detainId, int personId, decimal paidFees, int userId)
        {
            var application = PrepareApplication(personId, at, paidFees, userId);
            return await _applicationsRepository.ReleaseDetainedDrivingLicenseAsync(application, detainId, userId);
        }

        public async Task<int> RenewExpiredDrivingLicenseAsync(ApplicationType at, License currentLicense, LicenseClass licenseClass, string notes, int personId, decimal paidFees, int userId)
        {
            var application = PrepareApplication(personId, at, paidFees, userId);
            
            License renewedLicense = PrepareReplacementLicense(currentLicense, licenseClass, paidFees, userId,LicenseIsssueReasons.Renew, notes);

            return await _applicationsRepository.RenewExpiredDrivingLicenseAsync(application, renewedLicense);
        }

        public async Task<int> ReplaceDamagedDrivingLicenseAsync(ApplicationType at, int personId, decimal paidFees, int userId, License damagedLicense)
        {
            var application = PrepareApplication(personId, at, paidFees, userId);
            return await _applicationsRepository.ReplaceDamagedDrivingLicenseAsync(application, damagedLicense);
        }

        public async Task<int> ReplaceLostDrivingLicenseAsync(ApplicationType at, int personId, decimal paidFees, int userId, License lostLicense)
        {
            var application = PrepareApplication(personId, at, paidFees, userId);
            return await _applicationsRepository.ReplaceLostDrivingLicenseAsync(application, lostLicense);
        }
    }
}
