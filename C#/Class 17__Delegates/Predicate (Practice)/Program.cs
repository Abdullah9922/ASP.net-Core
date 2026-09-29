using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 2, 5, 8, 11, 14, 17 };

        Predicate<int> IsOdd = num => num % 2 != 0;
        foreach (int i in numbers)
        {
            if(IsOdd(i)) Console.Write(i + " ");
        }
        Console.WriteLine();

        Predicate<int> IsGreater = num => num > 10;
        foreach (int i in numbers)
        {
            if (IsGreater(i)) Console.Write(i + " ");
        }


    }
}