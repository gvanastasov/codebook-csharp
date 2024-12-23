// Chapter 53: File I/O
// This program demonstrates reading from and writing to files in C# 
// with simple examples and detailed explanations.

using System;
using System.IO;

namespace Chapter53_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // File I/O (Input/Output) operations allow you to read from and write to files.
            // The System.IO namespace provides various classes for file I/O operations, such as File, StreamReader, and StreamWriter.

            // Example: Writing to a File
            // This example demonstrates how to write text to a file.
            Console.WriteLine("Example: Writing to a File.");

            string filePath = "example.txt";
            string[] linesToWrite = { "First line", "Second line", "Third line" };

            File.WriteAllLines(filePath, linesToWrite);
            Console.WriteLine($"Text written to {filePath}");

            // Example: Reading from a File
            // This example demonstrates how to read text from a file.
            Console.WriteLine("\nExample: Reading from a File.");

            if (File.Exists(filePath))
            {
                string[] linesRead = File.ReadAllLines(filePath);
                Console.WriteLine($"Text read from {filePath}:");
                foreach (string line in linesRead)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"File {filePath} does not exist.");
            }

            // Example: Appending to a File
            // This example demonstrates how to append text to a file.
            Console.WriteLine("\nExample: Appending to a File.");

            string textToAppend = "Fourth line";
            File.AppendAllText(filePath, textToAppend + Environment.NewLine);
            Console.WriteLine($"Text appended to {filePath}");

            // Reading the file again to show the appended text
            if (File.Exists(filePath))
            {
                string[] linesRead = File.ReadAllLines(filePath);
                Console.WriteLine($"Text read from {filePath} after appending:");
                foreach (string line in linesRead)
                {
                    Console.WriteLine(line);
                }
            }

            // Example: Using StreamReader and StreamWriter
            // This example demonstrates how to use StreamReader and StreamWriter for file I/O operations.
            Console.WriteLine("\nExample: Using StreamReader and StreamWriter.");

            string streamFilePath = "stream_example.txt";
            using (StreamWriter writer = new StreamWriter(streamFilePath))
            {
                writer.WriteLine("First line using StreamWriter");
                writer.WriteLine("Second line using StreamWriter");
            }

            using (StreamReader reader = new StreamReader(streamFilePath))
            {
                string line;
                Console.WriteLine($"Text read from {streamFilePath} using StreamReader:");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}