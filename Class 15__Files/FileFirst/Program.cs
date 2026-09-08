using System;
using System.IO;

class Program
{
    static void Main()
    {
        string folder = "Data";
        string filePath = Path.Combine(folder, "students.txt");

        // Create folder
        Directory.CreateDirectory(folder);

        // Write
        File.WriteAllLines(filePath, new[]
        {
            "101,Asif,CSE",
            "102,Rahim,CSE",
            "103,Karim,EEE"
        });

        // Read
        foreach (string line in File.ReadLines(filePath))
        {
            Console.WriteLine(line);
        }

        // FileInfo
        FileInfo file = new FileInfo(filePath);

        Console.WriteLine($"Size: {file.Length} bytes");
        Console.WriteLine($"Name: {file.Name}");
        Console.WriteLine($"Extension: {file.Extension}");
    }
}