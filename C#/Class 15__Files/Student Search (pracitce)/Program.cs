
using FileStream fs = new FileStream ("students.txt",FileMode.Open,FileAccess.Read);

using StreamReader reader = new StreamReader (fs);

Console.Write("Input Studen Id: ");
string id = Console.ReadLine()!;

string? line;
bool found = true;

while((line = reader.ReadLine()) != null)
{
    string[] data = line.Split(',');

    if (data[0] == id)
    {
        Console.WriteLine("Student Found:");
        Console.WriteLine(line);

        found = false;
        break;
    }
}

if (found)
{
    Console.WriteLine("Student not found.");
}
