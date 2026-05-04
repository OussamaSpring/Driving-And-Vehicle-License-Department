using Core.Interfaces;
using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVLD_BusinessLogic
{
    public class TestController
    {
        private readonly ITestRepository _testRepository;

        public TestController(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public async Task<Test> GetTestByIdAsync(int id)
        {
            return await _testRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Test>> GetAllTestsAsync()
        {
            return await _testRepository.GetAllAsync();
        }

        public async Task<int> AddTestAsync(Test test)
        {
            return await _testRepository.AddAsync(test);
        }

        public async Task<bool> UpdateTestAsync(Test test)
        {
            return await _testRepository.UpdateAsync(test);
        }

        public async Task<bool> DeleteTestAsync(int id)
        {
            return await _testRepository.DeleteAsync(id);
        }

        public async Task<int> GetTotalPassedTestCountAsync(int localDrivingLicenseApplicationId)
        {
            return await _testRepository.GetTotalPassedTestCountAsync(localDrivingLicenseApplicationId);
        }
    }
}