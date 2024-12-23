// Chapter 44: LINQ Basics
// This program demonstrates the basics of LINQ (Language Integrated Query) in C# 
// with simple examples and detailed explanations.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter44_LINQBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ (Language Integrated Query) is a powerful feature in C# that allows querying collections in a concise and readable manner.
            // LINQ can be used with various data sources, including arrays, lists, and databases.
            // The syntax of a LINQ query in C# is:
            // var result = from item in collection
            //              where condition
            //              select item;

            // Example: LINQ with a List
            // This example demonstrates the use of LINQ to query a list of integers.
            Console.WriteLine("Example: LINQ with a List.");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ query to select even numbers
            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;

            Console.WriteLine("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            // Example: LINQ with a Dictionary
            // This example demonstrates the use of LINQ to query a dictionary.
            Console.WriteLine("\nExample: LINQ with a Dictionary.");
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                { 1, "Alice" },
                { 2, "Bob" },
                { 3, "Charlie" },
                { 4, "David" }
            };

            // LINQ query to select students with names starting with 'C'
            var studentsWithC = from student in students
                                where student.Value.StartsWith("C")
                                select student;

            Console.WriteLine("Students with names starting with 'C':");
            foreach (var student in studentsWithC)
            {
                Console.WriteLine($"Key: {student.Key}, Value: {student.Value}");
            }

            // Example: LINQ Method Syntax
            // This example demonstrates the use of LINQ method syntax to query a list of integers.
            Console.WriteLine("\nExample: LINQ Method Syntax.");
            var oddNumbers = numbers.Where(n => n % 2 != 0);

            Console.WriteLine("Odd Numbers:");
            foreach (var number in oddNumbers)
            {
                Console.WriteLine(number);
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}