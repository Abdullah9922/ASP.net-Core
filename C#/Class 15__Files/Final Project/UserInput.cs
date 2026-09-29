using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    public static class UserInput
    {
        public static string PathInput()
        {
            Console.Write("Enter your path: ");
            string? inputPath = Console.ReadLine();
            if (inputPath.Contains('"'))
            {
                inputPath = inputPath.Replace("\"", "");
            }
            return inputPath;
        }

        public static string? TextInput()
        {
            Console.Write("Enter your text: ");
            string? text = Console.ReadLine();
            return text;
        }

        public static long SplitSize()
        {
            Console.Write("Enter split size (MB): ");
            long splitSizeMB = long.Parse(Console.ReadLine()!);
            return splitSizeMB;
        }
    }
}
