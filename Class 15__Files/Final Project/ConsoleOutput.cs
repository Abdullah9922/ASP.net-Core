using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    public static class ConsoleOutput
    {
        public static void InvalidPath()
        {
            Console.WriteLine("\nInvalid path!");
            Console.WriteLine("Please enter a valid folder path.");
        }
        public static void FileNotFound()
        {
            Console.WriteLine("\nNo files found.");
        }

        public static void AlreadyExist()
        {
            Console.WriteLine("\nThis folder has already been organized.");
            Console.WriteLine("  'NEW FOLDER' already exists.");
        }

        public static void Result()
        {
            Console.WriteLine("\n--> Result <--");
        }

        public static void WorkDone()
        {
            Console.WriteLine("\n✓ All files organized successfully!");
            Console.WriteLine("✓ Organized files are available in 'NEW ORGANIZED FOLDER'.");
        }
    }
}
