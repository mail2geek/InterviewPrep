using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowHighIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 5, 5, 5, 5, 5, 5, 5, 5, 20 };
            PrintLowHigh(input);
            Console.ReadKey();
        }

        static void PrintLowHigh(int[] input)
        {
            int key = 1;
            int lowIndex = BinarySearch_Iterative(input, key, 0, input.Length - 1, true);
            int highIndex = BinarySearch_Iterative(input, key,  0, input.Length - 1, false);

            Console.WriteLine($"Low index : {lowIndex}, High Index : {highIndex}");
        }

        static int BinarySearch_Iterative(int[] input, int key, int low, int high, bool findLow)
        {
            bool found = false;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (input[mid] == key)
                {
                    found = true;

                    if (findLow)
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                else
                {
                    if (input[mid] < key)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
                
            }

            if (found)
            {
                return findLow ? low : high;
            }

            return -1;
        }

    }
}
