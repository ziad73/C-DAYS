using Company_System.DAL.Entities.Departments;

namespace Company_System.DAL.Entities.Employees.Testers
{
    public class Tester : Employee
    {
        public const double Bouns = .2;
        public string TestingSpecialty { get; set; }
        public string AutomationTool { get; set; }

        public Tester() { }
        public Tester(int id, string name, EmployeeType t, Department dept, string spec, string a) : base(name, id, t, dept)
        {
            this.TestingSpecialty = spec;
            this.AutomationTool = a;
        }
        public override double CalculateBonus(double salary) => salary * Bouns;

        public override void DisplayTesterInfo()
        {
            Console.WriteLine($"TestingSpecialty: {TestingSpecialty}\n AutomationTool:{AutomationTool}");
        }
    }
}
