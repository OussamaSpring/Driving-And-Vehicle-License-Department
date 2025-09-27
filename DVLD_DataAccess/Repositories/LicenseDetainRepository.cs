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
                FineFees = Convert.ToDecimal(row["FineFees"]),
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
        public async Task<int> AddAsync(DetainedLicense detain)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@LicenseID", detain.LicenseID },
                { "@DetainDate", detain.DetainDate },
                { "@FineFees", detain.FineFees },
                { "@CreatedByUserID", detain.CreatedByUserID },
                { "@IsReleased", detain.IsReleased },
                { "@ReleaseDate", (object)detain.ReleaseDate ?? DBNull.Value },
                { "@ReleasedByUserID", (object)detain.ReleasedByUserID ?? DBNull.Value },
                { "@ReleaseApplicationID", (object)detain.ReleaseApplicationID ?? DBNull.Value }
            };
            string sqlQuery = @"INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                                VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);
                                SELECT SCOPE_IDENTITY();";
            object result = await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);
            return Convert.ToInt32(result);
        }
        public async Task<bool> UpdateAsync(DetainedLicense detain)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@DetainID", detain.DetainID },
                { "@LicenseID", detain.LicenseID },
                { "@DetainDate", detain.DetainDate },
                { "@FineFees", detain.FineFees },
                { "@CreatedByUserID", detain.CreatedByUserID },
                { "@IsReleased", detain.IsReleased },
                { "@ReleaseDate", (object)detain.ReleaseDate ?? DBNull.Value },
                { "@ReleasedByUserID", (object)detain.ReleasedByUserID ?? DBNull.Value },
                { "@ReleaseApplicationID", (object)detain.ReleaseApplicationID ?? DBNull.Value }
            };
            string sqlQuery = @"UPDATE DetainedLicenses SET
                                LicenseID = @LicenseID,
                                DetainDate = @DetainDate,
                                FineFees = @FineFees,
                                CreatedByUserID = @CreatedByUserID,
                                IsReleased = @IsReleased,
                                ReleaseDate = @ReleaseDate,
                                ReleasedByUserID = @ReleasedByUserID,
                                ReleaseApplicationID = @ReleaseApplicationID
                                WHERE DetainID = @DetainID;";
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@DetainID", id } };
            string sqlQuery = "DELETE FROM DetainedLicenses WHERE DetainID = @DetainID";
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
        public async Task<bool> IsLicenseDetainedAsync(int licenseId)
        {
            var parameters = new Dictionary<string, object> { { "@LicenseID", licenseId } };
            string sqlQuery = "SELECT COUNT(*) FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0";
            object result = await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);
            return Convert.ToInt32(result) > 0;
        }
        public async Task<bool> ReleaseDetainedLicenseAsync(int detainId, int releasedByUserId, int releaseApplicationId)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@DetainID", detainId },
                { "@IsReleased", true },
                { "@ReleaseDate", DateTime.Now },
                { "@ReleasedByUserID", releasedByUserId },
                { "@ReleaseApplicationID", releaseApplicationId }
            };
            string sqlQuery = @"UPDATE DetainedLicenses SET
                                IsReleased = @IsReleased,
                                ReleaseDate = @ReleaseDate,
                                ReleasedByUserID = @ReleasedByUserID,
                                ReleaseApplicationID = @ReleaseApplicationID
                                WHERE DetainID = @DetainID AND IsReleased = 0;";
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
    }
}
