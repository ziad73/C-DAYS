
namespace DAY3
{
    class EmployeeManagementSystem
    {
        private int maxSize;
        private int indx;
        private Employee[] Employees;

        public EmployeeManagementSystem(int size = 10)
        {
            maxSize = size;
            Employees = new Employee[maxSize];
            indx = 0;
        }

        private bool isExist(int id)
        {
            for (int i = 0; i < indx; i++)
            {
                if (Employees[i].GetId() == id)
                    return true;
            }
            return false;
        }

        public void AddEmployee()
        {
            if (indx >= maxSize)
            {
                Console.WriteLine("Cannot add more employees. Maximum capacity reached.\n");
                return;
            }

            Console.WriteLine("\nAdd New Employee");

            int id;
            Console.Write("Enter ID: ");
            string idInput = Console.ReadLine();
            if (int.TryParse(idInput, out id) && !isExist(id))
                id = int.Parse(idInput);
            else
            {
                Console.WriteLine("Invalid ID or ID already exists. Please enter a valid, unique number.");
                return;
            }

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            double salary;
            Console.Write("Enter Salary: ");
            string salaryInput = Console.ReadLine();
            if (double.TryParse(salaryInput, out salary) && salary >= 0)
                salary = double.Parse(salaryInput);
            else
            {
                Console.WriteLine("Invalid salary. Please enter a positive number.");
                return;
            }

            DateTime hireDate;
            Console.Write("Enter Hire Date (yyyy-mm-dd): ");
            string Dstring = Console.ReadLine();
            if (DateTime.TryParse(Dstring, out hireDate))
                hireDate = DateTime.Parse(Dstring);
            else
            {
                Console.WriteLine("Invalid date format. Please use yyyy-mm-dd.");
                return;
            }


            Employees[indx] = new Employee(id, name, salary, hireDate);
            indx++;
            Console.WriteLine("Employee added successfully!\n");
        }

        public void GetAllEmployees()
        {
            if (indx == 0)
            {
                Console.WriteLine("No employees in the system yet.");
                return;
            }
            Console.WriteLine("\nAll Employees:");

            for (int i = 0; i < indx; i++)
            {
                Employees[i].DisplayDetails();
            }
        }

        private Employee FindEmployee(int id)
        {
            for (int i = 0; i < indx; i++)
            {
                if (Employees[i].GetId() == id)
                    return Employees[i];
            }
            return null;
        }

        public void UpdateEmployee()
        {
            if (indx == 0)
            {
                Console.WriteLine("No employees to update.\n");
                return;
            }

            Console.Write("\nEnter Employee ID to update: ");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid ID format.\n");
                return;
            }

            Employee empToUpdate = FindEmployee(id);
            if (empToUpdate == null)
            {
                Console.WriteLine("Employee not found!\n");
                return;
            }

            Console.WriteLine("\nCurrent Employee Details:");
            empToUpdate.DisplayDetails();

            Console.Write("Enter new Name (leave blank to keep current): ");
            string name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name))
                empToUpdate.SetName(name);

            double salary;
            while (true)
            {
                Console.Write("Enter new Salary (leave blank to keep current): ");
                string salaryInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(salaryInput))
                    break;
                if (double.TryParse(salaryInput, out salary) && salary >= 0)
                {
                    empToUpdate.SetSalary(salary);
                    break;
                }
                Console.WriteLine("Invalid salary. Please enter a positive number.");
            }

            DateTime hireDate;
            while (true)
            {
                Console.Write("Enter new Hire Date (yyyy-mm-dd) or blank to keep current: ");
                string dateInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(dateInput))
                    break;
                if (DateTime.TryParse(dateInput, out hireDate))
                {
                    empToUpdate.SetHireDate(hireDate);
                    break;
                }
                Console.WriteLine("Invalid date format. Please use yyyy-mm-dd.");
            }

            Console.WriteLine("Employee updated successfully!\n");
        }

        public void GetEmployeeByID()
        {
            if (indx == 0)
            {
                Console.WriteLine("No employees in the system.\n");
                return;
            }

            Console.Write("\nEnter Employee ID: ");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid ID format.\n");
                return;
            }

            Employee emp = FindEmployee(id);
            if (emp != null)
            {
                Console.WriteLine("\nEmployee Details:");
                emp.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Employee not found!\n");
            }
        }
    }

}

