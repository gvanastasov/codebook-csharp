// Chapter 05: Comparison Operators
// This program demonstrates the use of comparison operators in C#,
// which are used to compare two values.

using System;

namespace Chapter05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare two numbers for demonstration
            int num1 = 10;
            int num2 = 20;

            // Performing comparisons
            // Equal to
            bool isEqual = num1 == num2;    

            // Not equal to
            bool isNotEqual = num1 != num2; 

            // Greater than
            bool isGreater = num1 > num2;   

            // Less than
            bool isLess = num1 < num2;      

            // Greater than or equal to
            bool isGreaterOrEqual = num1 >= num2; 

            // Less than or equal to
            bool isLessOrEqual = num1 <= num2;    

            // Displaying the results
            Console.WriteLine("Comparison Operators:");
            Console.WriteLine($"{num1} == {num2}: {isEqual}");
            Console.WriteLine($"{num1} != {num2}: {isNotEqual}");
            Console.WriteLine($"{num1} > {num2}: {isGreater}");
            Console.WriteLine($"{num1} < {num2}: {isLess}");
            Console.WriteLine($"{num1} >= {num2}: {isGreaterOrEqual}");
            Console.WriteLine($"{num1} <= {num2}: {isLessOrEqual}");

            // Pause for the user
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
