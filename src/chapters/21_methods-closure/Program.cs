// Chapter 21: Closures
// This program demonstrates the use of closures in C# 
// with various examples and detailed explanations.

using System;

namespace Chapter21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Closures are a feature where a nested function captures and remembers the variables from its containing scope.
            // This allows the nested function to access and modify those variables even after the containing function has finished execution.

            // Example 1: Basic closure
            // This example demonstrates a basic closure where the nested function captures a variable from the outer function.
            Console.WriteLine("Example 1: Basic closure.");
            Func<int> CreateCounter()
            {
                int count = 0;
                return () =>
                {
                    count++;
                    return count;
                };
            }
            var counter = CreateCounter();
            Console.WriteLine(counter()); // Output: 1
            Console.WriteLine(counter()); // Output: 2

            // Example 2: Closure with multiple captured variables
            // This example demonstrates a closure that captures multiple variables from the outer function.
            Console.WriteLine("\nExample 2: Closure with multiple captured variables.");
            Func<int, int> CreateMultiplier(int factor)
            {
                return (x) => x * factor;
            }
            var multiplier = CreateMultiplier(3);
            Console.WriteLine(multiplier(5)); // Output: 15
            Console.WriteLine(multiplier(10)); // Output: 30

            // Example 3: Closure modifying captured variables
            // This example demonstrates a closure that modifies the captured variables from the outer function.
            Console.WriteLine("\nExample 3: Closure modifying captured variables.");
            Action<int> CreateAccumulator()
            {
                int sum = 0;
                return (int value) =>
                {
                    sum += value;
                    Console.WriteLine($"Accumulated sum: {sum}");
                };
            }
            var accumulator = CreateAccumulator();
            accumulator(5); // Output: Accumulated sum: 5
            accumulator(10); // Output: Accumulated sum: 15

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}