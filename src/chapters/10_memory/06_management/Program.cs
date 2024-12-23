// Chapter 52: Span<T> and Memory<T>
// This program demonstrates the use of Span<T> and Memory<T> in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter52_SpanAndMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Span<T> and Memory<T> are low-level memory constructs introduced in C# to provide a more efficient way to work with contiguous regions of memory.
            // Span<T> is a stack-only type that provides a type-safe and memory-safe representation of a contiguous region of arbitrary memory.
            // Memory<T> is similar to Span<T> but can be used on the heap and can be stored in fields.

            // Example: Span<T>
            // This example demonstrates the use of Span<T> to work with a contiguous region of memory.
            Console.WriteLine("Example: Span<T>.");

            int[] array = { 1, 2, 3, 4, 5 };
            Span<int> span = array.AsSpan();

            Console.WriteLine("Original array:");
            foreach (var item in span)
            {
                Console.WriteLine(item);
            }

            // Modifying the span modifies the original array
            span[0] = 10;
            Console.WriteLine("\nModified array:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            // Example: Memory<T>
            // This example demonstrates the use of Memory<T> to work with a contiguous region of memory.
            Console.WriteLine("\nExample: Memory<T>.");

            Memory<int> memory = new Memory<int>(array);

            Console.WriteLine("Original array:");
            foreach (var item in memory.Span)
            {
                Console.WriteLine(item);
            }

            // Modifying the memory modifies the original array
            memory.Span[1] = 20;
            Console.WriteLine("\nModified array:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            // Example: Slicing
            // This example demonstrates how to slice a Span<T> and Memory<T>.
            Console.WriteLine("\nExample: Slicing.");

            Span<int> slice = span.Slice(1, 3);
            Console.WriteLine("Sliced span:");
            foreach (var item in slice)
            {
                Console.WriteLine(item);
            }

            Memory<int> memorySlice = memory.Slice(2, 2);
            Console.WriteLine("\nSliced memory:");
            foreach (var item in memorySlice.Span)
            {
                Console.WriteLine(item);
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}