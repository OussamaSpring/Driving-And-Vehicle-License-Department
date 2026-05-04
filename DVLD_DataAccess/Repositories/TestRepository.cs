using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using DVLD_DataAccess.Database;
using Core.Models;

namespace DVLD_DataAccess.Repositories
{
    public class TestRepository : ITestRepository
    {
        private Test MapTest(DataRow row)
        {
            if (row == null)
                return null;

            return new Test
            {
                Id = row.Field<int>("TestID"),
                TestAppointmentId = row.Field<int>("TestAppointmentID"),
                Result = row.Field<bool>("TestResult"),
                Notes = row["Notes"] == DBNull.Value ? null : row.Field<string>("Notes"),
                CreatedByUserId = row.Field<int>("CreatedByUserID")
            };
        }

        public async Task<int> AddAsync(Test entity)
        {
            using (var connection = DBHelper.CreateOpenConnection())
            using (var transaction = DBHelper.BeginTransaction(connection))
            {
                try
                {
                    // 1. Insert new test
                    string insertTestSql = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                                             VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                                             SELECT SCOPE_IDENTITY();";
                    var testParams = new Dictionary<string, object>
                    {
                        {"@TestAppointmentID", entity.TestAppointmentId},
                        {"@TestResult", entity.Result},
                        {"@Notes", (object)entity.Notes ?? System.DBNull.Value},
                        {"@CreatedByUserID", entity.CreatedByUserId}
                    };
                    object result = await DBHelper.ExecuteScalarAsync(insertTestSql, testParams, connection, transaction);
                    int newTestId = (result != null && int.TryParse(result.ToString(), out int id)) ? id : -1;

                    if (newTestId == -1)
                    {
                        transaction.Rollback();
                        return -1;
                    }

                    // 2. Lock the corresponding appointment
                    string updateAppointmentSql = @"UPDATE TestAppointments SET IsLocked = 1 WHERE TestAppointmentID = @TestAppointmentID";
                    var updateParams = new Dictionary<string, object>
                    {
                        {"@TestAppointmentID", entity.TestAppointmentId}
                    };
                    int rows = await DBHelper.ExecuteNonQueryAsync(updateAppointmentSql, updateParams, connection, transaction);
                    if (rows == 0)
                    {
                        transaction.Rollback();
                        return -1;
                    }

                    transaction.Commit();
                    return newTestId;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            string query = "DELETE FROM Tests WHERE TestID = @TestID";
            var parameters = new Dictionary<string, object> { {"@TestID", id} };
            int rows = await DBHelper.ExecuteNonQueryAsync(query, parameters);
            return rows > 0;
        }

        public async Task<IEnumerable<Test>> GetAllAsync()
        {
            string query = "SELECT * FROM Tests";
            var dt = await DBHelper.ExecuteReaderAsync(query);
            var list = new List<Test>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapTest(row));
            }
            return list;
        }

        public async Task<Test> GetByIdAsync(int id)
        {
            string query = "SELECT * FROM Tests WHERE TestID = @TestID";
            var parameters = new Dictionary<string, object> { {"@TestID", id} };
            var dt = await DBHelper.ExecuteReaderAsync(query, parameters);
            if (dt.Rows.Count == 0)
                return null;
            return MapTest(dt.Rows[0]);
        }

        public async Task<bool> UpdateAsync(Test entity)
        {
            string query = @"UPDATE Tests SET
                                TestAppointmentID = @TestAppointmentID,
                                TestResult = @TestResult,
                                Notes = @Notes,
                                CreatedByUserID = @CreatedByUserID
                              WHERE TestID = @TestID";
            var parameters = new Dictionary<string, object>
            {
                {"@TestID", entity.Id},
                {"@TestAppointmentID", entity.TestAppointmentId},
                {"@TestResult", entity.Result},
                {"@Notes", (object)entity.Notes ?? System.DBNull.Value},
                {"@CreatedByUserID", entity.CreatedByUserId}
            };
            int rows = await DBHelper.ExecuteNonQueryAsync(query, parameters);
            return rows > 0;
        }

        public async Task<int> GetTotalPassedTestCountAsync(int localDrivingLicenseApplicationId)
        {
            string query = @"SELECT COUNT(*) FROM Tests t
                             INNER JOIN TestAppointments ta ON t.TestAppointmentID = ta.TestAppointmentID
                             WHERE ta.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND t.TestResult = 1";
            var parameters = new Dictionary<string, object> { {"@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationId} };
            object result = await DBHelper.ExecuteScalarAsync(query, parameters);
            return (result != null && int.TryParse(result.ToString(), out int count)) ? count : 0;
        }
    }
}
