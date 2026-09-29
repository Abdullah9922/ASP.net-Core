

using Basic_Reflection_1__Practice_;
using System.Reflection;

string path = @"D:\Dev Skill\ASP.net-Core\Class 19__Indexers + Extension Methord + Reflection + Expression\Basic Reflection 1 (Practice)\bin\Debug\net10.0\Basic Reflection 1 (Practice).dll";
Assembly assembly = Assembly.LoadFile(path);
Type? type = assembly.GetType("Basic_Reflection_1__Practice_.Student");


PropertyInfo[] properties = type.GetProperties();
foreach (PropertyInfo property in properties)
{
    Console.WriteLine(property.Name);
    Console.WriteLine(property.PropertyType);
}

MemberInfo[] members = type.GetMembers(BindingFlags.Static|BindingFlags.NonPublic|BindingFlags.Instance);
foreach (MemberInfo member in members)
{
    Console.WriteLine(member.Name);
}

Object? obj = Activator.CreateInstance(type);

foreach (PropertyInfo property in properties)
{
    if (property.Name == "Name")
    {
        property.SetValue(obj, "Asifa");
        Console.WriteLine("--------> " +property.GetValue(obj, null));
    }
}

MethodInfo? method = type.GetMethod("Introduce");

method?.Invoke(obj, null);
