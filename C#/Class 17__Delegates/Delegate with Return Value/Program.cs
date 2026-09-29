delegate int Calculator(int a, int b);

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        Calculator calc = Add;

        int result = calc(10, 20);

        Console.WriteLine(result);
    }
}