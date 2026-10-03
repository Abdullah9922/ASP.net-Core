using System.ComponentModel;

namespace Templated_Html_Helper.Models
{
    public class Student
    {
        [DisplayName("Id Number")]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Disable or Not")]
        public bool IsDisable { get; set; }

        
    }
}
