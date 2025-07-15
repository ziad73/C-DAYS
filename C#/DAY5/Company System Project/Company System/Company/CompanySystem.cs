using Company_System.Employees;
using Company_System.Employees;
using Company_System.Departments;
using Company_System.Projects;


namespace Company_System.Company
{
    public class CompanySystem
    {
        Employee[] Employees;
        Department[] departments;
        Project[] projects;

        int EmpCount = 0, depCount = 0, projCount = 0;

        public CompanySystem(int depSize = 10, int EmpSize = 10, int proSize = 10)
        {

            Employees = new Employee[EmpSize];
            departments = new Department[depSize];
            projects = new Project[proSize];
        }

        public Department FindDep(int depId)
        {
            for (int i = 0; i < depCount; i++)
            {
                if (departments[i].DepId == depId)
                    return departments[i];
            }
            throw new Exception("Department not found.");
        }

        public void AddEmployee(EmployeeType type)
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write($"Enter {type} Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Enter Department ID to assign: ");
            int depId = int.Parse(Console.ReadLine());
            Department dep = FindDep(depId);
            Console.Write("Enter number of projects: ");
            int numOfProjects = int.Parse(Console.ReadLine());

            Employee e;
            if (type == EmployeeType.Developer)
                e = new Developer(id, name, salary, type, dep, numOfProjects);
            else
                e = new Tester(id, name, salary, type, dep, numOfProjects);

            Employees[EmpCount] = e;
            EmpCount++;
            Console.WriteLine("Developer Added.\n");
        }

        public void AddDepartment()
        {
            Console.Write("Enter Department ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Department Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Location: ");
            string loc = Console.ReadLine();

            departments[depCount] = new Department(id, name, loc);
            depCount++;
            Console.WriteLine("Department Added.\n");
        }

        public void AddProject()
        {
            Console.Write("Enter Project ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Project Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Description: ");
            string desc = Console.ReadLine();
            Console.Write("Enter End Date (yyyy-mm-dd): ");
            DateTime end = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Department ID: ");
            int depId = int.Parse(Console.ReadLine());
            Department dep = FindDep(depId);

            projects[projCount] = new Project(id, name, desc, end, dep);
            projCount++;
            Console.WriteLine("Project Added.\n");
        }

        public void AssignProjectToDeveloper()
        {
            Console.Write("Enter Developer ID: ");
            int empId = int.Parse(Console.ReadLine());

            Employee e = null;
            for (int i = 0; i < EmpCount; i++)
            {
                if (Employees[i].EmpId == empId)
                {
                    e = Employees[i];
                    break;
                }
            }

            if (e == null)
            {
                Console.WriteLine("Developer not found.");
                return;
            }

            Console.Write("Enter Project ID to assign: ");
            int projId = int.Parse(Console.ReadLine());

            Project proj = null;
            for (int i = 0; i < projCount; i++)
            {
                if (projects[i].ProjectId == projId)
                {
                    proj = projects[i];
                    break;
                }
            }

            if (proj == null)
            {
                Console.WriteLine("Project not found.");
                return;
            }

            for (int i = 0; i < e.Projects.Length; i++)
            {
                if (e.Projects[i] == null)
                {
                    e.Projects[i] = proj;
                    Console.WriteLine("Project assigned to eeloper.");
                    return;
                }
            }

            Console.WriteLine("Developer has reached the maximum number of projects.");
        }

        public void ViewAllDevelopers()
        {
            for (int i = 0; i < EmpCount; i++)
                Employees[i].DisplayInfo();
        }

        public void ViewAllDepartments()
        {
            for (int i = 0; i < depCount; i++)
                departments[i].Display();
        }

        public void ViewAllProjects()
        {
            for (int i = 0; i < projCount; i++)
                projects[i].Display();
        }
    }
}
