using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {

        #region HelpFunctions
        private User MapUser(DataRow row)
        {
            return new User
            {
                UserId = Convert.ToInt32(row["UserID"]),
                PersonId = Convert.ToInt32(row["PersonID"]),
                Username = row["UserName"].ToString(),
                Password = row["Password"].ToString(),
                IsActive = Convert.ToBoolean(row["IsActive"])
            };
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        #endregion

        public async Task<User> GetByIdAsync(int userId)
        {
            var parameters = new Dictionary<string, object> { { "@UserId", userId } };

            string sqlQuery = "SELECT * FROM Users WHERE UserID = @UserId";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);

            if (dataTable.Rows.Count == 0)
                return null;

            var row = dataTable.Rows[0];
            return MapUser(row);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            string sqlQuery = "SELECT * FROM Users";
            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);
            var users = new List<User>();
            foreach (DataRow row in dataTable.Rows)
            {
                users.Add(MapUser(row));
            }
            return users;
        }

        public async Task<int> AddAsync(User user)
        {
            var parameters = new Dictionary<string, object> {
            { "@PersonId", user.PersonId},
            { "@Username", user.Username},
            { "@Password", HashPassword(user.Password)},
            { "@IsActive", user.IsActive}
            };

            string sqlQuery = "INSERT INTO Users VALUES (@PersonId, @Username, @Password, @IsActive); SELECT SCOPE_IDENTITY();";

            int result = Convert.ToInt32(await DBHelper.ExecuteScalarAsync(sqlQuery, parameters));
            return result;
        }

        public async Task<bool> UpdateAsync(User user)
        {
            var parameters = new Dictionary<string, object> {
            { "@UserId", user.UserId},
            { "@PersonId", user.PersonId},
            { "@Username", user.Username},
            { "@Password", HashPassword(user.Password)},
            { "@IsActive", user.IsActive}
            };
            string sqlQuery = "UPDATE Users SET PersonID = @PersonId, UserName = @Username, Password = @Password, IsActive = @IsActive WHERE UserID = @UserId";

            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);

            return rowsAffected != 0 ? true : false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@UserId", id } };

            string sqlQuery = "DELETE FROM Users WHERE UserID = @UserId";

            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);

            return rowsAffected != 0 ? true : false;
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            var parameters = new Dictionary<string, object> { { "@Username", username } };

            string sqlQuery = "SELECT * FROM Users WHERE UserName = @Username";

            var dataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            if (dataTable.Rows.Count == 0)
                return null;

            var row = dataTable.Rows[0];
            return MapUser(row);
        }
    }
}
