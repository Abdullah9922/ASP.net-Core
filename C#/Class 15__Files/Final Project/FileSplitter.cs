using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    public static class FileSplitter
    {
        public static void Split()
        {
            Console.WriteLine("\n========== Split File ==========\n");
            string? filePath = UserInput.PathInput();

            long splitSizeMB = UserInput.SplitSize();

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
        }
    }
}
