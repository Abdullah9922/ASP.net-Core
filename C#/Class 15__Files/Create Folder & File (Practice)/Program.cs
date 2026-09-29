

using System.Runtime.Intrinsics.X86;

string mainFolderPath = "Data";
string filePath = Path.Combine(mainFolderPath, "students.txt");

// folder create
DirectoryInfo folder = new DirectoryInfo(mainFolderPath);
if (!folder.Exists)
{
    folder.Create();
    Console.WriteLine("Data Folder Created.");
}

// file create
FileInfo file = new FileInfo(filePath);
if (!file.Exists)
{
    file.Create();
    Console.WriteLine("Studnet File if Created");
}

// write in file
using (StreamWriter write = file.CreateText())
{
    write.WriteLine("101, Asif, CSE");
    write.WriteLine("102, Rahim, CSE");
    write.WriteLine("103, Karim, EEE");
}

// append text
using (StreamWriter write = file.AppendText())
{
    write.WriteLine("104, Arik, ICE");
}


//read text from file
string[] lins = File.ReadAllLines(filePath);
foreach (string line in lins)
{
    Console.WriteLine(line);
}

// file info
Console.WriteLine("Extension: " + file.Extension);
Console.WriteLine("File size: " + file.Length + "bytes");


// copy file
string copyPath = Path.Combine(mainFolderPath, "student_backup.text");
FileInfo backupFile = new FileInfo(copyPath);

if (!backupFile.Exists)
{
    //backupFile.Create();
    file.CopyTo(backupFile.FullName);
    Console.WriteLine("Backup file Created");
}


// move file
string backupFolderPath = Path.Combine(mainFolderPath, "BackupFolder");
DirectoryInfo backupFolder = new DirectoryInfo(backupFolderPath);

if (!backupFolder.Exists)
{
    backupFolder.Create();
    Console.WriteLine("Backup folder Created");
}

string newBackupFile = Path.Combine(backupFolder.FullName, "backupFileStudent.text");
if (backupFolder.Exists)
{
    file.MoveTo(newBackupFile);
    Console.WriteLine("Moved Successfully");
}

