using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    public static class FileSearcher
    {
        public static void Search()
        {
            Console.WriteLine("\n========== Search File ==========\n");

            string? inputPath2 = UserInput.PathInput();
            string? text = UserInput.TextInput();

            if (Path.Exists(inputPath2) && text != null)
            {
                FileInfo[] allFiles2 = new DirectoryInfo(inputPath2).GetFiles("*", SearchOption.AllDirectories);
                FileInfo[] textFile = new FileInfo[allFiles2.Length];
                int index = 0;

                if (allFiles2.Length > 0)
                {
                    foreach (var file in allFiles2)
                    {
                        string extensionn = file.Extension;
                        if (extensionn == ".txt")
                        {
                            string[] allText = File.ReadAllLines(file.FullName);
                            foreach (var x in allText)
                            {
                                if (x.Contains(text))
                                {
                                    textFile[index++] = file;
                                    break;
                                }
                            }
                        }
                    }

                    if (index > 0)
                    {
                        ConsoleOutput.Result();
                        for (int i = 0; i < index; i++)
                        {
                            Console.WriteLine($"\n{textFile[i].Name}");
                        }

                    }
                    else ConsoleOutput.FileNotFound();
                }

                else ConsoleOutput.FileNotFound();
            }
            else ConsoleOutput.InvalidPath();
        }
    }
}
