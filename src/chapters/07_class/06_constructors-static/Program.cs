// Chapter 28: Static Constructors
// This program demonstrates the use of static constructors in classes in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter28
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static constructors are used to initialize static members of a class.
            // They are called automatically before any static members are accessed or any instances are created.
            // The syntax of a static constructor in a class is:
            // static ClassName()
            // {
            //     // Initialization code
            // }

            // Example: Class with a static constructor
            // This example demonstrates a class with a static constructor and how it initializes static members.
            Console.WriteLine("Example: Class with a static constructor.");
            Person.PrintCount();
            Person nextPerson = new Person();
            Person.PrintCount();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class definition with a static constructor
    public class Person
    {
        // Static field
        public static int Count;

        // Static constructor
        static Person()
        {
            Count = 100;
            Console.WriteLine("Static constructor called.");
        }

        // Parameterized constructor
        public Person()
        {
            Count++;
        }

        // Static method
        public static void PrintCount()
        {
            Console.WriteLine("Count: " + Count);
        }
    }
}