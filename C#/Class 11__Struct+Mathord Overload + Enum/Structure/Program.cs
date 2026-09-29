using System;
using Structure;

class Program
{
    static void Main()
    {
        Student s = new Student(101, "Asif", 3.80);

        s.Display();

        Console.WriteLine(s);
    }
}
