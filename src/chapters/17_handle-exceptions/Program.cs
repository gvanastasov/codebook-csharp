// Chapter 17: Handling Exceptions
// This program demonstrates how to handle exceptions in C# 
// with various examples and detailed explanations.

using System;

namespace Chapter17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Handling exceptions allows your program to gracefully recover from errors.
            // You can handle exceptions using try-catch blocks.
            // The syntax of a try-catch block in C# is:
            // try
            // {
            //     // Code that may throw an exception
            // }
            // catch (ExceptionType ex)
            // {
            //     // Code to handle the exception
            // }

            // Example 1: Basic try-catch block
            // This example demonstrates how to handle a basic exception using a try-catch block.
            // The code inside the try block may throw an exception, which is then caught and handled in the catch block.
            Console.WriteLine("Example 1: Basic try-catch block.");
            try
            {
                throw new Exception("This is a basic exception.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught exception: {ex.Message}");
            }

            // Example 2: Handling specific exception types
            // This example demonstrates how to handle specific exception types, such as ArgumentNullException.
            // Specific exception types provide more detailed information about the error and allow for more precise handling.
            Console.WriteLine("\nExample 2: Handling specific exception types.");
            try
            {
                string value = null;
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Value cannot be null.");
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Caught ArgumentNullException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught general exception: {ex.Message}");
            }

            // Example 3: Finally block
            // This example demonstrates the use of a finally block, which always executes regardless of whether an exception is thrown.
            // The finally block is typically used for cleanup code, such as closing files or releasing resources.
            Console.WriteLine("\nExample 3: Finally block.");
            try
            {
                Console.WriteLine("Inside try block.");
                throw new Exception("This is a basic exception.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Inside finally block.");
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}