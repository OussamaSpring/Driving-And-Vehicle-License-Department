using Core.Interfaces;
using Core.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using DVLD_DataAccess.Database;


namespace DVLD_DataAccess.Repositories
{
    public class TestAppointmentRepository : ITestAppointmentRepository
    {
        // TODO: Implement the logic of rescheduling a test appointment not creating one for the same time.

        #region Help Functions
        private TestAppointment MapTestAppointment(DataRow row)
        {
            if (row == null)
                return null;

            var testType = new TestType
            {
                TypeId = row.Field<int>("TestTypeID"),
                TypeTitle = row.Field<string>("TestTypeTitle"),
                TypeDescription = row.Field<string>("TestTypeDescription"),
                TypeFee = row.Field<float>("TestTypeFees")
            };

            return new TestAppointment
            {
                TestAppointmentId = row.Field<int>("TestAppointmentID"),
                TestType = testType,
                LocalDrivingLicenseApplicationId = row.Field<int>("LocalDrivingLicenseApplicationID"),
                AppointmentDate = row.Field<System.DateTime>("AppointmentDate"),
                PaidFees = row.Field<decimal>("PaidFees"),
                CreatedByUserId = row.Field<int>("CreatedByUserID"),
                isLocked = row.Field<bool>("IsLocked"),
                RetakeApplicationId = row["RetakeTestApplicationID"] == System.DBNull.Value ? -1 : row.Field<int>("RetakeTestApplicationID")
            };
        }
        #endregion

        public async Task<int> AddAsync(TestAppointment entity)
        {
            string query = @"INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                             VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
                             SELECT SCOPE_IDENTITY();";
            var parameters = new Dictionary<string, object>
            {
                {"@TestTypeID", entity.TestType.TypeId},
                {"@LocalDrivingLicenseApplicationID", entity.LocalDrivingLicenseApplicationId},
                {"@AppointmentDate", entity.AppointmentDate},
                {"@PaidFees", entity.PaidFees},
                {"@CreatedByUserID", entity.CreatedByUserId},
                {"@IsLocked", entity.isLocked},
                {"@RetakeTestApplicationID", entity.RetakeApplicationId == -1 ? (object)System.DBNull.Value : entity.RetakeApplicationId}
            };
            object result = await DBHelper.ExecuteScalarAsync(query, parameters);
            return result != null && int.TryParse(result.ToString(), out int id) ? id : -1;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            string query = "DELETE FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            var parameters = new Dictionary<string, object> { {"@TestAppointmentID", id} };
            int rows = await DBHelper.ExecuteNonQueryAsync(query, parameters);
            return rows > 0;
        }

        public async Task<IEnumerable<TestAppointment>> GetAllAsync()
        {
            string query = "SELECT * FROM vw_TestAppointment ORDER BY AppointmentDate DESC";
            var dt = await DBHelper.ExecuteReaderAsync(query);
            var list = new List<TestAppointment>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapTestAppointment(row));
            }
            return list;
        }

        public async Task<TestAppointment> GetByIdAsync(int id)
        {
            string query = "SELECT * FROM vw_TestAppointment WHERE TestAppointmentID = @TestAppointmentID";
            var parameters = new Dictionary<string, object> { {"@TestAppointmentID", id} };
            var dt = await DBHelper.ExecuteReaderAsync(query, parameters);
            if (dt.Rows.Count == 0)
                return null;
            return MapTestAppointment(dt.Rows[0]);
        }

        public async Task<bool> UpdateAsync(TestAppointment entity)
        {
            string query = @"UPDATE TestAppointments SET
                                TestTypeID = @TestTypeID,
                                LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                AppointmentDate = @AppointmentDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID = @CreatedByUserID,
                                IsLocked = @IsLocked,
                                RetakeTestApplicationID = @RetakeTestApplicationID
                              WHERE TestAppointmentID = @TestAppointmentID";
            var parameters = new Dictionary<string, object>
            {
                {"@TestAppointmentID", entity.TestAppointmentId},
                {"@TestTypeID", entity.TestType.TypeId},
                {"@LocalDrivingLicenseApplicationID", entity.LocalDrivingLicenseApplicationId},
                {"@AppointmentDate", entity.AppointmentDate},
                {"@PaidFees", entity.PaidFees},
                {"@CreatedByUserID", entity.CreatedByUserId},
                {"@IsLocked", entity.isLocked},
                {"@RetakeTestApplicationID", entity.RetakeApplicationId == -1 ? (object)System.DBNull.Value : entity.RetakeApplicationId}
            };
            int rows = await DBHelper.ExecuteNonQueryAsync(query, parameters);
            return rows > 0;
        }

        public async Task<IEnumerable<TestAppointment>> GetByLocalDrivingLicenseApplicationIdAsync(int localDrivingLicenseApplicationId)
        {
            string query = @"SELECT * FROM vw_TestAppointment WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ORDER BY AppointmentDate DESC";
            var parameters = new Dictionary<string, object> { {"@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationId} };
            var dt = await DBHelper.ExecuteReaderAsync(query, parameters);
            var list = new List<TestAppointment>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapTestAppointment(row));
            }
            return list;
        }

        public async Task<TestAppointment> GetLatestAppointmentByLDAndTestTypeIdAsync(int localDrivingLicenseApplicationId, int testTypeId)
        {
            string query = @"SELECT TOP 1 * FROM vw_TestAppointment WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID ORDER BY TestAppointmentID DESC";
            var parameters = new Dictionary<string, object>
            {
                {"@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationId},
                {"@TestTypeID", testTypeId}
            };
            var dt = await DBHelper.ExecuteReaderAsync(query, parameters);
            if (dt.Rows.Count == 0)
                return null;
            return MapTestAppointment(dt.Rows[0]);
        }
    }
}
