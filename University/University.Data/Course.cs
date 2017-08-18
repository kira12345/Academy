using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data
{
    public class Course
    {
        #region properties
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Error Lenght", MinimumLength = 10)]
        public string Name { get; set; }
        public int credits { get; set; }
        #endregion
        #region navegation properties
        public virtual ICollection<Student> Students { get; set; }
        #endregion
    }
}
