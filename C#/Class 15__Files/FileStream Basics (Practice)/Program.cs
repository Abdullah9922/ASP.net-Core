
using System.Text;

string path = "notes.txt";
using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
{
    string text = "Hello C#\r\nI am learning FileStream.\r\nFileStream is useful.";
    byte[] data = Encoding.UTF8.GetBytes(text);
    fs.Write(data, 0, data.Length);
}

using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
{
    byte[] buffer = new byte[fs.Length];
    fs.Read(buffer, 0, buffer.Length);
    string text = Encoding.UTF8.GetString(buffer);
    Console.WriteLine(text);
}