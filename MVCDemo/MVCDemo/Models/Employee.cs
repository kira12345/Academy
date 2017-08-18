using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Employee
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string name { get; set; }
        [DisplayFormat(DataFormatString ="{0::MM/dd/yyyy}",ApplyFormatInEditMode =true)]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        [Range(18,60)]
        public int Age { get; set; }
    }

    public class EmpDBContext : DbContext
    {
        public EmpDBContext() { }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EmpDBContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}