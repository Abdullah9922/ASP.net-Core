using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Validating_Data_In_Standard_Type.Models
{
    public class Student
    {
        [DisplayName("Student's Id")]
        [Required(ErrorMessage ="Id lagbe re vai.")]
        public int? Id { get; set; }

        [DisplayName("Student's Name")]
        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        [DisplayName("Student's Email")]
        
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DisplayName("Student's Mobile Number")]
        [Required]
        [Phone]
        public string Number { get; set; }

        [DisplayName("Student's Date Of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }

        
    }
}
