// Chapter 24: Class Fields
// This program demonstrates the use of fields in classes in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fields are variables that belong to a class.
            // They are used to store the state or data of an object.
            // The syntax of defining a field in a class is:
            // accessModifier fieldType fieldName;

            // Example: Class with fields
            // This example demonstrates a class with fields and how to access them.
            Console.WriteLine("Example: Class with fields.");
            Person alice = new Person();
            alice.Name = "Alice";
            alice.Age = 30;
            alice.PrintInfo();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class definition with fields
    public class Person
    {
        // Fields

        // This field is assigned (inline) a default value of "Unknown".
        public string Name = "Unknown";

        // This field is also assigned a default value of 0, by the compiler. 
        public int Age;

        // Method to print information
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}