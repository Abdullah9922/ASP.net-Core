

using Delegates_Examples__Practice_2_;
using System.Diagnostics;
using System.Xml.Linq;

class Program
{
    // Predicate<Student> দিয়ে condition গ্রহণ করবে
    static List<Student> FilterStudents(List<Student> students, Predicate<Student> condition)
    {
        List<Student> result = new();

        foreach (Student student in students)
        {
            if (condition(student))
            {
                result.Add(student);
            }
        }

        return result;
    }

    public static List<Product> GetPrice(List<Product> products , Func<Product, Product> condition)
    {
        List<Product> result = new();
        Product temp = null;
        foreach(Product product in products)
        {
            temp = condition(product);
            result.Add(temp);
        }

        return result;
    }

    static void Main()
    {
        // 5 Students
        List<Student> students = new()
        {
            new Student(101, "Asif", 3.80, "CSE"),
            new Student(102, "Rahim", 3.60, "EEE"),
            new Student(103, "Karim", 3.75, "CSE"),
            new Student(104, "Sakib", 3.20, "BBA"),
            new Student(105, "Nabil", 2.80, "CSE")
        };


        // 1. CGPA >= 3.50
        Predicate<Student> highCGPA = student => student.CGPA >= 3.50;

        List<Student> result1 = FilterStudents(students, highCGPA);

        Console.WriteLine("Students with CGPA >= 3.50:");

        foreach (Student student in result1)
        {
            student.Print();
        }


        Console.WriteLine();


        // 2. Department == CSE
        Predicate<Student> cseStudent = student => student.Department == "CSE";

        List<Student> result2 = FilterStudents(students, cseStudent);

        Console.WriteLine("Students from CSE:");

        foreach (Student student in result2)
        {
            Console.WriteLine($"{student.Name} - {student.Department}");
        }


        Console.WriteLine();


        // 3. CGPA >= 3.00
        Predicate<Student> cgpaAbove3 = student => student.CGPA >= 3.00;

        List<Student> result3 = FilterStudents(students, cgpaAbove3);

        Console.WriteLine("Students with CGPA >= 3.00:");

        foreach (Student student in result3)
        {
            student.Print();
        }



        // product 
        List<Product> products = new List<Product>()
        {
            new Product(101, "Laptop", 75000, 5),
            new Product(102, "Mouse", 1200, 10),
            new Product(103, "Keyboard", 2500, 3)
        };

        Func<Product, Product> conditionDiscount = x => 
        {
            x.Price *= 0.1;
            return x;
        };

        Func<Product, Product> conditionVat = x =>
        {
            x.Price *= 0.15;
            return x;
        };
        Func<Product, double> finalPrice = x =>
        {
            double sum = 0;
            sum += x.Price;
            return sum;
        };

        List<Product> result = GetPrice(products, conditionDiscount);
        Console.WriteLine("Price with 10% discount : ");
        foreach (Product product in result)
        {
            product.Print();
        }
        result.Clear();

        result = GetPrice(products, conditionDiscount);
        Console.WriteLine("Price with 15% VAT : ");
        foreach (Product product in result)
        {
            product.Print();
        }
         result.Clear();

        result = GetPrice(products, conditionDiscount);
        Console.WriteLine("Final price: " + result[0].Price);


        // action
        Action<Student> print = (student) =>
        {
            Console.WriteLine($"Id         : {student.Id}");
            Console.WriteLine($"Name       : {student.Name}");
            Console.WriteLine($"CGPA       : {student.CGPA}");
            Console.WriteLine($"Department : {student.Department}");
        };
        
    }
}

