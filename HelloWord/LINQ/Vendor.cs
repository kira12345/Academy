using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Vendor:{this.CompanyName}({this.VendorId})";
        }
    }
}
