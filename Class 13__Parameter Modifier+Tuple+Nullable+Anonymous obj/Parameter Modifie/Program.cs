
using Parameter_Modifie;
using System.Runtime.InteropServices;

internal class Program
{
    public static void DoubleValue(ref int x)
    {
        x *= 2;
    }

    public static void Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }

    public static void GetSquare(int n,out int result)
    {
        result = n * n;
    }

    public static void CheckNumber(int n, out bool isEven)
    {
        if (n % 2 == 0) isEven = true;
        else isEven = false;
    }
    public static void Login(string username,string password, out string massage)
    {
        if (username == "admin" && password == "1234") massage = "Valid";
        else massage = "Invalid";
    }

    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        for(int i=0; i<numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    public static void ReplaceNegative(ref int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0 ) numbers[i] = 0;
        }
    }

    public static void ShowStudent(in Student student)
    {
        Console.WriteLine("Name: " + student.Name);
    }

    public static void Calculate(ref int total , out int max, params int[] digits)
    {
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += digits[i];
        }
        total = sum;
        max = digits.Max();
    }
    public static void Main(string[] args)
    {
        int x = 10;
        Program.DoubleValue(ref x);
        Console.WriteLine(x);

        int a = 10;
        int b = 99;
        Program.Swap(ref a, ref b);
        Console.WriteLine(a + " " + b);

        int n = 5;
        int result;
        Program.GetSquare(n,out result);
        Console.WriteLine(result);

        int z = 5;
        bool isEven = false;
        Program.CheckNumber(z,out isEven);
        Console.WriteLine(isEven ? "Even" : "Odd");

        string admin = "admin";
        string password = "password";

        string massage;
        Program.Login(admin, password, out massage);
        Console.WriteLine(massage);


        Console.WriteLine(Sum(1, 2, 3, 4, 5));
        Console.WriteLine(Sum(10, 20, 30));

        int[] numbers = { 1, 2, 3, -4, 5, -6, };
        ReplaceNegative(ref numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();


        Student s = new Student();
        s.Name = "Test";
        s.Age = 1;
        s.CGPA = 4.5;
        ShowStudent(s);


        int total=0;
        int max;
        int[] digits = { 1, 2, 3, 4, 5, 6, };
        Calculate(ref total, out max, digits);
        Console.WriteLine($"{total} {max} ");
    }
}