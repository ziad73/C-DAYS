using System;

namespace DAY3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Employee Management System");

            int size;
            Console.Write("Enter maximum number of employees (default 10): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out size) && size > 0)
                size = int.Parse(input);
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                return;
            }

            EmployeeManagementSystem system = new EmployeeManagementSystem(size);

            while (true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Find Employee by ID");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid option. Please enter a number 1-5.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        system.AddEmployee();
                        break;
                    case 2:
                        system.GetAllEmployees();
                        break;
                    case 3:
                        system.UpdateEmployee();
                        break;
                    case 4:
                        system.GetEmployeeByID();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}