
public  delegate int Operation(int a, int b);

public class Program
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    public static int Divide(int a, int b)
    {
        return a / b;
    }

    public static void Main(string[] args)
    {
        Operation o;

        o = Add;
        Console.WriteLine(o(10, 5));
        o = Subtract;
        Console.WriteLine(o(10, 5));
        o = Multiply;
        Console.WriteLine(o(10, 5));
        o = Divide;
        Console.WriteLine(o(10, 5));
    }
}