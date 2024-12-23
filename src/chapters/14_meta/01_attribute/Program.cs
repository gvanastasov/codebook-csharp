// Chapter 70: Attributes
// This program demonstrates the use of attributes in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter70_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Attributes provide a way to add metadata to your code.
            // They can be used to specify additional information about classes, methods, properties, and other code elements.

            // Example: Using Attributes
            // This example demonstrates how to define and use custom attributes.
            Console.WriteLine("Example: Using Attributes.");

            var person = new Person("Alice", 30);
            var type = typeof(Person);
            var attributes = type.GetCustomAttributes(typeof(InfoAttribute), false);

            foreach (InfoAttribute attribute in attributes)
            {
                Console.WriteLine($"Author: {attribute.Author}, Version: {attribute.Version}");
            }

            // Example: Retrieving Attribute Information
            // This example demonstrates how to retrieve attribute information at runtime.
            Console.WriteLine("\nExample: Retrieving Attribute Information.");

            var method = type.GetMethod("PrintInfo");
            var methodAttributes = method.GetCustomAttributes(typeof(InfoAttribute), false);

            foreach (InfoAttribute attribute in methodAttributes)
            {
                Console.WriteLine($"Method Author: {attribute.Author}, Method Version: {attribute.Version}");
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Custom attribute definition
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class InfoAttribute : Attribute
    {
        public string Author { get; }
        public string Version { get; }

        public InfoAttribute(string author, string version)
        {
            Author = author;
            Version = version;
        }
    }

    // Class with custom attribute
    [Info("John Doe", "1.0")]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        [Info("Jane Doe", "1.1")]
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}