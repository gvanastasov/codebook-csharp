// Chapter 14: While and Do-While Loops
// This program demonstrates the use of while and do-while loops in C# 
// with various examples and detailed explanations.

using System;

namespace Chapter14
{
    class Program
    {
        static void Main(string[] args)
        {
            // While loops are used to execute a block of code repeatedly as long as a 
            // specified condition is true.
            // The syntax of a while loop in C# is:
            // while (condition)
            // {
            //     // Code to execute in each iteration
            // }

            // Example 1: Basic while loop
            // This loop runs as long as the variable 'i' is less than 5.
            // It prints the current value of 'i' in each iteration and increments 'i' by 1.
            Console.WriteLine("Example 1: Basic while loop.");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine($"Iteration: {i}");
                i++;
            }

            // Example 2: While loop with a break statement
            // This loop runs indefinitely, but it breaks out of the loop when 'i' equals 5.
            // The break statement terminates the loop prematurely.
            // This can be useful when you need to exit the loop based on a certain condition.
            Console.WriteLine("\nExample 2: While loop with a break statement.");
            i = 0;
            while (true)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine($"Iteration: {i}");
                i++;
            }

            // Example 3: While loop with a continue statement
            // This loop runs as long as the variable 'i' is less than 10, but it skips the
            // current iteration when 'i' is an even number. The continue statement skips 
            // the rest of the loop body and proceeds with the next iteration. This can be 
            // useful when you want to skip certain iterations based on a condition.
            Console.WriteLine("\nExample 3: While loop with a continue statement.");
            i = 0;
            while (i < 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine($"Iteration: {i}");
                i++;
            }

            // Do-while loops are similar to while loops, but they execute the block of code 
            // at least once before checking the condition.
            // The syntax of a do-while loop in C# is:
            // do
            // {
            //     // Code to execute in each iteration
            // } while (condition);

            // Example 4: Basic do-while loop
            // This loop runs at least once and continues to run as long as the variable 'i' is less than 5.
            // It prints the current value of 'i' in each iteration and increments 'i' by 1.
            Console.WriteLine("\nExample 4: Basic do-while loop.");
            i = 0;
            do
            {
                Console.WriteLine($"Iteration: {i}");
                i++;
            } while (i < 5);

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}