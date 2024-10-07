using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCRUDExample
{
    public class PersonController
    {
        private List<Person> _person;

        public PersonController()
        {
            _person = new List<Person>();
        }

        /// <summary>
        /// Create a new objcet in the database
        /// </summary>
        /// <param name="person"></param>
        public void CreatePerson(Person person)
        {
            _person.Add(person);
            Console.WriteLine("Person is added successfully!\n\n");
            Console.WriteLine("Person List");
            Console.WriteLine("......................................");
            GellAllPerson();
        }

        /// <summary>
        /// Retreive all the data from database
        /// </summary>
        public void GellAllPerson()
        {
            if (_person.Count <= 0)
            {
                Console.WriteLine("\n\nNo person is available now! Please add a new person!");
            }
            else
            {
                foreach (Person person in _person)
                {
                    Console.WriteLine($"Id: {person.Id}- Name: {person.Name}- Phone: {person.Phone}");
                }
            }
        }

        /// <summary>
        /// Find the individual data from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person GetById(int? id)
        {
            return _person.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// This method is use to delete an object from the database!
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        public void UpdatePerson(int id, Person model)
        {
            var personToUpdate = GetById(id);
            if (personToUpdate != null)
            {
                personToUpdate.Id = model.Id; 
                personToUpdate.Name = model.Name;
                personToUpdate.Phone = model.Phone;
                Console.WriteLine("\nPerson is updated successfully!");
                Console.WriteLine("Person List");
                Console.WriteLine("......................................");
                GellAllPerson();
            }
            else
            {
                Console.WriteLine("Person is not found to update!");
            }
        }

        /// <summary>
        /// This method is used to delete an object from the database
        /// </summary>
        /// <param name="id"></param>
        public void DeletePerson(int id)
        {
            var personToDelete = GetById(id);   
            if(personToDelete != null)
            {
                _person.Remove(personToDelete);
                Console.WriteLine("\nPerson is Deleted!");
                Console.WriteLine("Person List");
                Console.WriteLine("......................................");
                GellAllPerson();
            }
        }
    }
}
