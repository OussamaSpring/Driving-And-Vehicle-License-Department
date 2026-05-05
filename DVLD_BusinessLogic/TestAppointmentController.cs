using Core.Interfaces;
using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVLD_BusinessLogic
{
    public class TestAppointmentController
    {
        private readonly ITestAppointmentRepository _testAppointmentRepository;

        public TestAppointmentController(ITestAppointmentRepository testAppointmentRepository)
        {
            _testAppointmentRepository = testAppointmentRepository;
        }

        public async Task<TestAppointment> GetTestAppointmentByIdAsync(int id)
        {
            return await _testAppointmentRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<TestAppointment>> GetAllTestAppointmentsAsync()
        {
            return await _testAppointmentRepository.GetAllAsync();
        }

        public async Task<int> AddTestAppointmentAsync(TestAppointment appointment)
        {
            return await _testAppointmentRepository.AddAsync(appointment);
        }

        public async Task<bool> UpdateTestAppointmentAsync(TestAppointment appointment)
        {
            return await _testAppointmentRepository.UpdateAsync(appointment);
        }

        public async Task<bool> DeleteTestAppointmentAsync(int id)
        {
            return await _testAppointmentRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TestAppointment>> GetTestAppointmentsByLocalDrivingLicenseApplicationIdAsync(int localDrivingLicenseApplicationId)
        {
            return await _testAppointmentRepository.GetByLocalDrivingLicenseApplicationIdAsync(localDrivingLicenseApplicationId);
        }

        public async Task<IEnumerable<TestAppointment>> GetTestAppointmentsByLocalDrivingLicenseApplicationIdAndTestTypeIdAsync(int localDrivingLicenseApplicationId, int testTypeId)
        {
            return await _testAppointmentRepository.GetByLocalDrivingLicenseApplicationIdAndTestTypeIdAsync(localDrivingLicenseApplicationId, testTypeId);
        }

        public async Task<TestAppointment> GetLatestAppointmentByLDAndTestTypeIdAsync(int localDrivingLicenseApplicationId, int testTypeId)
        {
            return await _testAppointmentRepository.GetLatestAppointmentByLDAndTestTypeIdAsync(localDrivingLicenseApplicationId, testTypeId);
        }

        public async Task<int> RescheduleTestAppointmentAsync(TestAppointment appointment, Applications retakeApplication)
        {
            return await _testAppointmentRepository.RescheduleTestAppointmentAsync(appointment, retakeApplication);
        }
    }
}
