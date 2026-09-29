
using Employee_Salary_System__Practice_2_;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class Program
{
    public static List<Employee> FilterEmployee (List<Employee> list, Predicate<Employee> condition)
    {
        List<Employee> result = new();
        foreach(var e in list)
        {
            if(condition(e)) result.Add(e);
        }
        return result;
    }

    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee(101, "Asif", "CSE", 50000),
            new Employee(102, "Rahim", "IT", 45000),
            new Employee(103, "Karim", "CSE", 60000),
            new Employee(104, "Sakib", "EEE", 40000),
            new Employee(105, "Nabil", "BBA", 55000),
            new Employee(106, "Fahim", "CSE", 48000),
            new Employee(107, "Tanvir", "IT", 65000),
            new Employee(108, "Shakil", "EEE", 42000),
            new Employee(109, "Rafi", "CSE", 70000),
            new Employee(110, "Hasan", "BBA", 52000)
        };

        Predicate<Employee> filter = x => x.Salary > 50000 && x.Department == "CSE";
        List<Employee> sortedEmployee = FilterEmployee(employees, filter);

        Console.WriteLine("Boro lok Employees : ");
        foreach (var x in sortedEmployee)
        {
            x.Print();
        }
        Console.WriteLine();
    }
}

