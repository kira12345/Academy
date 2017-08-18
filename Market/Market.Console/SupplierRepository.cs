using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Data;

namespace Market.Console
{
    public class SupplierRepository
    {
        public DbEfMarket market = new DbEfMarket();

        public bool Add(string name, string email)
        {
            try
            {
                var suppliers = new Supplier { Name = name, Email = email };
                market.Suppliers.Add(suppliers);
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
