// Chapter 12: Switch Statements
// This program demonstrates the use of switch statements in C#.
// It shows how to use switch with integers, strings, and switch expressions.

using System;

namespace Chapter12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Using a switch statement with an integer
            // The switch statement evaluates the value of "day"
            // and matches it to a specific case block.
            Console.WriteLine("Example 1: Day of the week using switch.");
            Console.WriteLine("Enter a number (1-7) for the day of the week:");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                    break;
            }

            // Example 2: Using switch with strings
            // Switch can also be used with strings to match text-based inputs.
            Console.WriteLine("\nExample 2: Switch statement with string values.");
            Console.WriteLine("Enter your role (Admin, User, Guest):");
            string? role = Console.ReadLine();

            switch (role?.ToLower())
            {
                case "admin":
                    Console.WriteLine("Welcome, Administrator! You have full access.");
                    break;

                case "user":
                    Console.WriteLine("Welcome, User! You have limited access.");
                    break;

                case "guest":
                    Console.WriteLine("Welcome, Guest! You have minimal access.");
                    break;

                default:
                    Console.WriteLine("Invalid role. Access denied.");
                    break;
            }

            // Example 3: Using a switch expression
            // Switch expressions provide a concise way to implement switch logic.
            Console.WriteLine("\nExample 3: Using switch expression.");
            Console.WriteLine("Enter a grade (A, B, C, D, or F):");
            string? grade = Console.ReadLine();

            string feedback = grade?.ToUpper() switch
            {
                "A" => "Excellent work!",
                "B" => "Good job!",
                "C" => "Satisfactory.",
                "D" => "Needs improvement.",
                "F" => "Failed. Better luck next time.",
                _ => "Invalid grade entered."
            };

            Console.WriteLine(feedback);

            // Pause for user review
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
