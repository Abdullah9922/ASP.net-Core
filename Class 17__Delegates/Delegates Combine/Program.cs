using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            1, 2, 3, 4, 5, 6
        };

        // Predicate → check করবে number even কিনা
        Predicate<int> isEven = x => x % 2 == 0;

        // Func → number এর square করবে
        Func<int, int> square = x => x * x;

        // Action → result print করবে
        Action<int> print = x => Console.WriteLine(x);


        foreach (int number in numbers)
        {
            // Predicate
            if (isEven(number))
            {
                // Func
                int result = square(number);

                // Action
                print(result);
            }
        }
    }
}