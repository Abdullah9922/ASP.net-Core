namespace Student_Management_System.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }

        public double Cgpa { get; set; }

        public DateTime DateOfBirth { get; set; }

        public static List<Student> Students { get; set; } = new List<Student>();
    }
}
