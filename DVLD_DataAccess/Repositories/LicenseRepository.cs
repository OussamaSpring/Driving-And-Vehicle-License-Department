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
                ClassId = Convert.ToInt16(row["LicenseClass"]),
                IssueDate = Convert.ToDateTime(row["IssueDate"]),
                ExpirationDate = Convert.ToDateTime(row["ExpirationDate"]),
                Notes = row["Notes"] != DBNull.Value ? row["Notes"].ToString() : null,
                PaidFees = Convert.ToSingle(row["PaidFees"]),
                IsActive = Convert.ToBoolean(row["IsActive"]),
                enIssuesReason = (LicenseIsssueReasons)Convert.ToInt32(row["IssueReason"]),
                IssuedByUserId = Convert.ToInt32(row["CreatedByUserID"])
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
    }
}
