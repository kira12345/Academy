using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Data;

namespace Market.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductRepository product = new ProductRepository();
            CategoryRepository category = new CategoryRepository();
            Product products = new Product();

            var add = product.Add("Kirama", 1, 1, 2);
            //var categoryadd=category.Add("KIM","HOLA");
            var list=product.Get();
            if (add == true)
            {
                System.Console.WriteLine("Changes successfull");
                foreach (var item in list)
                {
                    var data = ($"Name:{products.Name=item.ToString()},CategoryId:{products.CategoryId=item.CategoryId},SupplierId:{products.SupplierId=item.SupplierId}");
                }
            }
            else
            {
                System.Console.WriteLine("Fail");
            }
            product.Delete(1);
            
            System.Console.ReadLine();
        }
    }
}
