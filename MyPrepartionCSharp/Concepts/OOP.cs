using System;

namespace Concepts
{
    public class SimpleCar
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }

        public SimpleCar(string make, string model, int year)
        {
            Make = make; Model = model; Year = year;
        }

        public void DisplayInfo() => Console.WriteLine($"Car: {Make} {Model} ({Year})");
    }

    public class Animal
    {
        public string Name { get; }
        public Animal(string name) => Name = name;
        public virtual void Speak() => Console.WriteLine($"{Name} makes a sound.");
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void Speak() => Console.WriteLine($"{Name} barks.");
    }
}
