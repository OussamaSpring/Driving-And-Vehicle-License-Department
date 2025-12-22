using DVLD_DataAccess.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using System.Runtime.InteropServices;

namespace DVLD_BusinessLogic
{
    public class ApplicationsController
    {
        private readonly ApplicationsRepository _applicationsRepository;

        public ApplicationsController(ApplicationsRepository applicationsRepository)
        {
            _applicationsRepository = applicationsRepository;
        }

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
