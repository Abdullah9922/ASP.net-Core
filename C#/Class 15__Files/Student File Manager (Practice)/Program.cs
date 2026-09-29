
using System.Text;

string folderPath = "Data";
DirectoryInfo folder = new DirectoryInfo(folderPath);
if (!folder.Exists)
{
    folder.Create();
    Console.WriteLine("Folder is Created.");
}

string studentFolderPath = Path.Combine(folderPath, "Students");
DirectoryInfo studentFolder = new DirectoryInfo(studentFolderPath);
if (!studentFolder.Exists)
{
    studentFolder.Create();
    Console.WriteLine("Student Folder is Created.");
}

string filePath = Path.Combine(studentFolderPath, "students.txt");
FileInfo file = new FileInfo(filePath);
if (!file.Exists)
{
    file.Create();
    Console.WriteLine("Student file is Created.");
}

using (StreamWriter write = file.CreateText())
{
    write.WriteLine("101,Asif,CSE\r\n102,Rahim,EEE\r\n103,Karim,CSE\r\n104,Sakib,ICE");
}

using (StreamWriter write = file.AppendText())
{
    write.WriteLine("105,jodim,jorina");
}

using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
{
    byte[] data = new byte[fs.Length];
    fs.Read(data, 0, data.Length);
    string text = Encoding.UTF8.GetString(data);
    Console.WriteLine(text);
}

Console.WriteLine("File name        : " + file.Name);
Console.WriteLine("File Extension   : " + file.Extension);
Console.WriteLine("File Lenght      : " + file.Length + "(Byte)");

Console.WriteLine("Folder name      : " + studentFolder.Name);
Console.WriteLine("Folder path      : " + studentFolder.FullName);
FileInfo[] files = studentFolder.GetFiles();

Console.WriteLine("Total files      : " + files.Length);
