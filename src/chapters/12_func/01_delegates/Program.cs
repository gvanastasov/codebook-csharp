// Chapter 56: Delegates and Events
// This program demonstrates the use of delegates and events in C# 
// with simple examples and detailed explanations.

using System;

namespace Chapter56_DelegatesAndEvents
{
    public class Program
    {
        // Delegate declaration
        public delegate void Notify(string message);

        static void Main(string[] args)
        {
            // Delegates are type-safe function pointers that allow methods to be passed as parameters.
            // Events are a way for a class to notify other classes or objects when something of interest occurs.

            // Example: Delegates
            // This example demonstrates the use of delegates to call methods.
            Console.WriteLine("Example: Delegates.");

            Notify notifyDelegate = ShowMessage;
            notifyDelegate("Hello, Delegates!");

            // Example: Events
            // This example demonstrates the use of events to notify subscribers when something occurs.
            Console.WriteLine("\nExample: Events.");

            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.OnPublish += subscriber.HandleEvent;
            publisher.Publish("Hello, Events!");

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method to be called by delegate
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    // Publisher class that raises an event
    public class Publisher
    {
        // Event declaration
        public event Program.Notify OnPublish;

        // Method to raise the event
        public void Publish(string message)
        {
            OnPublish?.Invoke(message);
        }
    }

    // Subscriber class that handles the event
    public class Subscriber
    {
        // Event handler method
        public void HandleEvent(string message)
        {
            Console.WriteLine($"Event received: {message}");
        }
    }
}