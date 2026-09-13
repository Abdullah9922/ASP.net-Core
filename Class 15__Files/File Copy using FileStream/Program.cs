

using FileStream source = new FileStream(
    "source.txt",
    FileMode.Open,
    FileAccess.Read
);

using FileStream destination = new FileStream(
    "copy.txt",
    FileMode.Create,
    FileAccess.Write
);

byte[] buffer = new byte[4096];

int bytesRead;

while ((bytesRead = source.Read(
    buffer,
    0,
    buffer.Length)) > 0)
{
    destination.Write(
        buffer,
        0,
        bytesRead
    );
}