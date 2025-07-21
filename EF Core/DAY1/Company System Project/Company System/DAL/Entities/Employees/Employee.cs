using Company_System.DAL.Entities.Departments;
using Company_System.DAL.Entities.EmployeeProjects;

namespace Company_System.DAL.Entities.Employees
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
        public Department? Dep { get; set; }
        public int DepartmentId { get; set; }   
        public EmployeeType? Type { get; private set; }
        public double FixedSalary { get; private set; } = 5000.0;

        public ICollection<EmployeeProjectAssignment> Assignments { get; set; } = new List<EmployeeProjectAssignment>();

        public Employee()
        {

            HireDate = DateTime.Now;
            isActive = true;
        }
        public Employee(string name, int id, EmployeeType type, Department dep) : this()
        {
            EmpId = id;
            EmpName = name;
            Type = type;
            Dep = dep;
        }
        public virtual double CalculateBonus(double salary) => salary * 0.1;

        public virtual void DisplayDevInfo() { }
        public virtual void DisplayTesterInfo() { }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee ID: {EmpId}");
            Console.WriteLine($"Name: {EmpName}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Department: {Dep.DepName}");
            Console.WriteLine($"FixedSalary: {FixedSalary}");
            Console.WriteLine($"Bonus: {CalculateBonus(FixedSalary)}");
            Console.WriteLine($"Total Compensation: {FixedSalary + CalculateBonus(FixedSalary)}");
            if (Type == EmployeeType.Developer) DisplayDevInfo();
            else if (Type == EmployeeType.Tester) DisplayTesterInfo();
        }

    }

}
