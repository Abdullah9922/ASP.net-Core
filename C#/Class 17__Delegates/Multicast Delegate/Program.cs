delegate void MyDelegate();

class Program
{
    static void A()
    {
        Console.WriteLine("A");
    }

    static void B()
    {
        Console.WriteLine("B");
    }

    static void c()
    {
        Console.WriteLine("c");
    }

    static void Main()
    {
        MyDelegate d = A;
        d += B;
        d += c;

        d -= A;

        d();


        Action message = () => Console.WriteLine("Hello");
        message += () => Console.WriteLine("Welcome");
        message += () => Console.WriteLine("Good Morning");
    }
}
