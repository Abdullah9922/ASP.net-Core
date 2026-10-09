namespace Scaffolding.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public double CGPA { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool IsActive { get; set; }

        public char Grade { get; set; }

        public decimal TuitionFee { get; set; }
    }
}
