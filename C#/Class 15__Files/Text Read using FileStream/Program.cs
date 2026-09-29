
using System.Text;

string path = "data.txt";
using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Read, FileShare.Read))
{
    byte[] data = new byte[fs.Length];
    fs.Read(data, 0, data.Length);
    string text = Encoding.UTF8.GetString(data);
    Console.WriteLine(text);
}

// read in small chunk
using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
{
    byte[] buffer = new byte[10];
    int bytesRead;

    while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
    {
        string text = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        Console.WriteLine(text);
    }
}