using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Validation_Summary.Models
{
    public class Customer
    {
        [DisplayName("Customer Id")]
        [Required(ErrorMessage="Id Field Can not be Blank")]
        public string Id { get; set; }


        [DisplayName("Customer Name")]
        [Required(ErrorMessage = "Name Field Can not be Blank")]
        public string Name { get; set; }


        [DisplayName("Customer Date of Birthe")]
        [Required(ErrorMessage = "Please select date of birth")]
        public DateTime Date { get; set; }


        [DisplayName("Customer Mobile Number")]
        [Required(ErrorMessage = "Mobile Field Can not be Blank")]
        public string Mobile { get; set; }


        [DisplayName("Customer Email")]
        [Required(ErrorMessage = "Email Field Can not be Blank")]
        [EmailAddress(ErrorMessage ="Please Enter valid email")]
        public string Email { get; set; }
    }
}
