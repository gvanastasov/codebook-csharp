// Chapter 15: Foreach Loop
// This program demonstrates the use of foreach loops in C# 
// with various examples and detailed explanations.

using System;

namespace Chapter15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Foreach loops are used to iterate over a collection of items, such as arrays or lists.
            // They provide a simple and readable way to access each element in the collection.
            // The syntax of a foreach loop in C# is:
            // foreach (type variable in collection)
            // {
            //     // Code to execute for each element
            // }

            // Example 1: Basic foreach loop with an array
            // This loop iterates over each element in the 'numbers' array and prints its value.
            // Foreach loops automatically handle the iteration and termination conditions.
            Console.WriteLine("Example 1: Basic foreach loop with an array.");
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int number in numbers)
            {
                Console.WriteLine($"Number: {number}");
            }

            // Example 2: Foreach loop with a list
            // This loop iterates over each element in the 'fruits' list and prints its value.
            // Lists are dynamic collections that can grow or shrink in size.
            Console.WriteLine("\nExample 2: Foreach loop with a list.");
            var fruits = new List<string> { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"Fruit: {fruit}");
            }

            // Example 3: Foreach loop with a dictionary
            // This loop iterates over each key-value pair in the 'ages' dictionary and prints its key and value.
            // Dictionaries store data in key-value pairs, providing fast lookups by key.
            Console.WriteLine("\nExample 3: Foreach loop with a dictionary.");
            var ages = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 },
                { "Charlie", 35 }
            };
            foreach (var kvp in ages)
            {
                Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
            }

            // Example 4: Foreach loop with a string
            // This loop iterates over each character in the 'message' string and prints its value.
            // Strings are collections of characters, so they can be iterated using a foreach loop.
            Console.WriteLine("\nExample 4: Foreach loop with a string.");
            string message = "Hello, World!";
            foreach (char ch in message)
            {
                Console.WriteLine($"Character: {ch}");
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}