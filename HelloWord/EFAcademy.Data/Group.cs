using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data
{
    [Table("Group", Schema = "Groups")]
    public class Group
    {
        #region properties
        [Key]
        public int GroupId { get; set; }
        public string hour{get; set;}
        #endregion
        
        #region navegation properties
        public virtual ICollection<Student> Students { get; set; }
        #endregion
    }
}
