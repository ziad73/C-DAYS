using Company_System.DAL.Entities.Departments;
using Company_System.DAL.Entities.EmployeeProjects;

namespace Company_System.DAL.Entities.Projects
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Department Dep { get; set; }
        public int DepartmentId { get; set; }
        public Project() { StartDate = DateTime.Today; }

        public ICollection<EmployeeProjectAssignment> Assignments { get; set; } = new List<EmployeeProjectAssignment>();

        public Project(int id, string name, string desc, DateTime endDate, Department dept)
        {
            ProjectId = id;
            ProjectName = name;
            Description = desc;
            StartDate = DateTime.Now;
            EndDate = endDate;
            Dep = dept;
        }

        public void Display()
        {
            Console.WriteLine($"Project: {ProjectName}, Dept: {Dep?.DepName}, From: {StartDate.ToShortDateString()} to {EndDate.ToShortDateString()}");
        }
    }

}
