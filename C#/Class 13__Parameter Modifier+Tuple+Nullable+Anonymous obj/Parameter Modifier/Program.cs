using Parameter_Modifier;
using Parameter_Modifier;



class Program
{
    // Normal parameter
    static void Normal(int a)
    {
        Console.WriteLine($"Normal method er vitore age: {a}");

        a = 100;

        Console.WriteLine($"Normal method er vitore pore: {a}");
    }


    // ref parameter
    static void RefExample(ref int a)
    {
        Console.WriteLine($"Ref method er vitore age: {a}");

        a = 200;

        Console.WriteLine($"Ref method er vitore pore: {a}");
    }


    // in parameter
    static void InExample(in int a)
    {
        Console.WriteLine($"In method er value: {a}");

        // a = 300; // Error!
        // কারণ in parameter change করা যায় না
    }


    // out parameter
    static void OutExample(out int a)
    {
        a = 400; // অবশ্যই value assign করতে হবে
    }


    static void Main()
    {
        int x = 10;

        Console.WriteLine($"Main er শুরুতে x = {x}");
        Console.WriteLine();


        // Normal
        Normal(x);

        Console.WriteLine($"Normal er pore x = {x}");
        Console.WriteLine();


        // ref
        RefExample(ref x);

        Console.WriteLine($"Ref er pore x = {x}");
        Console.WriteLine();


        // in
        InExample(in x);

        Console.WriteLine($"In er pore x = {x}");
        Console.WriteLine();


        // out
        int y;

        OutExample(out y);

        Console.WriteLine($"Out er pore y = {y}");





        // old
        //var demo = new Demo();

        //int average = demo.Average(10, 20);
        //int average2 = demo.Average(10, 20, 30, 40, 30, 90);


        //int x = 10;
        //demo.Test1(ref x);
        //Console.WriteLine(x);

        //int y = 20;
        //demo.Test3(out y);
        //Console.WriteLine(y);
    }
}