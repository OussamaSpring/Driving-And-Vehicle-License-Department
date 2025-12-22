using Core.Enums;
using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
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

            return new LocalDrivingLicenseApplication
            {
                LDL_ApplicationId = row.Field<int>("LocalDrivingLicenseApplicationID"),
                LicenseClass = new LicenseClass
                {
                    Id = row.Field<short>("LicenseClassID"),
                    Name = row.Field<string>("ClassName"),
                    Description = row.Field<string>("ClassDescription"),
                    MiminumAllowedAge = row.Field<short>("MinimumAllowedAge"),
                    DefaultValidityLength = row.Field<short>("DefaultValidityLength"),
                    ClassFees = row.Field<decimal>("ClassFees")
                },
                NationalNumber = row.Field<string>("NationalNo"),
                FullName = row.Field<string>("FullName"),
                ApplicationId = row.Field<int>("ApplicationID"),
                ApplicationDate = row.Field<DateTime>("ApplicationDate"),
                PassedTest = row.Field<short>("PassedTest"),
                Status = (ApplicationStatus)row.Field<byte>("ApplicationStatus")
            };
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
        public async Task<bool> ReleaseDetainedDrivingLicenseAsync(Applications application, DetainedLicense detainedLicense)
        {
            using (var connection = DBHelper.CreateOpenConnection())
            using (var transaction = DBHelper.BeginTransaction(connection))
            {
                try
                {
                    // Insert into Applications table
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
                    detainedLicense.ReleaseApplicationID = Convert.ToInt32(newAppIdObj);


                    // Update detained license release info
                    var updateParams = new Dictionary<string, object>
                    {
                        { "@DetainID", detainedLicense.DetainID },
                        { "@IsReleased", detainedLicense.IsReleased },
                        { "@ReleaseDate", detainedLicense.ReleaseDate},
                        { "@ReleasedByUserID", detainedLicense.ReleasedByUserID},
                        { "@ReleaseApplicationID", detainedLicense.ReleaseApplicationID }
                    };

                    string updateSql = @"UPDATE DetainLicenses
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
        public async Task<int> RenewExpiredDrivingLicenseAsync(Applications application, License renewedLicense)
        {
            using (var connection = DBHelper.CreateOpenConnection())
            using (var transaction = DBHelper.BeginTransaction(connection))
            {
                try
                {
                    // Insert new Application
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
                    int newAppId = Convert.ToInt32(newAppIdObj);

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
        public async Task<int> ReplaceDamagedDrivingLicenseAsync(Applications application, License damagedLicense)
        {
            using (var connection = DBHelper.CreateOpenConnection())
            using (var transaction = DBHelper.BeginTransaction(connection))
            {
                try
                {
                    // Insert new Application
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
                    int newAppId = Convert.ToInt32(newAppIdObj);

                    // Insert new License
                    var licenseParams = new Dictionary<string, object>
                    {
                        { "@ApplicationId", newAppId },
                        { "@DriverId", damagedLicense.DriverId },
                        { "@ClassId", damagedLicense.ClassId },
                        { "@IssueDate", damagedLicense.IssueDate },
                        { "@ExpirationDate", damagedLicense.ExpirationDate },
                        { "@Notes", damagedLicense.Notes ?? string.Empty },
                        { "@PaidFees", damagedLicense.PaidFees },
                        { "@IsActive", damagedLicense.IsActive },
                        { "@enIssuesReason", (int)LicenseIsssueReasons.ReplacementForDamaged },
                        { "@IssuedByUserId", damagedLicense.IssuedByUserId }
                    };
                    string insertLicenseSql = @"INSERT INTO Licenses
                                            (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssuesReason, CreatedByUserID)
                                            VALUES (@ApplicationId, @DriverId, @ClassId, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @enIssuesReason, @IssuedByUserId);
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
        public async Task<int> ReplaceLostDrivingLicenseAsync(Applications application, License lostLicense)
        {
            using (var connection = DBHelper.CreateOpenConnection())
            using (var transaction = DBHelper.BeginTransaction(connection))
            {
                try
                {
                    // Insert new Application
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
                    int newAppId = Convert.ToInt32(newAppIdObj);

                    // Insert new License
                    var licenseParams = new Dictionary<string, object>
                    {
                        { "@ApplicationId", newAppId },
                        { "@DriverId", lostLicense.DriverId },
                        { "@ClassId", lostLicense.ClassId },
                        { "@IssueDate", lostLicense.IssueDate },
                        { "@ExpirationDate", lostLicense.ExpirationDate },
                        { "@Notes", lostLicense.Notes ?? string.Empty },
                        { "@PaidFees", lostLicense.PaidFees },
                        { "@IsActive", lostLicense.IsActive },
                        { "@enIssuesReason", (int)LicenseIsssueReasons.ReplacementForLost },
                        { "@IssuedByUserId", lostLicense.IssuedByUserId }
                    };
                    string insertLicenseSql = @"INSERT INTO Licenses
                                            (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssuesReason, CreatedByUserID)
                                            VALUES (@ApplicationId, @DriverId, @ClassId, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @enIssuesReason, @IssuedByUserId);
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
