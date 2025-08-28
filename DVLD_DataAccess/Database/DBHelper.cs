using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Database
{
    public static class DBHelper
    {
        public static async Task<DataTable> ExecuteReaderAsync(string sqlQuery, Dictionary<string, object> parameters = null)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                await connection.OpenAsync();
                using (var command = CreateCommand(connection, sqlQuery, parameters))
                {
                    DataTable dataTable = new DataTable();

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        dataTable.Load(reader);
                    }
                    return dataTable;
                }
            }
        }

        public static async Task<object> ExecuteScalarAsync(string sqlQuery, Dictionary<string, object> parameters = null)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                await connection.OpenAsync();

                using (var command = CreateCommand(connection, sqlQuery, parameters))
                {
                    return await command.ExecuteScalarAsync();
                }
            }
        }

        public static async Task<int> ExecuteNonQueryAsync(string sqlQuery, Dictionary<string, object> parameters = null)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                await connection.OpenAsync();

                using (var command = CreateCommand(connection, sqlQuery, parameters))
                {
                    return await command.ExecuteNonQueryAsync();
                }
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, string sqlQuery, Dictionary<string, object> parameters)
        {
            var command = new SqlCommand(sqlQuery, connection);

            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue("@" + param.Key, param.Value ?? DBNull.Value);
                }
            }

            return command;
        }
    }
}
