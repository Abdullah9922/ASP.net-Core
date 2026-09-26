using Reflection_Example_1__Typeof_GetType_;

Person person = new Student();

Type t1 = typeof(Person);
Type t2 = person.GetType();

Console.WriteLine(t1.Name);
Console.WriteLine(t2.Name);