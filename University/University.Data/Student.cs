using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data
{
    public class Student : Person
    {
        #region properties
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Error Lenght", MinimumLength = 3)]
        public string Name { get; set; }
        //public string Lastname { get; set; }
        
        public int Enrollment { get; set; }
       
        #endregion
        #region navegation properties
        public virtual ICollection<Course> Courses { get; set; }
        #endregion
    }
}
