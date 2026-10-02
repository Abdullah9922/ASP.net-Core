namespace Student_Management_System__Get_Post_.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }

        public double Cgpa { get; set; }

        public DateTime DateOfBirth { get; set; }

        public static List<Student> students { get; set; } = new List<Student>();
    }
}
