using Market.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Console
{
    public class CategoryRepository
    {
        public DbEfMarket market = new DbEfMarket();

        public bool Add(string name,string description)
        {
            try
            {
                var category = new Category { Name = name,Description=description};
                market.Categories.Add(category);
                market.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void Delete(int Id)
        {
           
        }

        public void Update()
        {

        }
    }
}
