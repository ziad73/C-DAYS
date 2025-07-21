using Company_System.DAL.Entities.Company;
using Company_System.DAL.Entities.Employees;

namespace CompanySystem_System
{
    public class main
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome To Our CompanySystem System");

                CompanySystem system = new CompanySystem();
                while (true)
                {
                    Console.WriteLine("\nMain Menu");
                    Console.WriteLine("1. Add Employee");
                    Console.WriteLine("2. Add Project");
                    Console.WriteLine("3. Add Department");
                    Console.WriteLine("4. View All Employees");
                    Console.WriteLine("5. View All Departments");
                    Console.WriteLine("6. View All Projects");
                    Console.WriteLine("7. Assign Project to Employee");
                    Console.WriteLine("8. Exit");
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
                            Console.WriteLine("1.Developer");
                            Console.WriteLine("2.Tester");
                            Console.Write("Enter the type of employee:");
                            string c = Console.ReadLine();
                            EmployeeType type;
                            switch (c)
                            {
                                case "1":
                                    type = EmployeeType.Developer; break;
                                case "2":
                                    type = EmployeeType.Tester; break;
                                default:
                                    throw new Exception("invalid Type"); break;
                            }
                            system.AddEmployee(type); break;
                        case 2:
                            system.AddProject(); break;
                        case 3:
                            system.AddDepartment(); break;
                        case 4:
                            system.ViewAllEmployees(); break;
                        case 5:
                            system.ViewAllDepartments(); break;
                        case 6:
                            system.ViewAllProjects(); break;
                        case 7:
                            system.AssignProjectToDeveloper(); break;
                        case 8:
                            Console.WriteLine("Exiting..."); return;
                        default:
                            Console.WriteLine("Invalid choice."); break;
                    }
                }

            }
        }

    }
}