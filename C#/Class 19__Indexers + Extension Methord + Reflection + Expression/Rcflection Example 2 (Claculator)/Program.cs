using System.Reflection;
using Rcflection_Example_2__Claculator_;

// if I know the class name
Assembly assembly = Assembly.LoadFrom("Rcflection Example 2 (Claculator).dll"); // file path

Type? type = assembly.GetType("Rcflection_Example_2__Claculator_.Calculator"); // namespace . class

object? calculator = Activator.CreateInstance(type!);

MethodInfo? method = type?.GetMethod("Add");

object? result = method?.Invoke(
    calculator,
    new object[] { 10, 20 }
);

Console.WriteLine(result);

// Class ar name na janle
// DLL-এর সব class/type বের করলাম
Type? type2 = assembly
    .GetTypes()
    .FirstOrDefault(t => t.GetMethod("Add") != null);

// Type পাওয়া গেছে কিনা
if (type2 == null)
{
    Console.WriteLine("Type with Add method not found!");
    return;
}

// Object তৈরি
object? calculator2 = Activator.CreateInstance(type2);

// Add method খুঁজে বের করা
MethodInfo? method2 = type2.GetMethod("Add");

if (method2 == null)
{
    Console.WriteLine("Add method not found!");
    return;
}

// Method execute
object? result2 = method2.Invoke(calculator2,new object[] { 10, 20 });

Console.WriteLine(result2);


// mathord ar perameter na janle
// DLL-এর মধ্যে এমন Type খুঁজছি
// যার মধ্যে Add method আছে
Type? type3 = assembly
    .GetTypes()
    .FirstOrDefault(t => t.GetMethod("Add") != null);

if (type3 == null)
{
    Console.WriteLine("Type with Add method not found!");
    return;
}

// Object তৈরি
object? calculator3 = Activator.CreateInstance(type3);

if (calculator3 == null)
{
    Console.WriteLine("Object creation failed!");
    return;
}

// Add method খুঁজে বের করা
MethodInfo? method3 = type3.GetMethod("Add");

if (method3 == null)
{
    Console.WriteLine("Add method not found!");
    return;
}


// ==================================
// Parameter সম্পর্কে information
// ==================================

ParameterInfo[] parameters = method3.GetParameters();

Console.WriteLine("Method: " + method3.Name);
Console.WriteLine("Parameter Count: " + parameters.Length);

foreach (ParameterInfo parameter in parameters)
{
    Console.WriteLine($"{parameter.Name} : {parameter.ParameterType.Name}");
}


// ==================================
// User-এর কাছ থেকে input নেওয়া
// ==================================

object[] arguments = new object[parameters.Length];

for (int i = 0; i < parameters.Length; i++)
{
    Console.Write($"Enter {parameters[i].Name} ({parameters[i].ParameterType.Name}): ");

    string? input = Console.ReadLine();

    arguments[i] = Convert.ChangeType(input,parameters[i].ParameterType)!;
}


// ==================================
// Method Execute
// ==================================

object? result3 = method3.Invoke(
    calculator3,
    arguments
);

Console.WriteLine("Result = " + result3);