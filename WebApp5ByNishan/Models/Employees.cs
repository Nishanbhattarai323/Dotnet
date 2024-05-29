using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp5ByNishan.Models
{
    public partial class Employees
    {
        [Key]
        [Required]
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public decimal Salary { get; set; } // Change data type to string
    }
}
