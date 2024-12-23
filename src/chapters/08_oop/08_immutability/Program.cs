// Chapter 76: Immutability
// This program demonstrates the concept of immutability in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter76_Immutability
{
    class Program
    {
        static void Main(string[] args)
        {
            // Immutability means that an object's state cannot be modified after it is created.
            // Immutable objects are inherently thread-safe and can simplify reasoning about code.

            // Example: Immutable Class
            // This example demonstrates how to create an immutable class.
            Console.WriteLine("Example: Immutable Class.");

            ImmutablePerson person = new ImmutablePerson("Alice", 30);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            // Example: Immutable Struct
            // This example demonstrates how to create an immutable struct.
            Console.WriteLine("\nExample: Immutable Struct.");

            ImmutablePoint point = new ImmutablePoint(1, 2);
            Console.WriteLine($"Point: ({point.X}, {point.Y})");

            // Example: Using ReadOnlyCollection
            // This example demonstrates how to use ReadOnlyCollection to create an immutable collection.
            Console.WriteLine("\nExample: Using ReadOnlyCollection.");

            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var readOnlyNumbers = Array.AsReadOnly(numbers);
            Console.WriteLine("ReadOnlyCollection:");
            foreach (var number in readOnlyNumbers)
            {
                Console.WriteLine(number);
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Immutable class definition
    public class ImmutablePerson
    {
        public string Name { get; }
        public int Age { get; }

        public ImmutablePerson(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // Immutable struct definition
    public struct ImmutablePoint
    {
        public int X { get; }
        public int Y { get; }

        public ImmutablePoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}