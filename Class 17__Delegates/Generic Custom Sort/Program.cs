using Generic_Custom_Sort;

MyList<Student> students = new MyList<Student>();

students.Add(new Student("Asif", 22, 85));
students.Add(new Student("Rahim", 21, 72));
students.Add(new Student("Karim", 23, 90));
students.Add(new Student("Sakib", 20, 65));
students.Add(new Student("Nabil", 22, 78));


Console.WriteLine("Original List:");
students.Print();


// Sort by Marks - Ascending
students.Sort((a, b) => a.Marks > b.Marks);
Console.WriteLine("\nSorted by Marks:");
students.Print();


// Sort by Name - Ascending
students.Sort((a, b) => string.Compare(a.Name, b.Name) > 0);
Console.WriteLine("\nSorted by Name:");
students.Print();
