// Chapter 65: Creating and Managing Threads
// This program demonstrates how to create and manage threads in C# 
// with simple examples and detailed explanations.

using System;
using System.Threading;

namespace Chapter65_CreatingAndManagingThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            // Threads allow you to perform multiple operations concurrently.
            // The System.Threading namespace provides classes and methods for creating and managing threads.

            // Example: Creating a Thread
            // This example demonstrates how to create and start a thread.
            Console.WriteLine("Example: Creating a Thread.");

            Thread thread1 = new Thread(PrintMessage);
            thread1.Start("Hello from thread 1!");

            // Example: Creating a Thread with Lambda Expression
            // This example demonstrates how to create and start a thread using a lambda expression.
            Console.WriteLine("\nExample: Creating a Thread with Lambda Expression.");

            Thread thread2 = new Thread(() => PrintMessage("Hello from thread 2!"));
            thread2.Start();

            // Example: Joining Threads
            // This example demonstrates how to wait for a thread to complete using the Join method.
            Console.WriteLine("\nExample: Joining Threads.");

            Thread thread3 = new Thread(() => SimulateWork(2000)); // Simulate 2 seconds of work
            thread3.Start();
            thread3.Join(); // Wait for thread3 to complete
            Console.WriteLine("Thread 3 has completed.");

            // Example: Thread Sleep
            // This example demonstrates how to pause a thread using the Sleep method.
            Console.WriteLine("\nExample: Thread Sleep.");

            Thread thread4 = new Thread(() => 
            {
                Console.WriteLine("Thread 4 is sleeping for 1 second...");
                Thread.Sleep(1000); // Sleep for 1 second
                Console.WriteLine("Thread 4 has woken up.");
            });
            thread4.Start();

            // Example: Thread Priority
            // This example demonstrates how to set the priority of a thread.
            Console.WriteLine("\nExample: Thread Priority.");

            Thread thread5 = new Thread(() => PrintMessage("Hello from thread 5!"));
            thread5.Priority = ThreadPriority.Highest;
            thread5.Start();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method to print a message
        static void PrintMessage(object message)
        {
            Console.WriteLine(message);
        }

        // Method to simulate work by waiting for a specified amount of time
        static void SimulateWork(int milliseconds)
        {
            Console.WriteLine($"Simulating {milliseconds / 1000.0} seconds of work...");
            Thread.Sleep(milliseconds); // Simulate work by sleeping
        }
    }
}