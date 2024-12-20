// Chapter 07: Bitwise Operators
// This program demonstrates the use of bitwise operators in C#,
// which operate on binary representations of integers.

using System;

namespace Chapter07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare two numbers for demonstration
            int num1 = 5;  // Binary: 0101
            int num2 = 3;  // Binary: 0011

            // Bitwise operations
            // Bitwise AND
            int andResult = num1 & num2;  

            // Bitwise OR
            int orResult = num1 | num2;   

            // Bitwise XOR
            int xorResult = num1 ^ num2;  

            // Bitwise NOT
            int notResult = ~num1;

            // Bitwise shift left
            int leftShift = num1 << 1;

            // Bitwise shift right
            int rightShift = num1 >> 1;

            // Displaying the results
            Console.WriteLine("Bitwise Operators:");
            Console.WriteLine($"Bitwise AND: {num1} & {num2} = {andResult}");
            Console.WriteLine($"Bitwise OR: {num1} | {num2} = {orResult}");
            Console.WriteLine($"Bitwise XOR: {num1} ^ {num2} = {xorResult}");
            Console.WriteLine($"Bitwise NOT: ~{num1} = {notResult}");
            Console.WriteLine($"Left Shift: {num1} << 1 = {leftShift}");
            Console.WriteLine($"Right Shift: {num1} >> 1 = {rightShift}");

            // Pause for the user
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
