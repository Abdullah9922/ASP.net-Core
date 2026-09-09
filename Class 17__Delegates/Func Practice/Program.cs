
using System.Diagnostics;

public class Program
{
    public static bool Divisible(int a, int b)
    {
        return a % b == 0;
    }


    public static void Main(string[] args)
    {
        Func<int,int,int> Addition = (x, y) => x + y;
        Console.WriteLine(Addition(1, 2));

        Func<int, double, int, double> Addition2 = (x, y, z) => x + y + z;
        Console.WriteLine(Addition2(1, 2.5,3));

        Func<int, int, bool> Div;
        Div = Divisible;
        if (Div(4, 2))
        {
            Console.WriteLine("It is divisiable");
        }
        else Console.WriteLine("NOT");
    }
}
