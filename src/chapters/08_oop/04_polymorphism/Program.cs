// Chapter 0804: Polymorphism
// This program demonstrates the use of polymorphism in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter0804_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism is one of the fundamental principles of object-oriented programming.
            // It allows objects of different classes to be treated as objects of a common base class.
            // Polymorphism is typically achieved through method overriding and interfaces.

            // Example: Polymorphism
            // This example demonstrates polymorphism using a base class 'Animal' and derived classes 'Dog' and 'Cat'.
            Console.WriteLine("Example: Polymorphism.");

            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.MakeSound();
            myCat.MakeSound();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Base class
    public class Animal
    {
        // Virtual method
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    // Derived class
    public class Dog : Animal
    {
        // Overridden method
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    // Derived class
    public class Cat : Animal
    {
        // Overridden method
        public override void MakeSound()
        {
            Console.WriteLine("Cat says: Meow!");
        }
    }
}