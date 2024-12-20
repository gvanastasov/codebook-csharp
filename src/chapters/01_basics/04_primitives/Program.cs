// Chapter 02.1: Primitive Data Types
// This program demonstrates the basic data types available in C#.
// These include integers, floating-point numbers, booleans, characters, and strings.

using System;

namespace Chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer type (int)
            // Used to store whole numbers, such as 1, 42, or -99.
            int age = 25;

            // Floating-point type (double)
            // Used to store numbers with decimals, such as 3.14 or -0.001.
            double temperature = 36.6;

            // Boolean type (bool)
            // Represents a value that is either true or false.
            bool isCSharpFun = true;

            // Character type (char)
            // Used to store a single character, such as 'A' or '$'.
            char grade = 'A';

            // String type (string)
            // Used to store a sequence of characters, such as "Hello, World!".
            string message = "Hello, C#!";

            // Displaying the values of the variables with explanations.
            Console.WriteLine("Primitive Data Types:");
            Console.WriteLine($"Age (int): {age} - A whole number.");
            Console.WriteLine($"Temperature (double): {temperature} - A number with decimals.");
            Console.WriteLine($"Is C# fun? (bool): {isCSharpFun} - A true/false value.");
            Console.WriteLine($"Grade (char): {grade} - A single character.");
            Console.WriteLine($"Message (string): {message} - A sequence of characters.");

            // Pause for the user
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
