using System.ComponentModel.DataAnnotations;
namespace SchoolAppCoreMVC.Models
{
    public class Department
    {
        [Key]
        public required int DepartmentID { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
    }
}
