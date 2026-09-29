using System;
using System.IO;

class Program
{
    static void Main()
    {
        // =========================================================
        // 1. DIRECTORYINFO - Folder নিয়ে কাজ
        // =========================================================

        string mainFolderPath = "Data";
        string studentFolderPath = Path.Combine(mainFolderPath, "Students");

        DirectoryInfo mainFolder = new DirectoryInfo(mainFolderPath);
        DirectoryInfo studentFolder = new DirectoryInfo(studentFolderPath);


        // ---------- CREATE DIRECTORY ----------
        if (!mainFolder.Exists)
        {
            mainFolder.Create();
            Console.WriteLine("Data folder created.");
        }

        if (!studentFolder.Exists)
        {
            studentFolder.Create();
            Console.WriteLine("Students folder created.");
        }


        // ---------- DIRECTORY INFORMATION ----------
        Console.WriteLine("\n===== MAIN FOLDER INFO =====");

        Console.WriteLine("Full Path: " + mainFolder.FullName);
        Console.WriteLine("Name: " + mainFolder.Name);
        Console.WriteLine("Parent: " + mainFolder.Parent);
        Console.WriteLine("Exists: " + mainFolder.Exists);
        Console.WriteLine("Creation Time: " + mainFolder.CreationTime);
        Console.WriteLine("Last Access Time: " + mainFolder.LastAccessTime);
        Console.WriteLine("Last Write Time: " + mainFolder.LastWriteTime);


        // ---------- CREATE FILE INSIDE FOLDER ----------
        string filePath = Path.Combine(studentFolderPath, "students.txt");

        FileInfo file = new FileInfo(filePath);


        // =========================================================
        // 2. FILEINFO - File নিয়ে কাজ
        // =========================================================

        // ---------- CREATE FILE ----------
        if (!file.Exists)
        {
            using (FileStream fs = file.Create())
            {
                // Empty file created
            }

            Console.WriteLine("\nstudents.txt created.");
        }


        // ---------- WRITE TO FILE ----------
        File.WriteAllLines(file.FullName, new string[]
        {
            "101,Asif,CSE",
            "102,Rahim,CSE",
            "103,Karim,EEE"
        });

        Console.WriteLine("Data written successfully.");


        // ---------- APPEND DATA ----------
        File.AppendAllText(
            file.FullName,
            "104,Sakib,CSE" + Environment.NewLine
        );

        Console.WriteLine("New student added.");


        // ---------- READ FILE ----------
        Console.WriteLine("\n===== FILE CONTENT =====");

        string[] lines = File.ReadAllLines(file.FullName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }


        // ---------- FILE INFORMATION ----------
        Console.WriteLine("\n===== FILE INFO =====");

        Console.WriteLine("Name: " + file.Name);
        Console.WriteLine("Full Path: " + file.FullName);
        Console.WriteLine("Directory: " + file.DirectoryName);
        Console.WriteLine("Extension: " + file.Extension);
        Console.WriteLine("Length: " + file.Length + " bytes");
        Console.WriteLine("Exists: " + file.Exists);
        Console.WriteLine("Creation Time: " + file.CreationTime);
        Console.WriteLine("Last Access Time: " + file.LastAccessTime);
        Console.WriteLine("Last Write Time: " + file.LastWriteTime);


        // =========================================================
        // 3. FILEINFO COPY
        // =========================================================

        string copyPath =
            Path.Combine(studentFolderPath, "students_backup.txt");

        FileInfo backupFile = new FileInfo(copyPath);

        if (!backupFile.Exists)
        {
            file.CopyTo(backupFile.FullName);

            Console.WriteLine("\nBackup file created.");
        }


        // =========================================================
        // 4. FILEINFO MOVE
        // =========================================================

        string archiveFolderPath =
            Path.Combine(mainFolderPath, "Archive");

        DirectoryInfo archiveFolder = new DirectoryInfo(archiveFolderPath);

        if (!archiveFolder.Exists)
        {
            archiveFolder.Create();
        }

        string movedFilePath =
            Path.Combine(archiveFolder.FullName, "students_backup.txt");

        if (File.Exists(backupFile.FullName))
        {
            backupFile.MoveTo(movedFilePath);

            Console.WriteLine("Backup file moved to Archive.");
        }


        // =========================================================
        // 5. DIRECTORYINFO - SUBDIRECTORIES
        // =========================================================

        Console.WriteLine("\n===== SUBDIRECTORIES =====");

        DirectoryInfo[] directories =
            mainFolder.GetDirectories();

        foreach (DirectoryInfo dir in directories)
        {
            Console.WriteLine(dir.Name);
        }


        // =========================================================
        // 6. DIRECTORYINFO - FILES
        // =========================================================

        Console.WriteLine("\n===== FILES INSIDE DATA =====");

        FileInfo[] files =
            mainFolder.GetFiles("*", SearchOption.AllDirectories);

        foreach (FileInfo f in files)
        {
            Console.WriteLine(f.FullName);
        }


        // =========================================================
        // 7. DIRECTORYINFO MOVE
        // =========================================================

        // Example:
        // DirectoryInfo oldFolder = new DirectoryInfo("Data/Students");
        // oldFolder.MoveTo("Data/OldStudents");


        // =========================================================
        // 8. DELETE FILE
        // =========================================================

        // FileInfo tempFile = new FileInfo("Data/Students/temp.txt");

        // if (tempFile.Exists)
        // {
        //     tempFile.Delete();
        // }


        // =========================================================
        // 9. DELETE DIRECTORY
        // =========================================================

        // DirectoryInfo oldFolder = new DirectoryInfo("Data/OldStudents");

        // if (oldFolder.Exists)
        // {
        //     oldFolder.Delete(true);
        // }


        Console.WriteLine("\nProgram finished.");
    }
}