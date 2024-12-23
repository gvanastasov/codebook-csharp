// Chapter 0709: Overriding
// This program demonstrates the use of overriding in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter0709_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Overriding allows a derived class to provide a specific implementation of a member that is already defined in its base class.
            // The member in the base class must be marked with the 'virtual' keyword, and the member in the derived class must be marked with the 'override' keyword.
            // The syntax of overriding (for example of methods) in C# is:
            // class BaseClass
            // {
            //     public virtual void MethodName()
            //     {
            //         // Base class implementation
            //     }
            // }
            // class DerivedClass : BaseClass
            // {
            //     public override void MethodName()
            //     {
            //         // Derived class implementation
            //     }
            // }

            // Example: Method Overriding
            // This example demonstrates a base class 'Person' with a virtual method 'PrintInfo' and a derived class 'Student' that overrides 'PrintInfo'.
            Console.WriteLine("Example: Method Overriding.");
            Person person = new Person("Alice", 30);
            person.PrintInfo();

            Student student = new Student("Bob", 20, "Computer Science");
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

        // Virtual method
        public virtual void PrintInfo()
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

        // Overridden method
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Major: {Major}");
        }
    }
}