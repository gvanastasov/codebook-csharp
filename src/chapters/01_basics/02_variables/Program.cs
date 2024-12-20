// Chapter 02: Variables
// This program demonstrates how to use variables in C#,
// including declaration, initialization, and basic operations.

using System; // Required for console input/output.

namespace Chapter02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Variables
            // A variable is a named storage for data. Its value can change during the program.

            // Declaring and initializing an integer variable.
            int age = 25;

            // Declaring and initializing a string variable.
            string name = "Alice";
            
            // Declaring and initializing a double-precision floating-point variable.
            double pi = 3.14159;

            // Displaying the values of the variables.
            Console.WriteLine("Variables:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Pi: {pi}");

            // 2. Changing Values
            // Variables can be reassigned.
            age = 30;
            name = "Bob";

            Console.WriteLine();
            Console.WriteLine("Updated Variables:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");

            // Pause to allow the user to read the output.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
