namespace Company_System.EmployeeProjects
{
    public class EmployeeProjectAssignment
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public double Hours { get; set; }
        public DateTime AssignmentDate { get; set; } = DateTime.Now;

    }
}
