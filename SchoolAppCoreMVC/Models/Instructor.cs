using System.ComponentModel.DataAnnotations;
namespace SchoolAppCoreMVC.Models
{
    public class Instructor
    {
        [Key]
        public required int InstructorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
    }
}
