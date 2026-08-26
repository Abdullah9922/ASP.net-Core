

using System.Runtime.InteropServices;

(int,int) Calculate(int a,int b)
{
    int division = a / b;
    int multiplication = a * b;
    return (division , multiplication);
}

void Test ((string, double, bool) something , int count)
{
    string x = something.Item1;
    double y = something.Item2;

    x = "hello";
    something.Item1 = "hello";
    something.Item3 = true;
}

(string a, int b)[] f = new (string, int)[3];

f[0] = ("One", 1);

var m = Calculate(10, 2);
Console.WriteLine(m.Item1);
Console.WriteLine(m.Item2);


//new prac
var x = (10, 20);
var x2 = (a: 10, b: 20);

Console.WriteLine(x.Item1);
Console.WriteLine(x.Item2);
Console.WriteLine(x2.a);
Console.WriteLine(x2.b);

static (int sum, int product) Test(int a, int b)
{
    return (a + b, a * b);
}

static (int, int) Test()
{
    return (10, 20);
}

var (sum, _, product) = Test(10, 20); // ignore

(a, b) = (b, a); // swap
