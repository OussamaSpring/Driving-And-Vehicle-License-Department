using Core.Enums;
using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Repositories
{
    public class LicenseRepository : ILicenseRepository
    {
        #region HelpFunctions
        private License MapLicense(DataRow row)
        {
            if (row == null)
                return null;

            return new License
            {
                LicenseId = Convert.ToInt32(row["LicenseID"]),
                ApplicationId = Convert.ToInt32(row["ApplicationID"]),
                DriverId = Convert.ToInt32(row["DriverID"]),
                ClassId = Convert.ToInt16(row["LicenseClass"]),
                IssueDate = Convert.ToDateTime(row["IssueDate"]),
                ExpirationDate = Convert.ToDateTime(row["ExpirationDate"]),
                Notes = row["Notes"] != DBNull.Value ? row["Notes"].ToString() : null,
                PaidFees = Convert.ToSingle(row["PaidFees"]),
                IsActive = Convert.ToBoolean(row["IsActive"]),
                enIssueReason = (LicenseIsssueReasons)Convert.ToInt32(row["IssueReason"]),
                IssuedByUserId = Convert.ToInt32(row["CreatedByUserID"])
            };
        }

        private async Task<int> InsertDriverAsync(int personId, SqlConnection connection, SqlTransaction transaction)
        {
            string sql = "INSERT INTO Drivers (PersonID) OUTPUT INSERTED.DriverID VALUES (@PersonID)";
            using (var command = new SqlCommand(sql, connection, transaction))
            {
                command.Parameters.AddWithValue("@PersonID", personId);
                var result = await command.ExecuteScalarAsync().ConfigureAwait(false);
                return Convert.ToInt32(result);
            }
        }

        private async Task<int> InsertDriverAsync(Driver driver, SqlConnection connection, SqlTransaction transaction)
        {
            var driverParam = new Dictionary<string, object>
            {
                { "@PersonID", driver.DriverPersonId },
                { "@CreatedByUserID", driver.CreatedByUserId },
                { "@CreatedDate", driver.CreateDate },
                { "@NationalNo", driver.NationalNumber },
                { "@FullName", driver.FullName }
            };

            string insertDriverSQL = @"
                INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate, NationalNo, FullName)
                OUTPUT INSERTED.*
                VALUES (@PersonID, @CreatedByUserID, @CreatedDate, @NationalNo, @FullName); SELECT SCOPE_IDENTITY();";

            var newDriverId = await DBHelper.ExecuteScalarAsync(insertDriverSQL, driverParam, connection, transaction);

            return Convert.ToInt32(newDriverId);
        }

        #endregion

        public async Task<License> GetByIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@LicenseID", id } };
            string sqlQuery = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            if (dataTable.Rows.Count == 0)
                return null;
            return MapLicense(dataTable.Rows[0]);
        }
        public async Task<IEnumerable<License>> GetAllAsync()
        {
            string sqlQuery = "SELECT * FROM Licenses";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);
            var list = new List<License>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapLicense(row));
            }
            return list;
        }
        public async Task<IEnumerable<License>> GetLicensesByDriverIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@DriverID", id } };
            string sqlQuery = "SELECT * FROM Licenses WHERE DriverID = @DriverID";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            var list = new List<License>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapLicense(row));
            }
            return list;
        }
        public async Task<IEnumerable<License>> GetLicensesByPersonIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@PersonID", id } };
            string sqlQuery = "SELECT * FROM Licenses WHERE DriverID IN (SELECT DriverID FROM Drivers WHERE PersonID = @PersonID)";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            var list = new List<License>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapLicense(row));
            }
            return list;
        }
        public async Task<bool> HasLicenseTypeAsync(int personId, short licenseClassId)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@PersonID", personId },
                { "@LicenseClass", licenseClassId }
            };
            string sqlQuery = @"SELECT COUNT(1) FROM Licenses WHERE 
                                DriverID IN (SELECT DriverID FROM Drivers WHERE PersonID = @PersonID)
                                AND LicenseClass = @LicenseClass";
            var result = await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);
            int count = Convert.ToInt32(result);
            return count > 0;
        }
        public async Task<bool> DoesLicenseExistAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@LicenseID", id } };
            string sqlQuery = "SELECT COUNT(1) FROM Licenses WHERE LicenseID = @LicenseID";
            var result = await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        public async Task<int> IssueLicenseFirstTime(License license, Driver driver)
        {
            using (var connection = DBHelper.CreateOpenConnection())
            using (var transaction = DBHelper.BeginTransaction(connection))
            {
                try
                {
                    // Insert Driver
                    int newDriverId = await InsertDriverAsync(driver, connection, transaction);

                    // Insert License
                    var licenseParams = new Dictionary<string, object>
                    {
                        { "@ApplicationID", license.ApplicationId },
                        { "@DriverID", newDriverId },
                        { "@LicenseClass", license.ClassId },
                        { "@IssueDate", license.IssueDate },
                        { "@ExpirationDate", license.ExpirationDate },
                        { "@Notes", (object)license.Notes ?? DBNull.Value },
                        { "@PaidFees", license.PaidFees },
                        { "@IsActive", license.IsActive },
                        { "@IssueReason", (int)license.enIssueReason },
                        { "@CreatedByUserID", license.IssuedByUserId }
                    };

                    string insertLicenseSql = @"
                        INSERT INTO Licenses
                            (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                        VALUES
                            (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                        SELECT SCOPE_IDENTITY();";

                    var newLicenseIdObj = await DBHelper.ExecuteScalarAsync(insertLicenseSql, licenseParams, connection, transaction);

                    transaction.Commit();
                    return Convert.ToInt32(newLicenseIdObj);
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
