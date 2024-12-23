// Chapter 43: Dictionaries
// This program demonstrates the use of dictionaries in C# 
// with simple examples and detailed explanations.

using System;
using System.Collections.Generic;

namespace Chapter43_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionaries are a part of the System.Collections.Generic namespace and provide a way to store key-value pairs.
            // Each key in a dictionary must be unique, and it is used to access the corresponding value.
            // The syntax of a dictionary in C# is:
            // Dictionary<keyType, valueType> dictionaryName = new Dictionary<keyType, valueType>();

            // Example: Dictionary Initialization and Access
            // This example demonstrates the creation, initialization, and access of a dictionary.
            Console.WriteLine("Example: Dictionary Initialization and Access.");
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                { 1, "Alice" },
                { 2, "Bob" },
                { 3, "Charlie" }
            };

            foreach (var student in students)
            {
                Console.WriteLine($"Key: {student.Key}, Value: {student.Value}");
            }

            // Example: Dictionary Methods
            // This example demonstrates some common dictionary methods.
            Console.WriteLine("\nExample: Dictionary Methods.");

            // Add
            students.Add(4, "David");
            Console.WriteLine("After Add:");
            foreach (var student in students)
            {
                Console.WriteLine($"Key: {student.Key}, Value: {student.Value}");
            }

            // Remove
            students.Remove(2);
            Console.WriteLine("\nAfter Remove:");
            foreach (var student in students)
            {
                Console.WriteLine($"Key: {student.Key}, Value: {student.Value}");
            }

            // ContainsKey
            bool containsKey = students.ContainsKey(1);
            Console.WriteLine($"\nContains Key 1: {containsKey}");

            // ContainsValue
            bool containsValue = students.ContainsValue("Charlie");
            Console.WriteLine($"Contains Value 'Charlie': {containsValue}");

            // TryGetValue
            if (students.TryGetValue(3, out string? studentName))
            {
                Console.WriteLine($"\nStudent with Key 3: {studentName}");
            }

            // Keys and Values
            Console.WriteLine("\nKeys:");
            foreach (var key in students.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\nValues:");
            foreach (var value in students.Values)
            {
                Console.WriteLine(value);
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}