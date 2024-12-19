// Chapter 19: Method Overloading
// This program demonstrates method overloading in C# 
// with various examples and detailed explanations.

using System;

namespace Chapter19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method overloading allows you to define multiple methods with the same name but different parameters.
            // The compiler determines which method to call based on the number and types of arguments passed.
            // This helps in improving code readability and reusability.

            // Example 1: Overloaded methods with different parameter counts
            // These methods have the same name 'Print' but different parameter counts.
            Console.WriteLine("Example 1: Overloaded methods with different parameter counts.");
            Print();
            Print("Hello, World!");

            // Example 2: Overloaded methods with different parameter types
            // These methods have the same name 'Add' but different parameter types.
            Console.WriteLine("\nExample 2: Overloaded methods with different parameter types.");
            int sumInt = Add(5, 3);
            double sumDouble = Add(4.5, 3.2);
            Console.WriteLine($"Sum (int): {sumInt}");
            Console.WriteLine($"Sum (double): {sumDouble}");

            // Example 3: Overloaded methods with different parameter orders
            // These methods have the same name 'Display' but different parameter orders.
            Console.WriteLine("\nExample 3: Overloaded methods with different parameter orders.");
            Display("Alice", 30);
            Display(25, "Bob");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method definitions

        // Overloaded method with no parameters
        static void Print()
        {
            Console.WriteLine("Print method with no parameters.");
        }

        // Overloaded method with one parameter
        static void Print(string message)
        {
            Console.WriteLine($"Print method with one parameter: {message}");
        }

        // Overloaded method with int parameters
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded method with double parameters
        static double Add(double a, double b)
        {
            return a + b;
        }

        // Overloaded method with string and int parameters
        static void Display(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // Overloaded method with int and string parameters
        static void Display(int age, string name)
        {
            Console.WriteLine($"Age: {age}, Name: {name}");
        }
    }
}