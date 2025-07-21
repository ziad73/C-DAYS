using Company_System.DAL.Entities.Departments;
using Company_System.DAL.Entities.EmployeeProjects;
using Company_System.DAL.Entities.Employees;
using Company_System.DAL.Entities.Employees.Developers;
using Company_System.DAL.Entities.Employees.Testers;
using Company_System.DAL.Entities.Projects;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace Company_System.DAL.Database
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ZUZZ;Database=CompanyTesting; Trusted_Connection=True; MultipleActiveResultSets=true; TrustServerCertificate=true");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Tester> Testers { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<EmployeeProjectAssignment> Assignment { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new EmployeeConfig());

            // Apply all configurations from assembly (Your Project)
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
