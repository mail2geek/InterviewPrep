using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 14, 7, 3, 12, 9, 11, 6, 2 };
            Console.WriteLine("Input array is");
            PrintArray(input);
            Console.WriteLine();

            BubbleSort(input);
            Console.WriteLine("Sorted Output is ");
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

        static void BubbleSort(int[] input)
        {
            for (int pass = 0; pass < input.Length - 1; pass++)
            {
                for (int i = 0; i < input.Length - pass - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                    }
                }
            }
        }
    }
}
