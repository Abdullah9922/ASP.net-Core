
public class Program
{
    public static List<T>Filer<T> (List<T> list, Predicate<T> condition)
    {
        List<T> result = new List<T>();
        T temp;

        foreach (T item in list)
        {
            if (condition(item)) result.Add(item);
        }

        return result;
    }

    public static void Main(string[] args)
    {
        Predicate<int> evenNumber = x => x % 2 == 0;
        Predicate<int> geater = x => x > 20;
        Predicate<int> divisible = x => x % 5 == 0;

        Predicate<double> geater2 = x => x > 20.5;

        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        List<double> numbers2 = new List<double> { 10.5, 20.2, 30.7, 40.1 };

        List<int> result = Filer<int>(numbers, geater);
        foreach (var x in result)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }
}
