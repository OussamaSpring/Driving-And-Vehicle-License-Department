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
    public class ApplicationsRepository : IApplicationsRepository
    {
        #region HelpFunctions

        // mapping from row is used through "Field" which is more modern and than traditional converting method
        private Applications MapApplications(DataRow row)
        {
            if (row == null)
                return null;

            return new Applications
            {
                ApplicationId = row.Field<int>("ApplicationID"),
                ApplicantPersonId = row.Field<int>("ApplicantPersonID"),
                ApplicationDate = row.Field<DateTime>("ApplicationDate"),
                ApplicationType = new ApplicationType
                {
                    ApplicationTypeId = row.Field<int>("ApplicationTypeID"),
                    ApplicationTypeName = row.Field<string>("ApplicationTypeTitle"),
                    ApplicationTypeFees = row.Field<decimal>("ApplicationFees")
                },
                enApplicationStatus = (ApplicationStatus)row.Field<byte>("ApplicationStatus"),
                LastStatusDate = row.Field<DateTime?>("LastStatusDate"),
                PaidFees = row.Field<decimal?>("PaidFees"),
                CreatedByUserId = row.Field<int>("CreatedByUserID")
            };
        }

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



        public async Task<LocalDrivingLicenseApplication> GetLocalDrivingLicenseApplicationByIdAsync(int id)
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
        public async Task<IEnumerable<LocalDrivingLicenseApplication>> GetAllLocalDrivingLicenseApplicationsAsync()
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
        public async Task<Applications> GetByIdAsync(int id)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@ApplicationId", id }
            };
            string sqlQuery = @"SELECT a.ApplicationID, a.ApplicantPersonID, a.ApplicationDate, at.*, a.ApplicationStatus, 
                                       a.LastStatusDate, a.PaidFees, a.CreatedByUserID
                                FROM Applications a
                                JOIN ApplicationTypes at ON a.ApplicationTypeId = at.ApplicationTypeId
                                WHERE a.ApplicationID = @ApplicationId";

            var DataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);

            if (DataTable.Rows.Count == 0)
                return null;

            var row = DataTable.Rows[0];
            return MapApplications(row);
        }
        public async Task<IEnumerable<Applications>> GetAllAsync()
        {
            string sqlQuery = @"SELECT a.ApplicationID, a.ApplicantPersonID, a.ApplicationDate, at.*, a.ApplicationStatus, 
                                       a.LastStatusDate, a.PaidFees, a.CreatedByUserID
                                FROM Applications a
                                JOIN ApplicationTypes at ON a.ApplicationTypeID = at.ApplicationTypeID;";

            var DataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);

            var ApplicationsList = new List<Applications>();
            foreach (DataRow row in DataTable.Rows)
            {
                ApplicationsList.Add(MapApplications(row));
            }

            return ApplicationsList;
        }

        public async Task<int> AddNewLocalDrivingLicenseApplicationAsync(Applications application, int licenseClassId)
        { 
            using (var connection = DBHelper.CreateOpenConnection())
            using(var transaction = DBHelper.BeginTransaction(connection))
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
        public async Task<int> AddNewInternationalLicenseApplicationAsync(Applications application, InternationalLicense localLicense)
        {
            using (var connection = DBHelper.CreateOpenConnection())
            using (var transaction = DBHelper.BeginTransaction(connection))
            {
                try
                {
                    var newAppId = await InsertApplicationAsync(application, connection, transaction);

                    // Insert into InternationalLicenses
                    var ilaParams = new Dictionary<string, object>
                    {
                        { "@ApplicationId", newAppId },
                        { "@DriverId",localLicense.DriverId },
                        { "@IssuedUsingLocalLicenseId", localLicense.LocalLicenseId },
                        { "@IssueDate", localLicense.IssueDate },
                        { "@ExpirationDate", localLicense.ExpirationDate},
                        { "@IsActive", localLicense.IsActive },
                        { "@CreatedByUserId", localLicense.IssuedByUserId }
                    };
                    string insertILA_Sql = @"INSERT INTO InternationalLicenses
                                            (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                                              VALUES (@ApplicationId, @DriverId, @IssuedUsingLocalLicenseId, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserId);
                                              SELECT SCOPE_IDENTITY();";
                    var ilaId = await DBHelper.ExecuteScalarAsync(insertILA_Sql, ilaParams, connection, transaction);
                    transaction.Commit();
                    return Convert.ToInt32(ilaId);
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        public async Task<bool> ReleaseDetainedDrivingLicenseAsync(Applications application, int detainId, int userId)
        {
            using (var connection = DBHelper.CreateOpenConnection())
            using (var transaction = DBHelper.BeginTransaction(connection))
            {
                try
                {
                    var newAppId = await InsertApplicationAsync(application, connection, transaction);

                    // Update detained license release info
                    var updateParams = new Dictionary<string, object>
                    {
                        { "@DetainID", detainId },
                        { "@IsReleased", true },
                        { "@ReleaseDate", DateTime.Now},
                        { "@ReleasedByUserID", userId},
                        { "@ReleaseApplicationID", newAppId }
                    };

                    string updateSql = @"UPDATE DetainedLicenses
                                 SET IsReleased = @IsReleased,
                                     ReleaseDate = @ReleaseDate,
                                     ReleasedByUserID = @ReleasedByUserID,
                                     ReleaseApplicationID = @ReleaseApplicationID
                                 WHERE DetainID = @DetainID;";

                    await DBHelper.ExecuteNonQueryAsync(updateSql, updateParams, connection, transaction);

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        public async Task<int> RenewExpiredDrivingLicenseAsync(Applications application, License renewedLicense, int oldLicenseId)
        {
            using (var connection = DBHelper.CreateOpenConnection())
            using (var transaction = DBHelper.BeginTransaction(connection))
            {
                try
                {
                    var newAppId = await InsertApplicationAsync(application, connection, transaction);

                    // Insert new License
                    var licenseParams = new Dictionary<string, object>
                    {
                        { "@ApplicationId", newAppId },
                        { "@DriverId", renewedLicense.DriverId },
                        { "@ClassId", renewedLicense.ClassId },
                        { "@IssueDate", renewedLicense.IssueDate },
                        { "@ExpirationDate", renewedLicense.ExpirationDate },
                        { "@Notes", renewedLicense.Notes ?? string.Empty },
                        { "@PaidFees", renewedLicense.PaidFees },
                        { "@IsActive", renewedLicense.IsActive },
                        { "@enIssuesReason", (int)LicenseIsssueReasons.Renew },
                        { "@IssuedByUserId", renewedLicense.IssuedByUserId }
                    };
                    string insertLicenseSql = @"INSERT INTO Licenses
                                            (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssuesReason, CreatedByUserID)
                                            VALUES (@ApplicationId, @DriverId, @ClassId, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @enIssuesReason, @IssuedByUserId);
                                            SELECT SCOPE_IDENTITY();";
                    var newLicenseIdObj = await DBHelper.ExecuteScalarAsync(insertLicenseSql, licenseParams, connection, transaction);

                    // Set old license to inactive
                    var updateOldLicenseParams = new Dictionary<string, object>
                    {
                        { "@LicenseId", oldLicenseId }
                    };
                    string updateOldLicenseSql = @"UPDATE Licenses SET IsActive = 0 WHERE LicenseID = @LicenseId;";
                    await DBHelper.ExecuteNonQueryAsync(updateOldLicenseSql, updateOldLicenseParams, connection, transaction);


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
        public async Task<int> ReplaceDamagedDrivingLicenseAsync(Applications application, License replacementLicense, int oldLicenseId)
        {
            using (var connection = DBHelper.CreateOpenConnection())
            using (var transaction = DBHelper.BeginTransaction(connection))
            {
                try
                {
                    var newAppId = await InsertApplicationAsync(application, connection, transaction);

                    // Insert new License
                    var licenseParams = new Dictionary<string, object>
                    {
                        { "@ApplicationId", newAppId },
                        { "@DriverId", replacementLicense.DriverId },
                        { "@ClassId", replacementLicense.ClassId },
                        { "@IssueDate", replacementLicense.IssueDate },
                        { "@ExpirationDate", replacementLicense.ExpirationDate },
                        { "@Notes", replacementLicense.Notes ?? string.Empty },
                        { "@PaidFees", replacementLicense.PaidFees },
                        { "@IsActive", replacementLicense.IsActive },
                        { "@enIssuesReason", (int)LicenseIsssueReasons.ReplacementForDamaged },
                        { "@IssuedByUserId", replacementLicense.IssuedByUserId }
                    };
                    string insertLicenseSql = @"INSERT INTO Licenses
                                            (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssuesReason, CreatedByUserID)
                                            VALUES (@ApplicationId, @DriverId, @ClassId, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @enIssuesReason, @IssuedByUserId);
                                            SELECT SCOPE_IDENTITY();";
                    var newLicenseIdObj = await DBHelper.ExecuteScalarAsync(insertLicenseSql, licenseParams, connection, transaction);

                    // Set old license to inactive
                    var updateOldLicenseParams = new Dictionary<string, object>
                    {
                        { "@LicenseId", oldLicenseId }
                    };
                    string updateOldLicenseSql = @"UPDATE Licenses SET IsActive = 0 WHERE LicenseID = @LicenseId;";
                    await DBHelper.ExecuteNonQueryAsync(updateOldLicenseSql, updateOldLicenseParams, connection, transaction);

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
        public async Task<int> ReplaceLostDrivingLicenseAsync(Applications application, License replacementLicense, int oldLicenseId)
        {
            using (var connection = DBHelper.CreateOpenConnection())
            using (var transaction = DBHelper.BeginTransaction(connection))
            {
                try
                {
                    var newAppId = await InsertApplicationAsync(application, connection, transaction);

                    // Insert new License
                    var licenseParams = new Dictionary<string, object>
                    {
                        { "@ApplicationId", newAppId },
                        { "@DriverId", replacementLicense.DriverId },
                        { "@ClassId", replacementLicense.ClassId },
                        { "@IssueDate", replacementLicense.IssueDate },
                        { "@ExpirationDate", replacementLicense.ExpirationDate },
                        { "@Notes", replacementLicense.Notes ?? string.Empty },
                        { "@PaidFees", replacementLicense.PaidFees },
                        { "@IsActive", replacementLicense.IsActive },
                        { "@enIssuesReason", (int)LicenseIsssueReasons.ReplacementForLost },
                        { "@IssuedByUserId", replacementLicense.IssuedByUserId }
                    };
                    string insertLicenseSql = @"INSERT INTO Licenses
                                            (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssuesReason, CreatedByUserID)
                                            VALUES (@ApplicationId, @DriverId, @ClassId, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @enIssuesReason, @IssuedByUserId);
                                            SELECT SCOPE_IDENTITY();";
                    var newLicenseIdObj = await DBHelper.ExecuteScalarAsync(insertLicenseSql, licenseParams, connection, transaction);

                    // Set old license to inactive
                    var updateOldLicenseParams = new Dictionary<string, object>
                    {
                        { "@LicenseId", oldLicenseId }
                    };
                    string updateOldLicenseSql = @"UPDATE Licenses SET IsActive = 0 WHERE LicenseID = @LicenseId;";
                    await DBHelper.ExecuteNonQueryAsync(updateOldLicenseSql, updateOldLicenseParams, connection, transaction);

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
