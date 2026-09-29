using Generics;

MyStack<int> s = new MyStack<int>(4);
s.Push(1);
s.Push(4);
Console.WriteLine(s.Pop());


MyStack<string> s2 = new MyStack<string>(5);
s2.Push("A");
s2.Push("B");
Console.WriteLine(s2.Pop());


//Repository<Student> students = new Repository<Student>();
//Repository<Product> products = new Repository<Product>();


static void Swap<T>(ref T a, ref T b) // ae khane ref na dile main x and y ar value change hobe na
{
    T temp = a;
    a = b;
    b = temp;
}

int x = 10;
int y = 20;

Swap(ref x, ref y);

//Take two values and print them.
static void PrintTwo<T>(T a, T b)
{
    Console.WriteLine(a);
    Console.WriteLine(b);
}
PrintTwo(10, 20);
PrintTwo("Hello", "World");

var bubbleSort = new BubbleSort2<double>([50.3, 32.1, 71.2, 32.3, 41.9, 88.7]);
bubbleSort.Sort();
foreach (var item in bubbleSort.Numbers)
    Console.WriteLine(item);


var result2 = BubbleSort<double>.Sort([50.3, 32.1, 71.2, 32.3, 41.9, 88.7]);
foreach (var item in result2)
    Console.WriteLine(item);


/*
 
void Process(int x)
{
    Console.WriteLine(x * x);
}

void Process(string x)
{
    Console.WriteLine(x.ToUpper());
}

Process(5);
Process("hello");

-> ae khane 2ter kaj alada alada ae jonne mathord overload
-> r aki code jodi ber likte hoi suhdu data type alada tokon generics

int → একই কাজ
double → একই কাজ
decimal → একই কাজ
👉 Generics ভালো।


int → square
string → uppercase
Student → অন্য কাজ
👉 Method Overloading / আলাদা method ভালো।
*/

// advance type
ShoppingCart2<Electronic<decimal>, decimal> cart = new ShoppingCart2<Electronic<decimal>, decimal>(new Electronic<decimal>[]
{
    new Electronic<decimal>{ Price = 2000, Name = "Camera" },
    new Electronic<decimal>{ Price = 3000, Name = "Laptop" },
    new Electronic<decimal>{ Price = 4000, Name = "Desktop" }
});

var total = cart.GetTotal();
Console.WriteLine(total);


/*
 new() in generics

class Student
{
    public Student()
    {
    }

    public Student(int id)
    {
    }
}
Test<Student> x = new Test<Student>();

Answer: ✅ Valid।


class Student
{
    public Student(int id)
    {
    }
}

class Test<T> where T : new()
{
}
Test<Student> x = new Test<Student>();

Answer: ❌ Invalid।

কারণ Student-এর parameterless constructor নেই।
 */


/*Calculator<string> c = new Calculator<string>();

Answer: ❌

string INumber<string> implement করে না।*/
