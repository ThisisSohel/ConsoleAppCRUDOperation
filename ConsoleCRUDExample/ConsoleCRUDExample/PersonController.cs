using Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleCRUDExample
{
    public class PersonController
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        /// <summary>
        /// Create a new objcet in the database
        /// </summary>
        /// <param name="person"></param>
        public void CreatePerson()
        {
            var person = new Person();
            Console.Write("Enter Id: ");
            person.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            person.Name = Console.ReadLine();
            Console.Write("Enter Phone: ");
            person.Phone = Console.ReadLine();

            _personService.AddPerson(person);
            Console.WriteLine("Person created successfully.");
            GellAllPerson();
        }


        /// <summary>
        /// Retreive all the data from database
        /// </summary>
        public void GellAllPerson()
        {
            var persons = _personService.GetAllPersons();
            if (persons.Count == 0)
            {
                Console.WriteLine("No persons found.");
            }
            else
            {
                foreach (var person in persons)
                {
                    Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Phone: {person.Phone}");
                }
            }
        }

        /// <summary>
        /// Find the individual data from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void GetById(int id)
        {
            _personService.GetPerson(id);
        }

        /// <summary>
        /// This method is use to delete an object from the database!
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        public void UpdatePerson()
        {
            Console.Write("Enter ID of the person to update: ");
            int id = int.Parse(Console.ReadLine());
            var updatedPerson = new Person();
            updatedPerson.Id = id;
            Console.Write("Enter New Name: ");
            updatedPerson.Name = Console.ReadLine();
            Console.Write("Enter New Phone: ");
            updatedPerson.Phone = Console.ReadLine();

            _personService.UpdatePerson(id, updatedPerson);
            Console.WriteLine("Person updated successfully.");
            GellAllPerson();
        }

        /// <summary>
        /// This method is used to delete an object from the database
        /// </summary>
        /// <param name="id"></param>
        public void DeletePerson(int id)
        {
            _personService.RemovePerson(id);
            Console.WriteLine("Person deleted successfully."); 
            GellAllPerson();
        }
    }
}
