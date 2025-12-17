using Core.Models;
using Core.Interfaces;
using DVLD_DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Repositories
{
    public class LicenseClassRepository : ILicenseClassRepository
    {
        #region HelpFunctions

        private LicenseClass MapLicenseClass(DataRow row)
        {
            if (row == null)
                return null;

            return new LicenseClass
            {
                Id = Convert.ToInt16(row["LicenseClassID"]),
                Name = row["ClassName"]?.ToString(),
                Description = row["ClassDescription"]?.ToString(),
                MiminumAllowedAge = Convert.ToInt16(row["MinimumAllowedAge"]),
                DefaultValidityLength = Convert.ToInt16(row["DefaultValidityLength"]),
                ClassFees = Convert.ToDecimal(row["ClassFees"])
            };
        }

        #endregion

        public async Task<LicenseClass> GetByIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@LicneseClassID", id } };
            string sqlQuery = "SELECT * FROM LicenseClasses WHERE LicneseClassID = @LicneseClassID";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            if (dataTable.Rows.Count == 0)
                return null;
            var row = dataTable.Rows[0];
            return MapLicenseClass(row);
        }
        public async Task<IEnumerable<LicenseClass>> GetAllAsync()
        {
            string sqlQuery = "SELECT * FROM LicenseClasses";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);
            var list = new List<LicenseClass>();
            if (dataTable.Rows.Count == 0)
                return list;
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapLicenseClass(row));
            }
            return list;
        }
    
    }
}
