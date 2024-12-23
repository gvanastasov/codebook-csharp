// Chapter 42: Lists
// This program demonstrates the use of lists in C# 
// with simple examples and detailed explanations.

using System;
using System.Collections.Generic;

namespace Chapter42_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists are a part of the System.Collections.Generic namespace and provide a way to store a collection of objects.
            // Unlike arrays, lists can dynamically resize and provide various methods for manipulating the collection.
            // The syntax of a list in C# is:
            // List<type> listName = new List<type>();

            // Example: List Initialization and Access
            // This example demonstrates the creation, initialization, and access of a list.
            Console.WriteLine("Example: List Initialization and Access.");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Element at index {i}: {numbers[i]}");
            }

            // Example: List Methods
            // This example demonstrates some common list methods.
            Console.WriteLine("\nExample: List Methods.");
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            // Add
            names.Add("David");
            Console.WriteLine("After Add:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Remove
            names.Remove("Bob");
            Console.WriteLine("\nAfter Remove:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Insert
            names.Insert(1, "Eve");
            Console.WriteLine("\nAfter Insert:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Contains
            bool containsAlice = names.Contains("Alice");
            Console.WriteLine($"\nContains 'Alice': {containsAlice}");

            // IndexOf
            int indexOfCharlie = names.IndexOf("Charlie");
            Console.WriteLine($"Index of 'Charlie': {indexOfCharlie}");

            // Sort
            names.Sort();
            Console.WriteLine("\nAfter Sort:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}