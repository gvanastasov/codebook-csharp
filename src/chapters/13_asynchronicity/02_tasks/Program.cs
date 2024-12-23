// Chapter 64: Tasks
// This program demonstrates the use of tasks in C# 
// with simple examples and detailed explanations.

using System;
using System.Threading.Tasks;

namespace Chapter64_Tasks
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Tasks are used to represent asynchronous operations in C#.
            // They provide a way to run code asynchronously and handle the result or exception when the operation completes.

            // Example: Basic Task
            // This example demonstrates how to create and run a basic task.
            Console.WriteLine("Example: Basic Task.");

            Task task = Task.Run(() => PrintMessage("Hello, Task!"));
            await task;

            // Example: Task with Result
            // This example demonstrates how to create and run a task that returns a result.
            Console.WriteLine("\nExample: Task with Result.");

            Task<int> taskWithResult = Task.Run(() => CalculateSum(3, 4));
            int result = await taskWithResult;
            Console.WriteLine($"Sum of 3 and 4: {result}");

            // Example: Task with Exception Handling
            // This example demonstrates how to handle exceptions in a task.
            Console.WriteLine("\nExample: Task with Exception Handling.");

            try
            {
                Task taskWithException = Task.Run(() => ThrowException());
                await taskWithException;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            // Example: Task.WhenAll
            // This example demonstrates how to run multiple tasks concurrently and wait for all of them to complete.
            Console.WriteLine("\nExample: Task.WhenAll.");

            Task task1 = Task.Run(() => SimulateWork(1000)); // Simulate 1 second of work
            Task task2 = Task.Run(() => SimulateWork(1500)); // Simulate 1.5 seconds of work
            Task task3 = Task.Run(() => SimulateWork(500));  // Simulate 0.5 seconds of work

            await Task.WhenAll(task1, task2, task3);
            Console.WriteLine("All tasks completed.");

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

        // Method to calculate the sum of two integers
        static int CalculateSum(int x, int y)
        {
            return x + y;
        }

        // Method to throw an exception
        static void ThrowException()
        {
            throw new InvalidOperationException("This is a test exception.");
        }

        // Method to simulate work by waiting for a specified amount of time
        static void SimulateWork(int milliseconds)
        {
            Console.WriteLine($"Simulating {milliseconds / 1000.0} seconds of work...");
            Task.Delay(milliseconds).Wait();
        }
    }
}