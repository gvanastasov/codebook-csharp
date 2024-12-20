// Chapter 13: For Loops
// This program demonstrates the use of for loops in C# 
// with various examples and detailed explanations.

using System;

namespace Chapter13
{
    class Program
    {
        static void Main(string[] args)
        {
            // For loops are a fundamental control flow tool in programming.
            // They allow you to execute a block of code multiple times with a controlled iteration.
            // The syntax of a for loop in C# is:
            // for (initialization; condition; iteration)
            // {
            //     // Code to execute in each iteration
            // }

            // Example 1: Basic for loop
            // This loop runs from 0 to 4, incrementing the variable 'i' by 1 in each iteration.
            // It prints the current value of 'i' in each iteration.
            // The loop starts with 'i' initialized to 0.
            // The condition 'i < 5' is checked before each iteration.
            // The iteration statement 'i++' increments 'i' by 1 after each iteration.
            Console.WriteLine("Example 1: Basic for loop.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration: {i}");
            }

            // Example 2: For loop with multiple variables
            // This loop demonstrates the use of multiple variables in the for loop.
            // It initializes 'i' to 0 and 'j' to 10, and in each iteration, 'i' is incremented and 'j' is decremented.
            // The loop runs until 'i' is less than 5.
            // Using multiple variables can be useful for scenarios where you need to track more than one value.
            Console.WriteLine("\nExample 2: For loop with multiple variables.");
            for (int i = 0, j = 10; i < 5; i++, j--)
            {
                Console.WriteLine($"i: {i}, j: {j}");
            }

            // Example 3: For loop with a break statement
            // This loop runs from 0 to 9, but it breaks out of the loop when 'i' equals 5.
            // The break statement terminates the loop prematurely.
            // This can be useful when you need to exit the loop based on a certain condition.
            Console.WriteLine("\nExample 3: For loop with a break statement.");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine($"Iteration: {i}");
            }

            // Example 4: For loop with a continue statement
            // This loop runs from 0 to 9, but it skips the current iteration when 'i' is an even number.
            // The continue statement skips the rest of the loop body and proceeds with the next iteration.
            // This can be useful when you want to skip certain iterations based on a condition.
            Console.WriteLine("\nExample 4: For loop with a continue statement.");
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine($"Iteration: {i}");
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}