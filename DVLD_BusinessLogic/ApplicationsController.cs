using Core.Interfaces;
using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

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
    }
}
