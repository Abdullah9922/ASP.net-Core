using Student_Information_System__Practice3_;
using System.Runtime.Intrinsics.Arm;

Student s1 = new Student();
s1.Name = "Test";
s1.Id = 1;
s1.Cgpa = 3.45;
s1.BirthDate = new DateTime(2002, 10, 18);

DateTime now = DateTime.Now;

if(now.Month == s1.BirthDate.Month && now.Day >= s1.BirthDate.Day || (now.Month > s1.BirthDate.Month))
{
    Console.WriteLine($"You are {now.Year - s1.BirthDate.Year} Years old");
}
else Console.WriteLine($"You are {(now.Year - s1.BirthDate.Year) - 1} Years old");


var student = s1.Print();
Console.WriteLine(student.Name +" -> Result is Printed.");