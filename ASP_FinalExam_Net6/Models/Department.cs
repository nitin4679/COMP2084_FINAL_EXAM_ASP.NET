using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_FinalExam_Net6.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required] // this is to make it a required field
        [MaxLength(100, ErrorMessage = "Name cannot be greater than 100 characters!!!")] // when max-length is greater than 100, it will display this message
        public string Name { get; set; }

        [Range(0,Int32.MaxValue)] // this is to set the minimum value to 0
        public int EmployeeCount { get; set; }

        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
