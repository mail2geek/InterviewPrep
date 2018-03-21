using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.Reverse(-153));
            Console.WriteLine("done..");
            Console.ReadKey();
        }

        public class Solution
        {
            public static int Reverse(int x)
            {   
                long reverseNumber = 0;
                while (x != 0)
                {                    
                    int remaining = x % 10;
                    reverseNumber = reverseNumber * 10 + x%10;
                    x = x / 10;

                    if (reverseNumber > Int32.MaxValue || reverseNumber <= Int32.MinValue)
                        return 0;
                }                

                return (int)reverseNumber;
            }
        }
    }
}
