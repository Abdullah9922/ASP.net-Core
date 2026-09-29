
using System.ComponentModel.DataAnnotations;
using Employee_Salary_Calculator;

public class Solution
{
    public static int CalculatSalary(int salary, Func<int, int> calculate)
    {
        return calculate(salary);
    }

    public static int AddBonus(int salary)
    {
        return salary + 5000;
    }

    public static int RemoveTax(int salary)
    {
        return salary - (salary * 10 / 100);
    }


    // Promotion হলে salary 20% বাড়বে
    public static int Promotion(int salary)
    {
        return salary + (salary * 20 / 100);
    }


    // Salary double
    public static int DoubleSalary(int salary)
    {
        return salary * 2;
    }


    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Name = "Asif",  Salary = 50000, Department = "IT" },
            new Employee { Name = "Rahim", Salary = 35000, Department = "HR" },
            new Employee { Name = "Karim", Salary = 70000, Department = "IT" },
            new Employee { Name = "Sakib", Salary = 45000, Department = "Sales" },
            new Employee { Name = "Nabil", Salary = 80000, Department = "IT" }
        };

        Console.WriteLine("===== ORIGINAL SALARY =====");

        foreach (Employee e in employees)
        {
            Console.WriteLine(
                $"{e.Name} -> {e.Salary}"
            );
        }

        Console.WriteLine("\n===== BONUS ADDED =====");
        foreach(Employee e in employees)
        {
            int result = CalculatSalary(e.Salary, AddBonus);
            Console.WriteLine(
                $"{e.Name} -> {result}"
            );
        }
        Console.WriteLine("\n===== AFTER TAX =====");

        foreach (Employee e in employees)
        {
            int result = CalculatSalary(
                e.Salary,
                RemoveTax
            );

            Console.WriteLine(
                $"{e.Name} -> {result}"
            );
        }


        Console.WriteLine("\n===== AFTER PROMOTION =====");

        foreach (Employee e in employees)
        {
            int result = CalculatSalary(
                e.Salary,
                Promotion
            );

            Console.WriteLine(
                $"{e.Name} -> {result}"
            );
        }

        Console.WriteLine("\n===== USING LAMBDA =====");

        foreach (Employee e in employees)
        {
            int result = CalculatSalary(
                e.Salary,
                x => x + 10000
            );

            Console.WriteLine(
                $"{e.Name} -> {result}"
            );
        }
    }
}
