using Company_System.DAL.Entities.Departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Company_System.DAL.Entities.Projects
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");
            builder.HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).HasMaxLength(500);

            //relationship with Assignments 1 to M
            builder.HasMany(a => a.Assignments).WithOne(p => p.Project).HasForeignKey(a => a.ProjectId);

        }
    }
}
