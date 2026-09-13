using Smart_University_Management_System;


Student s = new Student();
s.DisplayInfo();
s.Study();
Console.WriteLine();


Person s2 = new Student();
s2.DisplayInfo();
s2.Study();
Console.WriteLine();


Student s3 = new Student("CSE",3.45,124);
s3.DisplayInfo();
s3.Study();
Console.WriteLine();


Student s4 = new Student("Asif",25,509,"CSE", 3.45, 124);
s4.DisplayInfo();
s4.Study();
Console.WriteLine();


Student s5 = new Student("Asif", "CSE", 3.45, 124);
s5.DisplayInfo();
s5.Study();
Console.WriteLine();
