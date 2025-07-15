using Company_System.Departments;
namespace Company_System.Employees
{
    public class Developer : Employee
    {
        public const double Bouns = .4;
        public double Salary { get; private set; }

        public Developer(int id, string name, double salary, EmployeeType t, Department dept, int numOfProjects) : base(name, id, t, dept, numOfProjects)
        {
            Salary = salary;
        }
        public override double CalculateBonus(double salary) => salary * Bouns;
    }

}
