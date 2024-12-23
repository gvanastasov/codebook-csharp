// Chapter 0802: Encapsulation
// This program demonstrates the use of encapsulation in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter0802_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation is one of the fundamental principles of object-oriented programming.
            // It involves bundling the data (fields) and methods that operate on the data into a single unit (class) and restricting access to some of the object's components.
            // This is typically achieved using access modifiers to make fields private and providing public properties or methods to access and modify the data.

            // Example: Encapsulation
            // This example demonstrates a class 'Person' that encapsulates its fields and provides public properties to access and modify the data.
            Console.WriteLine("Example: Encapsulation.");

            Person person = new Person("Alice", 30);
            person.PrintInfo();

            // Accessing and modifying encapsulated data through properties
            person.Name = "Bob";
            person.Age = 25;
            person.PrintInfo();

            // Attempting to access private fields directly would result in a compilation error:
            // person.name = "Charlie"; // Error
            // person.age = 35; // Error

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class definition demonstrating encapsulation
    public class Person
    {
        // Private fields
        private string name;
        private int age;

        // Public properties to access and modify the private fields
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Method to print information
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}