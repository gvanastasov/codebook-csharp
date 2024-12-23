// Chapter 0801: Access Modifiers
// This program demonstrates the use of access modifiers in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter0801_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Access modifiers control the visibility and accessibility of classes, methods, and other members.
            // The common access modifiers in C# are:
            // - public: The member is accessible from any other code.
            // - private: The member is accessible only within the containing class.
            // - protected: The member is accessible within the containing class and derived classes.
            // - internal: The member is accessible within the same assembly.
            // - protected internal: The member is accessible within the same assembly and derived classes.
            // - private protected: The member is accessible within the containing class and derived classes within the same assembly.

            // Example: Access Modifiers
            // This example demonstrates a class 'Person' with members having different access modifiers.
            Console.WriteLine("Example: Access Modifiers.");

            Person person = new Person("Alice", 30);
            person.PrintInfo();

            // Accessing public member
            Console.WriteLine($"Public Name: {person.Name}");

            // Accessing internal member
            Console.WriteLine($"Internal Age: {person.GetAge()}");

            // Accessing protected internal member
            Console.WriteLine($"Protected Internal Info: {person.GetProtectedInternalInfo()}");

            // The following lines would cause compilation errors due to access restrictions:
            // Console.WriteLine($"Private ID: {person.id}");
            // Console.WriteLine($"Protected Info: {person.GetProtectedInfo()}");
            // Console.WriteLine($"Private Protected Info: {person.GetPrivateProtectedInfo()}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class definition with different access modifiers
    public class Person
    {
        // Private field
        private int id;

        // Public property
        public string Name { get; set; }

        // Internal property
        internal int Age { get; set; }

        // Protected property
        protected string ProtectedInfo { get; set; }

        // Protected internal property
        protected internal string ProtectedInternalInfo { get; set; }

        // Private protected property
        private protected string PrivateProtectedInfo { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            id = new Random().Next(1, 1000);
            Name = name;
            Age = age;
            ProtectedInfo = "Protected Information";
            ProtectedInternalInfo = "Protected Internal Information";
            PrivateProtectedInfo = "Private Protected Information";
        }

        // Public method
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        // Internal method
        internal int GetAge()
        {
            return Age;
        }

        // Protected method
        protected string GetProtectedInfo()
        {
            return ProtectedInfo;
        }

        // Protected internal method
        protected internal string GetProtectedInternalInfo()
        {
            return ProtectedInternalInfo;
        }

        // Private protected method
        private protected string GetPrivateProtectedInfo()
        {
            return PrivateProtectedInfo;
        }
    }
}