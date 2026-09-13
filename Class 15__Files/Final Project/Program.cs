
using Final_Project;
using System.Diagnostics;


while (true)
{
    ConsoleMenu.ConsoleMainMenu();
    int input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 1:
            Console.WriteLine("\n========== File Organizer ==========\n");
            Console.Write("Enter your path: ");

            string? inputPath = Console.ReadLine();

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

                        Console.WriteLine("\n✓ All files organized successfully!");
                        Console.WriteLine("✓ Organized files are available in 'NEW ORGANIZED FOLDER'.");

                        Console.WriteLine("\n--> Resulting Structure <--");

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
                    else
                    {
                        Console.WriteLine(
                            "\nThis folder has already been organized."
                        );

                        Console.WriteLine(
                            "  'NEW FOLDER' already exists."
                        );
                    }
                }
                else
                {
                    Console.WriteLine("\nNo files found in the specified folder.");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid path!");
                Console.WriteLine("Please enter a valid folder path.");
            }


            break;



        case 2:
            Console.WriteLine("\n========== Search File ==========\n");
            Console.Write("Enter your path: ");
            string? inputPath2 = Console.ReadLine(); // inputPath2 for case 2
            Console.Write("Enter your text: ");
            string? text = Console.ReadLine();

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
                        Console.WriteLine("\n--> Resulting Files <--");

                        for (int i = 0; i < index; i++)
                        {
                            Console.WriteLine($"\n{textFile[i].Name}");
                        }
                        Console.WriteLine("\n");
                    }
                    else Console.WriteLine("\nNo file found that contain your text.\n");
                }

                else Console.WriteLine("\nNo files found in the specified folder.");
            }
            else
            {
                Console.WriteLine("\nInvalid path! or Invalid Text!");
                Console.WriteLine("Please enter a valid folder path and Text.");
            }

            break;

        case 3:
            Console.WriteLine("\n========== Split File ==========\n");
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine()!;

            Console.Write("Enter split size (MB): ");
            long splitSizeMB = long.Parse(Console.ReadLine()!);

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            long splitSize = splitSizeMB * 1024 * 1024;

            string directory = Path.GetDirectoryName(filePath)!;
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string extension = Path.GetExtension(filePath);

            string outputFolder = Path.Combine(directory, "SplitFiles");

            Directory.CreateDirectory(outputFolder);

            using (FileStream inputFile = new FileStream(filePath, FileMode.Open))
            {
                byte[] buffer = new byte[1024 * 1024]; // 1 MB buffer

                int partNumber = 1;
                long bytesWritten = 0;
                int bytesRead;

                FileStream? output = null;

                while ((bytesRead = inputFile.Read(buffer, 0, buffer.Length)) > 0)
                {
                    if (output == null || bytesWritten >= splitSize)
                    {
                        output?.Close();

                        string outputPath = Path.Combine(outputFolder, $"{fileName}_part_{partNumber}{extension}");

                        output = new FileStream(outputPath, FileMode.Create);

                        Console.WriteLine($"Created: {outputPath}");

                        partNumber++;
                        bytesWritten = 0;
                    }

                    long remaining = splitSize - bytesWritten;

                    int bytesToWrite = (int)Math.Min(bytesRead, remaining);

                    output.Write(buffer, 0, bytesToWrite);

                    bytesWritten += bytesToWrite;

                    if (bytesToWrite < bytesRead)
                    {
                        inputFile.Position -= (bytesRead - bytesToWrite);
                    }
                }

                output?.Close();
            }

            Console.WriteLine("File split completed!");

            break;

        case 4:
            Console.WriteLine("\nBye!\n");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("\nInvalid choice!\n");
            break;
    }
}
