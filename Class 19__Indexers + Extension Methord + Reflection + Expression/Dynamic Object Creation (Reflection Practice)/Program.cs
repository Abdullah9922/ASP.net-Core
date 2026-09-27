

using Dynamic_Object_Creation__Reflection_Practice_;
using System.Reflection;

string path = @"D:\Dev Skill\ASP.net-Core\Class 19__Indexers + Extension Methord + Reflection + Expression\Dynamic Object Creation (Reflection Practice)\bin\Debug\net10.0\Dynamic Object Creation (Reflection Practice).dll";
Assembly assembly = Assembly.LoadFrom(path);

Type[] types = assembly.GetTypes();

Type? type = null;

foreach (Type t in types)
{
    if (t.Name == "Product")
    {
        type = t;
        break;
    }
}

if (type == null)
{
    Console.WriteLine("Product not found!");
    return;
}

ConstructorInfo[] constructors = type.GetConstructors(
    BindingFlags.Public |
    BindingFlags.NonPublic |
    BindingFlags.Instance
);

foreach (ConstructorInfo constructor in constructors)
{
    Console.WriteLine(constructor);
}


Object? obj = null; // here come the object 
Type? typ = obj.GetType();


PropertyInfo[] properties = typ.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
foreach(PropertyInfo property in properties)
{
    Console.WriteLine(property.Name);
    Console.WriteLine(property.GetValue(obj));
}


MemberInfo[] members = typ.GetMembers(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);
foreach (MemberInfo member in members)
{
    Console.WriteLine(member.Name);
}
