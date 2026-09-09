delegate void MyDelegate(string name);

class Program
{
    static void SayHello(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    static void Main()
    {
        MyDelegate d = SayHello;

        d("Asif");
    }
}