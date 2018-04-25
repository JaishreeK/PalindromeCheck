using System;
using System.Threading;

namespace PalindromeCheck
{
    class Program
    {
        public static void Main(string[] args)
        {
            Check("abcba", true);
            Thread.Sleep(500);
            Check("abcde", false);
            Thread.Sleep(500);
            Check("Mr owl ate my metal worm", true);
            Thread.Sleep(500);
            Check("Never Odd Or Even", true);
            Thread.Sleep(500);
            Check("Never Even Or Odd", false);
            Thread.Sleep(500);
        }

        // Implement a palindrome checker to make the following test cases pass. This starter code is in C# but you are welcome to write your solution in any language
        public static bool IsPalindrome(string s)
        {
            //suppress the spaces
            s = s.Replace(" ", "");
            //suppress the caps
            s = s.ToLower();
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            string backwards = new string(array);
            return s == backwards;
        }

        public static void Check(string s, bool shouldBePalindrome)
        {
            Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
        }
    }
}
