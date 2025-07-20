using Company_System.Departments;
namespace Company_System.Employees
{
    public class Tester : Employee
    {
        public const double Bouns = .2;

        public Tester(int id, string name, EmployeeType t, Department dept) : base(name, id, t, dept)
        {
        }
        public override double CalculateBonus(double salary) => salary * Bouns;
    }
}
