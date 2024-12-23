// Chapter 63: Async and Await
// This program demonstrates the use of async and await in C# 
// with simple examples and detailed explanations.

using System;
using System.Threading.Tasks;

namespace Chapter63_AsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The async and await keywords are used to write asynchronous code in C#.
            // The async keyword is used to declare an asynchronous method, and the await keyword is used to wait for an asynchronous operation to complete.
            // Asynchronous programming allows for non-blocking execution, meaning the program can continue to run other tasks while waiting for the asynchronous operation to complete.

            // Example: Basic Async and Await
            // This example demonstrates a basic use of async and await to perform an asynchronous operation.
            Console.WriteLine("Example: Basic Async and Await.");

            await PrintMessageAsync("Hello, Async and Await!");

            // Example: Simulating Asynchronous Work
            // This example demonstrates the use of async and await to simulate asynchronous work by waiting for a specified amount of time.
            Console.WriteLine("\nExample: Simulating Asynchronous Work.");

            await SimulateWorkAsync(2000); // Simulate 2 seconds of work
            Console.WriteLine("Work simulation completed.");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Asynchronous method to print a message
        static async Task PrintMessageAsync(string message)
        {
            await Task.Delay(1000); // Simulate an asynchronous operation
            Console.WriteLine(message);
        }

        // Asynchronous method to simulate work by waiting for a specified amount of time
        static async Task SimulateWorkAsync(int milliseconds)
        {
            Console.WriteLine($"Simulating {milliseconds / 1000.0} seconds of work...");
            await Task.Delay(milliseconds); // Simulate work by waiting
        }
    }
}