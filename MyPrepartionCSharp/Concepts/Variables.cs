using System;

namespace Concepts
{
    public static class Variables
    {
        public static void ShowExamples()
        {
            Console.WriteLine("-- Variables & Declarations --");
            int x = 10;
            string text = "Hello Concepts";
            bool flag = true;
            var inferred = 3.14;
            Console.WriteLine($"int x = {x}, string text = {text}, bool flag = {flag}, var inferred = {inferred}");
            Console.WriteLine();
        }
    }
}
