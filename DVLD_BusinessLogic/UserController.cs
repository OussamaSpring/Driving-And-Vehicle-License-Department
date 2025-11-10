using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_BusinessLogic
{
    public class UserController
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        #region HelpFunctions
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

        public List<string> GetUserFilterCriteria()
        {
            return new List<string>
            {
                "Username",
                "Active Status"
            };
        }

        #endregion

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _userRepository.GetByIdAsync(userId);
        }
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }
        public async Task<int> CreateUserAsync(User user)
        {
            return await _userRepository.AddAsync(user);
        }
        public async Task<bool> UpdateUserAsync(User user)
        {
            return await _userRepository.UpdateAsync(user);
        }
        public async Task<bool> DeleteUserAsync(int userId)
        {
            return await _userRepository.DeleteAsync(userId);
        }
        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _userRepository.GetByUsernameAsync(username);
        }
        public async Task<bool> IsUsernameTakenAsync(string username)
        {
            return await _userRepository.IsUsernameExistAsync(username);
        }

        /// <summary>
        /// This Method authenticates a user based on the provided username and password.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>
        /// Number (0, 1, 2) that specify the result of the Authentication:
        /// 0 => User not found / Incorrect password | 1 => Active User | 2 => Inactive User
        /// </returns>
        public async Task<short> AuthenticateUserAsync(string username, string password)
        {
            var user = await _userRepository.GetByUsernameAsync(username);
            if (user == null)
                return 0;

            var hashedInput = HashPassword(password);
            if (!string.Equals(user.Password, hashedInput, StringComparison.OrdinalIgnoreCase))
                return 0;

            return user.IsActive ? (short)1 : (short)2;
        }
    }
}
