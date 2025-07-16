using Company_System.Departments;
namespace Company_System.Employees
{
    public class Developer : Employee
    {
        public const double Bouns = .4;

        public Developer(int id, string name, EmployeeType t, Department dept, int numOfProjects) : base(name, id, t, dept,numOfProjects){}
        public override double CalculateBonus(double salary) => salary * Bouns;
    }

}
