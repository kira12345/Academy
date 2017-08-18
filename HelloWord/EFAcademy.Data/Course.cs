using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data
{
    [Table("Course", Schema = "Course")]
    public class Course
    {
        #region Properties
        [Key]
        public int CourseId { get; set; }
        //Define el tamaño y la longitud minima. Tambien se define el error
        //[StringLength(50, ErrorMessage = "Error Lenght", MinimumLength = 10)]
        public int StudentId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public int horas { get; set; }
        #endregion

        #region navegation properties
        
        public virtual ICollection<Enrollment> enrollment { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
        #endregion
        
    }
}
