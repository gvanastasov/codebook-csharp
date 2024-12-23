// Chapter 47: Value vs Reference Types
// This program demonstrates the differences between value types and reference types in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter47_ValueVsReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // In C#, types are divided into value types and reference types.
            // Value types store their data directly, while reference types store a reference to their data.
            // Common value types include int, double, and struct, while common reference types include string, array, and class.

            // Example: Value Types
            // This example demonstrates the behavior of value types.
            Console.WriteLine("Example: Value Types.");
            int a = 10;
            int b = a; // b is a copy of a
            b = 20;
            Console.WriteLine($"a: {a}, b: {b}"); // a remains unchanged

            // Example: Reference Types
            // This example demonstrates the behavior of reference types.
            Console.WriteLine("\nExample: Reference Types.");
            Person person1 = new Person("Alice");
            Person person2 = person1; // person2 is a reference to person1
            person2.Name = "Bob";
            Console.WriteLine($"person1.Name: {person1.Name}, person2.Name: {person2.Name}"); // both references reflect the change

            // Example: Struct (Value Type)
            // This example demonstrates the behavior of a struct, which is a value type.
            Console.WriteLine("\nExample: Struct (Value Type).");
            Point point1 = new Point(1, 2);
            Point point2 = point1; // point2 is a copy of point1
            point2.X = 3;
            Console.WriteLine($"point1: ({point1.X}, {point1.Y}), point2: ({point2.X}, {point2.Y})"); // point1 remains unchanged

            // Example: Class (Reference Type)
            // This example demonstrates the behavior of a class, which is a reference type.
            Console.WriteLine("\nExample: Class (Reference Type).");
            Rectangle rect1 = new Rectangle(1, 2);
            Rectangle rect2 = rect1; // rect2 is a reference to rect1
            rect2.Width = 3;
            Console.WriteLine($"rect1: ({rect1.Width}, {rect1.Height}), rect2: ({rect2.Width}, {rect2.Height})"); // both references reflect the change

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
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

    // Struct definition (Value Type)
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    // Class definition (Reference Type)
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}