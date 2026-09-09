using Basic_Delegates;


class Program
{
    public delegate int Operation(int a, int b);


    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static void Calculate1(int x, int y, Operation op)
    {
        Console.WriteLine(op(x, y));
    }





    // callback
    static void Calculatee2(int a, int b, Func<int, int, int> operation)
    {
        int result = operation(a, b);

        Console.WriteLine(result);
    }

    static int Calculate(int a, int b, Func<int, int, int> operation)
    {
        return operation(a, b);
    }

    static void Main()
    {


        Calculate1(10, 20, Add);
        Calculate1(10, 20, Multiply);



        Calculatee2(10, 20, (a, b) => a + b); // a -> int, b-> int, a+b -> int(return type)

        Calculatee2(10, 20, (a, b) => a * b);

        Calculatee2(10, 20, (a, b) => a - b);



        int result1 = Calculate(10, 5, (a, b) => a + b);
        int result2 = Calculate(10, 5, (a, b) => a - b);
        int result3 = Calculate(10, 5, (a, b) => a * b);

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
    }
}