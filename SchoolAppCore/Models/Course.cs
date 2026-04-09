using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace SchoolAppCore.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public required string Title { get; set; }
        public int Credits { get; set; }
    }
}
