
using System.Diagnostics;

public class Program
{
   
    public static void Main(string[] args)
    {
        List<int> Marks = new List<int>
        {
            35, 72, 48, 90, 65, 30, 85
        };

        Predicate<int> Pass = x => x >= 33;

        Func<int, string> Grade = mark =>
        {
            if (mark >= 90) return "A+";

            else if (mark >= 80) return "A";

            else if (mark >= 70) return "A-";

            else if (mark >= 60) return "B";

            else if (mark >= 40) return "C";

            else return "F";

        };

        Action<int> Print = x => Console.WriteLine(x);

        foreach (int mark in Marks)
        {
            if (Pass(mark))
            {
                Console.WriteLine(
                    $"{mark} -> {Grade(mark)}"
                );
            }
            else
            {
                Console.WriteLine(
                    $"{mark} -> {Grade(mark)} (Fail)"
                );
            }

            Print(mark);
            Console.WriteLine();
        }
    }
}

