using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;


namespace DVLD_DataAccess.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        #region HelpFunctions
        private Driver MapDriver(DataRow row)
        {
            if (row == null)
                return null;

            return new Driver
            {
                DriverId = row["DriverID"] != DBNull.Value ? Convert.ToInt32(row["DriverID"]) : 0,
                DriverPersonId = row["PersonID"] != DBNull.Value ? Convert.ToInt32(row["PersonID"]) : 0,
                CreatedByUserId = row["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(row["CreatedByUserID"]) : 0,
                CreateDate = row["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.MinValue,
                NationalNumber = row["NationalNo"] != DBNull.Value ? row["NationalNo"].ToString() : string.Empty,
                FullName = row["FullName"] != DBNull.Value ? row["FullName"].ToString() : string.Empty,
                ActiveLicensesCount = row.Table.Columns.Contains("ActiveLicensesCount") && row["ActiveLicensesCount"] != DBNull.Value ? Convert.ToInt16(row["ActiveLicensesCount"]) : (short)0,
            };
        }

        #endregion

        public async Task<Driver> GetByIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> 
            {
                { "@DriverId", id } 
            };

            string sqlQuery = "SELECT * FROM DriversDetailTable WHERE DriverID = @DriverId";

            var DataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);

            if (DataTable.Rows.Count == 0)
                return null;

            var row = DataTable.Rows[0];
            return MapDriver(row);
        }
        public async Task<IEnumerable<Driver>> GetAllAsync()
        {
            string sqlQuery = "SELECT * FROM DriversDetailTable;";

            var DataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);

            var Drivers = new List<Driver>();

            foreach (DataRow row in DataTable.Rows)
            {
                Drivers.Add(MapDriver(row));
            }

            return Drivers;
        }
        public async Task<int> AddAsync(Driver driver)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@PersonId", driver.DriverPersonId },
                { "@CreatedByUserID", driver.CreatedByUserId },
                { "@CreatedDate", driver.CreateDate },
            };

            string sqlQuery = @"INSERT INTO Drivers 
                                (PersonID, CreatedByUserID, CreatedDate) 
                                VALUES (@PersonId, @CreatedByUserID, @CreatedDate);
                                SELECT SCOPE_IDENTITY();";

            int result = Convert.ToInt32(await DBHelper.ExecuteScalarAsync(sqlQuery, parameters));
            return result;
        }
        public async Task<bool> UpdateAsync(Driver driver)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@PersonId", driver.DriverPersonId },
                { "@CreatedByUserID", driver.CreatedByUserId },
                { "@CreatedDate", driver.CreateDate },
            };

            parameters.Add("@DriverId", driver.DriverId);

            string sqlQuery = @"UPDATE Drivers 
                                SET PersonID = @PersonId, 
                                    CreatedByUserID = @CreatedByUserID, 
                                    CreatedDate = @CreatedDate 
                                WHERE DriverID = @DriverId";

            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@DriverId", id }
            };

            string sqlQuery = "DELETE FROM Drivers WHERE DriverID = @DriverId";

            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
        public async Task<Driver> GetByPersonIdAsync(int id)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@PersonId", id }
            };

            string sqlQuery = "SELECT * FROM DriversDetailTable WHERE DriverID = @DriverId";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);

            if (dataTable.Rows.Count == 0)
                return null;

            var row = dataTable.Rows[0];
            return MapDriver(row);
        }
        public async Task<Driver> GetByNationalNumberAsync(string nationalNumber)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@NationalNo", nationalNumber }
            };

            string sqlQuery = "SELECT * FROM DriversDetailTable WHERE NationalNo = @NationalNo";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);

            if (dataTable.Rows.Count == 0)
                return null;

            var row = dataTable.Rows[0];
            return MapDriver(row);
        }
        public async Task<bool> IsDriverExist(int id)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@DriverId", id }
            };

            string sqlQuery = "SELECT COUNT(1) FROM Drivers WHERE DriverID = @DriverId";

            int count = Convert.ToInt32(await DBHelper.ExecuteScalarAsync(sqlQuery, parameters));
            return count > 0;
        }
    }
}
