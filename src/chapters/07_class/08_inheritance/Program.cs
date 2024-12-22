// Chapter 0708: Inheritance
// This program demonstrates the use of inheritance in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter0708_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance is a fundamental concept in object-oriented programming that allows a class to inherit members from another class.
            // The class that inherits is called the derived class, and the class being inherited from is called the base class.
            // The syntax of inheritance in C# is:
            // class DerivedClass : BaseClass
            // {
            //     // Additional members
            // }

            // Example: Inheritance
            // This example demonstrates a base class 'Person' and a derived class 'Student' that inherits from 'Person'.
            Console.WriteLine("Example: Inheritance.");
            Student student = new Student("Alice", 20, "Computer Science");
            student.PrintInfo();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Base class
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

        // Method to print information
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Derived class
    public class Student : Person
    {
        // Additional property
        public string Major { get; set; }

        // Constructor
        public Student(string name, int age, string major) : base(name, age)
        {
            Major = major;
        }

        // Method to print information
        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Major: {Major}");
        }
    }
}