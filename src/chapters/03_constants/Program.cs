// Chapter 03: Constants
// This program demonstrates how to use constants in C#,
// including declaration, initialization, and basic operations.

using System; // Required for console input/output.

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Constants
            // A constant is a value that cannot change during the program.
            // Constants must be initialized when declared.
            const int DaysInWeek = 7;
            const double Gravity = 9.8;

            // Displaying the values of constants.
            Console.WriteLine("\nConstants:");
            Console.WriteLine($"Days in a week: {DaysInWeek}");
            Console.WriteLine($"Gravity: {Gravity}");

            // 2. Constants cannot be reassigned.
            // Uncommenting the line below would cause a compilation error 
            // because constants cannot be changed.
            // DaysInWeek = 8;

            // Pause to allow the user to read the output.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
