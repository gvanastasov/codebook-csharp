// Chapter 22: Extension Methods
// This program demonstrates the use of extension methods in C# 
// with various examples and detailed explanations.

using System;

namespace Chapter22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Extension methods allow you to add new methods to existing types without modifying their source code.
            // They are defined as static methods in static classes, with the first parameter specifying the type they extend.
            // The 'this' keyword is used before the first parameter to indicate that it is an extension method - more on this later.

            // Example 1: Basic extension method
            // This example demonstrates a basic extension method that extends the string type.
            Console.WriteLine("Example 1: Basic extension method.");
            string message = "Hello, World!";
            int wordCount = message.WordCount();
            Console.WriteLine($"Word count: {wordCount}");

            // Example 2: Extension method with parameters
            // This example demonstrates an extension method that takes parameters and extends the int type.
            Console.WriteLine("\nExample 2: Extension method with parameters.");
            int number = 5;
            int result = number.MultiplyBy(3);
            Console.WriteLine($"Result: {result}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Static class containing extension methods (more on this later)
    public static class Extensions
    {
        // Extension method for the string type
        public static int WordCount(this string str)
        {
            return str.Split(new[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        // Extension method for the int type
        public static int MultiplyBy(this int number, int factor)
        {
            return number * factor;
        }
    }
}