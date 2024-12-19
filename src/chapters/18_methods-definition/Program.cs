// Chapter 18: Methods
// This program demonstrates the definition of methods, parameters, and return types in C# 
// with various examples and detailed explanations.

using System;

namespace Chapter18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Methods are blocks of code that perform a specific task.
            // They help in organizing code into reusable units.
            // The syntax of a method in C# is:
            // returnType MethodName(parameterList)
            // {
            //     // Code to execute
            //     return value; // if returnType is not void
            // }

            // Example 1: Method with no parameters and no return value
            // This method prints a greeting message to the console.
            Console.WriteLine("Example 1: Method with no parameters and no return value.");
            PrintGreeting();

            // Example 2: Method with parameters and no return value
            // This method takes a string parameter and prints a personalized greeting message.
            Console.WriteLine("\nExample 2: Method with parameters and no return value.");
            PrintPersonalizedGreeting("Alice");

            // Example 3: Method with parameters and a return value
            // This method takes two integer parameters, adds them, and returns the result.
            Console.WriteLine("\nExample 3: Method with parameters and a return value.");
            int sum = Add(5, 3);
            Console.WriteLine($"Sum: {sum}");

            // Example 4: Method with multiple parameters and a return value
            // This method takes three double parameters, calculates the average, and returns the result.
            Console.WriteLine("\nExample 4: Method with multiple parameters and a return value.");
            double average = CalculateAverage(4.5, 3.2, 5.8);
            Console.WriteLine($"Average: {average}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method definitions

        // Method with no parameters and no return (void) value
        static void PrintGreeting()
        {
            Console.WriteLine("Hello, World!");
        }

        // Method with parameters and no return value
        static void PrintPersonalizedGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        // Method with parameters and a return value
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Method with multiple parameters and a return value
        static double CalculateAverage(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }
    }
}