using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IPersonService
    {
        void AddPerson(Person person);
        List<Person> GetAllPersons();
        Person GetPerson(int id);
        void RemovePerson(int id);
        void UpdatePerson(int id, Person person);
    }
}
