
string source = "source.txt";
string destination = "backup.txt";

using FileStream input = new FileStream(
    source,
    FileMode.Open,
    FileAccess.Read);

using FileStream output = new FileStream(
    destination,
    FileMode.Create,
    FileAccess.Write);

byte[] buffer = new byte[10];

long totalBytes = input.Length;
long copiedBytes = 0;

int bytesRead;

while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
{
    output.Write(buffer, 0, bytesRead);

    copiedBytes += bytesRead;

    double percentage =
        (double)copiedBytes / totalBytes * 100;

    Console.WriteLine($"Copying...{percentage:F2}%");
}