

public class Program
{
    public static (int sum,int diff,int product, double div) Calculate (int a, int b)
    {
        return (a + b, a - b, a * b, a / b);
    }

    public static (int id,string name, double cg) FindTopStudent((int id,string name, double cg)[] students)
    {
        var top = students[0];

        foreach (var student in students)
        {
            if (student.cg > top.cg)
            {
                top = student;
            }
        }

        return (top.id, top.name, top.cg);
    }

    public static void Main(string[] args)
    {
        (int Id, string Name, double CGPA) student = (101, "Korim", 3.93);

        Console.WriteLine(student.Id);
        Console.WriteLine(student.Name);
        Console.WriteLine(student.CGPA);

        Console.WriteLine(student.Item1);
        Console.WriteLine(student.Item2);
        Console.WriteLine(student.Item3);

        // Tuple Deconstruction 
        var (id, name, cgpa) = student;
        Console.WriteLine(id);
        Console.WriteLine(name);
        Console.WriteLine(cgpa);

        var (rol, nam, cg) = (111, "KKKKK", 3.76);
        Console.WriteLine(rol);
        Console.WriteLine(nam);
        Console.WriteLine(cg);

        var (item1, item2, item3, item4) = Calculate(6, 7);
        Console.WriteLine(item1);
        Console.WriteLine(item2);
        Console.WriteLine(item3);
        Console.WriteLine(item4);


        // 1
        var students = new[]
        {
            (Id: 101, Name: "Asif", CGPA: 3.50),
            (Id: 102, Name: "Rahim", CGPA: 3.80),
            (Id: 103, Name: "Karim", CGPA: 3.60)
        };

        //2
        var students2 = new[]
            {
                (101, "Asif", 3.50),
                (102, "Rahim", 3.80),
                (103, "Karim", 3.60)
            };

        // 3
        (int Id, string Name, double CGPA)[] students3 =
        {
            (101, "Asif", 3.50),
            (102, "Rahim", 3.80),
            (103, "Karim", 3.60)
        };

        // 4
        ValueTuple<int, string, double>[] students4 =
        {
            (101, "Asif", 3.50),
            (102, "Rahim", 3.80),
            (103, "Karim", 3.60)
        };

        var top = FindTopStudent(students);
        Console.WriteLine(top.Item2);
    }
}