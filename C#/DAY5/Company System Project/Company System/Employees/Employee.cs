using Company_System.Departments;
using Company_System.Projects;

namespace Company_System.Employees
{
    public enum EmployeeType
    {
        Developer,
        Tester
    }

    public abstract class Employee
    {
        public DateTime HireDate { get; private set; }
        public int EmpId { get; private set; }
        public string EmpName { get; set; }
        public bool isActive { get; private set; }
        public Department? Department { get; set; }
        public EmployeeType? Type { get; private set; }
        public double FixedSalary { get; } = 5000.0;
        public Project[] Projects;


        public Employee()
        {

            this.HireDate = DateTime.Now;
            this.isActive = true;
        }
        public Employee(string name, int id, EmployeeType type, Department dep, int NumOfProjects = 10) : this()
        {
            this.EmpId = id;
            this.EmpName = name;
            this.Type = type;
            this.Department = dep;
            this.Projects = new Project[NumOfProjects];
        }
        public virtual double CalculateBonus(double salary) => salary * 0.1;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee ID: {EmpId}");
            Console.WriteLine($"Name: {EmpName}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Department: {Department.DepName}");
            Console.WriteLine($"FixedSalary: {FixedSalary}");
            Console.WriteLine($"Bonus: {CalculateBonus(FixedSalary)}");
            Console.WriteLine($"Total Compensation: {FixedSalary + CalculateBonus(FixedSalary)}");
            Console.WriteLine($"Projects assigned: ");
            for (int i = 0; i < Projects.Length; i++)
            {
                if (Projects[i] != null)
                    Console.WriteLine($"- {Projects[i].ProjectName}");
                else
                    Console.WriteLine("- [No project assigned]");
            }

            Console.WriteLine("----------------------");
        }

    }

}
