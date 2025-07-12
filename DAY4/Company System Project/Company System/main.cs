using Company_System.Cmopany;

namespace Company_System
{
    

    public class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Company System");
            Company system = new Company();

            while (true)
            {
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("1. Add Developer");
                Console.WriteLine("2. Add Project");
                Console.WriteLine("3. Add Department");
                Console.WriteLine("4. View All Developers");
                Console.WriteLine("5. View All Departments");
                Console.WriteLine("6. View All Projects");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        system.AddDeveloper(); break;
                    case 2:
                        system.AddProject(); break;
                    case 3:
                        system.AddDepartment(); break;
                    case 4:
                        system.ViewAllDevelopers(); break;
                    case 5:
                        system.ViewAllDepartments(); break;
                    case 6:
                        system.ViewAllProjects(); break;
                    case 7:
                        Console.WriteLine("Exiting..."); return;
                    default:
                        Console.WriteLine("Invalid choice."); break;
                }
            }

        }

    }
}