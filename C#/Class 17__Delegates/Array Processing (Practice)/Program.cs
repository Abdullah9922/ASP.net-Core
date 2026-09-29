using System.Diagnostics;

delegate decimal Process(int x);

public class Program
{
    public static decimal Square(int x)
    {
        return x * x;
    }

    public static decimal Div(int x)
    {
        return x / 2;
    }
    public static void Main(string[] args)
    {
        int[] numbers = { 2, 5, 8, 11, 14, 17 };

        Process p;

        p = Square;
        foreach (var num in numbers) 
        {
            Console.Write(p(num) + " ");
        }
        Console.WriteLine();

        p = Div;
        foreach (var num in numbers)
        {
            Console.Write(p(num) + " ");
        }
    }
}