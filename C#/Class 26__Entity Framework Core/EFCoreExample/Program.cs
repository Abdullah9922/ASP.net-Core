using EFCoreExample;

TrainingDbContext dbContext = new TrainingDbContext();

//Student s1 = new Student()
//{
//    Name = "Asif",
//    Age = 24,
//    Cgpa = 3.56
//};

//dbContext.Students.Add(s1);
//dbContext.SaveChanges();


//dbContext.AddRange(new Student[]
//{
//    new Student () {Name = "Rohomot", Age =  24, Cgpa = 3.89 },
//    new Student () {Name = "Josim", Age =  27, Cgpa = 3.74 }
//});
//dbContext.SaveChanges();


List<Student> students = dbContext.Students.ToList();
Student? s = dbContext.Students.Where(x => x.Name == "Josim").FirstOrDefault();

Console.WriteLine(s.Name + " -> " + s.Age);