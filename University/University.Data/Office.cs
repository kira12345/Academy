﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data
{
    public class Office
    {
        #region properties

        public int Id { get; set; }
        public int Edificio { get; set; }
        [StringLength(50, ErrorMessage = "Error Lenght", MinimumLength = 10)]
        public string Piso { get; set; }

        #endregion
        #region navegation properties
        public virtual ICollection<Employee> Employees { get; set; }
        #endregion
    }
}
