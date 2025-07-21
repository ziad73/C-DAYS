using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company_System.DAL.Entities.Employees.Testers
{
    public class TesterConfig : IEntityTypeConfiguration<Tester>
    {
        public void Configure(EntityTypeBuilder<Tester> builder)
        {
            builder.Property(t => t.TestingSpecialty).HasMaxLength(50);

            builder.Property(t => t.AutomationTool).HasMaxLength(100);
            builder.HasBaseType<Employee>();

        }
    }
}
