// Chapter 0803: Finalize
// This program demonstrates the use of the Finalize method in classes in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter0803_Finalizers
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Finalize method is used to perform cleanup operations before an object is reclaimed by garbage collection.
            // In C#, the Finalize method is represented by a destructor, which is a special method with the same name as the class, prefixed with a tilde (~).
            // The syntax of a destructor in a class is:
            // ~ClassName()
            // {
            //     // Cleanup code
            // }

            // Example: Class with a destructor
            // This example demonstrates a class with a destructor and how it performs cleanup operations.
            Console.WriteLine("Example: Class with a destructor.");
            CreateAndDestroyPerson();

            // Force garbage collection to demonstrate the destructor call
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void CreateAndDestroyPerson()
        {
            Person person = new Person("Alice", 30);
            person.PrintInfo();
        }
    }

    // Class definition with a destructor
    public class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Destructor
        ~Person()
        {
            Console.WriteLine($"Destructor called for {Name}");
        }

        // Method to print information
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}