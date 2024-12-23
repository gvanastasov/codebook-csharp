// Chapter 73: Dynamic Types
// This program demonstrates the use of dynamic types and late binding in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter73_DynamicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dynamic types allow you to bypass compile-time type checking and resolve types at runtime.
            // The dynamic keyword is used to declare a dynamic type, which can be useful for scenarios like COM interop, dynamic languages, and reflection.

            // Example: Using Dynamic Types
            // This example demonstrates how to use dynamic types to store different types of values.
            Console.WriteLine("Example: Using Dynamic Types.");

            dynamic dynamicVariable = 10;
            Console.WriteLine($"Dynamic variable (int): {dynamicVariable}");

            dynamicVariable = "Hello, World!";
            Console.WriteLine($"Dynamic variable (string): {dynamicVariable}");

            dynamicVariable = DateTime.Now;
            Console.WriteLine($"Dynamic variable (DateTime): {dynamicVariable}");

            // Example: Late Binding
            // This example demonstrates how to use dynamic types for late binding.
            Console.WriteLine("\nExample: Late Binding.");

            dynamic person = new Person("Alice", 30);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            person.PrintInfo();

            // Example: Dynamic with Reflection
            // This example demonstrates how to use dynamic types with reflection.
            Console.WriteLine("\nExample: Dynamic with Reflection.");

            dynamic assembly = AppDomain.CurrentDomain.Load("mscorlib");
            dynamic type = assembly.GetType("System.String");
            dynamic method = type.GetMethod("Concat", new Type[] { typeof(string), typeof(string) });
            dynamic result = method.Invoke(null, new object[] { "Hello, ", "Reflection!" });
            Console.WriteLine($"Reflection result: {result}");

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