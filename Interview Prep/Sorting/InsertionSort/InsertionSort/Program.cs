using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 14, 7, 3, 12, 9, 11, 6, 2 };
            Console.WriteLine("Input array is");
            PrintArray(input);
            Console.WriteLine();

            InsertionSort(input);
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

        static void InsertionSort(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                int temp = input[i];
                int marker = i;

                while (marker > 0 && input[marker - 1] > temp)
                {
                    input[marker] = input[marker - 1];
                    marker--;
                }

                input[marker] = temp;
            }
        }

    }
}
