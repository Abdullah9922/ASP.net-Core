delegate int Operation(int a, int b);

class Program
{
    static int Calculate(int a, int b, Operation op)
    {
        return op(a, b);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Calculate2(int a, int b, Func<int, int, int> operation)
    {
        return operation(a, b);
    }

    static void Main()
    {
        int result = Calculate(10, 20, Add);

        Console.WriteLine(result);

        int result2 = Calculate2(100, 20, (a, b) => a + b);

        Console.WriteLine(result2);
    }
}