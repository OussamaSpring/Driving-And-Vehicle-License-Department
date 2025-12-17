using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLogic
{
    public class DriverController
    {
        private readonly IDriverRepository _driverRepository;

        public DriverController(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        #region HelpFunctions

        public List<string> GetDriverFilterCriteria()
        {
            var filterCriteria = new List<string>
            {
                "Driver ID",
                "Person ID",
                "National No.",
                "Full Name"
            };
            return filterCriteria;
        }

        #endregion

        public async Task<IEnumerable<Driver>> GetAllDriversAsync()
        {
            return await _driverRepository.GetAllAsync();
        }

        public async Task<Driver> GetDriverByIdAsync(int id)
        {
            return await _driverRepository.GetByIdAsync(id);
        }

        public async Task<Driver> GetDriverByPersonIdAsync(int personId)
        {
            return await _driverRepository.GetByPersonIdAsync(personId);
        }

        public async Task<Driver> GetDriverByNationalNumberAsync(string nationalNumber)
        {
            return await _driverRepository.GetByNationalNumberAsync(nationalNumber);
        }

        public async Task<bool> IsDriverExistAsync(int id)
        {
            return await _driverRepository.IsDriverExist(id);
        }
    }
}
