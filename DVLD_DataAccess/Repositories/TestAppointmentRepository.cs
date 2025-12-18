using Core.Interfaces;
using Core.Models;
using System.Data;
namespace DVLD_DataAccess.Repositories
{
    public class TestAppointmentRepository 
    {

        #region Help Functions

        public TestAppointment MapTestAppointments(DataRow row) { 
            if(row == null)
                return null;

            return new TestAppointment(

                );
        }

        #endregion

        //public async Task<TestAppointment> GetByIdAsync(int id)
        //{
        //    var parameters = new Dictionary<string, object>
        //    {
        //        { "@TestAppointmentId", id }
        //    };
        //    string sqlQuery = "SELECT * FROM TestAppointmentsTable WHERE TestAppointmentID = @TestAppointmentId";
        //    var DataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
        //    if (DataTable.Rows.Count == 0)
        //        return null;
        //    var row = DataTable.Rows[0];
        //    return MapTestAppointments(row);
        //}
    }
}
