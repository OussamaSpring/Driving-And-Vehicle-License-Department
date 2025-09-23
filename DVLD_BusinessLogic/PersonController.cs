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


        public async Task<Person> GetPersonByIdAsync(int personId)
        {
            return await _personRepository.GetByIdAsync(personId);
        }
        public async Task<IEnumerable<Person>> GetPeopleListAsync()
        {
            return await _personRepository.GetAllAsync();
        }
        public async Task<bool> AddPersonAsync(Person person)
        {
            int personID = await _personRepository.AddAsync(person);

            if (personID != 0)
                return await _personRepository.UpdatePhotoAsync(personID, person.PersonalImage);
            else 
                return false;
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
    }
}
