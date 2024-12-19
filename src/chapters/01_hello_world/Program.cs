// Chapter 01: Hello, World!
// This is the first and simplest C# program to get you started.
// It introduces the basic structure of a C# application and demonstrates
// how to output text to the console.

using System; // The System namespace provides fundamental classes like Console.

namespace Chapter01
{
    // The Program class contains the Main method, the entry point of the application.
    class Program
    {
        // The Main method is where the program starts execution.
        // 'args' is an array of strings that can hold command-line arguments.
        static void Main(string[] args)
        {
            // 1. Output a message to the console
            // Console.WriteLine is used to print text to the terminal, followed by a new line.
            Console.WriteLine("Hello, World!");

            // 2. Pause the program before exiting
            // Console.ReadKey waits for the user to press a key, giving them time
            // to read the output before the program closes.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}