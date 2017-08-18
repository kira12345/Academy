using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data
{
    public class Employee:Person
    {
        #region properties
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Error Lenght", MinimumLength = 10)]
        public string Firstname { get; set; }
        //public string Lastname { get; set; }
        public int Hours { get; set; }
        public int CategoryId { get; set; }
        [StringLength(50, ErrorMessage = "Error Lenght", MinimumLength = 10)]
        public string EmployeeEnrollment { get; set; }

        public int? OfficeId { get; set; }
        #endregion
        #region navegation properties
        public virtual ICollection<Department> Departments { get; set; }
        public virtual Office Offices { get; set; }
        public virtual EmployeeCategory EmployeesCategories { get; set; }
        #endregion

    }
}
