using Core.Interfaces;
using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVLD_BusinessLogic
{
    public class TestTypeController
    {
        private readonly ITestTypeRepository _testTypeRepository;

        public TestTypeController(ITestTypeRepository testTypeRepository)
        {
            _testTypeRepository = testTypeRepository;
        }

        public async Task<TestType> GetTestTypeByIdAsync(int id)
        {
            return await _testTypeRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<TestType>> GetAllTestTypesAsync()
        {
            return await _testTypeRepository.GetAllAsync();
        }

    }
}
