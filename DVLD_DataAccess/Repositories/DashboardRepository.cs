using Core.Interfaces;
using Core.DTOs;
using System;
using System.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using DVLD_DataAccess.Database;

namespace DVLD_DataAccess.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        #region HelpFunctions

        private DashboardStatisticsDto MapDashboardStatisticsDto(DataRow row)
        {
            if (row == null) return null;
            return new DashboardStatisticsDto
            {
                RegisteredDrivers = row["RegisteredDrivers"] != DBNull.Value ? Convert.ToInt32(row["RegisteredDrivers"]) : 0,
                ActiveLicenses = row["ActiveLicenses"] != DBNull.Value ? Convert.ToInt32(row["ActiveLicenses"]) : 0,
                PendingApplications = row["PendingApplications"] != DBNull.Value ? Convert.ToInt32(row["PendingApplications"]) : 0,
                ScheduledTests = row["ScheduledTests"] != DBNull.Value ? Convert.ToInt32(row["ScheduledTests"]) : 0
            };
        }

        private ApplicationTypeDto MapApplicationTypeDto(DataRow row)
        {
            if (row == null) return null;
            return new ApplicationTypeDto
            {
                ApplicationTypeName = row["ApplicationTypeName"]?.ToString(),
                TotalApplications = row["TotalApplications"] != DBNull.Value ? Convert.ToInt32(row["TotalApplications"]) : 0
            };
        }

        private DetainedRevenueDto MapDetainedRevenueDto(DataRow row)
        {
            if (row == null) return null;
            return new DetainedRevenueDto
            {
                MonthName = row["MonthName"]?.ToString() ?? string.Empty,
                DetainedLicensesCount = row["DetainedLicensesCount"] != DBNull.Value ? Convert.ToInt32(row["DetainedLicensesCount"]) : 0,
                Revenue = row["Revenue"] != DBNull.Value ? Convert.ToDecimal(row["Revenue"]) : 0m
            };
        }

        private LicenseDistributionDto MapLicenseDistributionDto(DataRow row)
        {
            if (row == null) return null;
            return new LicenseDistributionDto
            {
                LicenseClassName = row["LicenseClassName"]?.ToString() ?? string.Empty,
                TotalLicenses = row["TotalLicenses"] != DBNull.Value ? Convert.ToInt32(row["TotalLicenses"]) : 0
            };
        }

        private RecentTestResultDto MapRecentTestResultDto(DataRow row)
        {
            if (row == null) return null;
            return new RecentTestResultDto
            {
                ApplicantName = row["ApplicantName"]?.ToString() ?? string.Empty,
                TestType = row["TestType"]?.ToString() ?? string.Empty,
                Result = row["Result"]?.ToString() ?? string.Empty,
                TestDate = row["TestDate"] != DBNull.Value ? Convert.ToDateTime(row["TestDate"]) : default(DateTime)
            };
        }

        #endregion

        public async Task<DashboardStatisticsDto> GetStatisticsAsync()
        {
            string sqlQuery = @"
                SELECT
                    (SELECT COUNT(*) FROM Drivers) AS RegisteredDrivers,
                    (SELECT COUNT(*) FROM Licenses WHERE IsActive = 1) AS ActiveLicenses,
                    (SELECT COUNT(*) FROM Applications WHERE ApplicationStatus = 1) AS PendingApplications,
                    (SELECT COUNT(*) 
                        FROM TestAppointments 
                        WHERE CAST(AppointmentDate AS DATE) = CAST(GETDATE() AS DATE)
                    ) AS ScheduledTests;";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);
            if (dataTable.Rows.Count == 0)
                return null;
            var row = dataTable.Rows[0];
            return MapDashboardStatisticsDto(row);
        }

        public async Task<IEnumerable<ApplicationTypeDto>> GetApplicationsByServiceTypeAsync()
        {
            string sqlQuery = @"
                SELECT at.ApplicationTypeTitle AS ApplicationTypeName, COUNT(a.ApplicationID) AS TotalApplications
                FROM Applications a
                JOIN ApplicationTypes at ON a.ApplicationTypeID = at.ApplicationTypeID
                GROUP BY at.ApplicationTypeTitle
                ORDER BY TotalApplications DESC;";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);
            var list = new List<ApplicationTypeDto>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapApplicationTypeDto(row));
            }
            return list;
        }

        public async Task<IEnumerable<DetainedRevenueDto>> GetDetainedRevenueByMonthAsync()
        {
            string sqlQuery = @"
                SELECT 
                    DATENAME(MONTH, ReleaseDate) AS MonthName,
                    COUNT(*) AS DetainedLicensesCount,
                    SUM(FineFees) AS Revenue
                FROM DetainedLicenses
                WHERE ReleaseDate >= DATEADD(MONTH, -6, GETDATE())
                GROUP BY DATENAME(MONTH, ReleaseDate), MONTH(ReleaseDate), YEAR(ReleaseDate)
                ORDER BY YEAR(ReleaseDate), MONTH(ReleaseDate);";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);
            var list = new List<DetainedRevenueDto>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapDetainedRevenueDto(row));
            }
            return list;
        }

        public async Task<IEnumerable<LicenseDistributionDto>> GetLicenseDistributionAsync()
        {
            string sqlQuery = @"
                SELECT lc.ClassName AS LicenseClassName, COUNT(l.LicenseID) AS TotalLicenses
                FROM Licenses l
                RIGHT JOIN LicenseClasses lc on l.LicenseClass = lc.LicenseClassID
                GROUP BY lc.ClassName
                ORDER BY LicenseClassName;";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);
            var list = new List<LicenseDistributionDto>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapLicenseDistributionDto(row));
            }
            return list;
        }

        public async Task<IEnumerable<RecentTestResultDto>> GetRecentTestResultsAsync()
        {
            string sqlQuery = @"
                SELECT TOP(10) CONCAT_WS(' ', p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS ApplicantName,
                       tt.TestTypeTitle AS TestType,
                       t.TestResult AS Result,
                       ta.AppointmentDate AS TestDate
                FROM Applications a
                JOIN TestAppointments ta ON a.ApplicationID = ta.RetakeTestApplicationID
                JOIN Tests t ON ta.TestAppointmentID = t.TestAppointmentID
                JOIN TestTypes tt ON ta.TestTypeID = tt.TestTypeID
                JOIN People p ON a.ApplicantPersonID = p.PersonID
                ORDER BY TestDate DESC;";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);
            var list = new List<RecentTestResultDto>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapRecentTestResultDto(row));
            }
            return list;
        }
    }
}
