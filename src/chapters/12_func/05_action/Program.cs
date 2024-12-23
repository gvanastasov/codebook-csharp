// Chapter 61: Action
// This program demonstrates the use of the Action delegate in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter61_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Action delegate is a built-in delegate type in C# that represents a method that does not return a value.
            // It can have zero or more input parameters and no output parameter.
            // The syntax of an Action delegate in C# is:
            // Action<in T1, in T2, ...>

            // Example: Action with One Parameter
            // This example demonstrates the use of an Action delegate with one input parameter.
            Console.WriteLine("Example: Action with One Parameter.");

            Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
            greet("Alice");

            // Example: Action with Multiple Parameters
            // This example demonstrates the use of an Action delegate with two input parameters.
            Console.WriteLine("\nExample: Action with Multiple Parameters.");

            Action<int, int> add = (x, y) => Console.WriteLine($"Sum of {x} and {y}: {x + y}");
            add(3, 4);

            // Example: Action with No Parameters
            // This example demonstrates the use of an Action delegate with no input parameters.
            Console.WriteLine("\nExample: Action with No Parameters.");

            Action sayHello = () => Console.WriteLine("Hello, Action!");
            sayHello();

            // Example: Action with Array.ForEach
            // This example demonstrates the use of an Action delegate with Array.ForEach to perform an action on each element of an array.
            Console.WriteLine("\nExample: Action with Array.ForEach.");

            int[] numbers = { 1, 2, 3, 4, 5 };
            Action<int> printNumber = n => Console.WriteLine(n);
            Array.ForEach(numbers, printNumber);

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}