using Core.Enums;
using Core.Models;
using Core.Interfaces;
using DVLD_DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Repositories
{
    public class LocalDrivingLicenseApplicationRepository : ILocalDrivingLicenseRepository
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
        public async Task<int> AddNewLocalDrivingLicenseApplicationAsync(Applications application, int licenseClassId)
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
    }
}
