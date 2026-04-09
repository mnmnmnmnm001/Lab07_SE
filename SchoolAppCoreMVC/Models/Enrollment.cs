using System.ComponentModel.DataAnnotations;
namespace SchoolAppCoreMVC.Models
{
    public class Enrollment
    {
        [Key]
        public required int EnrollmentID { get; set; }
        public decimal Grade { get; set; }
    }
}
