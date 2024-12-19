// Chapter 23: Class Definition
// This program demonstrates the definition of classes in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes are the building blocks of object-oriented programming in C#.
            // They allow you to create custom types by grouping variables (fields) and functions (methods) together.
            // The syntax of a class in C# is:
            // class ClassName
            // {
            //     // Members (fields, properties, methods, etc. - more on this later)
            // }

            // Example: Basic class definition and instantiation
            // This example demonstrates a basic class definition and how to create an instance of the class.
            Console.WriteLine("Example: Basic class definition and instantiation.");
            Person person = new Person();
            person.PrintInfo();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class definition
    public class Person
    {
        public void PrintInfo()
        {
            Console.WriteLine($"This is a person.");
        }
    }
}