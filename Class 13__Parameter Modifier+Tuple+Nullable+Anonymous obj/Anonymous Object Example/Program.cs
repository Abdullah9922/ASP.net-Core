using System;
using System.Linq;

class Program
{
    static void Main()
    {
        /*
         

        ### Anonymous Object / Anonymous Type

            **Definition:**
            An anonymous type allows us to create an object without explicitly defining a named class/type.

            ### Syntax

            ```csharp
            var student = new
            {
                Id = 101,
                Name = "Asif",
                CGPA = 3.75
            };
            ```

            ### Important Points

            * Created using `new { }`.
            * Usually declared using `var`.
            * Compiler generates the type automatically.
            * We cannot explicitly name the anonymous type.
            * Properties are public and read-only.
            * Properties cannot be modified after creation.
            * Methods, events and custom operators cannot be added.
            * Commonly used with LINQ.
            * Can contain nested anonymous objects.
            * Cannot directly be used as a method return type or parameter type.
            * Anonymous types are reference types.
            * `Equals()` compares property values for compatible anonymous types.
            * `ToString()`, `Equals()` and `GetHashCode()` are compiler-generated.
            * Anonymous Type ≠ Anonymous Method.
            * Tuple is another option for temporary grouped data.

            ### Most Common LINQ Example

            ```csharp
            var result = students.Select(s => new
            {
                s.Name,
                s.CGPA
            });
            ```

            ### Remember

            `new { }` → Anonymous Type

            `new Student { }` → Named Class Object

            `(101, "Asif")` → Tuple

            `delegate { }` / `x => ...` → Anonymous Function/Lambda




         
         */



        // ============================================================
        // 1. BASIC ANONYMOUS OBJECT
        // ============================================================
        // কোনো class-এর নাম না দিয়েই object তৈরি করা যায়।
        // Syntax: new { Property1 = value, Property2 = value }

        var student = new
        {
            Id = 101,
            Name = "Asif",
            CGPA = 3.75
        };

        Console.WriteLine(student.Id);
        Console.WriteLine(student.Name);
        Console.WriteLine(student.CGPA);


        // ============================================================
        // 2. var এখানে কেন?
        // ============================================================
        // Anonymous type-এর কোনো নাম আমরা জানি না।
        // তাই সাধারণত var ব্যবহার করি।
        //
        // var dynamic নয়।
        // Compiler compile-time-এ actual type বুঝে ফেলে।

        var product = new
        {
            Id = 1,
            Name = "Laptop",
            Price = 80000
        };

        Console.WriteLine(product.Name);


        // ============================================================
        // 3. DIFFERENT DATA TYPES
        // ============================================================
        // Compiler value দেখে property-এর type determine করে।

        var person = new
        {
            Id = 101,             // int
            Name = "Asif",        // string
            CGPA = 3.75,          // double
            Passed = true         // bool
        };

        Console.WriteLine(person.Id);
        Console.WriteLine(person.Name);
        Console.WriteLine(person.CGPA);
        Console.WriteLine(person.Passed);


        // ============================================================
        // 4. VARIABLE NAME AUTOMATICALLY PROPERTY NAME
        // ============================================================

        string name = "Asif";
        int age = 22;

        var p = new
        {
            name,
            age
        };

        // উপরেরটা basically এমন:
        //
        // var p = new
        // {
        //     name = name,
        //     age = age
        // };

        Console.WriteLine(p.name);
        Console.WriteLine(p.age);


        // ============================================================
        // 5. PROPERTY RENAME করা
        // ============================================================
        // নতুন property-এর নাম নিজের মতো দিতে পারি।

        var student2 = new
        {
            StudentId = 101,
            StudentName = "Asif",
            Result = 3.80
        };

        Console.WriteLine(student2.StudentName);
        Console.WriteLine(student2.Result);


        // ============================================================
        // 6. ANONYMOUS OBJECT-এর PROPERTY CHANGE করা যায় না
        // ============================================================

        var student3 = new
        {
            Id = 101,
            Name = "Asif"
        };

        Console.WriteLine(student3.Name);

        // নিচেরটা করলে ERROR হবে:
        //
        // student3.Name = "Rahim";
        //
        // কারণ Anonymous Type-এর properties read-only।


        // ============================================================
        // 7. NESTED ANONYMOUS OBJECT
        // ============================================================
        // একটি anonymous object-এর ভিতরে আরেকটি anonymous object
        // রাখা যায়।

        var student4 = new
        {
            Id = 101,
            Name = "Asif",

            Address = new
            {
                City = "Dhaka",
                Country = "Bangladesh"
            }
        };

        Console.WriteLine(student4.Name);

        // Nested object access
        Console.WriteLine(student4.Address.City);
        Console.WriteLine(student4.Address.Country);


        // ============================================================
        // 8. ARRAY OF ANONYMOUS OBJECTS
        // ============================================================
        // একই structure-এর একাধিক anonymous object array-তে রাখা যায়।

        var students = new[]
        {
            new { Id = 101, Name = "Asif", CGPA = 3.80 },
            new { Id = 102, Name = "Rahim", CGPA = 3.50 },
            new { Id = 103, Name = "Karim", CGPA = 3.90 }
        };

        foreach (var s in students)
        {
            Console.WriteLine(
                $"{s.Id} {s.Name} {s.CGPA}"
            );
        }


        // ============================================================
        // 9. ANONYMOUS OBJECT + LINQ Select()
        // ============================================================
        // Anonymous Type-এর সবচেয়ে important ব্যবহারগুলোর একটি।
        //
        // Original object-এর সব property না নিয়ে
        // শুধু প্রয়োজনীয় property নিয়ে নতুন object বানানো যায়।

        var selectedStudents = students.Select(s => new
        {
            s.Name,
            s.CGPA
        });

        foreach (var s in selectedStudents)
        {
            Console.WriteLine($"{s.Name} - {s.CGPA}");
        }


        // ============================================================
        // 10. LINQ-এ PROPERTY RENAME
        // ============================================================

        var result = students.Select(s => new
        {
            StudentName = s.Name,
            Grade = s.CGPA
        });

        foreach (var s in result)
        {
            Console.WriteLine($"{s.StudentName} - {s.Grade}");
        }


        // ============================================================
        // 11. LINQ + CALCULATED PROPERTY
        // ============================================================
        // Anonymous object-এর property-এর value expression থেকেও
        // তৈরি করা যায়।

        var products = new[]
        {
            new { Name = "Laptop", Price = 80000, Quantity = 2 },
            new { Name = "Mouse", Price = 1000, Quantity = 5 },
            new { Name = "Keyboard", Price = 2000, Quantity = 3 }
        };

        var productInfo = products.Select(p => new
        {
            p.Name,
            p.Price,
            p.Quantity,

            // নতুন calculated property
            TotalPrice = p.Price * p.Quantity
        });

        foreach (var p2 in productInfo)
        {
            Console.WriteLine(
                $"{p2.Name} = {p2.TotalPrice}"
            );
        }


        // ============================================================
        // 12. ANONYMOUS OBJECT + WHERE + SELECT
        // ============================================================
        // আগে filter, তারপর নতুন anonymous object।

        var expensiveProducts = products
            .Where(p => p.Price > 1500)
            .Select(p => new
            {
                p.Name,
                p.Price
            });

        foreach (var p3 in expensiveProducts)
        {
            Console.WriteLine($"{p3.Name} - {p3.Price}");
        }


        // ============================================================
        // 13. ANONYMOUS OBJECT + ToString()
        // ============================================================
        // Anonymous Type-এর ToString() ব্যবহার করা যায়।

        var student5 = new
        {
            Id = 101,
            Name = "Asif",
            CGPA = 3.75
        };

        Console.WriteLine(student5.ToString());


        // ============================================================
        // 14. EQUALITY
        // ============================================================
        // একই structure এবং একই values-এর anonymous objects
        // Equals() করলে True পাওয়া যেতে পারে।

        var a = new
        {
            Name = "Asif",
            Age = 22
        };

        var b = new
        {
            Name = "Asif",
            Age = 22
        };

        Console.WriteLine(a.Equals(b));   // True


        // Value change করলে:

        var c = new
        {
            Name = "Rahim",
            Age = 22
        };

        Console.WriteLine(a.Equals(c));   // False


        // ============================================================
        // 15. ANONYMOUS TYPE-এর SHAPE
        // ============================================================
        // Property Name + Type + Order-এর combination গুরুত্বপূর্ণ।
        //
        // Example:

        var x = new
        {
            Name = "Asif",
            Age = 22
        };

        var y = new
        {
            Name = "Rahim",
            Age = 25
        };

        // x এবং y-এর structure একই:
        //
        // Name : string
        // Age  : int
        //
        // তাই compiler একই anonymous type ব্যবহার করতে পারে।


        // ============================================================
        // 16. DIFFERENT PROPERTY ORDER
        // ============================================================
        // Order আলাদা হলে anonymous type-এর structure আলাদা হতে পারে।

        var obj1 = new
        {
            Name = "Asif",
            Age = 22
        };

        var obj2 = new
        {
            Age = 22,
            Name = "Asif"
        };

        // দেখতে একই data হলেও property order আলাদা।
        // তাই এগুলোকে একই anonymous type ধরে নেওয়া যাবে না।


        // ============================================================
        // 17. ANONYMOUS OBJECT VS NAMED CLASS
        // ============================================================

        // Named Class:
        //
        // Student s = new Student
        // {
        //     Id = 101,
        //     Name = "Asif"
        // };
        //
        // এখানে Student একটি named class।

        // Anonymous Type:
        //
        // var s = new
        // {
        //     Id = 101,
        //     Name = "Asif"
        // };
        //
        // এখানে কোনো class name নেই।


        // ============================================================
        // 18. ANONYMOUS OBJECT VS TUPLE
        // ============================================================

        // Anonymous Type
        var anonymousStudent = new
        {
            Id = 101,
            Name = "Asif"
        };

        // Tuple
        var tupleStudent = (Id: 101, Name: "Asif"); //access by -> tupleStudent2.Name
        var tupleStudent2 = (101, "Asif"); // access by -> tupleStudent2.Item1

        // Anonymous Type:
        // new { Id = 101, Name = "Asif" }
        //
        // Tuple:
        // (Id: 101, Name: "Asif")
        //
        // Tuple হলো value type।
        // Anonymous Type হলো reference type।


        // ============================================================
        // 19. ANONYMOUS OBJECT VS ANONYMOUS METHOD
        // ============================================================

        // Anonymous Object → DATA

        var data = new
        {
            Name = "Asif",
            Age = 22
        };


        // Anonymous Function / Lambda → CODE

        Action<int> print = x =>
        {
            Console.WriteLine(x);
        };

        print(100);

        // মনে রাখবে:
        //
        // new { }       → Anonymous Type/Object
        //
        // x => x * 2    → Lambda / Anonymous Function


        // ============================================================
        // 20. METHOD থেকে Anonymous Type সরাসরি RETURN করা যায় না
        // ============================================================

        // এমন করা যায় না:
        //
        // static ??? GetStudent()
        // {
        //     return new
        //     {
        //         Id = 101,
        //         Name = "Asif"
        //     };
        // }
        //
        // কারণ Anonymous Type-এর কোনো নাম আমরা জানি না।
        //
        // এর পরিবর্তে:
        // 1. Named class
        // 2. Record
        // 3. Tuple
        // ব্যবহার করতে পারি।


        // ============================================================
        // 21. PRACTICAL EXAMPLE
        // ============================================================

        var students2 = new[]
        {
            new { Id = 101, Name = "Asif", Department = "CSE", CGPA = 3.80 },
            new { Id = 102, Name = "Rahim", Department = "EEE", CGPA = 3.40 },
            new { Id = 103, Name = "Karim", Department = "CSE", CGPA = 3.90 },
            new { Id = 104, Name = "Sakib", Department = "CSE", CGPA = 3.60 }
        };

        // CSE students
        // CGPA >= 3.70
        // শুধু Name + CGPA দেখাবো

        var topCSEStudents = students2
            .Where(s => s.Department == "CSE" && s.CGPA >= 3.70)
            .Select(s => new
            {
                s.Name,
                s.CGPA
            });

        foreach (var s in topCSEStudents)
        {
            Console.WriteLine($"{s.Name} - {s.CGPA}");
        }

        //Anonymous Method 
        Action<int> print2 = delegate (int x)
        {
            Console.WriteLine(x);
        };

        Action<int> print3 = x => Console.WriteLine(x);
    }
}