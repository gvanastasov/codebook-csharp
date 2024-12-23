// Chapter 75: Preprocessor Directives
// This program demonstrates the use of preprocessor directives in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter75_PreprocessorDirectives
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preprocessor directives are instructions that are processed by the compiler before the actual compilation of code begins.
            // They are used to control the compilation process and can be used for conditional compilation, defining symbols, and including files.

            // Example: #define and #undef
            // This example demonstrates how to define and undefine symbols using #define and #undef.
            Console.WriteLine("Example: #define and #undef.");

#if DEBUG
            Console.WriteLine("DEBUG is defined.");
#else
            Console.WriteLine("DEBUG is not defined.");
#endif

            // Example: #if, #elif, #else, and #endif
            // This example demonstrates how to use #if, #elif, #else, and #endif for conditional compilation.
            Console.WriteLine("\nExample: #if, #elif, #else, and #endif.");

#if DEBUG
            Console.WriteLine("DEBUG mode.");
#elif RELEASE
            Console.WriteLine("RELEASE mode.");
#else
            Console.WriteLine("Unknown mode.");
#endif

            // Example: #warning and #error
            // This example demonstrates how to use #warning and #error to generate compiler warnings and errors.
            Console.WriteLine("\nExample: #warning and #error.");

#if DEBUG
#warning This is a debug build.
#else
#error This is not a debug build.
#endif

            // Example: #region and #endregion
            // This example demonstrates how to use #region and #endregion to define code regions.
            Console.WriteLine("\nExample: #region and #endregion.");

#region ExampleRegion
            Console.WriteLine("This is inside the region.");
#endregion

            // Example: #pragma
            // This example demonstrates how to use #pragma to control compiler warnings.
            Console.WriteLine("\nExample: #pragma.");

#pragma warning disable CS0168 // Disable warning for unused variable
            int unusedVariable;
#pragma warning restore CS0168 // Restore warning for unused variable

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}