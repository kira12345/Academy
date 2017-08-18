using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Data;

namespace Market.Console
{
    public class ProductRepository
    {
        public DbEfMarket market = new DbEfMarket();
        public Product product = new Product();
        public bool Add(string name,int categoryId, int supplierId,float price)
        {
            try
            {
                var product = new Product { Name = name, CategoryId=categoryId,SupplierId=supplierId,Price=price };
                market.Products.Add(product);
                market.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<Product> Get()
        {
            return market.Products.ToList(); 
        }

        public void Get(int id)
        {
            market.Products.First<Product>();
            market.SaveChanges();
        }

        public void Delete(int id)
        {
            try
            {
                market.Products.Remove(product);
                market.SaveChanges();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("");
            }  
        }

        public void Update()
        {
            
        }
    }
}
