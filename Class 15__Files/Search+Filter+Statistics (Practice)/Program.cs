

using System.Security.Cryptography.X509Certificates;

string mainFolderPath = "Student";
DirectoryInfo mainFolder = new DirectoryInfo(mainFolderPath);

if (!mainFolder.Exists)
{
    mainFolder.Create();
    Console.WriteLine("Main Student folder Created\n");
}

string filePath = Path.Combine(mainFolderPath, "student.text");
FileInfo file = new FileInfo(filePath);

if (!file.Exists)
{
    file.Create();
    Console.WriteLine("Student File Created\n");
}


using (StreamWriter sw = file.CreateText())
{
    sw.WriteLine("101, Asif, CSE");
    sw.WriteLine("102, Arif, CSE");
    sw.WriteLine("103, Arik, CSE");
    Console.WriteLine("Data write Done\n");
}


using (StreamWriter sw = file.AppendText())
{
    sw.WriteLine("104, Korim, EEE");
    Console.WriteLine("Data Append Done\n");
}


FileInfo[] line = mainFolder.GetFiles();
foreach(FileInfo lineItem in line)
{
    if (lineItem.Name.Substring(0,3) == "102")
    {
        Console.WriteLine("Data Found -> " + lineItem.Name);
    }
}

List<string> filteredValue = new List<string>();

foreach (FileInfo filter in line)
{
    string content = File.ReadAllText(filter.FullName);

    if (content.Contains("CSE"))
    {
        filteredValue.Add(filter.Name);
    }
}

Console.WriteLine("Filtered Value:");

foreach (string filter in filteredValue)
{
    Console.WriteLine(filter);
}


// copy
string backupFolderPath = Path.Combine(mainFolderPath, "Backup");
DirectoryInfo backupFolder = new DirectoryInfo(backupFolderPath);

if (!backupFolder.Exists)
{
    backupFolder.Create();
    Console.WriteLine("Backup Folder Created\n");
}


string copyPath = Path.Combine(backupFolderPath, "Backup_Info.text");
FileInfo backupFile = new FileInfo(copyPath);

if (!backupFile.Exists)
{
    file.CopyTo(backupFile.FullName);
    Console.WriteLine("Backup file Created\n");
}


