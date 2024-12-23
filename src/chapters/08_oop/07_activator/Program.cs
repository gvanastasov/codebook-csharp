// Chapter 72: Activator
// This program demonstrates the use of the Activator class in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter72_Activator
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Activator class provides methods to create instances of types dynamically at runtime.
            // It is part of the System namespace and is commonly used in scenarios where the type is not known at compile time.

            // Example: Creating an Instance with Default Constructor
            // This example demonstrates how to use the Activator class to create an instance of a type with the default constructor.
            Console.WriteLine("Example: Creating an Instance with Default Constructor.");

            Person person1 = (Person)Activator.CreateInstance(typeof(Person));
            person1.Name = "Alice";
            person1.Age = 30;
            person1.PrintInfo();

            // Example: Creating an Instance with Parameterized Constructor
            // This example demonstrates how to use the Activator class to create an instance of a type with a parameterized constructor.
            Console.WriteLine("\nExample: Creating an Instance with Parameterized Constructor.");

            Person person2 = (Person)Activator.CreateInstance(typeof(Person), "Bob", 25);
            person2.PrintInfo();

            // Example: Creating an Instance of a Generic Type
            // This example demonstrates how to use the Activator class to create an instance of a generic type.
            Console.WriteLine("\nExample: Creating an Instance of a Generic Type.");

            GenericContainer<int> container = (GenericContainer<int>)Activator.CreateInstance(typeof(GenericContainer<>).MakeGenericType(typeof(int)), 42);
            Console.WriteLine($"GenericContainer<int>: {container.Value}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class definition
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Generic class definition
    public class GenericContainer<T>
    {
        public T Value { get; set; }

        public GenericContainer(T value)
        {
            Value = value;
        }
    }
}