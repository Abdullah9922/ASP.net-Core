public delegate void Greeting(string message);


public class Program
{
    public static void SayHello(string message)
    {
        Console.WriteLine("Hello " + message);
    }
    public static void SayWelcome(string message)
    {
        Console.WriteLine("Welcome " + message);
    }

    public static void Main(string[] args)
    {
        Greeting g;
        g = SayHello;
        g("Arif");
        g = SayWelcome;
        g("Arif");
    }
}