using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    public static class ConsoleMenu
    {
        public static void ConsoleMainMenu()
        {
            Console.WriteLine("\n\n=== File Manager ===");
            Console.WriteLine("1. Organize by Extension");
            Console.WriteLine("2. Search Text");
            Console.WriteLine("3. Split File");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");
        }
    }
}
