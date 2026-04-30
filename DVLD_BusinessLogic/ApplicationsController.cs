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
        private readonly ILicenseRepository _licenseRepository;
        private readonly IInternationalLicenseRepository _internationalLicenseRepository;

        public ApplicationsController(IApplicationsRepository applicationsRepository, ILicenseRepository licenseRepository, IInternationalLicenseRepository internationalLicenseRepository)
        {
            _applicationsRepository = applicationsRepository;
            _licenseRepository = licenseRepository;
            _internationalLicenseRepository = internationalLicenseRepository;
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

        private int GetValidityYears(LicenseClass licenseClass, LicenseIsssueReasons enIssueReason)
        {
            return (enIssueReason == LicenseIsssueReasons.ReplacementForLost || enIssueReason == LicenseIsssueReasons.ReplacementForDamaged) ? 0 : licenseClass?.DefaultValidityLength ?? 0;
        }

        private License PrepareReplacementLicense(License currentLicense, LicenseClass licenseClass, decimal paidFees, int userId, LicenseIsssueReasons enIssueReason, string notes = null)
        {
            DateTime issueDate = DateTime.Now;
            short classId = licenseClass?.Id ?? currentLicense.ClassId;
            int validityYears = GetValidityYears(licenseClass, enIssueReason);

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

        private InternationalLicense PrepareInternationalLicense(License localLicnese, int userId)
        {
            return new InternationalLicense
            {
                DriverId = localLicnese.DriverId,
                LocalLicenseId = localLicnese.LicenseId,
                IssueDate = DateTime.UtcNow,
                ExpirationDate = DateTime.UtcNow.AddYears(10),
                IsActive = true,
                IssuedByUserId= userId
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


        public async Task<int> AddNewInternationalDrivingLicenseApplicationAsync(ApplicationType at, License localDrivingLicense, int personId, int userId)
        {
            bool hasValidInternationalLicense = await _internationalLicenseRepository.HasValidInternationalLicenseAsync(localDrivingLicense.DriverId);
            if (hasValidInternationalLicense)
            {
                return -1;
            }

            var application = PrepareApplication(personId, at, at.ApplicationTypeFees, userId);
            var interLicense = PrepareInternationalLicense(localDrivingLicense, userId);

            return await _applicationsRepository.AddNewInternationalLicenseApplicationAsync(application, interLicense);
        }
        public async Task<bool> ReleaseDetainedDrivingLicenseAsync(ApplicationType at, int detainId, int personId, decimal paidFees, int userId)
        {
            var application = PrepareApplication(personId, at, paidFees, userId);
            return await _applicationsRepository.ReleaseDetainedDrivingLicenseAsync(application, detainId, userId);
        }

        public async Task<int> RenewExpiredDrivingLicenseAsync(ApplicationType at, License currentExpiredLicense, LicenseClass licenseClass, string notes, int personId, int userId)
        {
            decimal paidFees = licenseClass.ClassFees + at.ApplicationTypeFees;

            var application = PrepareApplication(personId, at, paidFees, userId);
            
            License renewedLicense = PrepareReplacementLicense(currentExpiredLicense, licenseClass, paidFees, userId, LicenseIsssueReasons.Renew, notes);

            return await _applicationsRepository.RenewExpiredDrivingLicenseAsync(application, renewedLicense, currentExpiredLicense.LicenseId);
        }

        public async Task<int> ReplaceDamagedDrivingLicenseAsync(ApplicationType at, License currentDamagedLicense, LicenseClass licenseClass, int personId, int userId)
        {
            decimal paidFees = licenseClass.ClassFees + at.ApplicationTypeFees;

            var application = PrepareApplication(personId, at, paidFees, userId);

            License replacementLicense = PrepareReplacementLicense(currentDamagedLicense, licenseClass, paidFees, userId, LicenseIsssueReasons.ReplacementForDamaged, currentDamagedLicense.Notes);

            return await _applicationsRepository.ReplaceDamagedDrivingLicenseAsync(application, replacementLicense, currentDamagedLicense.LicenseId);
        }

        public async Task<int> ReplaceLostDrivingLicenseAsync(ApplicationType at, License currentLostLicense, LicenseClass licenseClass, int personId, int userId)
        {
            decimal paidFees = licenseClass.ClassFees + at.ApplicationTypeFees;

            var application = PrepareApplication(personId, at, paidFees, userId);

            License replacementLicense = PrepareReplacementLicense(currentLostLicense, licenseClass, paidFees, userId, LicenseIsssueReasons.ReplacementForLost, currentLostLicense.Notes);

            return await _applicationsRepository.ReplaceLostDrivingLicenseAsync(application, replacementLicense, currentLostLicense.LicenseId);
        }
    }
}
