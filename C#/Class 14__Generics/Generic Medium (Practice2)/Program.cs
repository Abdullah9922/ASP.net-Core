
using Generic_Medium__Practice2_;

Calculator<int>.Add(22,4);
Calculator<double>.Add(28.245,4.146);
Calculator<int>.Multiply(22,4);


int[] arr = new int[] { 25, 14, 62, 1, 4, 5, 2, 3, 6, 9, 7, 4 };
ArrayHelper<int> help = new ArrayHelper<int>();
Console.WriteLine(help.GetFirst(arr));
Console.WriteLine(help.GetCount(arr, 4));


Repository<int> repository = new Repository<int>();
repository.Add(22);
repository.Add(14);
repository.Add(62);
repository.Add(43);
repository.Remove(43);

List<int> temp = repository.GetAll();
foreach (int i in temp)
{
    Console.Write(i + " ");
}

Repository<Student> studentRepo = new Repository<Student>();
Student s1 = new Student() { Age = 25, Id = 101, Name = "Asif"};
Student s2 = new Student() { Age = 22, Id = 102, Name = "Arif"};
Student s3 = new Student() { Age = 26, Id = 103, Name = "Arik"};

studentRepo.Add(s1);
studentRepo.Add(s2);
studentRepo.Add(s3);

List<Student> temp2 = studentRepo.GetAll();
Console.WriteLine();
foreach (var i in temp2)
{
    Console.WriteLine($"Name: {i.Name} | Id: {i.Id} | Age: {i.Age}");
}

Repository2<Student, int> repo = new();

repo.Add(new Student { Id = 101, Name = "Asif", Age = 22 });
repo.Add(new Student { Id = 102, Name = "Rahim", Age = 21 });

Student? student = repo.GetById(102);

Console.WriteLine(student?.Name);

