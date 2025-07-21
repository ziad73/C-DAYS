using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company_System.DAL.Entities.Departments
{

    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");

            builder.HasKey(d => d.DepId);

            builder.Property(d => d.DepName).IsRequired().HasMaxLength(100);
            builder.Property(d => d.Location).IsRequired().HasMaxLength(100);

            //Relationship with Employees 
            builder.HasMany(d => d.Employees).WithOne(e => e.Dep).HasForeignKey(e => e.DepartmentId);

            //Relationship with Projects
            builder.HasMany(d => d.Projects).WithOne(p => p.Dep).HasForeignKey(p => p.DepartmentId);
        }
    }
}
