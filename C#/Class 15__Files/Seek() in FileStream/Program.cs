using System.Text;

string path = "data.txt";

using FileStream fs = new FileStream(
    path,
    FileMode.Open,
    FileAccess.Read);

fs.Position = 5;

byte[] buffer = new byte[fs.Length - fs.Position];

fs.Read(buffer, 0, buffer.Length);

string result = Encoding.UTF8.GetString(buffer);

Console.WriteLine(result);



//
fs.Seek(5, SeekOrigin.Begin);

byte[] buffer2 = new byte[fs.Length - fs.Position];

int bytesRead = fs.Read(buffer2, 0, buffer2.Length);

Console.WriteLine(
    Encoding.UTF8.GetString(buffer2, 0, bytesRead)
);