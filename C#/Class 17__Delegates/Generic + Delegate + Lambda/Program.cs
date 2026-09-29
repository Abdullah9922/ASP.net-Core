
class Program
{
    static T Calculate<T>(T a, T b, Func<T, T, T> operation)
    {
        return operation(a, b);
    }

    static void Main()
    {
        int result = Calculate(10, 20, (a, b) => a + b);

        double result2 = Calculate(2.5, 3.5, (a, b) => a * b);

        Console.WriteLine(result);
        Console.WriteLine(result2);
    }
}