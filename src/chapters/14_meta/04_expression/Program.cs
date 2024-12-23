// Chapter 74: Expression Trees
// This program demonstrates the use of expression trees in C# 
// with simple examples and detailed explanations.

using System;
using System.Linq.Expressions;

namespace Chapter74_ExpressionTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            // Expression trees represent code in a tree-like data structure, where each node is an expression.
            // They are used to parse, analyze, and compile code at runtime, and are commonly used in LINQ providers and dynamic query generation.

            // Example: Creating an Expression Tree
            // This example demonstrates how to create an expression tree that represents a simple mathematical expression.
            Console.WriteLine("Example: Creating an Expression Tree.");

            // Expression: x => x * x
            ParameterExpression param = Expression.Parameter(typeof(int), "x");
            BinaryExpression body = Expression.Multiply(param, param);
            Expression<Func<int, int>> expression = Expression.Lambda<Func<int, int>>(body, param);

            Console.WriteLine($"Expression: {expression}");

            // Example: Compiling and Executing an Expression Tree
            // This example demonstrates how to compile and execute an expression tree.
            Console.WriteLine("\nExample: Compiling and Executing an Expression Tree.");

            Func<int, int> compiledExpression = expression.Compile();
            int result = compiledExpression(5);
            Console.WriteLine($"Result of compiled expression (5 * 5): {result}");

            // Example: Building a Complex Expression Tree
            // This example demonstrates how to build a more complex expression tree.
            Console.WriteLine("\nExample: Building a Complex Expression Tree.");

            // Expression: (x, y) => x * y + 2
            ParameterExpression param1 = Expression.Parameter(typeof(int), "x");
            ParameterExpression param2 = Expression.Parameter(typeof(int), "y");
            BinaryExpression multiply = Expression.Multiply(param1, param2);
            ConstantExpression constant = Expression.Constant(2);
            BinaryExpression add = Expression.Add(multiply, constant);
            Expression<Func<int, int, int>> complexExpression = Expression.Lambda<Func<int, int, int>>(add, param1, param2);

            Console.WriteLine($"Complex Expression: {complexExpression}");

            Func<int, int, int> compiledComplexExpression = complexExpression.Compile();
            int complexResult = compiledComplexExpression(3, 4);
            Console.WriteLine($"Result of compiled complex expression (3 * 4 + 2): {complexResult}");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}