using Company_System.Departments;
namespace Company_System.Employees
{
    public class Tester : Employee
    {
        public const double Bouns = .2;
        public double Salary { get; private set; }

        public Tester(int id, string name, double salary, EmployeeType t, Department dept, int numOfProjects) : base(name, id, t, dept, numOfProjects)
        {
            Salary = salary;
        }
        public override double CalculateBonus(double salary) => salary * Bouns;
    }
}
