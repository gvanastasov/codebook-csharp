// Chapter 25: Class Properties
// This program demonstrates the use of properties in classes in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter25
{
    class Program
    {
        static void Main(string[] args)
        {
            // Properties are members of a class that provide a flexible mechanism to read, write, or compute the values of private fields.
            // They are used to protect a field by reading and writing to it through the property.
            // The syntax of a property in a class is:
            // accessModifier returnType PropertyName { get; set; }

            // Example: Class with properties
            // This example demonstrates a class with properties and how to access them.
            Console.WriteLine("Example: Class with properties.");
            Person person = new Person();
            person.Name = "Alice";
            person.Age = 30;
            person.PrintInfo();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class definition with properties
    public class Person
    {
        // Private fields
        private string name;
        private int age;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age cannot be negative.");
                } 
                age = value; 
            }
        }

        // Method to print information
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}