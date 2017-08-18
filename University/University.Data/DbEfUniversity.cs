using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data
{
    public class DbEfUniversity: DbContext
    {
        public DbEfUniversity() : base("Data Source=.; Initial Catalog=University; User ID=kirama; Password=root;")
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<EmployeeCategory> EmployeeCategory { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Departament { get; set; }
        public DbSet<Office> Office { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany<Course>(s => s.Courses)
                .WithMany(c => c.Students);
            modelBuilder.Entity<Employee>()
                .HasMany<Department>(e => e.Departments)
                .WithMany(d => d.Employees);
            modelBuilder.Entity<Office>()
                .HasMany<Employee>(o => o.Employees)
                .WithOptional(e => e.Offices);
            modelBuilder.Entity<EmployeeCategory>()
                .HasMany<Employee>(ec => ec.Employees)
                .WithRequired(e => e.EmployeesCategories);
        }
    }
}
