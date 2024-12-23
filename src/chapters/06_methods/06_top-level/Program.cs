// Chapter 79: Top-Level Statements
// This program demonstrates the use of top-level statements in C# 
// with simple examples and detailed explanations.

// Top-level statements allow you to write the main entry point of a program without explicitly defining a Main method.
// This feature simplifies the code and is useful for small programs and scripts.

using System;

// Example: Top-Level Statements
// This example demonstrates how to use top-level statements to create a simple program.
Console.WriteLine("Example: Top-Level Statements.");

int a = 5;
int b = 10;
int sum = a + b;
Console.WriteLine($"Sum of {a} and {b} is {sum}.");

// Pause for user review
// This line pauses the program execution and waits for the user to press any key before exiting.
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
