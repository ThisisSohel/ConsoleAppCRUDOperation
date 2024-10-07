using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PersonRepository : IPersonRepository
    {
        private List<Person> persons;

        public PersonRepository()
        {
            persons = new List<Person>();
        }
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public void DeletePerson(int id)
        {
            var person = GetPersonById(id);
            if (person != null)
            {
                persons.Remove(person);
            }
        }

        public List<Person> GetAllPersons()
        {
            return persons;
        }

        public Person GetPersonById(int id)
        {
            return persons.FirstOrDefault(x => x.Id == id);
        }

        public void UpdatePerson(int id, Person model)
        {
            var existingPerson = GetPersonById(model.Id);
            if (existingPerson != null)
            {
                existingPerson.Id = model.Id;
                existingPerson.Name = model.Name;
                existingPerson.Phone = model.Phone;
            }
        }
    }
}
