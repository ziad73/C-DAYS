using Company_System.DAL.Entities.Employees;
using Company_System.DAL.Entities.Projects;

namespace Company_System.DAL.Entities.EmployeeProjects
{
    public class EmployeeProjectAssignment
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public double Hours { get; set; }
        public DateTime AssignmentDate { get; set; } = DateTime.Now;

        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
