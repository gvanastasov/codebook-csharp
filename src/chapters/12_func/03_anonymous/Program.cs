// Chapter 59: Anonymous Methods
// This program demonstrates the use of anonymous methods in C# 
// with simple examples and detailed explanations.

using System;
using System.Collections.Generic;

namespace Chapter59_AnonymousMethods
{
    class Program
    {
        // Delegate declaration
        public delegate void Notify(string message);
        public delegate int Add(int x, int y);
        public delegate bool IsEven(int number);

        static void Main(string[] args)
        {
            // Anonymous methods provide a way to define an inline method without having to explicitly declare it.
            // They are useful for short, simple pieces of code that are not reused elsewhere.

            // Example: Basic Anonymous Method
            // This example demonstrates a basic anonymous method that takes a string and prints it.
            Console.WriteLine("Example: Basic Anonymous Method.");

            Notify notify = delegate (string message)
            {
                Console.WriteLine(message);
            };
            notify("Hello, Anonymous Methods!");

            // Example: Anonymous Method with Parameters
            // This example demonstrates an anonymous method that takes two integers and returns their sum.
            Console.WriteLine("\nExample: Anonymous Method with Parameters.");

            Add add = delegate (int x, int y)
            {
                return x + y;
            };
            int sum = add(3, 4);
            Console.WriteLine($"Sum of 3 and 4: {sum}");

            // Example: Anonymous Method with List
            // This example demonstrates the use of an anonymous method with a list.
            Console.WriteLine("\nExample: Anonymous Method with List.");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = numbers.FindAll(delegate (int n)
            {
                return n % 2 == 0;
            });

            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}