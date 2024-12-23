// Chapter 50: Nullable Reference Types
// This program demonstrates the use of nullable reference types in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter50_NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable reference types were introduced in C# 8.0 to help prevent null reference exceptions.
            // By default, reference types are non-nullable, meaning they cannot be assigned a null value.
            // To make a reference type nullable, you can use the ? annotation.

            // Example: Nullable Reference Types
            // This example demonstrates the use of nullable reference types.
            Console.WriteLine("Example: Nullable Reference Types.");

            string? nullableString = null; // Nullable reference type
            string nonNullableString = "Hello, World!"; // Non-nullable reference type

            if (nullableString == null)
            {
                Console.WriteLine("nullableString is null.");
            }
            else
            {
                Console.WriteLine($"nullableString: {nullableString}");
            }

            Console.WriteLine($"nonNullableString: {nonNullableString}");

            // Example: Null Forgiving Operator
            // This example demonstrates the use of the null forgiving operator (!).
            Console.WriteLine("\nExample: Null Forgiving Operator.");

            nullableString = "Hello, Nullable!";
            Console.WriteLine($"nullableString: {nullableString!}"); // The ! operator tells the compiler that nullableString is not null

            // Example: Nullable Annotations and Warnings
            // This example demonstrates how nullable annotations and warnings work.
            Console.WriteLine("\nExample: Nullable Annotations and Warnings.");

            PrintMessage(nullableString);
            PrintMessage(nonNullableString);

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void PrintMessage(string? message)
        {
            if (message == null)
            {
                Console.WriteLine("Message is null.");
            }
            else
            {
                Console.WriteLine($"Message: {message}");
            }
        }
    }
}