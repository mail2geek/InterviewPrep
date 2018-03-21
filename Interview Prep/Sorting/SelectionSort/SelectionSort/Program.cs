using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 14, 7, 3, 12, 9, 11, 6, 2 };
            Console.WriteLine("Input array is");
            PrintArray(input);
            Console.WriteLine();

            SelectionSort(input);
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

        static void SelectionSort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[minIndex] > input[j])
                    {
                        minIndex = j;
                    }
                }

                Swap(input, minIndex, i);
            }
        }

        static void Swap(int[] input, int i, int j)
        {
            int temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }
    }
}
