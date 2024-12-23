// Chapter 83: Debugging Basics
// This program demonstrates the use of Debug and Trace in C# 
// with simple examples and detailed explanations.

using System;
using System.Diagnostics;

namespace Chapter83_DebuggingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Debug and Trace classes provide a way to output debugging and tracing information.
            // They are useful for diagnosing issues and monitoring the execution of your application.

            // Example: Using Debug
            // This example demonstrates how to use the Debug class to output debugging information.
            Console.WriteLine("Example: Using Debug.");

            Debug.WriteLine("This is a debug message.");
            Debug.WriteLineIf(true, "This debug message is conditional.");
            Debug.Assert(1 + 1 == 2, "Math is broken!");

            // Example: Using Trace
            // This example demonstrates how to use the Trace class to output tracing information.
            Console.WriteLine("\nExample: Using Trace.");

            Trace.WriteLine("This is a trace message.");
            Trace.WriteLineIf(true, "This trace message is conditional.");
            Trace.Assert(1 + 1 == 2, "Math is broken!");

            // Example: Configuring Trace Listeners
            // This example demonstrates how to configure trace listeners to direct output to different destinations.
            Console.WriteLine("\nExample: Configuring Trace Listeners.");

            Trace.Listeners.Clear();
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.Listeners.Add(new TextWriterTraceListener("trace.log"));

            Trace.WriteLine("This message is written to both console and file.");

            // Flush and close the listeners
            foreach (TraceListener listener in Trace.Listeners)
            {
                listener.Flush();
                listener.Close();
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}