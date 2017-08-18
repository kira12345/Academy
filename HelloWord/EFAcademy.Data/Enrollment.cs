using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data
{
    [Table("Enrollment", Schema = "Enrollment")]
    public class Enrollment
    {
        public Enrollment()
        {

        }

        #region Properties
        [Key]
        public int EnrollmentId { get; set; }
        //Define el tamaño y la longitud minima. Tambien se define el error
        //[StringLength(50, ErrorMessage = "Error Lenght", MinimumLength = 10)]
        
        public int CourseId { get; set; }
        
        public int StudentId { get; set; }
        public int Grade { get; set; }
        #endregion

        #region navegation properties
        [ForeignKey("StudentId")]
        public virtual Student student { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course course { get; set; }
        #endregion
        

        //public List<Student> Student { get; set; }
        //public List<Course> Course { get; set; }
    }
}
