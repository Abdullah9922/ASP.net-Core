

using Student_Management_System;

Student student = new Student();

Student s1 = new Student
{
    Id = 101,
    Name = "Asif",
    Department = Department.CSE,
    Gender = Gender.Male,
    CGPA = 3.75,
    DateOfBirth = new DateTime(2004, 5, 10),
    Address = new Address("Dhaka", "Bangladesh", 1207),
    PhoneNumber = 01711111111
};

Student s2 = new Student
{
    Id = 102,
    Name = "Rahim",
    Department = Department.EEE,
    Gender = Gender.Male,
    CGPA = 3.50,
    DateOfBirth = new DateTime(2005, 2, 15),
    Address = new Address("Rajshahi", "Bangladesh", 6200),
    PhoneNumber = null
};

Student s3 = new Student
{
    Id = 103,
    Name = "Karim",
    Department = Department.CSE,
    Gender = Gender.Male,
    CGPA = 3.90,
    DateOfBirth = new DateTime(2003, 11, 20),
    Address = new Address("Chittagong", "Bangladesh", 4000),
    PhoneNumber = 01822222222
};

Student s4 = new Student
{
    Id = 104,
    Name = "Nusrat",
    Department = Department.BBA,
    Gender = Gender.Female,
    CGPA = 3.65,
    DateOfBirth = new DateTime(2004, 8, 5),
    Address = new Address("Khulna", "Bangladesh", 9000),
    PhoneNumber = 01933333333
};

Student s5 = new Student
{
    Id = 105,
    Name = "Sakib",
    Department = Department.ICE,
    Gender = Gender.Male,
    CGPA = 3.25,
    DateOfBirth = new DateTime(2005, 1, 25),
    Address = new Address("Sylhet", "Bangladesh", 3100),
    PhoneNumber = null
};

Student s6 = new Student
{
    Id = 106,
    Name = "Mim",
    Department = Department.CSE,
    Gender = Gender.Female,
    CGPA = 3.85,
    DateOfBirth = new DateTime(2004, 12, 12),
    Address = new Address("Dhaka", "Bangladesh", 1212),
    PhoneNumber = 01644444444
};

Student s7 = new Student
{
    Id = 107,
    Name = "Tanvir",
    Department = Department.EEE,
    Gender = Gender.Male,
    CGPA = 3.40,
    DateOfBirth = new DateTime(2003, 7, 18),
    Address = new Address("Rajshahi", "Bangladesh", 6201),
    PhoneNumber = 01555555555
};

Student s8 = new Student
{
    Id = 108,
    Name = "Tania",
    Department = Department.BBA,
    Gender = Gender.Female,
    CGPA = 3.95,
    DateOfBirth = new DateTime(2004, 3, 8),
    Address = new Address("Barisal", "Bangladesh", 8200),
    PhoneNumber = 01366666666
};

List<Student> students = new List<Student>
{
    s1, s2, s3, s4,
    s5, s6, s7, s8
};

var summay = student.GetStudentSummary(student);

Console.WriteLine(summay.Name);
Console.WriteLine(summay.CGPA);

var result2 = new
{
    student.Name,
    student.Department,
    student.CGPA
};


dynamic studentInfo = new
{
    Name = "Asif",
    CGPA = 3.75,
    Department = Department.CSE
};

Console.WriteLine(studentInfo.Name);
Console.WriteLine(studentInfo.CGPA);

var studentInfo2 = new
{
    Name = "Asif",
    CGPA = 3.75,
    Department = Department.CSE
};

Console.WriteLine(studentInfo2.Name);
Console.WriteLine(studentInfo2.CGPA);


GetInfo.GetResult(student.CGPA);
GetInfo.GetReport(student);

foreach(var s  in students)
{
    GetInfo.GetReport(s);
    Console.WriteLine();
}
