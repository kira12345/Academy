using Market.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Data
{
    public class DbEfMarket : DbContext
    {
        public DbEfMarket() : base("Data Source=.; Initial Catalog=Market; User ID=kirama; Password=root;") {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasRequired<Supplier>(p => p.Supliers)
                .WithMany(s=>s.Products);
            modelBuilder.Entity<Product>()
                .HasRequired<Category>(p => p.Categories)
                .WithMany(c=>c.Products);               
            //base.OnModelCreating(modelBuilder);
        }
    }
}
