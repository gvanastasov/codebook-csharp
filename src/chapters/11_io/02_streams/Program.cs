// Chapter 54: Streams
// This program demonstrates the use of file and memory streams in C# 
// with simple examples and detailed explanations.

using System;
using System.IO;

namespace Chapter54_Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Streams are used to read and write data to various data sources such as files, memory, and network connections.
            // The System.IO namespace provides various classes for working with streams, such as FileStream, MemoryStream, StreamReader, and StreamWriter.

            // Example: FileStream
            // This example demonstrates how to use FileStream to read from and write to a file.
            Console.WriteLine("Example: FileStream.");

            string filePath = "filestream_example.txt";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, FileStream!");
                fileStream.Write(data, 0, data.Length);
            }

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] data = new byte[fileStream.Length];
                fileStream.Read(data, 0, data.Length);
                string text = System.Text.Encoding.UTF8.GetString(data);
                Console.WriteLine($"Text read from {filePath}: {text}");
            }

            // Example: MemoryStream
            // This example demonstrates how to use MemoryStream to read from and write to memory.
            Console.WriteLine("\nExample: MemoryStream.");

            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, MemoryStream!");
                memoryStream.Write(data, 0, data.Length);

                // Reset the position to the beginning of the stream
                memoryStream.Position = 0;

                byte[] buffer = new byte[memoryStream.Length];
                memoryStream.Read(buffer, 0, buffer.Length);
                string text = System.Text.Encoding.UTF8.GetString(buffer);
                Console.WriteLine($"Text read from MemoryStream: {text}");
            }

            // Example: StreamReader and StreamWriter
            // This example demonstrates how to use StreamReader and StreamWriter for file I/O operations.
            Console.WriteLine("\nExample: StreamReader and StreamWriter.");

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