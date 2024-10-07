namespace ConsoleCRUDExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonController controller = new PersonController();

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
                            Person newPerson = new Person();
                            Console.WriteLine("Enter the person Id:");
                            newPerson.Id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the person name:");
                            newPerson.Name = Console.ReadLine();
                            Console.WriteLine("Enter the person Phone:");
                            newPerson.Phone = Console.ReadLine();
                            controller.CreatePerson(newPerson);
                            break;
                        }
                    case "2":
                        {
                            controller.GellAllPerson();
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Enter ID of the person to update: ");
                            int updateId = int.Parse(Console.ReadLine());
                            var updatedPerson = new Person();
                            updatedPerson.Id = updateId;
                            Console.Write("Enter New Name: ");
                            updatedPerson.Name = Console.ReadLine();
                            Console.Write("Enter New Phone: ");
                            updatedPerson.Phone = Console.ReadLine();
                            controller.UpdatePerson(updateId, updatedPerson);
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
