// Chapter 27: Parameterized Constructors
// This program demonstrates the use of parameterized constructors in classes in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructors are special methods that are called when an instance of a class is created.
            // Parameterized constructors allow you to initialize an object with specific values when it is created.
            // The syntax of a parameterized constructor in a class is:
            // accessModifier ClassName(parameterList)
            // {
            //     // Initialization code
            // }

            // Example: Class with a parameterized constructor
            // This example demonstrates a class with a parameterized constructor and how to create an instance of the class with specific values.
            Console.WriteLine("Example: Class with a parameterized constructor.");
            Person person = new Person("Alice", 30);
            person.PrintInfo();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class definition with a parameterized constructor
    public class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Parameterized constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to print information
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}