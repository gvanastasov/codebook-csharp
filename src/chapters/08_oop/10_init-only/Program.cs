// Chapter 78: Init-Only Properties
// This program demonstrates the use of init-only properties in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter78_InitOnlyProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init-only properties allow you to create immutable objects with properties that can only be set during object initialization.
            // The init accessor is used instead of set to make a property init-only.

            // Example: Init-Only Properties
            // This example demonstrates how to define and use init-only properties.
            Console.WriteLine("Example: Init-Only Properties.");

            Person person = new Person { Name = "Alice", Age = 30 };
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            // The following line would cause a compile-time error because the properties are init-only
            // person.Name = "Bob";

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class definition with init-only properties
    public class Person
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }
}