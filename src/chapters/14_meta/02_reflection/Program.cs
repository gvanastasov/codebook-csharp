// Chapter 71: Reflection
// This program demonstrates the use of reflection in C# 
// with simple examples and detailed explanations.

using System;
using System.Reflection;

namespace Chapter71_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reflection provides a way to inspect and interact with types and assemblies at runtime.
            // It allows you to obtain information about assemblies, modules, and types, and to dynamically create instances, invoke methods, and access fields and properties.

            // Example: Inspecting a Type
            // This example demonstrates how to use reflection to inspect a type.
            Console.WriteLine("Example: Inspecting a Type.");

            Type personType = typeof(Person);
            Console.WriteLine($"Type: {personType.Name}");

            Console.WriteLine("\nProperties:");
            foreach (PropertyInfo property in personType.GetProperties())
            {
                Console.WriteLine($"{property.Name} ({property.PropertyType.Name})");
            }

            Console.WriteLine("\nMethods:");
            foreach (MethodInfo method in personType.GetMethods())
            {
                Console.WriteLine($"{method.Name} ({method.ReturnType.Name})");
            }

            // Example: Creating an Instance Dynamically
            // This example demonstrates how to use reflection to dynamically create an instance of a type.
            Console.WriteLine("\nExample: Creating an Instance Dynamically.");

            object personInstance = Activator.CreateInstance(personType, "Alice", 30);
            MethodInfo printInfoMethod = personType.GetMethod("PrintInfo");
            printInfoMethod.Invoke(personInstance, null);

            // Example: Accessing Fields and Properties Dynamically
            // This example demonstrates how to use reflection to dynamically access fields and properties.
            Console.WriteLine("\nExample: Accessing Fields and Properties Dynamically.");

            PropertyInfo nameProperty = personType.GetProperty("Name");
            nameProperty.SetValue(personInstance, "Bob");
            printInfoMethod.Invoke(personInstance, null);

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class definition
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}