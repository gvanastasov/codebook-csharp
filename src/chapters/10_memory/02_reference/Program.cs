// Chapter 48: Ref Keyword
// This program demonstrates the use of the ref keyword in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter48_RefKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // The ref keyword is used to pass arguments by reference.
            // This allows the called method to modify the value of the argument and have that change reflected in the calling method.
            // The syntax of using the ref keyword in C# is:
            // Method definition: void MethodName(ref type parameter)
            // Method call: MethodName(ref argument);

            // Example: Ref Keyword
            // This example demonstrates the use of the ref keyword to modify the value of an argument.
            Console.WriteLine("Example: Ref Keyword.");

            int number = 10;
            Console.WriteLine($"Before method call: {number}");
            ModifyNumber(ref number);
            Console.WriteLine($"After method call: {number}");

            // Example: Ref Keyword with Objects
            // This example demonstrates the use of the ref keyword with objects.
            Console.WriteLine("\nExample: Ref Keyword with Objects.");

            Person person = new Person("Alice");
            Console.WriteLine($"Before method call: {person.Name}");
            ModifyPerson(ref person);
            Console.WriteLine($"After method call: {person.Name}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method to modify a number using the ref keyword
        static void ModifyNumber(ref int number)
        {
            number = 20;
        }

        // Method to modify a person object using the ref keyword
        static void ModifyPerson(ref Person person)
        {
            person.Name = "Bob";
        }
    }

    // Class definition
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }
}