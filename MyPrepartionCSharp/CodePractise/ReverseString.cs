using System;

namespace Practise
{
    public static class ReverseString
    {
        public static string Reverse(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            var chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
