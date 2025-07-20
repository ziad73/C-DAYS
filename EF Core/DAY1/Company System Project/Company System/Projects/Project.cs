using Company_System.Departments;
using Company_System.Employees;
namespace Company_System.Projects
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Department Department { get; set; }

        public Project() { StartDate = DateTime.Today; }

        public Project(int id, string name, string desc, DateTime endDate, Department dept)
        {
            ProjectId = id;
            ProjectName = name;
            Description = desc;
            StartDate = DateTime.Now;
            EndDate = endDate;
            Department = dept;
        }

        public void Display()
        {
            Console.WriteLine($"Project: {ProjectName}, Dept: {Department?.DepName}, From: {StartDate.ToShortDateString()} to {EndDate.ToShortDateString()}");
        }
    }

}
