// Chapter 82: Target-Typed new
// This program demonstrates the use of target-typed new in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter82_TargetTypedNew
{
    class Program
    {
        static void Main(string[] args)
        {
            // Target-typed new expressions allow you to omit the type on the right-hand side of an object creation expression when the type can be inferred from the context.
            // This feature simplifies the instantiation of objects and improves code readability.

            // Example: Target-Typed new with Variables
            // This example demonstrates how to use target-typed new with variables.
            Console.WriteLine("Example: Target-Typed new with Variables.");

            Person person = new("Alice", 30);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            // Example: Target-Typed new with Collections
            // This example demonstrates how to use target-typed new with collections.
            Console.WriteLine("\nExample: Target-Typed new with Collections.");

            var people = new List<Person>
            {
                new("Bob", 25),
                new("Charlie", 35)
            };

            foreach (var p in people)
            {
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            }

            // Example: Target-Typed new with Methods
            // This example demonstrates how to use target-typed new with methods.
            Console.WriteLine("\nExample: Target-Typed new with Methods.");

            var personFromMethod = CreatePerson("Dave", 40);
            Console.WriteLine($"Name: {personFromMethod.Name}, Age: {personFromMethod.Age}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method to create a person
        static Person CreatePerson(string name, int age)
        {
            return new(name, age);
        }
    }

    // Class definition
    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}