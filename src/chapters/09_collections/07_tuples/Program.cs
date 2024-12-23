// Chapter 46: Tuples
// This program demonstrates the use of tuples in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter46_Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tuples are a data structure that can hold multiple values of different types.
            // They are useful for returning multiple values from a method and for grouping related values together.
            // The syntax of a tuple in C# is:
            // (type1, type2, ...) tupleName = (value1, value2, ...);

            // Example: Returning Multiple Values with Tuples
            // This example demonstrates how to return multiple values from a method using a tuple.
            Console.WriteLine("Example: Returning Multiple Values with Tuples.");
            var person = GetPerson();
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            // Example: Tuple Destructuring
            // This example demonstrates how to destructure a tuple into individual variables.
            Console.WriteLine("\nExample: Tuple Destructuring.");
            (string name, int age) = GetPerson();
            Console.WriteLine($"Name: {name}, Age: {age}");

            // Example: Tuple with Named Elements
            // This example demonstrates how to create a tuple with named elements.
            Console.WriteLine("\nExample: Tuple with Named Elements.");
            var namedTuple = (FirstName: "Alice", LastName: "Smith", Age: 30);
            Console.WriteLine($"First Name: {namedTuple.FirstName}, Last Name: {namedTuple.LastName}, Age: {namedTuple.Age}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method returning a tuple
        static (string Name, int Age) GetPerson()
        {
            return ("Alice", 30);
        }
    }
}