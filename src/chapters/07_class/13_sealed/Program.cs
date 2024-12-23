// Chapter 35: Sealed Classes
// This program demonstrates the use of sealed classes in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter35_SealedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sealed classes are classes that cannot be inherited.
            // The syntax of a sealed class in C# is:
            // sealed class ClassName
            // {
            //     // Members
            // }

            // Example: Sealed Classes
            // This example demonstrates a base class 'Animal' and a sealed class 'Dog' that inherits from 'Animal'.
            Console.WriteLine("Example: Sealed Classes.");

            // Creating an instance of the sealed class
            Dog dog = new Dog();
            dog.MakeSound();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Base class
    public class Animal
    {
        // Method
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    // Sealed class inheriting the base class
    public sealed class Dog : Animal
    {
        // Overridden method
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }
}