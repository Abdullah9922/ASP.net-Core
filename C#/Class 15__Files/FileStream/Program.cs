using System.Text;

string path = "test.txt";

// Write
using (FileStream fs = new FileStream(
    path,
    FileMode.Create,
    FileAccess.Write))
{
    string text = "Hello FileStream!";

    byte[] data = Encoding.UTF8.GetBytes(text);

    fs.Write(data, 0, data.Length);
}


// Read
using (FileStream fs = new FileStream(
    path,
    FileMode.Open,
    FileAccess.Read))
{
    byte[] buffer = new byte[1024];

    int bytesRead = fs.Read(
        buffer,
        0,
        buffer.Length
    );

    string text = Encoding.UTF8.GetString(
        buffer,
        0,
        bytesRead
    );

    Console.WriteLine(text);
}