using Core.Interfaces;
using Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVLD_BusinessLogic
{
    public class PersonController
    {

        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        #region HelpFunctions

        public List<string> GetPersonFilterCriteria()
        {
            var filterCriteria = new List<string>
            {
                "Person ID",
                "National No.",
                "First Name",
                "Second Name",
                "Third Name",
                "Last Name",
                "Nationality",
                "Gender",
                "Phone",
                "Email"
            };
            return filterCriteria;
        }

        #endregion

        public async Task<Person> GetPersonByIdAsync(int personId)
        {
            return await _personRepository.GetByIdAsync(personId);
        }


        public async Task<IEnumerable<Person>> GetPeopleListAsync()
        {
            return await _personRepository.GetAllAsync();
        }

        public async Task<(bool Success, int? PersonId, string ErrorMessage)> SavePersonAsync(Person person, bool isAdd, bool hasImageChanged)
        {
            // Duplicate check for add
            if (isAdd && await IsPersonExistAsync(person.NationalNumber))
                return (false, null, "National number already exists.");

            int personId;
            if (isAdd)
            {
                personId = await AddPersonAsync(person) ?? 0;
                if (personId == 0)
                    return (false, null, "Failed to add person.");
                // Always update image after add (if present)
                if (hasImageChanged && person.PersonalImage != null)
                    await UpdatePersonPhotoAsync(personId, person.PersonalImage);
            }
            else
            {
                personId = person.PersonId;
                bool updated = await UpdatePersonInfoAsync(person);
                if (!updated)
                    return (false, personId, "Failed to update person.");
                // Only update image if changed
                if (hasImageChanged)
                    await UpdatePersonPhotoAsync(personId, person.PersonalImage);
            }

            return (true, personId, null);
        }
        public async Task<int?> AddPersonAsync(Person person)
        {
            int personID = await _personRepository.AddAsync(person);

            if (personID != 0)
            {
                await _personRepository.UpdatePhotoAsync(personID, person.PersonalImage);
                return personID;
            }
            else
                return null;
        }

        public async Task<bool> UpdatePersonInfoAsync(Person person)
        {
            return await _personRepository.UpdateAsync(person);
        }

        public async Task<bool> DeletePersonAsync(int personId)
        {
            return await _personRepository.DeleteAsync(personId);
        }

        public async Task<Person> GetPersonByNationalNumberAsync(string nationalNumber)
        {
            return await _personRepository.GetByNationalNumberAsync(nationalNumber);
        }

        public async Task<byte[]> GetPersonPhotoAsync(int personId)
        {
            return await _personRepository.GetPhotoByIdAsync(personId);
        }

        public async Task<bool> UpdatePersonPhotoAsync(int personId, byte[] photo)
        {
            return await _personRepository.UpdatePhotoAsync(personId, photo);
        }

        public async Task<bool> IsPersonExistAsync(int personId)
        {
            return await _personRepository.IsPersonExist(personId);
        }

        public async Task<bool> IsPersonExistAsync(string nationalNumber)
        {
            return await _personRepository.IsPersonExist(nationalNumber);
        }

        public async Task<IEnumerable<Country>> GetAllCountriesAsync()
        {
            return await _personRepository.GetAllCountriesAsync();
        }

        public async Task<Country> GetCountryByNameAsync(string countryName)
        {
            return await _personRepository.GetCountryByNameAsync(countryName);
        }
    }
}
