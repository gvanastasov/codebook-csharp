// Chapter 66: Thread Safety
// This program demonstrates thread safety in C# 
// with simple examples and detailed explanations.

using System;
using System.Threading;

namespace Chapter66_ThreadSafety
{
    class Program
    {
        private static int counter = 0;
        private static readonly object lockObject = new object();

        static void Main(string[] args)
        {
            // Thread safety ensures that shared data is accessed by only one thread at a time to prevent data corruption.
            // The System.Threading namespace provides classes and methods for ensuring thread safety, such as lock, Monitor, and Mutex.

            // Example: Thread Safety with Lock
            // This example demonstrates how to use the lock statement to ensure thread safety.
            Console.WriteLine("Example: Thread Safety with Lock.");

            Thread thread1 = new Thread(IncrementCounter);
            Thread thread2 = new Thread(IncrementCounter);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine($"Counter value after locking: {counter}");

            // Example: Thread Safety with Monitor
            // This example demonstrates how to use the Monitor class to ensure thread safety.
            Console.WriteLine("\nExample: Thread Safety with Monitor.");

            counter = 0; // Reset counter

            Thread thread3 = new Thread(IncrementCounterWithMonitor);
            Thread thread4 = new Thread(IncrementCounterWithMonitor);

            thread3.Start();
            thread4.Start();

            thread3.Join();
            thread4.Join();

            Console.WriteLine($"Counter value after using Monitor: {counter}");

            // Example: Thread Safety with Interlocked
            // This example demonstrates how to use the Interlocked class to ensure thread safety.
            Console.WriteLine("\nExample: Thread Safety with Interlocked.");

            counter = 0; // Reset counter

            Thread thread5 = new Thread(IncrementCounterWithInterlocked);
            Thread thread6 = new Thread(IncrementCounterWithInterlocked);

            thread5.Start();
            thread6.Start();

            thread5.Join();
            thread6.Join();

            Console.WriteLine($"Counter value after using Interlocked: {counter}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method to increment the counter with lock
        static void IncrementCounter()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (lockObject)
                {
                    counter++;
                }
            }
        }

        // Method to increment the counter with Monitor
        static void IncrementCounterWithMonitor()
        {
            for (int i = 0; i < 1000; i++)
            {
                Monitor.Enter(lockObject);
                try
                {
                    counter++;
                }
                finally
                {
                    Monitor.Exit(lockObject);
                }
            }
        }

        // Method to increment the counter with Interlocked
        static void IncrementCounterWithInterlocked()
        {
            for (int i = 0; i < 1000; i++)
            {
                Interlocked.Increment(ref counter);
            }
        }
    }
}