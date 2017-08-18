using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data
{
    [Table("Student",Schema ="Students")]
    public class Student
    {
        public Student()
        {

        }

        #region Properties
        [Key]
        public int StudentId { get; set; }
        //Define el tamaño y la longitud minima. Tambien se define el error
        [StringLength(50,ErrorMessage ="Error Lenght",MinimumLength =10)]
        public string Lastname { get; set; }

        [Display(Name ="First Name")]
        public string Firstname { get; set; }

        public DateTime Enrollment { get; set; }

        #endregion
        #region navegation properties

        #endregion
        public int EnrollmentId { get; set; }
        public ICollection<Enrollment> enrollment { get; set; }

        public virtual StudentAddress Address { get; set; }

        //Foreign key
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int CourseId { get; set; }
        public virtual ICollection<Course> Course { get; set; }
    }
}
