// Chapter 62: Predicate
// This program demonstrates the use of the Predicate delegate in C# 
// with simple examples and detailed explanations.

using System;
using System.Collections.Generic;

namespace Chapter62_Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Predicate delegate is a built-in delegate type in C# that represents a method that takes one input parameter and returns a boolean value.
            // It is commonly used for searching and filtering collections.
            // The syntax of a Predicate delegate in C# is:
            // Predicate<in T>

            // Example: Predicate with List.Find
            // This example demonstrates the use of a Predicate delegate with List.Find to find an element in a list.
            Console.WriteLine("Example: Predicate with List.Find.");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Predicate<int> isEven = n => n % 2 == 0;
            int firstEvenNumber = numbers.Find(isEven);
            Console.WriteLine($"First even number: {firstEvenNumber}");

            // Example: Predicate with List.FindAll
            // This example demonstrates the use of a Predicate delegate with List.FindAll to find all elements in a list that match a condition.
            Console.WriteLine("\nExample: Predicate with List.FindAll.");

            List<int> evenNumbers = numbers.FindAll(isEven);
            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            // Example: Predicate with Array.Exists
            // This example demonstrates the use of a Predicate delegate with Array.Exists to check if an element exists in an array.
            Console.WriteLine("\nExample: Predicate with Array.Exists.");

            int[] numberArray = { 1, 2, 3, 4, 5 };
            bool hasEvenNumber = Array.Exists(numberArray, isEven);
            Console.WriteLine($"Array contains even number: {hasEvenNumber}");

            // Example: Predicate with Array.TrueForAll
            // This example demonstrates the use of a Predicate delegate with Array.TrueForAll to check if all elements in an array match a condition.
            Console.WriteLine("\nExample: Predicate with Array.TrueForAll.");

            bool allEvenNumbers = Array.TrueForAll(numberArray, isEven);
            Console.WriteLine($"All elements in array are even: {allEvenNumbers}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}