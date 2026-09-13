using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Age { get; set; }
    public double CGPA { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 101, Name = "Asif",   Department = "CSE", Age = 22, CGPA = 3.80 },
            new Student { Id = 102, Name = "Rahim",  Department = "CSE", Age = 21, CGPA = 3.50 },
            new Student { Id = 103, Name = "Karim",  Department = "EEE", Age = 23, CGPA = 3.20 },
            new Student { Id = 104, Name = "Sakib",  Department = "CSE", Age = 22, CGPA = 3.90 },
            new Student { Id = 105, Name = "Nabil",  Department = "EEE", Age = 21, CGPA = 3.60 },
            new Student { Id = 106, Name = "Hasan",  Department = "BBA", Age = 24, CGPA = 3.10 },
            new Student { Id = 107, Name = "Rakib",  Department = "CSE", Age = 23, CGPA = 3.70 },
            new Student { Id = 108, Name = "Tanvir", Department = "BBA", Age = 22, CGPA = 3.40 }
        };


        // =========================================================
        // 1. WHERE → Filtering
        // =========================================================

        var cseStudents = students
            .Where(s => s.Department == "CSE");

        Console.WriteLine("CSE Students:");

        foreach (var s in cseStudents)
        {
            Console.WriteLine(s.Name);
        }


        // =========================================================
        // 2. SELECT → Projection
        // =========================================================

        var studentNames = students
            .Select(s => s.Name);

        Console.WriteLine("\nStudent Names:");

        foreach (var name in studentNames)
        {
            Console.WriteLine(name);
        }


        // =========================================================
        // 3. WHERE + SELECT
        // =========================================================

        var cseNames = students
            .Where(s => s.Department == "CSE")
            .Select(s => s.Name);

        Console.WriteLine("\nCSE Names:");

        foreach (var name in cseNames)
        {
            Console.WriteLine(name);
        }


        // =========================================================
        // 4. ORDER BY → Ascending
        // =========================================================

        var ageAscending = students
            .OrderBy(s => s.Age);

        Console.WriteLine("\nAge Ascending:");

        foreach (var s in ageAscending)
        {
            Console.WriteLine($"{s.Name} - {s.Age}");
        }


        // =========================================================
        // 5. ORDER BY DESCENDING
        // =========================================================

        var cgpaDescending = students
            .OrderByDescending(s => s.CGPA);

        Console.WriteLine("\nCGPA Descending:");

        foreach (var s in cgpaDescending)
        {
            Console.WriteLine($"{s.Name} - {s.CGPA}");
        }


        // =========================================================
        // 6. THEN BY
        // =========================================================

        var sortedStudents = students
            .OrderBy(s => s.Department)
            .ThenByDescending(s => s.CGPA);

        Console.WriteLine("\nDepartment + CGPA:");

        foreach (var s in sortedStudents)
        {
            Console.WriteLine($"{s.Department} - {s.Name} - {s.CGPA}");
        }


        // =========================================================
        // 7. FIRST
        // =========================================================

        var firstStudent = students.First();

        Console.WriteLine($"\nFirst Student: {firstStudent.Name}");


        // =========================================================
        // 8. FIRST OR DEFAULT
        // =========================================================

        var student = students
            .FirstOrDefault(s => s.Id == 999);

        if (student != null)
        {
            Console.WriteLine(student.Name);
        }
        else
        {
            Console.WriteLine("\nStudent not found");
        }


        // =========================================================
        // 9. SINGLE OR DEFAULT
        // =========================================================

        var asif = students
            .SingleOrDefault(s => s.Name == "Asif");

        Console.WriteLine($"\nSingle Student: {asif?.Name}");


        // =========================================================
        // 10. ANY → At least one exists?
        // =========================================================

        bool hasCSE = students
            .Any(s => s.Department == "CSE");

        Console.WriteLine($"\nHas CSE Student: {hasCSE}");


        // =========================================================
        // 11. ALL → Everyone satisfies condition?
        // =========================================================

        bool everyoneAbove18 = students
            .All(s => s.Age >= 18);

        Console.WriteLine($"Everyone >= 18: {everyoneAbove18}");


        // =========================================================
        // 12. COUNT
        // =========================================================

        int totalStudents = students.Count();

        Console.WriteLine($"\nTotal Students: {totalStudents}");


        // Count with condition
        int cseCount = students
            .Count(s => s.Department == "CSE");

        Console.WriteLine($"CSE Count: {cseCount}");


        // =========================================================
        // 13. SUM
        // =========================================================

        double totalCGPA = students
            .Sum(s => s.CGPA);

        Console.WriteLine($"\nTotal CGPA: {totalCGPA}");


        // =========================================================
        // 14. AVERAGE
        // =========================================================

        double averageCGPA = students
            .Average(s => s.CGPA);

        Console.WriteLine($"Average CGPA: {averageCGPA:F2}");


        // =========================================================
        // 15. MAX
        // =========================================================

        double maximumCGPA = students
            .Max(s => s.CGPA);

        Console.WriteLine($"\nMaximum CGPA: {maximumCGPA}");


        // =========================================================
        // 16. MIN
        // =========================================================

        double minimumCGPA = students
            .Min(s => s.CGPA);

        Console.WriteLine($"Minimum CGPA: {minimumCGPA}");


        // =========================================================
        // 17. DISTINCT
        // =========================================================

        var departments = students
            .Select(s => s.Department)
            .Distinct();

        Console.WriteLine("\nDepartments:");

        foreach (var department in departments)
        {
            Console.WriteLine(department);
        }


        // =========================================================
        // 18. GROUP BY
        // =========================================================

        var groupedStudents = students
            .GroupBy(s => s.Department);

        Console.WriteLine("\nStudents By Department:");

        foreach (var group in groupedStudents)
        {
            Console.WriteLine($"\nDepartment: {group.Key}");

            foreach (var s in group)
            {
                Console.WriteLine(s.Name);
            }
        }


        // =========================================================
        // 19. GROUP BY + COUNT
        // =========================================================

        var departmentCount = students
            .GroupBy(s => s.Department)
            .Select(g => new
            {
                Department = g.Key,
                Count = g.Count()
            });

        Console.WriteLine("\nDepartment Student Count:");

        foreach (var item in departmentCount)
        {
            Console.WriteLine(
                $"{item.Department} = {item.Count}"
            );
        }


        // =========================================================
        // 20. TAKE
        // =========================================================

        var top3 = students
            .OrderByDescending(s => s.CGPA)
            .Take(3);

        Console.WriteLine("\nTop 3 Students:");

        foreach (var s in top3)
        {
            Console.WriteLine($"{s.Name} - {s.CGPA}");
        }


        // =========================================================
        // 21. SKIP
        // =========================================================

        var afterTop3 = students
            .OrderByDescending(s => s.CGPA)
            .Skip(3);

        Console.WriteLine("\nAfter Top 3:");

        foreach (var s in afterTop3)
        {
            Console.WriteLine(s.Name);
        }


        // =========================================================
        // 22. CONTAINS
        // =========================================================

        string[] allowedDepartments =
        {
            "CSE",
            "EEE"
        };

        var selectedStudents = students
            .Where(s => allowedDepartments.Contains(s.Department));

        Console.WriteLine("\nCSE + EEE Students:");

        foreach (var s in selectedStudents)
        {
            Console.WriteLine($"{s.Name} - {s.Department}");
        }


        // =========================================================
        // 23. RANGE + SELECT
        // =========================================================

        var numbers = Enumerable
            .Range(1, 10)
            .Select(x => x * x);

        Console.WriteLine("\nSquares:");

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }


        // =========================================================
        // 24. WHERE + ORDERBY + SELECT
        // =========================================================

        var highCGPAStudents = students
            .Where(s => s.CGPA >= 3.50)
            .OrderByDescending(s => s.CGPA)
            .Select(s => new
            {
                s.Name,
                s.CGPA
            });

        Console.WriteLine("\nHigh CGPA Students:");

        foreach (var s in highCGPAStudents)
        {
            Console.WriteLine($"{s.Name} - {s.CGPA}");
        }
    }
}