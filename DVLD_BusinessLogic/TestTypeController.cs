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

        public async Task<int> AddTestTypeAsync(TestType testType)
        {
            return await _testTypeRepository.AddAsync(testType);
        }

        public async Task<bool> UpdateTestTypeAsync(TestType testType)
        {
            return await _testTypeRepository.UpdateAsync(testType);
        }

        public async Task<bool> DeleteTestTypeAsync(int id)
        {
            return await _testTypeRepository.DeleteAsync(id);
        }
    }
}
