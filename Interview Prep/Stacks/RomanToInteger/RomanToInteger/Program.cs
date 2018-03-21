using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.RomanToInt("DCXXI"));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public static int RomanToInt(string s)
        {
            int result = 0;
            int current = 0;
            int prev = 0;

            Stack<char> stack = new Stack<char>();
            foreach(char ch in s)
            {
                stack.Push(ch);
            }
            
            while(stack.Count > 0)
            {
                char c = stack.Pop();
                switch(c)
                {
                    case 'M':
                        current = 1000;
                        break;
                    case 'C':
                        current = 100;
                        break;
                    case 'D':
                        current = 500;
                        break;
                    case 'L':
                        current = 50;
                        break;
                    case 'X':
                        current = 10;
                        break;                    
                    case 'V':
                        current = 5;
                        break;
                    case 'I':
                        current = 1;
                        break;
                    default:
                        current = -1;
                        break;

                }

                if (current > 0)
                {
                    if (current >= prev)
                    {
                        result += current;
                    }
                    else
                    {
                        result -= current;
                    }

                    prev = current;
                }
            }

            return result;
        }
    }
}
