using Company_System.DAL.Entities.Employees.Developers;
using Company_System.DAL.Entities.Employees.Testers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company_System.DAL.Entities.Employees
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");//Naming the table

            builder.HasKey(e => e.EmpId);//set EmpId as PK

            builder.Property(e => e.EmpName).IsRequired().HasMaxLength(30);

            builder.Property(e => e.FixedSalary).HasColumnType("Decimal(18,2)");

            builder.HasMany(e => e.Assignments)
                   .WithOne(a => a.Employee)
                   .HasForeignKey(a => a.EmployeeId); 

            builder.Property(e => e.Type)
                   .HasColumnName("EmployeeType")
                   .IsRequired();

            builder.HasDiscriminator<EmployeeType>("EmployeeType")
                   .HasValue<Developer>(EmployeeType.Developer)
                   .HasValue<Tester>(EmployeeType.Tester);
        }
    }
}