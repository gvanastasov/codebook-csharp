// Chapter 37: Property Patterns
// This program demonstrates the use of property patterns in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter37_PropertyPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Property patterns are used in pattern matching to match on the properties of an object.
            // They allow you to deconstruct an object and match its properties against specific values or patterns.
            // The syntax of a property pattern in C# is:
            // if (obj is { Property1: pattern1, Property2: pattern2, ... })
            // {
            //     // Code to execute if the pattern matches
            // }

            // Example: Property Patterns
            // This example demonstrates the use of property patterns to match on the properties of a 'Person' object.
            Console.WriteLine("Example: Property Patterns.");

            Person person = new Person("Alice", 30);
            PrintPersonInfo(person);

            person = new Person("Bob", 25);
            PrintPersonInfo(person);

            // Example: Relational Patterns
            // This example demonstrates the use of relational patterns.
            Console.WriteLine("Example: Relational Patterns.");

            int number = 42;
            string result = number switch
            {
                < 0 => "Negative",
                0 => "Zero",
                > 0 and < 10 => "Single digit",
                >= 10 and < 100 => "Double digits",
                _ => "Large number"
            };
            Console.WriteLine($"Number {number} is a {result}.");

            // Example: Logical Patterns (and, or, not)
            // This example demonstrates the use of logical patterns.
            Console.WriteLine("\nExample: Logical Patterns (and, or, not).");

            object obj = "Hello, World!";
            string description = obj switch
            {
                string s and not null => $"String of length {s.Length}",
                int i and >= 0 => $"Non-negative integer {i}",
                int i and < 0 => $"Negative integer {i}",
                null => "Null object",
                _ => "Unknown type"
            };
            Console.WriteLine($"Object description: {description}");

            // Example: Combining Patterns
            // This example demonstrates how to combine patterns using logical operators.
            Console.WriteLine("\nExample: Combining Patterns.");

            int age = 25;
            string ageGroup = age switch
            {
                < 13 => "Child",
                >= 13 and < 20 => "Teenager",
                >= 20 and < 65 => "Adult",
                >= 65 => "Senior"
            };
            Console.WriteLine($"Age {age} is in the {ageGroup} group.");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void PrintPersonInfo(Person person)
        {
            if (person is { Name: "Alice", Age: 30 })
            {
                Console.WriteLine("Matched Alice, Age 30");
            }
            else if (person is { Name: "Bob", Age: 25 })
            {
                Console.WriteLine("Matched Bob, Age 25");
            }
            else
            {
                Console.WriteLine("No match found");
            }
        }
    }

    // Class definition
    public class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}