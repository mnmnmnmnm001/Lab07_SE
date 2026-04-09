using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace SchoolAppCore.Models
{
    public class Enrollment
    {
        [Key]
        public required int EnrollmentID { get; set; }
        public decimal Grade { get; set; }
    }
}
