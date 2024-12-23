// Chapter 50: Structs
// This program demonstrates the use of structs in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter50_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Structs are value types that can contain data and methods. (more on value vs reference types in Memory chapter)
            // They are useful for representing small data structures that do not require inheritance.
            // The syntax of a struct in C# is:
            // struct StructName
            // {
            //     // Fields, properties, methods, etc.
            // }

            // Example: Struct Declaration and Usage
            // This example demonstrates the declaration and usage of a struct.
            Console.WriteLine("Example: Struct Declaration and Usage.");

            Point point1 = new Point(1, 2);
            Point point2 = point1; // point2 is a copy of point1
            point2.X = 3;
            Console.WriteLine($"point1: ({point1.X}, {point1.Y}), point2: ({point2.X}, {point2.Y})"); // point1 remains unchanged

            // Example: Struct with Methods
            // This example demonstrates a struct with methods.
            Console.WriteLine("\nExample: Struct with Methods.");

            Rectangle rect = new Rectangle(4, 5);
            Console.WriteLine($"Area of rectangle: {rect.Area()}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Struct definition
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

    // Struct definition with methods
    public struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area()
        {
            return Width * Height;
        }
    }
}