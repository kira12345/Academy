using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data
{
    [Table("StudentAddress", Schema = "StudentsAddress")]
    public class StudentAddress
    {

        #region properties
        [Key, ForeignKey("Student")]
        public int StudentAddressId { get; set; }
        
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        #endregion

        #region navegation properties
        public virtual Student Student { get; set; }
        #endregion
    }
}
