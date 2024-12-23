// Chapter 55: Serialization and Deserialization
// This program demonstrates the use of serialization and deserialization in C# 
// with simple examples and detailed explanations.

using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Chapter55_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // Serialization is the process of converting an object into a format that can be stored or transmitted.
            // Deserialization is the process of converting the serialized data back into an object.
            // Common serialization formats include JSON and XML.

            // Example: JSON Serialization and Deserialization
            // This example demonstrates how to serialize and deserialize an object to and from JSON.
            Console.WriteLine("Example: JSON Serialization and Deserialization.");

            Person person = new Person { Name = "Alice", Age = 30 };
            string jsonString = JsonSerializer.Serialize(person);
            Console.WriteLine($"Serialized JSON: {jsonString}");

            Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonString);
            Console.WriteLine($"Deserialized Person: Name = {deserializedPerson.Name}, Age = {deserializedPerson.Age}");

            // Example: XML Serialization and Deserialization
            // This example demonstrates how to serialize and deserialize an object to and from XML.
            Console.WriteLine("\nExample: XML Serialization and Deserialization.");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, person);
                string xmlString = textWriter.ToString();
                Console.WriteLine($"Serialized XML: {xmlString}");

                using (StringReader textReader = new StringReader(xmlString))
                {
                    Person deserializedXmlPerson = (Person)xmlSerializer.Deserialize(textReader);
                    Console.WriteLine($"Deserialized Person: Name = {deserializedXmlPerson.Name}, Age = {deserializedXmlPerson.Age}");
                }
            }

            // Pause for user review
            // This line pauses the program execution and waits for the user to press any key before exiting.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class definition for serialization
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}