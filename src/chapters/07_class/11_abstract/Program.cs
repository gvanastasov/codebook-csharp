// Chapter 0711: Abstract Classes
// This program demonstrates the use of abstract classes in C# 
// with a simple example and detailed explanations.

using System;

namespace Chapter0711_AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract classes are classes that cannot be instantiated and are intended to be inherited by other classes.
            // They can contain abstract methods, which are methods without implementation that must be implemented by derived classes.
            // The syntax of an abstract class in C# is:
            // abstract class ClassName
            // {
            //     // Abstract method
            //     public abstract void MethodName();
            // }

            // Example: Abstract Classes
            // This example demonstrates an abstract class 'Animal' with an abstract method 'MakeSound' and derived classes 'Dog' and 'Cat' that implement the method.
            Console.WriteLine("Example: Abstract Classes.");
            Animal dog = new Dog();
            Animal cat = new Cat();

            dog.MakeSound();
            cat.MakeSound();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Abstract class definition
    public abstract class Animal
    {
        // Abstract method
        public abstract void MakeSound();
    }

    // Class inheriting the abstract class
    public class Dog : Animal
    {
        // Method implementation
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    // Class inheriting the abstract class
    public class Cat : Animal
    {
        // Method implementation
        public override void MakeSound()
        {
            Console.WriteLine("Cat says: Meow!");
        }
    }
}