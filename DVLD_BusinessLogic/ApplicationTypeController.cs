using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVLD_BusinessLogic
{
    public class ApplicationTypeController
    {
        private readonly IApplicationTypeRepository _repository;

        public ApplicationTypeController(IApplicationTypeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ApplicationType> GetApplicationTypeByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<ApplicationType>> GetAllApplicationTypesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<decimal> GetApplicationTypeFeeByIdAsync(int id)
        {
            var applicationType = await _repository.GetByIdAsync(id);
            return applicationType != null ? applicationType.ApplicationTypeFees : 0;
        }
    }
}