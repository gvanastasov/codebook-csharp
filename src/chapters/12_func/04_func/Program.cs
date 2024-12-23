// Chapter 60: Func
// This program demonstrates the use of the Func delegate in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter60_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Func delegate is a built-in delegate type in C# that represents a method that returns a value.
            // It can have zero or more input parameters and one output parameter.
            // The syntax of a Func delegate in C# is:
            // Func<in T1, in T2, ..., out TResult>

            // Example: Func with One Parameter
            // This example demonstrates the use of a Func delegate with one input parameter and one output parameter.
            Console.WriteLine("Example: Func with One Parameter.");

            Func<int, int> square = x => x * x;
            int result = square(5);
            Console.WriteLine($"Square of 5: {result}");

            // Example: Func with Multiple Parameters
            // This example demonstrates the use of a Func delegate with two input parameters and one output parameter.
            Console.WriteLine("\nExample: Func with Multiple Parameters.");

            Func<int, int, int> add = (x, y) => x + y;
            int sum = add(3, 4);
            Console.WriteLine($"Sum of 3 and 4: {sum}");

            // Example: Func with No Parameters
            // This example demonstrates the use of a Func delegate with no input parameters and one output parameter.
            Console.WriteLine("\nExample: Func with No Parameters.");

            Func<string> greet = () => "Hello, Func!";
            string message = greet();
            Console.WriteLine(message);

            // Example: Func with LINQ
            // This example demonstrates the use of Func delegates with LINQ to filter and project data.
            Console.WriteLine("\nExample: Func with LINQ.");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Func<int, bool> isEven = n => n % 2 == 0;
            var evenNumbers = System.Linq.Enumerable.Where(numbers, isEven);

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