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
                Id = Convert.ToInt16(row["LicneseClassID"]),
                Name = row["Name"]?.ToString(),
                Description = row["Description"]?.ToString(),
                MiminumAllowedAge = Convert.ToInt16(row["MiminumAllowedAge"]),
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
        public async Task<int> AddAsync(LicenseClass licenseClass)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@Name", licenseClass.Name },
                { "@Description", (object)licenseClass.Description ?? DBNull.Value },
                { "@MiminumAllowedAge", licenseClass.MiminumAllowedAge },
                { "@DefaultValidityLength", licenseClass.DefaultValidityLength },
                { "@ClassFees", licenseClass.ClassFees }
            };
            string sqlQuery = @"INSERT INTO LicenseClasses (Name, Description, MiminumAllowedAge, DefaultValidityLength, ClassFees)
                                VALUES (@Name, @Description, @MiminumAllowedAge, @DefaultValidityLength, @ClassFees);
                                SELECT SCOPE_IDENTITY();";
            object result = await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);
            return Convert.ToInt32(result);
        }
        public async Task<bool> UpdateAsync(LicenseClass licenseClass)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@LicneseClassID", licenseClass.Id },
                { "@Name", licenseClass.Name },
                { "@Description", (object)licenseClass.Description ?? DBNull.Value },
                { "@MiminumAllowedAge", licenseClass.MiminumAllowedAge },
                { "@DefaultValidityLength", licenseClass.DefaultValidityLength },
                { "@ClassFees", licenseClass.ClassFees }
            };
            string sqlQuery = @"UPDATE LicenseClasses SET
                                Name = @Name,
                                Description = @Description,
                                MiminumAllowedAge = @MiminumAllowedAge,
                                DefaultValidityLength = @DefaultValidityLength,
                                ClassFees = @ClassFees
                                WHERE LicneseClassID = @LicneseClassID;";
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@LicneseClassID", id } };
            string sqlQuery = "DELETE FROM LicenseClasses WHERE LicneseClassID = @LicneseClassID";
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
    
    }
}
