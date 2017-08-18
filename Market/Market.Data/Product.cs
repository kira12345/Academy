using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Data
{
    [Table("Product", Schema = "Products")]
    public class Product
    {
        #region properties
        [Key]
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Error Lenght", MinimumLength = 10)]
        public string Name { get; set; }
        public int? CategoryId { get; set; } 
        public int? SupplierId { get; set; }
        public float Price { get; set; }
        #endregion
        #region navegation properties
        public Supplier Supliers { get; set; }
        public Category Categories { get; set; }
        #endregion
    }
}
