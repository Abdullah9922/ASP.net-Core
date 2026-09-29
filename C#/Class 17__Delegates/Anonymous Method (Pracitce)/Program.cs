
using System.Diagnostics;

public class Program
{

    public static void Main(string[] args)
    {
        Func<int, int> Square = (x) => x * x;
        Console.WriteLine(Square(5));
    }
}
