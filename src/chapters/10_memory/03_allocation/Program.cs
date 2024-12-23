// Chapter 49: Stack vs Heap Memory
// This program demonstrates the differences between stack and heap memory in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter49_StackVsHeapMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            // In C#, memory is divided into stack and heap.
            // The stack is used for static memory allocation and the heap is used for dynamic memory allocation.
            // Value types are typically allocated on the stack, while reference types are allocated on the heap.

            // Example: Stack Memory
            // This example demonstrates the behavior of stack memory.
            Console.WriteLine("Example: Stack Memory.");
            int a = 10;
            int b = a; // b is a copy of a
            b = 20;
            Console.WriteLine($"a: {a}, b: {b}"); // a remains unchanged

            // Example: Heap Memory
            // This example demonstrates the behavior of heap memory.
            Console.WriteLine("\nExample: Heap Memory.");
            Person person1 = new Person("Alice");
            Person person2 = person1; // person2 is a reference to person1
            person2.Name = "Bob";
            Console.WriteLine($"person1.Name: {person1.Name}, person2.Name: {person2.Name}"); // both references reflect the change

            // Example: Stack and Heap Interaction
            // This example demonstrates the interaction between stack and heap memory.
            Console.WriteLine("\nExample: Stack and Heap Interaction.");
            CreatePerson();

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void CreatePerson()
        {
            Person person = new Person("Charlie");
            Console.WriteLine($"Created person: {person.Name}");
        }
    }

    // Class definition (Reference Type)
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }
}