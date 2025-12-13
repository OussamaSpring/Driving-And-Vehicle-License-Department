using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Repositories
{
    public class TestTypeRepository : ITestTypeRepository
    {
        #region HelpFunctions

        private TestType MapTestType(DataRow row)
        {
            if (row == null)
                return null;

            return new TestType
            {
                TypeId = Convert.ToInt32(row["TestTypeID"]),
                TypeTitle = row["TestTypeTitle"]?.ToString(),
                TypeDescription = row["TestTypeDescription"]?.ToString(),
                TypeFee = Convert.ToSingle(row["TestTypeFees"])
            };
        }

        #endregion

        public async Task<TestType> GetByIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@TestTypeID", id } };
            string sqlQuery = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            if (dataTable.Rows.Count == 0)
                return null;
            var row = dataTable.Rows[0];
            return MapTestType(row);
        }

        public async Task<IEnumerable<TestType>> GetAllAsync()
        {
            string sqlQuery = "SELECT * FROM TestTypes";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);
            var list = new List<TestType>();
            if (dataTable.Rows.Count == 0)
                return list;
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapTestType(row));
            }
            return list;
        }

        public async Task<int> AddAsync(TestType testType)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@TypeTitle", testType.TypeTitle },
                { "@TypeDescription", (object)testType.TypeDescription ?? DBNull.Value },
                { "@TypeFee", testType.TypeFee }
            };
            string sqlQuery = @"INSERT INTO TestTypes (TestTypeTitle, TestTypeDescription, TestTypeFees)
                                VALUES (@TypeTitle, @TypeDescription, @TypeFee);
                                SELECT SCOPE_IDENTITY();";
            object result = await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);
            return Convert.ToInt32(result);
        }

        public async Task<bool> UpdateAsync(TestType testType)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@TestTypeID", testType.TypeId },
                { "@TypeTitle", testType.TypeTitle },
                { "@TypeDescription", (object)testType.TypeDescription ?? DBNull.Value },
                { "@TypeFee", testType.TypeFee }
            };
            string sqlQuery = @"UPDATE TestTypes SET
                                TestTypeTitle = @TypeTitle,
                                TestTypeDescription = @TypeDescription,
                                TestTypeFees = @TypeFee
                                WHERE TestTypeID = @TestTypeID;";
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@TestTypeID", id } };
            string sqlQuery = "DELETE FROM TestTypes WHERE TestTypeID = @TestTypeID";
            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);
            return rowsAffected > 0;
        }
    }
}
