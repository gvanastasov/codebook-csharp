// Chapter 0712: Static Classes
// This program demonstrates the use of static classes in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter0712_StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static classes are classes that cannot be instantiated and can only contain static members.
            // The syntax of a static class in C# is:
            // static class ClassName
            // {
            //     // Static members
            // }

            // Example: Static Classes
            // This example demonstrates a static class 'MathUtilities' with static methods.
            Console.WriteLine("Example: Static Classes.");

            // Using static methods from the static class
            double result = MathUtilities.Add(5, 3);
            Console.WriteLine($"Result of addition: {result}");

            result = MathUtilities.Subtract(10, 4);
            Console.WriteLine($"Result of subtraction: {result}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Static class definition
    public static class MathUtilities
    {
        // Static method
        public static double Add(double a, double b)
        {
            return a + b;
        }

        // Static method
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}