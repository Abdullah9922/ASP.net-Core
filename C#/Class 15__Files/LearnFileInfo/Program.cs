using System;
using System.IO;

public class Test
{
    public static void Main(string[] args)
    {
        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo("Projects");

        if (!dir.Exists)
        {
            dir.Create();
        }

        FileInfo file = new FileInfo(
            Path.Combine(dir.FullName, "data.txt")
        );

        if (!file.Exists)
        {
            file.Create().Close();
        }

        Console.WriteLine(file.FullName);
    }
}