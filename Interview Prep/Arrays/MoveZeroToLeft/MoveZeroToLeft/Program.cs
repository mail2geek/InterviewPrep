using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeroToLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = { 1, 10, 20, 0, 59, 63, 0, 88, 0 };
            int[] input = { 1, 10, 20, 59, 63, 88 };
            MoveZeroToLeft(input);
        }

        static void MoveZeroToLeft(int[] input)
        {
            int lastIndex = 0;
            int zeroCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 0)
                {
                    if (lastIndex != i)
                    {
                        int temp = input[i];
                        input[i] = 0;
                        input[lastIndex] = temp;
                    }
                    lastIndex++;
                }
                else
                {
                    zeroCount++;
                }
            }

            if (zeroCount > 0)
            {
                Reverse(input, 0, input.Length - 1);
                Reverse(input, zeroCount, input.Length - 1);
            }
        }

        static void Reverse(int[] input, int start, int end)
        {
            for (int i = start, j = end; i < j; i++, j--)
            {
                int temp = input[i];
                input[i] = input[j];
                input[j] = temp;
            }
        }
    }
}
