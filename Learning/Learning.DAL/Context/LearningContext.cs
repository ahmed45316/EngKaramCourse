using Learning.DAL.Configuration;
using Learning.Entity.Entites;
using Microsoft.EntityFrameworkCore;

namespace Learning.DAL.Context
{
    public class LearningContext : DbContext
    {
        public LearningContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configuration
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            #endregion
            #region GlobalFilter
            modelBuilder.Entity<Department>().HasQueryFilter(b => !b.IsDelete);
            modelBuilder.Entity<Employee>().HasQueryFilter(b => !b.IsDelete);
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
