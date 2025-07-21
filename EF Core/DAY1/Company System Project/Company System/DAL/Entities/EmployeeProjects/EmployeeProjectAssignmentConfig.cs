using Company_System.DAL.Entities.Departments;
using Company_System.DAL.Entities.Employees;
using Company_System.DAL.Entities.Projects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_System.DAL.Entities.EmployeeProjects
{
    //public int EmployeeId { get; set; }
    //public int ProjectId { get; set; }
    //public double Hours { get; set; }
    //public DateTime AssignmentDate { get; set; } = DateTime.Now;

    //public Employee Employee { get; set; }
    //public Project Project { get; set; }
    public class EmployeeProjectAssignmentConfig : IEntityTypeConfiguration<EmployeeProjectAssignment>
    {
        public void Configure(EntityTypeBuilder<EmployeeProjectAssignment> builder)
        {
            builder.ToTable("ProjectAssignment");

            builder.HasKey(a => new { a.ProjectId, a.EmployeeId });

            //Defualt Foreign key deletion is by Cascade and (SQL Server) prevent more than one for the same table.

            builder.HasOne(e => e.Employee)
                .WithMany(e => e.Assignments)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict

            builder.HasOne(e => e.Project)
                .WithMany(p => p.Assignments)
                .HasForeignKey(e => e.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
