// Chapter 02.2: Nullable Types
// This program demonstrates nullable value types in C#.
// Nullable types allow variables of value types to also represent null.

using System;

namespace Chapter05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable integer (int?)
            // A nullable type is declared by adding a '?' to the type.
            // This allows the variable to hold either a value or null.
            int? nullableInt = null;

            // Nullable double (double?)
            // This type can hold either a decimal number or null.
            double? nullableDouble = 3.14159;

            // Null coalescing operator (??)
            // Provides a fallback value if a nullable variable is null.
            int defaultValue = nullableInt ?? 0;

            // Displaying nullable values and their state.
            Console.WriteLine("Nullable Types:");
            Console.WriteLine($"Nullable int: {nullableInt} - Can be null or a number.");
            Console.WriteLine($"Nullable double: {nullableDouble} - Can be null or a decimal.");
            Console.WriteLine($"Default value (if null): {defaultValue} - Provides a value when null.");

            // Checking for null values using the HasValue property
            // HasValue is true if the variable contains a value, otherwise false.
            if (nullableInt.HasValue)
            {
                Console.WriteLine($"Nullable int has a value: {nullableInt.Value}");
            }
            else
            {
                Console.WriteLine("Nullable int is null.");
            }

            // Pause for the user
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
