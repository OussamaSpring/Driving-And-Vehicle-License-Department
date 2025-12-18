using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Repositories
{
    public class LicenseDetainRepository : ILicenseDetainRepository
    {
        #region HelpFunctions
        private DetainedLicense MapToLicenseDetain(DataRow row)
        {
            if (row == null)
                return null;
            return new DetainedLicense
            {
                DetainID = Convert.ToInt32(row["DetainID"]),
                LicenseID = Convert.ToInt32(row["LicenseID"]),
                DetainDate = Convert.ToDateTime(row["DetainDate"]),
                FineFees = (float)Convert.ToDecimal(row["FineFees"]),
                CreatedByUserID = Convert.ToInt32(row["CreatedByUserID"]),
                IsReleased = Convert.ToBoolean(row["IsReleased"]),
                ReleaseDate = row["ReleaseDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ReleaseDate"]),
                ReleasedByUserID = row["ReleasedByUserID"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["ReleasedByUserID"]),
                ReleaseApplicationID = row["ReleaseApplicationID"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["ReleaseApplicationID"])
            };
        }
        #endregion

        public async Task<DetainedLicense> GetByIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@DetainID", id } };
            string sqlQuery = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            if (dataTable.Rows.Count == 0)
                return null;
            return MapToLicenseDetain(dataTable.Rows[0]);
        }
        public async Task<IEnumerable<DetainedLicense>> GetAllAsync()
        {
            string sqlQuery = "SELECT * FROM DetainedLicenses";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);
            var list = new List<DetainedLicense>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapToLicenseDetain(row));
            }
            return list;
        }
        public async Task<bool> IsLicenseDetainedAsync(int licenseId)
        {
            var parameters = new Dictionary<string, object> { { "@LicenseID", licenseId } };
            string sqlQuery = "SELECT COUNT(*) FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0";
            object result = await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);
            return Convert.ToInt32(result) > 0;
        }
        public async Task<bool> DetainLicenseAsync(DetainedLicense detainedLicense)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@LicenseID", detainedLicense.LicenseID },
                { "@DetainDate", detainedLicense.DetainDate },
                { "@FineFees", detainedLicense.FineFees },
                { "@CreatedByUserID", detainedLicense.CreatedByUserID },
                { "@IsReleased", detainedLicense.IsReleased },
                { "@ReleaseDate", (object)detainedLicense.ReleaseDate ?? DBNull.Value },
                { "@ReleasedByUserID", (object)detainedLicense.ReleasedByUserID ?? DBNull.Value },
                { "@ReleaseApplicationID", (object)detainedLicense.ReleaseApplicationID ?? DBNull.Value }
            };
            string sqlQuery = @"INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                                VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID)";

            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
    }
}
