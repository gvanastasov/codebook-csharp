// Chapter 26: Class Methods
// This program demonstrates the use of methods in classes in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Methods in classes are functions that belong to a class.
            // They define the behavior of the objects created from the class.
            // The syntax of a method in a class is:
            // accessModifier returnType MethodName(parameterList)
            // {
            //     // Code to execute
            //     return value; // if returnType is not void
            // }

            // Example: Class with methods
            // This example demonstrates a class with methods and how to call them.
            Console.WriteLine("Example: Class with methods.");
            Person person = new Person();
            person.Name = "Alice";
            person.Age = 30;
            person.PrintInfo();
            person.IncreaseAge();
            person.PrintInfo();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class definition with methods
    public class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Method to print information
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        // Method to increase age
        public void IncreaseAge()
        {
            Age++;
        }
    }
}