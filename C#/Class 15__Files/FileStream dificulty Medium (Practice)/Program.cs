
using System.Text;

string path = "students.txt";
using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
{
    byte[] buffer = Encoding.UTF8.GetBytes("101,Asif,CSE\r\n102,Rahim,CSE\r\n103,Karim,EEE");
    fs.Write(buffer, 0, buffer.Length);
}

Console.Write("Enter Id: ");
string id = Console.ReadLine();
Console.Write("Enter Name: ");
string name = Console.ReadLine();
Console.Write("Department: ");
string dep = Console.ReadLine();

using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
{
    string text = "\n" + id + "," + name + "," + dep;
    byte[] data = Encoding.UTF8.GetBytes(text);
    fs.Write(data, 0, data.Length);
}

string copyPath = "backup.txt";
using FileStream source = new FileStream(path, FileMode.Open, FileAccess.Read);
using FileStream destination = new FileStream(copyPath, FileMode.Create, FileAccess.Write);

byte[] data2 = new byte[source.Length];
source.Read(data2, 0, data2.Length);
destination.Write(data2, 0, data2.Length);


using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
{
    int bytesRead;
    byte[] buffer = new byte[10];

    while((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
    {
        Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, bytesRead)); ;
    }

}

Console.Write("Enter string: ");
string search = Console.ReadLine();
using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
{
    int bytesRead;
    byte[] buffer = new byte[fs.Length];
    fs.Read(buffer, 0, buffer.Length);
    string text = Encoding.UTF8.GetString(buffer);

    if (text.Contains(search)) Console.WriteLine("Your text is found.");
    else Console.WriteLine("Not found");
}
