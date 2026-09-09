
//public delegate int Operation(int a, int b);

public class Solution
{
    //public static int Calculate(int a, int b, Operation o)
    //{
    //    return o(a, b);
    //}

    public static int Calculate(int a, int b, Func<int,int,int> o)
    {
        return o(a, b);
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Mul(int a,int b)
    {
        return a * b;
    }


    public static void Main(String[] args)
    {
        int result = Calculate(20, 1, Add);
        Console.WriteLine(result);

        Console.WriteLine(Calculate(3, 2, Mul));
    }
}
