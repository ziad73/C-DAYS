using Company_System.Departments;
using Company_System.Projects;

namespace Company_System.Users
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }
        public Department Department { get; set; }
        public Project[] Projects;

        public Developer(int numOfProjects)
        {
            Projects = new Project[numOfProjects];
        }

        public Developer(int id, string name, double salary, DateTime hireDate, Department dept, int numOfProjects)
        {
            Id = id;
            Name = name;
            Salary = salary;
            HireDate = hireDate;
            Department = dept;
            Projects = new Project[numOfProjects];
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}, Hire Date: {HireDate.ToShortDateString()}");
            Console.WriteLine($"Department: {Department?.DepName}");
            Console.WriteLine("Projects:");
            foreach (var proj in Projects)
            {
                Console.WriteLine($"- {proj.ProjectName}");
            }
            Console.WriteLine("----------------------");
        }
    }

}
