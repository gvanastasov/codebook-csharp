// Chapter 77: Records
// This program demonstrates the use of records in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter77_Records
{
    class Program
    {
        static void Main(string[] args)
        {
            // Records are a reference type that provides built-in functionality for encapsulating data.
            // They are immutable by default and provide value-based equality.

            // Example: Defining a Record
            // This example demonstrates how to define and use a record.
            Console.WriteLine("Example: Defining a Record.");

            Person person1 = new Person("Alice", 30);
            Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");

            // Example: Value-Based Equality
            // This example demonstrates the value-based equality of records.
            Console.WriteLine("\nExample: Value-Based Equality.");

            Person person2 = new Person("Alice", 30);
            Console.WriteLine($"person1 == person2: {person1 == person2}");
            Console.WriteLine($"person1.Equals(person2): {person1.Equals(person2)}");

            // Example: With-Expression
            // This example demonstrates the use of the with-expression to create a copy of a record with modified properties.
            Console.WriteLine("\nExample: With-Expression.");

            Person person3 = person1 with { Age = 35 };
            Console.WriteLine($"Name: {person3.Name}, Age: {person3.Age}");

            // Example: Positional Records
            // This example demonstrates how to define and use a positional record.
            Console.WriteLine("\nExample: Positional Records.");

            Point point1 = new Point(1, 2);
            Console.WriteLine($"Point: ({point1.X}, {point1.Y})");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Record definition
    public record Person(string Name, int Age);

    // Positional record definition
    public record Point(int X, int Y);
}