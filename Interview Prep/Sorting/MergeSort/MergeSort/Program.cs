using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 14, 7, 3, 12, 9, 11, 6, 2 };
            Console.WriteLine("Input array is");
            PrintArray(input);
            Console.WriteLine();
            MergeSort(input, 0, input.Length - 1);
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

        static void MergeSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSort(input, low, mid);
                MergeSort(input, mid + 1, high);
                Merge(input, low, mid, high);
            }
        }

        static void Merge(int[] input, int low, int middle, int high)
        {
            int[] result = new int[high - low + 1];
            int leftIndex = low;
            int rightIndex = middle + 1;
            int resultIndex = 0;

            while (leftIndex <= middle && rightIndex <= high)
            {
                if (input[leftIndex] < input[rightIndex])
                {
                    result[resultIndex] = input[leftIndex];
                    leftIndex++;
                }
                else
                {
                    result[resultIndex] = input[rightIndex];
                    rightIndex++;
                }

                resultIndex++;
            }

            while (leftIndex <= middle)
            {
                result[resultIndex] = input[leftIndex];
                resultIndex++;
                leftIndex++;
            }

            while (rightIndex <= high)
            {
                result[resultIndex] = input[rightIndex];
                resultIndex++;
                rightIndex++;
            }

            
            for (int i = 0; i < result.Length; i++)
            {
                input[low+i] = result[i];                
            }

        }
    }
}
