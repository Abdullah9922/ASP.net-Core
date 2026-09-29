using Student_Mana_Indexer;

Student s1 = new Student(101, "Asif", "CSE", 3.80);
Student s2 = new Student(102, "Rahim", "EEE", 3.50);
Student s3 = new Student(103, "Karim", "CSE", 3.90);

Student[] students = {s1, s2, s3};

Manager manager = new Manager(students);

Console.WriteLine(manager[0].Name);
Console.WriteLine(manager[1].Department);
Console.WriteLine(manager[2].CGPA);