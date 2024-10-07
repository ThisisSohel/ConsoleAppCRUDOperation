using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface IPersonRepository
    {
        void AddPerson(Person person);
        List<Person> GetAllPersons();
        Person GetPersonById(int id);
        void UpdatePerson(int id, Person person);
        void DeletePerson(int id);
    }
}
