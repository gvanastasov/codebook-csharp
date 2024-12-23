// Chapter 0710: Interfaces
// This program demonstrates the use of interfaces in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter0710_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfaces define a contract that classes can implement.
            // They specify what methods, properties, events, or indexers a class must implement, but do not provide the implementation.
            // The syntax of an interface in C# is:
            // interface IInterfaceName
            // {
            //     // Method signatures
            //     // Property signatures
            // }

            // Example: Interfaces
            // This example demonstrates an interface 'IAnimal' and classes 'Dog' and 'Cat' that implement the interface.
            Console.WriteLine("Example: Interfaces.");
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();

            dog.MakeSound();
            cat.MakeSound();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Interface definition
    public interface IAnimal
    {
        // Method signature
        void MakeSound();
    }

    // Class implementing the interface
    public class Dog : IAnimal
    {
        // Method implementation
        public void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    // Class implementing the interface
    public class Cat : IAnimal
    {
        // Method implementation
        public void MakeSound()
        {
            Console.WriteLine("Cat says: Meow!");
        }
    }
}