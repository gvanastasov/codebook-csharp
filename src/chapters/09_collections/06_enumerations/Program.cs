// Chapter 45: Enumerations
// This program demonstrates the use of enumerations (enums) in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter45_Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enumerations (enums) are a distinct type that consists of a set of named constants called the enumerator list.
            // Enums are used to create a collection of related constants that can be assigned to a variable.
            // The syntax of an enum in C# is:
            // enum EnumName
            // {
            //     Constant1,
            //     Constant2,
            //     ...
            // }

            // Example: Enum Declaration and Usage
            // This example demonstrates the declaration and usage of an enum.
            Console.WriteLine("Example: Enum Declaration and Usage.");

            DayOfWeek today = DayOfWeek.Wednesday;
            Console.WriteLine($"Today is: {today}");

            // Example: Enum with Switch Statement
            // This example demonstrates the use of an enum with a switch statement.
            Console.WriteLine("\nExample: Enum with Switch Statement.");
            PrintDayMessage(today);

            // Example: Enum Iteration
            // This example demonstrates how to iterate over the values of an enum.
            Console.WriteLine("\nExample: Enum Iteration.");
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine(day);
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void PrintDayMessage(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Start of the work week.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Midweek day.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("End of the work week.");
                    break;
                default:
                    Console.WriteLine("Another day.");
                    break;
            }
        }
    }

    // Enum declaration
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}