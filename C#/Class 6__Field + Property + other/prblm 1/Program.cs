public class Mainn
{
    public static void Main(string[] args)
    {
        Student s = new Student();
        s.Name = "Test";
        s.Age = 30;

        Console.WriteLine("Name: " + s.Name);
        Console.WriteLine("Age: " + s.Age);
    }
}