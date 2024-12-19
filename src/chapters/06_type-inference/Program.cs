// Chapter 03: Type Inference
// This program demonstrates the use of the `var` keyword in C# for type inference.
// It shows how the compiler infers the type of a variable based on the assigned value.

using System;

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using explicit type declaration
            // Explicitly declaring the variable as an integer.
            int number = 10;

            // Using type inference with var
            // Compiler infers the type as string.
            var message = "Hello, C#!"; 

            // Compiler infers the type as double.
            var price = 19.99;          

            // Compiler infers the type as bool.
            var isAvailable = true;     

            // Displaying the values
            Console.WriteLine("Type Inference with var:");
            Console.WriteLine($"Message: {message} - Type inferred as string.");
            Console.WriteLine($"Price: {price} - Type inferred as double.");
            Console.WriteLine($"Is Available: {isAvailable} - Type inferred as bool.");

            // Demonstrating limitations
            // The type must be determinable at compile-time.
            // The following line would cause a compilation error because null has no type.
            // var undefined = null;

            // When to use var?
            // - Use var when the type is obvious or when working with anonymous types.
            // - Avoid var for complex types if it reduces code clarity.

            // Example: Explicit type for clarity
            // Clear and readable.
            int explicitNumber = 20;

            // Example: var for anonymous types (more on this later)
            var anonymousObject = new { Name = "Alice", Age = 25 };
            Console.WriteLine($"Anonymous Object: Name={anonymousObject.Name}, Age={anonymousObject.Age}");

            // Pause for the user
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
