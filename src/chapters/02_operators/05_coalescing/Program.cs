// Chapter 69: Null Coalescing
// This program demonstrates the use of nullable types and the null coalescing operator in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter69_NullableTypesAndNullCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable types allow you to assign null to value types.
            // The null coalescing operator (??) provides a default value when a nullable type is null.

            // Example: Nullable Types
            // This example demonstrates the use of nullable types.
            Console.WriteLine("Example: Nullable Types.");

            int? nullableInt = null;
            if (nullableInt.HasValue)
            {
                Console.WriteLine($"Nullable int has value: {nullableInt.Value}");
            }
            else
            {
                Console.WriteLine("Nullable int is null.");
            }

            nullableInt = 42;
            if (nullableInt.HasValue)
            {
                Console.WriteLine($"Nullable int has value: {nullableInt.Value}");
            }
            else
            {
                Console.WriteLine("Nullable int is null.");
            }

            // Example: Null Coalescing Operator
            // This example demonstrates the use of the null coalescing operator.
            Console.WriteLine("\nExample: Null Coalescing Operator.");

            int? nullableNumber = null;
            int nonNullableNumber = nullableNumber ?? -1;
            Console.WriteLine($"Non-nullable number: {nonNullableNumber}");

            nullableNumber = 100;
            nonNullableNumber = nullableNumber ?? -1;
            Console.WriteLine($"Non-nullable number: {nonNullableNumber}");

            // Example: Null Coalescing Assignment Operator
            // This example demonstrates the use of the null coalescing assignment operator.
            Console.WriteLine("\nExample: Null Coalescing Assignment Operator.");

            string? nullableString = null;
            nullableString ??= "Default Value";
            Console.WriteLine($"Nullable string: {nullableString}");

            nullableString = "Hello, World!";
            nullableString ??= "Default Value";
            Console.WriteLine($"Nullable string: {nullableString}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}