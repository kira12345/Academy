using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data
{
    public class Cities_Api
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
        #region navegation properties
        public virtual ICollection<Vendor_Api> Vendors { get; set; }
        #endregion
    }
}
