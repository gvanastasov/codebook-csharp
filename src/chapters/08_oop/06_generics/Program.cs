// Chapter 68: Generics
// This program demonstrates the use of generics in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter68_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics allow you to define classes, methods, and data structures with a placeholder for the type of data they store or use.
            // This provides type safety without the need to specify a specific data type.

            // Example: Generic Method
            // This example demonstrates the use of a generic method.
            Console.WriteLine("Example: Generic Method.");

            int a = 5, b = 10;
            Swap(a, b);

            string x = "Hello", y = "World";
            Swap(x, y);

            // Example: Generic Class
            // This example demonstrates the use of a generic class.
            Console.WriteLine("\nExample: Generic Class.");

            GenericContainer<int> intContainer = new GenericContainer<int>(42);
            Console.WriteLine($"GenericContainer<int>: {intContainer.Value}");

            GenericContainer<string> stringContainer = new GenericContainer<string>("Hello, Generics!");
            Console.WriteLine($"GenericContainer<string>: {stringContainer.Value}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Generic method to swap two values
        static void Swap<T>(T a, T b)
        {
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After Swap: a = {a}, b = {b}");
        }
    }

    // Generic class
    public class GenericContainer<T>
    {
        public T Value { get; set; }

        public GenericContainer(T value)
        {
            Value = value;
        }
    }
}