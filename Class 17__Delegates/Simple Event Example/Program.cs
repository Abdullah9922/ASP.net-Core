using System;

class Program
{
    public delegate void MyDelegate();

    public static event MyDelegate MyEvent;

    static void Main()
    {
        MyEvent += Hello;

        MyEvent?.Invoke();
    }

    static void Hello()
    {
        Console.WriteLine("Hello!");
    }
}