using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            Vendor vendor = new Vendor();
            var id = r.Next(1, 200);
            //vendor.CompanyName = "ABC Corp";
            //vendor.Email = "abc@abc.com";
            Console.WriteLine(id);
            Console.ReadLine();
        }
       
    }
}
