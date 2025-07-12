namespace Company_System.Departments
{
    public class Department
    {
        public int DepId { get; set; }
        public string DepName { get; set; }
        public string Location { get; set; }
        public DateTime OpeningDate { get; set; }
        public bool IsActive { get; set; }

        public Department()
        {
            OpeningDate = DateTime.Now;
            IsActive = true;
        }

        public Department(int id, string name, string location)
        {
            DepId = id;
            DepName = name;
            Location = location;
            OpeningDate = DateTime.Now;
            IsActive = true;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {DepId}, Name: {DepName}, Location: {Location}, Active: {IsActive}, Opened: {OpeningDate.ToShortDateString()}");
        }
    }
}
