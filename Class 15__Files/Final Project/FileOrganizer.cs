using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    public static class FileOrganizer
    {
        public static void Organize()
        {
            Console.WriteLine("\n========== File Organizer ==========\n");

            string? inputPath = UserInput.PathInput();

            if (Path.Exists(inputPath))
            {
                string[] allFiles = Directory.GetFiles(inputPath, "*", SearchOption.AllDirectories);

                if (allFiles.Length > 0)
                {
                    string newFolderPath = Path.Combine(inputPath, "NEW ORGANIZED FOLDER");

                    if (!Directory.Exists(newFolderPath))
                    {
                        foreach (string file in allFiles)
                        {
                            string extensionn = Path.GetExtension(file).TrimStart('.').ToUpper();

                            // Skip files without an extension
                            if (string.IsNullOrEmpty(extensionn))
                                continue;

                            string folderPathByExtension =
                                Path.Combine(newFolderPath, extensionn);

                            if (!Directory.Exists(folderPathByExtension))
                            {
                                Directory.CreateDirectory(folderPathByExtension);
                            }

                            string newPath = Path.Combine(folderPathByExtension, Path.GetFileName(file));

                            if (!File.Exists(newPath))
                            {
                                File.Move(file, newPath);
                            }
                        }

                        ConsoleOutput.WorkDone();

                        ConsoleOutput.Result();

                        foreach (string folder in Directory.GetDirectories(newFolderPath))
                        {
                            Console.WriteLine($"\n {Path.GetFileName(folder)}");

                            foreach (string file in Directory.GetFiles(folder))
                            {
                                Console.WriteLine($"   └── {Path.GetFileName(file)}");
                            }
                        }

                        Console.WriteLine("\n==================================");
                    }
                    else ConsoleOutput.AlreadyExist();
                }
                else ConsoleOutput.FileNotFound();
            }
            else ConsoleOutput.InvalidPath();
        }
    }
}
