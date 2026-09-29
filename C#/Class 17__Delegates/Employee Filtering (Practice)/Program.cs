

using Employee_Filtering__Practice_;

List<Employee> employees = new List<Employee>
{
   new Employee { Name = "Asif",  Salary = 50000, Department = "IT" },
   new Employee { Name = "Rahim", Salary = 35000, Department = "HR" },
   new Employee { Name = "Karim", Salary = 70000, Department = "IT" },
   new Employee { Name = "Sakib", Salary = 45000, Department = "Sales" },
   new Employee { Name = "Nabil", Salary = 80000, Department = "IT" }
};


Predicate<Employee> Salary = x => x.Salary > 50000;
Predicate<Employee> Department = x => x.Department == "IT";
Predicate<Employee> Both = x => x.Department == "IT" && x.Salary > 50000;
Action<Employee> print = x => Console.WriteLine($"{x.Name} | {x.Salary} | {x.Department}");


foreach( Employee emp in employees)
{
    if(Both(emp)) print(emp);
}



