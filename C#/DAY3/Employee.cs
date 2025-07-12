namespace DAY3
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private double _salary;
        private DateTime _hireDate;

        public Employee() { }

        public Employee(int id, string name, double salary, DateTime hireDate)
        {
            _id = id;
            _name = name;
            _salary = salary;
            _hireDate = hireDate;
        }

        public int GetId() { return _id; }
        public void SetId(int value) { _id = value; }

        public string GetName() { return _name; }
        public void SetName(string value) { _name = value; }

        public double GetSalary() { return _salary; }
        public void SetSalary(double value) { _salary = value; }

        public DateTime GetHireDate() { return _hireDate; }
        public void SetHireDate(DateTime value) { _hireDate = value; }

        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {_id}");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Salary: {_salary}");
            Console.WriteLine($"Hire Date: {_hireDate.ToShortDateString()}");
            Console.WriteLine("----------------------");
        }
    }

}

