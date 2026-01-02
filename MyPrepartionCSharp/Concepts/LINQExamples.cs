using System;
using System.Collections.Generic;
using System.Linq;

namespace Concepts
{
    public static class LINQExamples
    {
        public static void Run()
        {
            Console.WriteLine("-- LINQ Examples --");
            var nums = new List<int> { 1, 2, 3, 4, 5, 6 };
            var evens = nums.Where(n => n % 2 == 0);
            Console.WriteLine("Even numbers: " + string.Join(", ", evens));
            var squares = nums.Select(n => n * n);
            Console.WriteLine("Squares: " + string.Join(", ", squares));
            Console.WriteLine();
        }
    }
}
