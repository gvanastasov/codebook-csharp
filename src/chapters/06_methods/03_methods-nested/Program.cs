// Chapter 20: Nested (Local) Functions
// This program demonstrates the use of nested (local) functions in C# 
// with various examples and detailed explanations.

using System;

namespace Chapter20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nested functions, also known as local functions, are functions defined within other functions.
            // They help in organizing code and improving readability by keeping related logic together.
            // Nested functions can access variables from the enclosing function.

            // Example 1: Basic nested function
            // This example demonstrates a basic nested function that prints a message.
            Console.WriteLine("Example 1: Basic nested function.");
            void PrintMessage()
            {
                Console.WriteLine("Hello from the nested function!");
            }
            PrintMessage();

            // Example 2: Nested function with parameters and return value
            // This example demonstrates a nested function that takes parameters, performs a calculation, and returns a result.
            Console.WriteLine("\nExample 2: Nested function with parameters and return value.");
            int CalculateSum(int a, int b)
            {
                return a + b;
            }
            int sum = CalculateSum(5, 3);
            Console.WriteLine($"Sum: {sum}");

            // Example 3: Nested function accessing outer variables
            // This example demonstrates a nested function that accesses variables from the enclosing function.
            Console.WriteLine("\nExample 3: Nested function accessing outer variables.");
            int outerVariable = 10;
            void MultiplyByOuterVariable(int value)
            {
                Console.WriteLine($"Result: {value * outerVariable}");
            }
            MultiplyByOuterVariable(5);

            // Example 4: Nested function within a loop
            // This example demonstrates a nested function defined within a loop to perform repeated calculations.
            Console.WriteLine("\nExample 4: Nested function within a loop.");
            for (int i = 1; i <= 3; i++)
            {
                int Square(int number)
                {
                    return number * number;
                }
                Console.WriteLine($"Square of {i}: {Square(i)}");
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}