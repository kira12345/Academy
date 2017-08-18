using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data
{
    public class DbEfAcademy: DbContext
    {
        public DbEfAcademy() : base("Data Source=.;Initial Catalog=School1;User ID=kirama; Password=root;")
        {

        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Citie> Citie { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            //One to one
            modelBuilder.Entity<Student>()
                //Es opcional que tenga domicilio
                .HasOptional(x => x.Address)
                //Requiere un estudiante a fuercitas
                .WithRequired(s => s.Student);

            //modelBuilder.Entity<StudentAddress>()
            //    .HasRequired(sa => sa.Student)
            //    .WithOptional(s=> s.Address);

            //One to many
            modelBuilder.Entity<Group>()
                .HasMany<Student>(g => g.Students)
                .WithRequired(s => s.Group);

            modelBuilder.Entity<Student>()
                .HasRequired<Group>(s => s.Group)
                .WithMany(g=>g.Students);

            modelBuilder.Entity<Course>()
                .HasRequired<Student>(c => c.Student)
                .WithMany(s => s.Course);

            //Many Many    
            modelBuilder.Entity<Cities_Api>()
                .HasMany<Vendor_Api>(c => c.Vendors)
                .WithMany(v => v.Cities)
                .Map(cv => {
                    cv.MapLeftKey("VendorId");
                    cv.MapRightKey("CitieId");
                    cv.ToTable("CityVendor","University");
                });
                
        }
    }
}
