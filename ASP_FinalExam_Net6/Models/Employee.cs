using System.ComponentModel.DataAnnotations;
namespace ASP_FinalExam_Net6.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required] // this is to make it a required field
        [MaxLength(100, ErrorMessage = "Name cannot be greater than 100 characters!!!")] // when max-length is greater than 100, it will display this message
        public string Name { get; set; }
        public bool IsManager { get; set; }

    }
}
