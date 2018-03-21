using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 2,1 };
            Console.WriteLine("Input array is");
            PrintArray(input);
            Console.WriteLine();

            MoveZeros(input);
            Console.WriteLine("Modified Output is ");
            PrintArray(input);
            Console.WriteLine();
            Console.WriteLine("done...");
            Console.ReadKey();

        }

        static void PrintArray(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }

        public static void MoveZeros(int[] nums)
        {
            int insertIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (insertIndex != i)
                    {
                        nums[insertIndex] = nums[i];
                        nums[i] = 0;
                    }
                    insertIndex++;
                }
            }
        }
    }
}
