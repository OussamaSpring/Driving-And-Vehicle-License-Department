using Core.Interfaces;
using Core.Models;
using Core.Enums;
using DVLD_DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
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
                ClassName = row["ClassName"].ToString(),
                IssueDate = Convert.ToDateTime(row["IssueDate"]),
                ExpirationDate = Convert.ToDateTime(row["ExpirationDate"]),
                Notes = row["Notes"] != DBNull.Value ? row["Notes"].ToString() : null,
                PaidFees = Convert.ToSingle(row["PaidFees"]),
                IsActive = Convert.ToBoolean(row["IsActive"]),
                enIssuesReason = (LicenseIsssueReason)Convert.ToInt32(row["IssueReason"]),
                IssuedByUserId = Convert.ToInt32(row["IssuedByUserID"])
            };
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
        public async Task<int> AddAsync(License license)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@ApplicationID", license.ApplicationId },
                { "@DriverID", license.DriverId },
                { "@ClassName", license.ClassName },
                { "@IssueDate", license.IssueDate },
                { "@ExpirationDate", license.ExpirationDate },
                { "@Notes", (object)license.Notes ?? DBNull.Value },
                { "@PaidFees", license.PaidFees },
                { "@IsActive", license.IsActive },
                { "@IssueReason", (int)license.enIssuesReason },
                { "@IssuedByUserID", license.IssuedByUserId }
            };
            string sqlQuery = @"INSERT INTO Licenses (ApplicationID, DriverID, ClassName, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, IssuedByUserID)
                                VALUES (@ApplicationID, @DriverID, @ClassName, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @IssuedByUserID);
                                SELECT SCOPE_IDENTITY();";
            object result = await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);
            return Convert.ToInt32(result);
        }
        public async Task<bool> UpdateAsync(License license)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@LicenseID", license.LicenseId },
                { "@ApplicationID", license.ApplicationId },
                { "@DriverID", license.DriverId },
                { "@ClassName", license.ClassName },
                { "@IssueDate", license.IssueDate },
                { "@ExpirationDate", license.ExpirationDate },
                { "@Notes", (object)license.Notes ?? DBNull.Value },
                { "@PaidFees", license.PaidFees },
                { "@IsActive", license.IsActive },
                { "@IssueReason", (int)license.enIssuesReason },
                { "@IssuedByUserID", license.IssuedByUserId }
            };
            string sqlQuery = @"UPDATE Licenses SET
                                ApplicationID = @ApplicationID,
                                DriverID = @DriverID,
                                ClassName = @ClassName,
                                IssueDate = @IssueDate,
                                ExpirationDate = @ExpirationDate,
                                Notes = @Notes,
                                PaidFees = @PaidFees,
                                IsActive = @IsActive,
                                IssueReason = @IssueReason,
                                IssuedByUserID = @IssuedByUserID
                                WHERE LicenseID = @LicenseID;";
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@LicenseID", id } };
            string sqlQuery = "DELETE FROM Licenses WHERE LicenseID = @LicenseID";
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
        public async Task<IEnumerable<License>> GetLicensesByDriverIdAsync(int driverId)
        {
            var parameters = new Dictionary<string, object> { { "@DriverID", driverId } };
            string sqlQuery = "SELECT * FROM Licenses WHERE DriverID = @DriverID";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            var list = new List<License>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapLicense(row));
            }
            return list;
        }
        public async Task<IEnumerable<License>> GetLicensesByPersonIdAsync(int personId)
        {
            var parameters = new Dictionary<string, object> { { "@PersonID", personId } };
            string sqlQuery = "SELECT * FROM Licenses WHERE DriverID IN (SELECT DriverID FROM Drivers WHERE PersonID = @PersonID)";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            var list = new List<License>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapLicense(row));
            }
            return list;
        }
        public async Task<bool> DesactivateLicenseAsync(int licenseId)
        {
            var parameters = new Dictionary<string, object> { { "@LicenseID", licenseId } };
            string sqlQuery = "UPDATE Licenses SET IsActive = 0 WHERE LicenseID = @LicenseID";
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
    }
}
