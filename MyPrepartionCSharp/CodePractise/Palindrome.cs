using System;
using System.Linq;

namespace Practise
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            if (s == null) return false;
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (s[i] != s[j]) return false;
                i++;
                j--;
            }
            return true;
        }

    }
}
