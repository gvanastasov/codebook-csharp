// Chapter 16: Throwing Errors
// This program demonstrates how to throw errors (exceptions) in C# 
// with various examples and detailed explanations.

using System;

namespace Chapter16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Throwing errors (exceptions) is a way to signal that something has gone wrong in your program.
            // You can throw an exception using the 'throw' keyword followed by an instance of an exception class.
            // The syntax of throwing an exception in C# is:
            // throw new ExceptionType("Error message");

            // Example 1: Throwing a basic exception
            // This example demonstrates how to throw a basic exception with a custom error message.
            Console.WriteLine("Example 1: Throwing a basic exception.");
            // throw new Exception("This is a basic exception.");

            // Example 2: Throwing a specific exception type
            // This example demonstrates how to throw a specific exception type, such as ArgumentNullException.
            // Specific exception types provide more detailed information about the error.
            Console.WriteLine("\nExample 2: Throwing a specific exception type.");
            string value = null;
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Value cannot be null.");
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}