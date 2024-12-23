// Chapter 81: Covariant Returns
// This program demonstrates the use of covariant returns in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter81_CovariantReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Covariant returns allow you to override a method in a derived class with a more specific return type.
            // This feature provides more flexibility and type safety when working with inheritance.

            // Example: Covariant Return Types
            // This example demonstrates how to use covariant return types in method overriding.
            Console.WriteLine("Example: Covariant Return Types.");

            Animal animal = new Animal();
            Dog dog = new Dog();
            Animal animalDog = new Dog();

            Console.WriteLine($"Animal sound: {animal.MakeSound()}");
            Console.WriteLine($"Dog sound: {dog.MakeSound()}");
            Console.WriteLine($"AnimalDog sound: {animalDog.MakeSound()}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Base class
    public class Animal
    {
        public virtual AnimalSound MakeSound()
        {
            return new AnimalSound("Generic animal sound");
        }
    }

    // Derived class with covariant return type
    public class Dog : Animal
    {
        public override DogSound MakeSound()
        {
            return new DogSound("Bark");
        }
    }

    // Base return type
    public class AnimalSound
    {
        public string Sound { get; }

        public AnimalSound(string sound)
        {
            Sound = sound;
        }

        public override string ToString()
        {
            return Sound;
        }
    }

    // Derived return type
    public class DogSound : AnimalSound
    {
        public DogSound(string sound) : base(sound) { }
    }
}