using Company_System.DAL.Entities.Departments;
using Company_System.DAL.Entities.Employees.Testers;
using System.Diagnostics;

namespace Company_System.DAL.Entities.Employees.Developers
{
    public class Developer : Employee
    {
        public const double Bouns = .4;
        public string ProgrammingLanguage { get; set; }
        public string TechStack { get; set; }

        public Developer() { }
        public Developer(int id, string name, EmployeeType t, Department dept, string p, string tech) : base(name, id, t, dept)
        {
            this.ProgrammingLanguage = p;
            this.TechStack = tech;
        }
        public override double CalculateBonus(double salary) => salary * Bouns;

        public override void DisplayDevInfo()
        {
            Console.WriteLine($"TechStack: {TechStack}\n ProgrammingLanguage:{ProgrammingLanguage}");
        }
    }

}
