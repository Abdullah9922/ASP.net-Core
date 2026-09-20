

int Addition (int a, int b)
{
    return a + b;
}
int Subtraction(int a, int b)
{
    return a - b;
}


// 3 form of Fucn
Func<int, int, int> add1 = (a, b) => a + b;  // 1

Func<int, int, int> add2 = Addition; // 2
add2 += Subtraction;

Func<int, int, int> add3 = (a, b) =>  // 3
{
    return a + b;
};



// 2 form of Action 
Action<string> printName1 = name => Console.WriteLine(name); // 1
printName1("Asif");


Action sayHello = () => // 2
{
    Console.WriteLine("Hello");
};

sayHello();

Action<string> printName2 = name =>   // 2
{
    Console.WriteLine("Student Name:");
    Console.WriteLine(name);
};
printName2("Asif");




// 2 form of Predicate
Predicate<int> isEven1 = x => x % 2 == 0;  // 1
Console.WriteLine(isEven1(10));


Predicate<int> isEven2 = x =>   // 2
{
    if (x % 2 == 0) return true;
    return false;
};
Console.WriteLine(isEven2(10));