using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practise project - interview problems\n");
            Console.WriteLine("1) Reverse string\n2) Palindrome check\n3) FizzBuzz\n");
            Console.Write("Choose (1-3): ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter text: ");
                    Console.WriteLine("Reversed: " + ReverseString.Reverse(Console.ReadLine()));
                    break;
                case "2":
                    Console.Write("Enter text: ");
                    Console.WriteLine("Is palindrome: " + Palindrome.IsPalindrome(Console.ReadLine()));
                    break;
                case "3":
                    Console.Write("Enter n: ");
                    if (int.TryParse(Console.ReadLine(), out int n))
                        Console.WriteLine(string.Join(", ", FizzBuzz.Run(n)));
                    else
                        Console.WriteLine("Invalid number");
                    break;
                default:
                    Console.WriteLine("Unknown choice");
                    break;
            }
        }
    }
}
