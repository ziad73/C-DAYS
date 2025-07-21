using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company_System.DAL.Entities.Employees.Developers
{
    public class DeveloperConfig : IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {

            builder.Property(d => d.ProgrammingLanguage).HasMaxLength(50);
            builder.Property(d => d.TechStack).HasMaxLength(100);
        }
    }
}
