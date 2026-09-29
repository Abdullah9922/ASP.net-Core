
using System.Text;

string path = "data.txt";
using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
{
    string text = "Hello FileStream!\nI am learning C#.";
    byte[] data = Encoding.UTF8.GetBytes(text);
    fs.Write(data, 0, data.Length);
}
Console.WriteLine("Data written successfully.");

using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
{
    string newText = "\nFileStream is interesting.";
    byte[] data = Encoding.UTF8.GetBytes(newText);
    fs.Write(data,0, data.Length);
}
Console.WriteLine("Data append successfully.");


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

using FileStream fs2 = new FileStream(path, FileMode.Open,FileAccess.Read);

Console.WriteLine($"Size: {fs2.Length}");
Console.WriteLine($"Position: {fs2.Position}");
Console.WriteLine($"Can Read: {fs2.CanRead}");
Console.WriteLine($"Can Write: {fs2.CanWrite}");
Console.WriteLine($"Can Seek: {fs2.CanSeek}");