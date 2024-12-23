// Chapter 41: Strings
// This program demonstrates the use of strings in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter41_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings are a special type of array that store sequences of characters.
            // In C#, strings are immutable, meaning their values cannot be changed after they are created.
            // The syntax of a string in C# is:
            // string variableName = "value";

            // Example: String Initialization and Access
            // This example demonstrates the creation, initialization, and access of a string.
            Console.WriteLine("Example: String Initialization and Access.");
            string message = "Hello, World!";
            Console.WriteLine($"Message: {message}");

            // Accessing individual characters in a string
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine($"Character at index {i}: {message[i]}");
            }

            // Example: String Methods
            // This example demonstrates some common string methods.
            Console.WriteLine("\nExample: String Methods.");
            string greeting = "Hello";
            string name = "Alice";

            // Concatenation
            string concatenated = greeting + ", " + name + "!";
            Console.WriteLine($"Concatenated: {concatenated}");

            // Substring
            string substring = concatenated.Substring(7, 5);
            Console.WriteLine($"Substring: {substring}");

            // Replace
            string replaced = concatenated.Replace("Alice", "Bob");
            Console.WriteLine($"Replaced: {replaced}");

            // ToUpper and ToLower
            string upper = concatenated.ToUpper();
            string lower = concatenated.ToLower();
            Console.WriteLine($"Upper: {upper}");
            Console.WriteLine($"Lower: {lower}");

            // Split
            string[] words = concatenated.Split(' ');
            Console.WriteLine("Split:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}