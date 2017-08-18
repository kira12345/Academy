using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Data
{
    [Table("Supplier", Schema = "Suppliers")]
    public class Supplier
    {
        #region properties
        [Key]
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Error Lenght", MinimumLength = 10)]
        public string Name { get; set; }
        [StringLength(50, ErrorMessage = "Error Lenght", MinimumLength = 10)]
        public string Email { get; set; }
        #endregion
        #region navegation properties
        public ICollection<Product> Products { get; set; }
        #endregion

    }
}
