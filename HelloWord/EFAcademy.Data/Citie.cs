using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data
{
    [Table("Cities", Schema = "University")]
    public class Citie
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
        #region navegation properties
        public virtual ICollection<Vendor> Vendors { get; set; }
        #endregion
    }
}
