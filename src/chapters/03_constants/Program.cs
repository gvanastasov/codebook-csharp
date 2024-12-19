// Chapter 03: Constants
// This program demonstrates how to declare and use constants in C#.
// Constants are immutable, meaning their value cannot be changed after declaration.

using System; // Required for console input/output.

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring constants
            // Constants are defined using the 'const' keyword.
            // Their value must be assigned during declaration and cannot change.
            const double Pi = 3.14159; // The value of Pi
            const int DaysInWeek = 7; // Number of days in a week

            // Uncommenting the line below would cause a compilation error
            // because constants cannot be reassigned.
            // Pi = 3.14;

            // Displaying constants with descriptions.
            Console.WriteLine("Constants:");
            Console.WriteLine($"Pi: {Pi} - A mathematical constant.");
            Console.WriteLine($"Days in a week: {DaysInWeek} - A fixed number representing days in a week.");

            // Why use constants?
            // - They prevent accidental modification of critical values.
            // - They make the code easier to read and maintain.

            // Pause for the user
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
