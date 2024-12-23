// Chapter 58: Lambdas
// This program demonstrates the use of lambda expressions in C# 
// with simple examples and detailed explanations.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter58_Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lambda expressions are a concise way to represent anonymous methods using a syntax that is similar to mathematical functions.
            // The syntax of a lambda expression in C# is:
            // (parameters) => expression

            // Example: Basic Lambda Expression
            // This example demonstrates a basic lambda expression that takes an integer and returns its square.
            Console.WriteLine("Example: Basic Lambda Expression.");

            var square = (int x) => x * x;
            int result = square(5);
            Console.WriteLine($"Square of 5: {result}");

            // Example: Lambda Expression with Multiple Parameters
            // This example demonstrates a lambda expression that takes two integers and returns their sum.
            Console.WriteLine("\nExample: Lambda Expression with Multiple Parameters.");

            var add = (int x, int y) => x + y;
            int sum = add(3, 4);
            Console.WriteLine($"Sum of 3 and 4: {sum}");

            // Example: Lambda Expression with LINQ
            // This example demonstrates the use of lambda expressions with LINQ to filter and project data.
            Console.WriteLine("\nExample: Lambda Expression with LINQ.");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0).Select(n => n);

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