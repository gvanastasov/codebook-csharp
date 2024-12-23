// Chapter 67: Parallel Programming
// This program demonstrates parallel programming in C# 
// with simple examples and detailed explanations.

using System;
using System.Threading.Tasks;

namespace Chapter67_ParallelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parallel programming allows you to execute multiple operations concurrently, taking advantage of multiple processors.
            // The System.Threading.Tasks namespace provides classes and methods for parallel programming, such as Parallel and PLINQ.

            // Example: Parallel.For
            // This example demonstrates how to use Parallel.For to execute a loop in parallel.
            Console.WriteLine("Example: Parallel.For.");

            Parallel.For(0, 10, i =>
            {
                Console.WriteLine($"Parallel.For iteration {i} on thread {Task.CurrentId}");
            });

            // Example: Parallel.ForEach
            // This example demonstrates how to use Parallel.ForEach to execute a loop in parallel over a collection.
            Console.WriteLine("\nExample: Parallel.ForEach.");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Parallel.ForEach(numbers, number =>
            {
                Console.WriteLine($"Parallel.ForEach number {number} on thread {Task.CurrentId}");
            });

            // Example: Parallel.Invoke
            // This example demonstrates how to use Parallel.Invoke to execute multiple actions in parallel.
            Console.WriteLine("\nExample: Parallel.Invoke.");

            Parallel.Invoke(
                () => PrintMessage("Action 1"),
                () => PrintMessage("Action 2"),
                () => PrintMessage("Action 3")
            );

            // Example: PLINQ
            // This example demonstrates how to use PLINQ (Parallel LINQ) to perform parallel operations on a collection.
            Console.WriteLine("\nExample: PLINQ.");

            var parallelQuery = from number in numbers.AsParallel()
                                where number % 2 == 0
                                select number;

            foreach (var number in parallelQuery)
            {
                Console.WriteLine($"PLINQ even number {number}");
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method to print a message
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}