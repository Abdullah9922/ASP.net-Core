using Student_Processing__Practice_;


StudentManager<Student> manager = new StudentManager<Student>();

manager.Add(new Student("Asif", 85));
manager.Add(new Student("Rahim", 35));
manager.Add(new Student("Karim", 90));
manager.Add(new Student("Sakib", 45));
manager.Add(new Student("Nabil", 75));

//Pass student
manager.Process(s => s.Marks >= 40, s => Console.WriteLine(s));

Console.WriteLine();
Console.WriteLine();

manager.Process( s => s.Marks >= 80,
            s => Console.WriteLine($"{s.Name} is Excellent!"));