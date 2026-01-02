using System;

namespace Concepts
{
    public static class DataTypes
    {
        public static void ShowExamples()
        {
            Console.WriteLine("-- Data Types --");
            int integer = 123;
            double floating = 3.1415;
            decimal money = 9.99M;
            char letter = 'A';
            string text = "Sample";
            Console.WriteLine($"int: {integer}, double: {floating}, decimal: {money}, char: {letter}, string: {text}");
            Console.WriteLine();
        }
    }
}
