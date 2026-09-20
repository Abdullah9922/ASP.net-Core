

using System.Runtime.Intrinsics.X86;
using System.Text;

string filePath = "student.txt";
FileInfo file = new FileInfo(filePath);

if (!file.Exists)
{
    file.Create();
    Console.WriteLine("File is created.");
}

string[] lines =
{
    "101 Asif CSE",
    "102 Rahim CSE",
    "103 Karim EEE",
    "104 Arik ICE",
    "105 Sakib CSE"
};

File.WriteAllLines(filePath, lines);


string text = "106 Fahim SWE\r\n107 Nayeem CSE";
using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
{
    byte[] buffer = Encoding.UTF8.GetBytes(text);
    fs.Write(buffer, 0, buffer.Length);
}


Console.Write("Input Id : ");
string? id = Console.ReadLine();

string[] allInfo = File.ReadAllLines(filePath);
bool flag = true;
foreach (string info in allInfo)
{
    string[] split = info.Split(' ');

    if (split[0] == id)
    {
        Console.WriteLine("Student Name: " + split[1]);
        flag = false;
        break;
    }
}

if (flag) Console.WriteLine("Not Found");