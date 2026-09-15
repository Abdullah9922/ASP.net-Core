using System;
using System.Text;

class Program
{
    static void Main()
    {
        // ==========================================
        // 1. Create StringBuilder
        // ==========================================

        StringBuilder sb = new StringBuilder();

        Console.WriteLine("Initial Length: " + sb.Length);

        Console.WriteLine();


        // ==========================================
        // 2. Append()
        // ==========================================

        sb.Append("Hello");

        sb.Append(" ");
        sb.Append("World");

        Console.WriteLine(sb);

        Console.WriteLine();


        // ==========================================
        // 3. AppendLine()
        // ==========================================

        sb.AppendLine();
        sb.AppendLine("C# Programming");
        sb.AppendLine("Learning StringBuilder");

        Console.WriteLine(sb);

        Console.WriteLine();


        // ==========================================
        // 4. Append different data types
        // ==========================================

        StringBuilder info = new StringBuilder();

        string name = "Asif";
        int age = 22;
        double cgpa = 3.75;

        info.Append("Name: ");
        info.Append(name);

        info.Append(", Age: ");
        info.Append(age);

        info.Append(", CGPA: ");
        info.Append(cgpa);

        Console.WriteLine(info);

        Console.WriteLine();


        // ==========================================
        // 5. Append chaining
        // ==========================================

        StringBuilder student = new StringBuilder();

        student
            .Append("Name: ")
            .Append("Asif")
            .Append(", Department: ")
            .Append("CSE")
            .Append(", Semester: ")
            .Append(6);

        Console.WriteLine(student);

        Console.WriteLine();


        // ==========================================
        // 6. Insert()
        // ==========================================

        StringBuilder text =
            new StringBuilder("Hello World");

        text.Insert(6, "Beautiful ");

        Console.WriteLine(text);

        Console.WriteLine();


        // ==========================================
        // 7. Remove()
        // ==========================================

        StringBuilder removeText =
            new StringBuilder("Hello Beautiful World");

        // Remove "Beautiful "
        removeText.Remove(6, 10);

        Console.WriteLine(removeText);

        Console.WriteLine();


        // ==========================================
        // 8. Replace()
        // ==========================================

        StringBuilder replaceText =
            new StringBuilder("I like Java");

        replaceText.Replace("Java", "C#");

        Console.WriteLine(replaceText);

        Console.WriteLine();


        // ==========================================
        // 9. Access character using index
        // ==========================================

        StringBuilder word =
            new StringBuilder("Hello");

        Console.WriteLine(word[0]);
        Console.WriteLine(word[1]);

        // Change character
        word[0] = 'Y';

        Console.WriteLine(word);

        Console.WriteLine();


        // ==========================================
        // 10. Length
        // ==========================================

        StringBuilder lengthTest =
            new StringBuilder("Hello");

        Console.WriteLine(
            "Length: " + lengthTest.Length
        );

        Console.WriteLine();


        // ==========================================
        // 11. Clear()
        // ==========================================

        StringBuilder clearTest =
            new StringBuilder("Some Text");

        Console.WriteLine(clearTest);

        clearTest.Clear();

        Console.WriteLine(
            "After Clear: " + clearTest
        );

        Console.WriteLine();


        // ==========================================
        // 12. Capacity
        // ==========================================

        StringBuilder capacityTest =
            new StringBuilder();

        Console.WriteLine(
            "Initial Capacity: " + capacityTest.Capacity
        );

        capacityTest.Append("Hello");

        Console.WriteLine(
            "Capacity: " + capacityTest.Capacity
        );

        Console.WriteLine();


        // ==========================================
        // 13. ToString()
        // ==========================================

        StringBuilder builder =
            new StringBuilder();

        builder.Append("Hello World");

        string result = builder.ToString();

        Console.WriteLine(result);

        Console.WriteLine();


        // ==========================================
        // 14. Practical Example
        //    Generate a student report
        // ==========================================

        StringBuilder report =
            new StringBuilder();

        report.AppendLine("===== Student Report =====");

        report.AppendLine("Name: Asif");
        report.AppendLine("ID: 101");
        report.AppendLine("Department: CSE");
        report.AppendLine("CGPA: 3.75");

        report.AppendLine("==========================");

        Console.WriteLine(report);
    }
}