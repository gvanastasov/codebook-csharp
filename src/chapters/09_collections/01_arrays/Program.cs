// Chapter 40: Arrays
// This program demonstrates the use of one-dimensional and multi-dimensional arrays in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter40_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays are used to store multiple values of the same type in a single variable.
            // The syntax of a one-dimensional array in C# is:
            // type[] arrayName = new type[size];

            // Example: One-Dimensional Array
            // This example demonstrates the creation, initialization, and access of a one-dimensional array.
            Console.WriteLine("Example: One-Dimensional Array.");
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {numbers[i]}");
            }

            // The syntax of a multi-dimensional array in C# is:
            // type[,] arrayName = new type[rows, columns];

            // Example: Multi-Dimensional Array
            // This example demonstrates the creation, initialization, and access of a multi-dimensional array.
            Console.WriteLine("\nExample: Multi-Dimensional Array.");
            int[,] matrix = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"Element at index [{i},{j}]: {matrix[i, j]}");
                }
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}