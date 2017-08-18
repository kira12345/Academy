using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class VendorRepository
    {
        public Dictionary<string, Vendor> RetrieveWithKeys()
        {
            Dictionary<string, Vendor> vendors = new Dictionary<string, Vendor>()
            {
                { "ABC Corp",new Vendor()
                   { VendorId=5,CompanyName="ABC Corp", Email="abc@abc.com"} },
                { "XYZ Inc",new Vendor()
                   { VendorId=8,CompanyName="XYZ Inc", Email="abc@xyz.com"} },
            };

            foreach (var companyNameK in vendors.Keys)
            {                 
               // Console.WriteLine(vendors[companyNameK]);
            }
            foreach (var element in vendors)
            {
                var vendor = element.Value;
                var key = element.Key;
                Console.WriteLine($"Company:{key} Email:{vendor.Email}");
            }
            Console.WriteLine(vendors["XYZ Inc"].CompanyName);
            return vendors;
        }
    }
}
