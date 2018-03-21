using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.IsPalindrome(-1221));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            long reverseNumber = 0;
            int input = x;
            while (x != 0)
            {
                int remaining = x % 10;
                reverseNumber = reverseNumber * 10 + x % 10;
                x = x / 10;

                if (reverseNumber > Int32.MaxValue || reverseNumber <= Int32.MinValue)
                    reverseNumber = 0;
            }

            return reverseNumber == input;
        }
    }
}
