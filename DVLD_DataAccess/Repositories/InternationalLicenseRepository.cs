using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Repositories
{
    public class InternationalLicenseRepository : IInternationalLicenseRepository
    {
        #region HelpFunctions
        private InternationalLicense MapToInternationalLicense(DataRow row)
        {
            if (row == null)
                return null;

            return new InternationalLicense
            {
                InternationalLicenseId = Convert.ToInt32(row["InternationalLicenseID"]),
                ApplicationId = Convert.ToInt32(row["ApplicationID"]),
                DriverId = Convert.ToInt32(row["DriverID"]),
                LocalLicenseId = Convert.ToInt32(row["IssuedUsingLocalLicenseID"]),
                IssueDate = Convert.ToDateTime(row["IssueDate"]),
                ExpirationDate = Convert.ToDateTime(row["ExpirationDate"]),
                IsActive = Convert.ToBoolean(row["IsActive"]),
                IssuedByUserId = Convert.ToInt32(row["CreatedByUserID"])
            };
        }
        #endregion

        public async Task<InternationalLicense> GetByIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@InternationalLicenseID", id } };
            string sqlQuery = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            if (dataTable.Rows.Count == 0)
                return null;
            return MapToInternationalLicense(dataTable.Rows[0]);
        }
        public async Task<IEnumerable<InternationalLicense>> GetAllAsync()
        {
            string sqlQuery = "SELECT * FROM InternationalLicenses";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);
            var list = new List<InternationalLicense>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapToInternationalLicense(row));
            }
            return list;
        }
        public async Task<InternationalLicense> GetInternationalLicenseByDriverIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@DriverID", id } };
            string sqlQuery = "SELECT * FROM InternationalLicenses WHERE DriverID = @DriverID AND IsActive = 1";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);

            if (dataTable.Rows.Count == 0)
                return null;

            return MapToInternationalLicense(dataTable.Rows[0]);
        }
        public async Task<InternationalLicense> GetInternationalLicenseByPersonIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@PersonID", id } };
            string sqlQuery = @"SELECT il.* 
                                FROM InternationalLicenses il
                                INNER JOIN Drivers d ON il.DriverID = d.DriverID
                                WHERE d.PersonID = @PersonID AND IsActive = 1";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);

            if (dataTable.Rows.Count == 0)
                return null;

            return MapToInternationalLicense(dataTable.Rows[0]);
        }
        public async Task<IEnumerable<InternationalLicense>> GetInternationalLicenseListByPersonIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@PersonID", id } };
            string sqlQuery = @"SELECT il.* 
                                FROM InternationalLicenses il
                                INNER JOIN Drivers d ON il.DriverID = d.DriverID
                                WHERE d.PersonID = @PersonID";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            var list = new List<InternationalLicense>();

            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapToInternationalLicense(row));
            }
            return list;
        }
        public async Task<IEnumerable<InternationalLicense>> GetInternationalLicenseListByDriverIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@DriverID", id } };
            string sqlQuery = "SELECT * FROM InternationalLicenses WHERE DriverID = @DriverID";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            var list = new List<InternationalLicense>();

            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapToInternationalLicense(row));
            }
            return list;
        }
        public async Task<bool> DesactivateInternationalLicenseAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@LicenseID", id } };
            string sqlQuery = "UPDATE InternationalLicenses SET IsActive = 0 WHERE LicenseID = @LicenseID";
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
        public async Task<bool> HasValidInternationalLicenseAsync(int driverId)
        {
            var parameters = new Dictionary<string, object> { { "@DriverID", driverId } };
            string sqlQuery = "SELECT COUNT(*) FROM InternationalLicenses WHERE DriverID = @DriverID AND ExpirationDate > GETDATE()";
            var result = await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);
            return Convert.ToInt32(result) > 0;
        }

        public async Task<bool> HasActiveInternationalLicenseAsync(int driverId)
        {
            var parameters = new Dictionary<string, object> { { "@DriverID", driverId } };
            string sqlQuery = "SELECT COUNT(*) FROM InternationalLicenses WHERE DriverID = @DriverID AND IsActive = 1";
            var result = await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);
            return Convert.ToInt32(result) > 0;
        }
    }
}
