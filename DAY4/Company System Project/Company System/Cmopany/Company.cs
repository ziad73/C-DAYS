
using Company_System.Departments;
using Company_System.Projects;
using Company_System.Users;

namespace Company_System.Cmopany
{
    public class Company
    {
        Developer[] developers;
        Department[] departments;
        Project[] projects;

        int devCount = 0, depCount = 0, projCount = 0;

        public Company(int depSize = 10, int devSize = 10, int proSize = 10)
        {
            developers = new Developer[devSize];
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

        public void AddDeveloper()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Enter Hire Date (yyyy-mm-dd): ");
            DateTime hireDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Department ID to assign: ");
            int depId = int.Parse(Console.ReadLine());
            Department dep = FindDep(depId);

            Console.Write("Enter number of projects: ");
            int numOfProjects = int.Parse(Console.ReadLine());

            Developer dev = new Developer(id, name, salary, hireDate, dep, numOfProjects);
            developers[devCount] = dev;
            devCount++;
            Console.WriteLine("Developer Added.\n");
        }

        public void AddDepartment()
        {
            Console.Write("Enter Department ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
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
            Console.Write("Enter Name: ");
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

        public void ViewAllDevelopers()
        {
            for (int i = 0; i < devCount; i++)
                developers[i].DisplayDetails();
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
