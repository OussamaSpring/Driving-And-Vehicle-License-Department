using Core.Enums;
using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace DVLD_DataAccess.Repositories
{
    public class LocalDrivingLicenseApplicationRepository : ILocalDrivingLicenseApplicationRepository
    {
        #region Help Functions

        private LocalDrivingLicenseApplication MapLDLApplication(DataRow row)
        {
            if (row == null)
                return null;

            return new LocalDrivingLicenseApplication()
            {
                LDL_ApplicationId = row.Field<int>("LocalDrivingLicenseApplicationID"),
                LicenseClass = new LicenseClass()
                {
                    Id = Convert.ToInt16(row["LicenseClassID"]),
                    Name = row.Field<string>("ClassName"),
                    Description = row.Field<string>("ClassDescription"),
                    MiminumAllowedAge = Convert.ToInt16(row["MinimumAllowedAge"]),
                    DefaultValidityLength = Convert.ToInt16(row["DefaultValidityLength"]),
                    ClassFees = Convert.ToDecimal(row["ClassFees"])
                },
                NationalNumber = row.Field<string>("NationalNo"),
                FullName = row.Field<string>("FullName"),
                ApplicationId = row.Field<int>("ApplicationID"),
                ApplicationDate = row.Field<DateTime>("ApplicationDate"),
                PassedTest = Convert.ToInt16(row["PassedTest"]),
                Status = (ApplicationStatus)row.Field<byte>("ApplicationStatus")
            };
        }

        private async Task<int> InsertApplicationAsync(Applications application, SqlConnection connection, SqlTransaction transaction)
        {
            var appParams = new Dictionary<string, object>
            {
                { "@ApplicantPersonID", application.ApplicantPersonId },
                { "@ApplicationDate", application.ApplicationDate },
                { "@ApplicationTypeID", application.ApplicationType.ApplicationTypeId },
                { "@ApplicationStatus", application.enApplicationStatus },
                { "@LastStatusDate", (object)application.LastStatusDate ?? DBNull.Value },
                { "@PaidFees", (object)application.PaidFees ?? DBNull.Value },
                { "@CreatedByUserID", application.CreatedByUserId }
            };

            string insertAppSql = @"INSERT INTO Applications 
                                    (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                                    VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                                    SELECT SCOPE_IDENTITY();";

            var newAppIdObj = await DBHelper.ExecuteScalarAsync(insertAppSql, appParams, connection, transaction);
            return Convert.ToInt32(newAppIdObj);
        }


        #endregion

        public async Task<LocalDrivingLicenseApplication> GetByIdAsync(int id)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@ApplicationId", id }
            };
            string sqlQuery = @"SELECT * FROM vw_LocalDrivingLicenseApplicationTable 
                                WHERE ApplicationID = @ApplicationId";

            var DataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);

            if (DataTable.Rows.Count == 0)
                return null;

            var row = DataTable.Rows[0];
            return MapLDLApplication(row);
        }


        public async Task<IEnumerable<LocalDrivingLicenseApplication>> GetAllAsync()
        {
            string sqlQuery = "SELECT * FROM vw_LocalDrivingLicenseApplicationTable;";

            var DataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);

            var LDLApplications = new List<LocalDrivingLicenseApplication>();
            foreach (DataRow row in DataTable.Rows)
            {
                LDLApplications.Add(MapLDLApplication(row));
            }

            return LDLApplications;
        }

        public async Task<int> AddAsync(Applications application, int licenseClassId)
        {
            using (var connection = DBHelper.CreateOpenConnection())
            using (var transaction = DBHelper.BeginTransaction(connection))
            {
                try
                {
                    var newAppId = await InsertApplicationAsync(application, connection, transaction);
                    // Insert into LocalDrivingLicenseApplications
                    var ldlaParams = new Dictionary<string, object>
                    {
                        { "@ApplicationId", newAppId },
                        { "@LicenseClassId", licenseClassId }
                    };
                    string insertLDLA_Sql = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                                              VALUES (@ApplicationId, @LicenseClassId);
                                              SELECT SCOPE_IDENTITY();";
                    var ldlaId = await DBHelper.ExecuteScalarAsync(insertLDLA_Sql, ldlaParams, connection, transaction);
                    transaction.Commit();
                    return Convert.ToInt32(ldlaId);
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public async Task<bool> UpdateAsync(int LDLApplicationId, int applicationId, int licenseClassId)
        {
            string query = @"UPDATE L
                             SET L.ApplicationID = @ApplicationID,
                                 L.LicenseClassID = @LicenseClassID
                             FROM LocalDrivingLicenseApplications AS L
                             WHERE L.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            var parameters = new Dictionary<string, object>
            {
                { "@LocalDrivingLicenseApplicationID", LDLApplicationId },
                { "@ApplicationID", applicationId },
                { "@LicenseClassID", licenseClassId }
            };
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(query, parameters);
            return rowsAffected > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            string query = @"DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            var parameters = new Dictionary<string, object>
            {
                { "@LocalDrivingLicenseApplicationID", id }
            };
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(query, parameters);
            return rowsAffected > 0;
        }

        public async Task<bool> DoesPassTestTypeAsync(int localDrivingLicenseApplicationId, int testTypeId)
        {
            string query = @"SELECT TOP 1 T.TestResult
                            FROM LocalDrivingLicenseApplications AS L
                            INNER JOIN TestAppointments AS TA ON L.LocalDrivingLicenseApplicationID = TA.LocalDrivingLicenseApplicationID
                            INNER JOIN Tests AS T ON TA.TestAppointmentID = T.TestAppointmentID
                            WHERE L.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                              AND TA.TestTypeID = @TestTypeID
                            ORDER BY TA.TestAppointmentID DESC";
            var parameters = new Dictionary<string, object>
            {
                { "@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationId },
                { "@TestTypeID", testTypeId }
            };
            object result = await DBHelper.ExecuteScalarAsync(query, parameters);
            if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
            {
                return returnedResult;
            }
            return false;
        }

        public async Task<int> GetTotalTrialsPerTestAsync(int localDrivingLicenseApplicationId, int testTypeId)
        {
            string query = @"SELECT COUNT(T.TestID)
                            FROM LocalDrivingLicenseApplications AS L
                            INNER JOIN TestAppointments AS TA ON L.LocalDrivingLicenseApplicationID = TA.LocalDrivingLicenseApplicationID
                            INNER JOIN Tests AS T ON TA.TestAppointmentID = T.TestAppointmentID
                            WHERE L.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                              AND TA.TestTypeID = @TestTypeID";
            var parameters = new Dictionary<string, object>
            {
                { "@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationId },
                { "@TestTypeID", testTypeId }
            };
            object result = await DBHelper.ExecuteScalarAsync(query, parameters);
            if (result != null && int.TryParse(result.ToString(), out int trials))
            {
                return trials;
            }
            return 0;
        }

        public async Task<bool> IsThereActiveScheduledTestExistAsync(int localDrivingLicenseApplicationId, int testTypeId)
        {
            string query = @"IF EXISTS (
                                SELECT 1
                                FROM LocalDrivingLicenseApplications AS L
                                INNER JOIN TestAppointments AS TA ON L.LocalDrivingLicenseApplicationID = TA.LocalDrivingLicenseApplicationID
                                WHERE L.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                  AND TA.TestTypeID = @TestTypeID
                                  AND TA.isLocked = 0
                              ) SELECT 1 ELSE SELECT 0";
            var parameters = new Dictionary<string, object>
            {
                { "@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationId },
                { "@TestTypeID", testTypeId }
            };
            object result = await DBHelper.ExecuteScalarAsync(query, parameters);
            return result != null && result.ToString() == "1";
        }

       
    }
}
