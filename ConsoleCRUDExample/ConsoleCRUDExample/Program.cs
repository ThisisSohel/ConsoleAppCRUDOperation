using DAO;
using Models;
using Service;

namespace ConsoleCRUDExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonRepository personRepository = new PersonRepository();
            IPersonService personService = new PersonService(personRepository);
            PersonController controller = new PersonController(personService);

            while (true)
            {
                Console.WriteLine("\n--- Person Management ---");
                Console.WriteLine("1. Create Person");
                Console.WriteLine("2. View All Persons");
                Console.WriteLine("3. Update Person");
                Console.WriteLine("4. Delete Person");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string? option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        {
                            controller.CreatePerson();
                            break;
                        }
                    case "2":
                        {
                            controller.GellAllPerson();
                            break;
                        }
                    case "3":
                        {
                            controller.UpdatePerson();
                            break;
                        }
                    case "4":
                        {
                            Console.Write("Enter ID of the person to delete: ");
                            int deleteId = int.Parse(Console.ReadLine());
                            controller.DeletePerson(deleteId);
                            break;
                        }
                    case "5":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option.Please try again.");
                            break;
                        }
                }
            }
        }
    }
}
