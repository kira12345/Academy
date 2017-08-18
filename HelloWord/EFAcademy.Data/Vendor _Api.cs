using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data
{
    public class Vendor_Api
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
        #region navegation properties
        public virtual ICollection<Cities_Api> Cities { get; set; }
        #endregion
    }
}
