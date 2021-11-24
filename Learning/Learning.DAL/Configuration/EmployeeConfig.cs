using Learning.Entity.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learning.DAL.Configuration
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
           builder.HasOne(b => b.Department)
                .WithMany(a => a.Employees)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
