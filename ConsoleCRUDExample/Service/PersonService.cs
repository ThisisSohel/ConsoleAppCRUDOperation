using DAO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository? _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public void AddPerson(Person person)
        {
            _personRepository.AddPerson(person);
        }

        public List<Person> GetAllPersons(int id)
        {
           return _personRepository.GetAllPersons();
        }

        public List<Person> GetAllPersons()
        {
            return _personRepository.GetAllPersons();
        }

        public Person GetPerson(int id)
        {
           return _personRepository.GetPersonById(id);
        }

        public void RemovePerson(int id)
        {
            _personRepository.DeletePerson(id);
        }

        public void UpdatePerson(int id, Person updatedPerson)
        {
            var person = _personRepository.GetPersonById(id);
            if (person != null)
            {
                person.Id = updatedPerson.Id;
                person.Name = updatedPerson.Name;
                person.Phone = updatedPerson.Phone;
                _personRepository.UpdatePerson(id, person);
            }
        }
    }
}
