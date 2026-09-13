using System;

// Custom Exception
class AgeException : Exception
{
    public AgeException(string message) : base(message) { }
}

class Program
{
    static void CheckAge(int age)
    {
        if (age < 18)
            throw new AgeException("Age must be 18 or above!");

        Console.WriteLine("You are eligible.");
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter age: ");

            // TryParse
            if (!int.TryParse(Console.ReadLine(), out int age))
                throw new FormatException("Please enter a valid number!");

            CheckAge(age);

            // Another possible exception
            int x = 10 / (age - 18);

            Console.WriteLine($"Result: {x}");
        }
        catch (FormatException ex)       // Multiple catch
        {
            Console.WriteLine($"Format Error: {ex.Message}");
        }
        catch (AgeException ex)           // Custom Exception
        {
            Console.WriteLine($"Age Error: {ex.Message}");
        }
        catch (DivideByZeroException ex) // Another catch
        {
            Console.WriteLine($"Math Error: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("Something went wrong.");

            throw; // Re-throws the same exception
        }
        finally
        {
            Console.WriteLine("Finally block always executes.");
        }
    }
}