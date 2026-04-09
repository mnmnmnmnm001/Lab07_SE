using System.ComponentModel.DataAnnotations;
namespace SchoolAppCoreMVC.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public required string Title { get; set; }
        public int Credits { get; set; }
    }
}
