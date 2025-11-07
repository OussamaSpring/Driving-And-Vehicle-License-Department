using Core.Enums;
using Core.Interfaces;
using Core.Models;
using DVLD_DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Policy;
using System.Threading.Tasks;

namespace DVLD_DataAccess.Repositories
{
    public class PersonRepository : IPersonRepository
    {

        #region HelpFunctions
        private Person MapPerson(DataRow row)
        {
            if (row == null)
                return null;

            return new Person
            {
                PersonId = Convert.ToInt32(row["PersonID"]),
                NationalNumber = row["NationalNo"].ToString(),
                FirstName = row["FirstName"].ToString(),
                SecondName = row["SecondName"] == DBNull.Value ? null : row["SecondName"].ToString(),
                ThirdName = row["ThirdName"] == DBNull.Value ? null : row["ThirdName"].ToString(),
                LastName = row["LastName"].ToString(),
                DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]),
                enGender = (Genders)Convert.ToInt16(row["Gender"]),
                Address = row["Address"].ToString(),
                NationalityCountry = new Country
                {
                    CountryId = Convert.ToInt32(row["NationalityCountryID"]),
                    CountryName = row["CountryName"].ToString()
                },
                Email = row["Email"] == DBNull.Value ? null : row["Email"].ToString(),
                Phone = row["Phone"].ToString(),
                PersonalImage = row["PersonalImage"] == DBNull.Value ? null : (byte[])row["PersonalImage"]
            };
        }

        #endregion


        public async Task<Person> GetByIdAsync(int id)
        {
            var parameters = new Dictionary<string, object> { { "@PersonId", id } };

            string sqlQuery = @"SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName,       
                        People.ThirdName, People.LastName, People.DateOfBirth, People.Gender, People.Address, People.NationalityCountryID,
                        Countries.CountryName, People.Phone, People.Email, People.PersonalImage
                        FROM People 
                        INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID
                        WHERE PersonID = @PersonId";

            var DataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);

            if (DataTable.Rows.Count == 0)
                return null;

            var row = DataTable.Rows[0];
            return MapPerson(row);
        }
        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            string sqlQuery = @"SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName,       
                        People.ThirdName, People.LastName, People.DateOfBirth, People.Gender, People.Address, People.NationalityCountryID,
                        Countries.CountryName, People.Phone, People.Email, People.PersonalImage
                        FROM People INNER JOIN
                        Countries ON People.NationalityCountryID = Countries.CountryID";

            var DataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);

            if(DataTable.Rows.Count == 0)
                return null;

            var people = new List<Person>();

            foreach (DataRow row in DataTable.Rows)
            {
                people.Add(MapPerson(row));
            }

            return people;
        }
        public async Task<int> AddAsync(Person person)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@NationalNo", person.NationalNumber },
                { "@FirstName", person.FirstName },
                { "@SecondName", (object)person.SecondName ?? DBNull.Value },
                { "@ThirdName", (object)person.ThirdName ?? DBNull.Value },
                { "@LastName", person.LastName },
                { "@DateOfBirth", person.DateOfBirth },
                { "@Gender", (int)person.enGender },
                { "@Address", person.Address },
                { "@NationalityCountryID", person.NationalityCountry.CountryId },
                { "@Email", person.Email },
                { "@Phone", person.Phone }
            };

            string sqlQuery = @"INSERT INTO People 
                (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, NationalityCountryID, Email, Phone)
                VALUES
                (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender, @Address, @NationalityCountryID, @Email, @Phone);
                SELECT SCOPE_IDENTITY();";

            int result = Convert.ToInt32(await DBHelper.ExecuteScalarAsync(sqlQuery, parameters));

            return result;
        }
        public async Task<bool> UpdateAsync(Person person)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@PersonID", person.PersonId },
                { "@NationalNo", person.NationalNumber },
                { "@FirstName", person.FirstName },
                { "@SecondName", (object)person.SecondName ?? DBNull.Value },
                { "@ThirdName", (object)person.ThirdName ?? DBNull.Value },
                { "@LastName", person.LastName },
                { "@DateOfBirth", person.DateOfBirth },
                { "@Gender", (int)person.enGender },
                { "@Address", person.Address },
                { "@NationalityCountryID", person.NationalityCountry.CountryId },
                { "@Email", person.Email },
                { "@Phone", person.Phone }
            };

            string sqlQuery = @"
                UPDATE People SET
                    NationalNo = @NationalNo,
                    FirstName = @FirstName,
                    SecondName = @SecondName,
                    ThirdName = @ThirdName,
                    LastName = @LastName,
                    DateOfBirth = @DateOfBirth,
                    Gender = @Gender,
                    Address = @Address,
                    NationalityCountryID = @NationalityCountryID,
                    Email = @Email,
                    Phone = @Phone
                WHERE PersonID = @PersonId;
            ";

            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);

            return rowsAffected > 0;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@PersonId", id }
            };

            string sqlQuery = "DELETE FROM People WHERE PersonID = @PersonId";

            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);

            return rowsAffected > 0;
        }
        public async Task<Person> GetByNationalNumberAsync(string nationalNo)
        {
            var parameters = new Dictionary<string, object> { { "@NationalNo", nationalNo } };

            string sqlQuery = @"SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.DateOfBirth, People.Gender, People.Address, People.NationalityCountryID,
                        Countries.CountryName, People.Phone, People.Email, People.PersonalImage
                        FROM People INNER JOIN
                        Countries ON People.NationalityCountryID = Countries.CountryID
                                WHERE NationalNo = @NationalNo";

            var DataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);

            if (DataTable.Rows.Count == 0)
                return null;

            var row = DataTable.Rows[0];
            return MapPerson(row);
        }
        public async Task<bool> IsPersonExist(int id)
        {
            var parameters = new Dictionary<string, object>
            {
                {"@PersonId", id }
            };

            string sqlQuery = "SELECT COUNT(1) FROM People WHERE PersonID = @PersonId";

            int result = (int)await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);

            return result > 0;
        }
        public async Task<bool> IsPersonExist(string nationalNumber)
        {
            var parameters = new Dictionary<string, object>
            {
                {"@NationalNo", nationalNumber }
            };
            string sqlQuery = "SELECT COUNT(1) FROM People WHERE NationalNo = @NationalNo";
            object result = await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);
            return Convert.ToInt16(result) == 1;
        }
        public async Task<bool> UpdatePhotoAsync(int id, byte[] photo)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@PersonId", id },
                { "@PersonalImage", photo ?? (object)DBNull.Value }
            };

            string sqlQuery = @"
                UPDATE People
                SET PersonalImage = @PersonalImage
                WHERE PersonID = @PersonId;
            ";

            int rowsAffected = await DBHelper.ExecuteNonQueryAsync(sqlQuery, parameters);

            return rowsAffected > 0;
        }
        public async Task<byte[]> GetPhotoByIdAsync(int id)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@PersonId", id },
            };

            string sqlQuery = @"
                    SELECT PersonalImage FROM People
                    WHERE PersonID = @PersonId;
                    ";

            byte[] image = (byte[]) await DBHelper.ExecuteScalarAsync(sqlQuery, parameters);

            return image ?? null;
        }


        #region Extra

        public async Task<IEnumerable<Country>> GetAllCountriesAsync()
        {
            string sqlQuery = "SELECT CountryID, CountryName FROM Countries";
            var DataTable = await DBHelper.ExecuteReaderAsync(sqlQuery);

            if (DataTable.Rows.Count == 0)
                return null;

            var countries = new List<Country>();

            foreach (DataRow row in DataTable.Rows)
            {
                countries.Add(new Country
                {
                    CountryId = Convert.ToInt32(row["CountryID"]),
                    CountryName = row["CountryName"].ToString()
                });
            }

            return countries;
        }
        public async Task<Country> GetCountryByNameAsync(string countryName)
        {
            var parameters = new Dictionary<string, object> { { "@CountryName", countryName } };
            string sqlQuery = "SELECT CountryID, CountryName FROM Countries WHERE CountryName = @CountryName";
            var DataTable = await DBHelper.ExecuteReaderAsync(sqlQuery, parameters);
            if (DataTable.Rows.Count == 0)
                return null;
            var row = DataTable.Rows[0];
            return new Country
            {
                CountryId = Convert.ToInt32(row["CountryID"]),
                CountryName = row["CountryName"].ToString()
            };
        }

        #endregion
    }
}
