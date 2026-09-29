using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    public static class GetInfo
    {
        public static void GetResult(in double cg)
        {
            if (cg <= 2.5)
                Console.WriteLine("Grade: C");
            else if (cg > 2.5 && cg <= 2.75)
                Console.WriteLine("Grade: B");
            else if (cg > 2.75 && cg <= 3.00)
                Console.WriteLine("Grade: B+");
            else if (cg > 3.00 && cg <= 3.25)
                Console.WriteLine("Grade: A-");
            else if (cg > 3.25 && cg <= 3.50)
                Console.WriteLine("Grade: A");
            else if (cg > 3.50 && cg <= 4.00)
                Console.WriteLine("Grade: A+");
            else
                Console.WriteLine("Invalid CGPA");
        }

        public static void GetReport(in Student s)
        {
            Address a = new Address();
            Console.WriteLine("========== STUDENT REPORT ==========");
            Console.WriteLine();
            Console.WriteLine("ID         : " + s.Id);
            Console.WriteLine("Name       : " + s.Name);
            Console.WriteLine("Department : " + s.Department);
            Console.WriteLine("Gender     : " + s.Gender);
            Console.WriteLine("CGPA       : " + s.CGPA);
            Console.WriteLine("Age        : " + s.GetAge(s));
            Console.WriteLine("Phone      : " + s.PhoneNumber);
            a.PrintAddress(s.Address);
            Console.WriteLine("------------------------------------");
        }
    }
}
