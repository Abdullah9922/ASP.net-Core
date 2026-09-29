using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        string path = @"D:\Dev Skill\ASP.net-Core\Combine\Hotel Management System\bin\Debug\net10.0\Hotel Management System.dll";

        // DLL load
        Assembly assembly = Assembly.LoadFrom(path);

        Console.WriteLine(
            $"Assembly: {assembly.FullName}");

        Console.WriteLine(
            $"Location: {assembly.Location}");

        // Get all types
        Type[] types =
            assembly.GetTypes();

        foreach (Type type in types)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine($"TYPE: {type.FullName}");
            Console.WriteLine("================================");

            // -------------------------
            // Basic information
            // -------------------------

            Console.WriteLine(
                $"Class: {type.IsClass}");

            Console.WriteLine(
                $"Interface: {type.IsInterface}");

            Console.WriteLine(
                $"Enum: {type.IsEnum}");

            Console.WriteLine(
                $"Abstract: {type.IsAbstract}");


            // -------------------------
            // Constructors
            // -------------------------

            Console.WriteLine("\nCONSTRUCTORS:");

            foreach (ConstructorInfo constructor
                     in type.GetConstructors(
                         BindingFlags.Public |
                         BindingFlags.NonPublic |
                         BindingFlags.Instance))
            {
                Console.WriteLine(
                    constructor);
            }


            // -------------------------
            // Fields
            // -------------------------

            Console.WriteLine("\nFIELDS:");

            foreach (FieldInfo field
                     in type.GetFields(
                         BindingFlags.Public |
                         BindingFlags.NonPublic |
                         BindingFlags.Instance |
                         BindingFlags.Static |
                         BindingFlags.DeclaredOnly))
            {
                Console.WriteLine(
                    $"{field.Name} : " +
                    $"{field.FieldType}");
            }


            // -------------------------
            // Properties
            // -------------------------

            Console.WriteLine("\nPROPERTIES:");

            foreach (PropertyInfo property
                     in type.GetProperties(
                         BindingFlags.Public |
                         BindingFlags.NonPublic |
                         BindingFlags.Instance |
                         BindingFlags.Static |
                         BindingFlags.DeclaredOnly))
            {
                Console.WriteLine(
                    $"{property.Name} : " +
                    $"{property.PropertyType}");
            }


            // -------------------------
            // Methods
            // -------------------------

            Console.WriteLine("\nMETHODS:");

            foreach (MethodInfo method
                     in type.GetMethods(
                         BindingFlags.Public |
                         BindingFlags.NonPublic |
                         BindingFlags.Instance |
                         BindingFlags.Static |
                         BindingFlags.DeclaredOnly))
            {
                Console.WriteLine(
                    $"{method.Name} -> " +
                    $"{method.ReturnType}");

                foreach (ParameterInfo parameter
                         in method.GetParameters())
                {
                    Console.WriteLine(
                        $"    {parameter.Name} : " +
                        $"{parameter.ParameterType}");
                }
            }


            // -------------------------
            // Attributes
            // -------------------------

            Console.WriteLine("\nATTRIBUTES:");

            foreach (object attribute
                     in type.GetCustomAttributes(false))
            {
                Console.WriteLine(
                    attribute.GetType().Name);
            }
        }
    }
}