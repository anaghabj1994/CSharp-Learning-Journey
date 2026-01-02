using System;
using System.Collections.Generic;
using System.Linq;

namespace Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Concepts project - .NET 8.0 examples\n");

            // Variables & Data types
            Variables.ShowExamples();
            DataTypes.ShowExamples();

            // OOP examples
            var car = new SimpleCar("Honda", "Civic", 2020);
            car.DisplayInfo();

            Animal a = new Dog("Rex");
            a.Speak();

            // LINQ example
            LINQExamples.Run();
        }
    }
}
