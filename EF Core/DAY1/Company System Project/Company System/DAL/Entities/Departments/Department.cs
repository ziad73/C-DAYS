using Company_System.DAL.Entities.Projects;
using Company_System.DAL.Entities.Employees;

namespace Company_System.DAL.Entities.Departments
{
    public class Department
    {
        public int DepId { get; set; }
        public string DepName { get; set; }
        public string Location { get; set; }
        public DateTime OpeningDate { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Project> Projects { get; set; } = new List<Project>();

        public Department()
        {
            OpeningDate = DateTime.Now;
            IsActive = true;
        }
        public Department(int id, string name, string location) : this()
        {
            DepId = id;
            DepName = name;
            Location = location;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {DepId}, Name: {DepName}, Location: {Location}, Active: {IsActive}, Opened: {OpeningDate.ToShortDateString()}");
        }
    }

}
