using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Database;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Repositories
{
    public class ApplicationTypeRepository : IApplicationTypeRepository
    {
        #region HelpFunctions
        private ApplicationType MapapplicationType(DataRow row)
        {
            if (row == null)
                return null;

            return new ApplicationType
            {
                ApplicationTypeId = row.Field<int>("ApplicationTypeID"),
                ApplicationTypeName = row.Field<string>("ApplicationTypeTitle"),
                ApplicationTypeFees = row.Field<float>("ApplicationFees")
            };
        }
        #endregion

        public async Task<ApplicationType> GetByIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@ApplicationTypeID", id } };
            string sqlQuery = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            if (dataTable.Rows.Count == 0)
                return null;
            var row = dataTable.Rows[0];
            return MapapplicationType(row);
        }

        public async Task<IEnumerable<ApplicationType>> GetAllAsync()
        {
            string sqlQuery = "SELECT * FROM ApplicationTypes";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);
            var list = new List<ApplicationType>();
            if (dataTable.Rows.Count == 0)
                return list;
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(MapapplicationType(row));
            }
            return list;
        }
    }
}
