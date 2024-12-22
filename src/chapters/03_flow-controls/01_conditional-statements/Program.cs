// Chapter 11: Conditional Statements
// This program demonstrates the use of if, else if, and else statements in C#.
// These statements allow the program to execute different blocks of code
// based on specified conditions.

using System;

namespace Chapter11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Using an if statement
            // The "if" statement checks a condition and executes the associated block of code
            // only if the condition evaluates to true.
            Console.WriteLine("Example 1: Basic if statement.");

            // Temperature in degrees Celsius
            int temperature = 30;

            if (temperature > 25)
            {
                Console.WriteLine("It's a hot day.");
            }

            // Example 2: Adding an else block
            // The "else" statement provides an alternative block of code that is executed
            // if the "if" condition evaluates to false.
            Console.WriteLine("\nExample 2: if-else statement.");

            // Current hour in 24-hour format
            int hour = 18;

            if (hour < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else
            {
                Console.WriteLine("Good afternoon!");
            }

            // Example 3: Using else if for multiple conditions
            // The "else if" statement allows the program to check multiple conditions
            // in sequence, executing the first block where the condition evaluates to true.
            Console.WriteLine("\nExample 3: if-else if-else statement.");
            int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            // Example 4: Combining conditions with logical operators
            // Logical operators such as "&&" (AND), "||" (OR), and "!" (NOT)
            // can be used to combine or modify conditions within if statements.
            Console.WriteLine("\nExample 4: Logical operators in conditions.");
            bool hasID = true;
            int age = 20;

            if (hasID && age >= 18)
            {
                Console.WriteLine("You are allowed to enter.");
            }
            else
            {
                Console.WriteLine("You are not allowed to enter.");
            }

            // Pause for the user to review the output
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
