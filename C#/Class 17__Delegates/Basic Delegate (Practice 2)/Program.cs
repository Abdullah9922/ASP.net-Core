

class Program
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply (int a, int b)
    {
        return a * b;
    }

    public static int Subtrac(int a, int b)
    {
        return a - b;
    }

    public static void Calculate(int a, int b, Func<int,int,int> o)
    {
        int result = o(a, b);
        Console.WriteLine(result);
    }

    static void Main()
    {
        Calculate(10, 5, Add);
        Calculate(10, 5, Multiply);

        Predicate<int> isEven = x => x % 2 == 0;
        Predicate<int> isPositive = x => x > 0;
        Predicate<int> isGreaterThan50 = x => x > 50;

        Console.WriteLine(isEven(4));          // True
        Console.WriteLine(isPositive(4));      // True
        Console.WriteLine(isGreaterThan50(4)); // False


        /*
         
         
        Action
        → একাধিক কাজ execute করা খুব useful

        Func
        → একাধিক function execute হতে পারে,
          কিন্তু return হিসেবে শেষটার result পাওয়া যায়

        Predicate
        → একইভাবে একাধিক condition execute হতে পারে,
          কিন্তু সব bool result আলাদাভাবে পাওয়া যায় না
         
         
         */

        // sob gula output pabo
        Action<string> print = x => Console.WriteLine("Hello " + x);        print += x => Console.WriteLine("Welcome " + x);
        print += x => Console.WriteLine("Goodbye " + x);
        print("Asif");


        // last ar ta just output pabo
        Func<int, int> calculate = x => x + 10;
        calculate += x => x * 2;
        calculate += x => x - 5;
        Console.WriteLine(calculate(10));

        // last ar ta just output pabo
        Predicate<int> NumberCheck = x => x % 2 == 0; 
        NumberCheck += x => x > 0; 
        NumberCheck += x => x > 50; 
        Console.WriteLine(NumberCheck(4));

    }
}