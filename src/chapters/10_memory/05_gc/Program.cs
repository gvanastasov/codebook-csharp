// Chapter 51: Garbage Collection
// This program demonstrates the basics of garbage collection in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter51_GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Garbage collection is an automatic memory management feature in C# that reclaims memory occupied by objects that are no longer in use.
            // The garbage collector (GC) runs periodically to free up memory and prevent memory leaks.

            // Example: Garbage Collection Basics
            // This example demonstrates the basics of garbage collection.
            Console.WriteLine("Example: Garbage Collection Basics.");

            CreateObjects();

            // Forcing garbage collection (not recommended in production code)
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Garbage collection has been forced.");

            // Example: Finalizers
            // This example demonstrates the use of finalizers to perform cleanup before an object is reclaimed by the garbage collector.
            Console.WriteLine("\nExample: Finalizers.");

            CreatePersonWithFinalizer();

            // Forcing garbage collection to demonstrate finalizer call
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void CreateObjects()
        {
            for (int i = 0; i < 1000; i++)
            {
                var obj = new object();
            }
        }

        static void CreatePersonWithFinalizer()
        {
            Person person = new Person("Alice");
        }
    }

    // Class with a finalizer
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        // Finalizer
        ~Person()
        {
            Console.WriteLine($"Finalizer called for {Name}");
        }
    }
}