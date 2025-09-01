using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;


namespace DVLD_DataAccess.Database
{

    internal static class DBConnection
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["DVLDConnection"].ConnectionString;

        public static SqlConnection CreateConnection()
        {
            var connection = new SqlConnection(_connectionString);
            return connection;
        }
    }
}
