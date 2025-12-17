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
    }
}
