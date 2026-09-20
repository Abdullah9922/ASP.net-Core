
using Generic_Sorting__Practice_2_;

public class Program
{
    public static void Sort<T> (List<T> arr, Func<T,T,bool> condition)
    {
        for (int i = 0; i < arr.Count - 1; i++)
        {
            for (int j = 0; j < arr.Count - 1 - i; j++)
            {
                if (condition(arr[j], arr[j + 1]))
                {
                    T temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        Func<int, int, bool> ascending = (a,b) => a > b;

        List<int> numbers = new List<int>
        {
            5, 2, 8, 1, 9, 3
        };

        Console.WriteLine("Original Integer List:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();


        // Ascending
        Sort(numbers, (a, b) => a > b);

        Console.WriteLine("\nAscending:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();


        // =====================================
        // 2. STUDENT SORT
        // =====================================

        List<Student> students = new List<Student>
        {
            new Student(101, "Asif", 3.50),
            new Student(102, "Rahim", 3.90),
            new Student(103, "Karim", 3.20),
            new Student(104, "Sakib", 3.75)
        };


        Console.WriteLine("\n\nOriginal Student List:");

        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }


        // CGPA Ascending
        Sort(students, (a, b) => a.CGPA > b.CGPA);

        Console.WriteLine("\nCGPA Ascending:");

        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }


        // CGPA Descending
        Func<Student,Student,bool> studentSortByCGPA = (n,m) => n.CGPA< m.CGPA;
        Sort(students, studentSortByCGPA);

        Console.WriteLine("\nCGPA Descending:");

        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}
