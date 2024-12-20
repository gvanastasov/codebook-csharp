// Chapter 06: Logical Operators
// This program demonstrates the use of logical operators in C#,
// which are used to combine or invert conditions.

using System;

namespace Chapter06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare two boolean variables for demonstration
            bool condition1 = true;
            bool condition2 = false;

            // Logical operations

            // Logical AND
            bool andResult = condition1 && condition2;
            
            // Logical OR 
            bool orResult = condition1 || condition2; 

            // Logical NOT
            bool notResult = !condition1;              

            // Displaying the results
            Console.WriteLine("Logical Operators:");
            Console.WriteLine($"Condition1 AND Condition2: {andResult}");
            Console.WriteLine($"Condition1 OR Condition2: {orResult}");
            Console.WriteLine($"NOT Condition1: {notResult}");

            // Pause for the user
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
