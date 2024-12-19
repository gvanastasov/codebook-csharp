// Chapter 04: Arithmetic Operators
// This program demonstrates the use of arithmetic operators in C#,
// including addition, subtraction, multiplication, division, and modulus.

using System;

namespace Chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare two numbers for demonstration
            int num1 = 10;
            int num2 = 3;

            // Performing arithmetic operations
            // Addition
            int sum = num1 + num2;     

            // Subtraction    
            int difference = num1 - num2;  

            // Multiplication
            int product = num1 * num2;     

            // Division (cast to double for precision, more on this later)
            double quotient = (double)num1 / num2; 

            // Modulus (remainder)
            int remainder = num1 % num2;   

            // Displaying the results
            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");
            Console.WriteLine($"Division: {num1} / {num2} = {quotient}");
            Console.WriteLine($"Modulus: {num1} % {num2} = {remainder}");

            // Pause for the user
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}