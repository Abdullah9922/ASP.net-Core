
delegate bool NumberCheck(int n);

public class Program
{
    public static bool Check(int n)
    {
        return n % 2 == 0;
    }


    public static void Main(string[] args)
    {
        NumberCheck c;
        c = Check;

        if (c(10)) Console.WriteLine("Even");
        else Console.WriteLine("ODD");
    }
}
