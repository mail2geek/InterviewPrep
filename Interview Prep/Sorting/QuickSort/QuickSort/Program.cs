using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 7, 2, 1, 6, 8, 5, 3, 4 };
            Console.WriteLine("Input array is : ");
            Print(inputArray);
            Console.WriteLine();
            QuickSort(inputArray, 0, inputArray.Length - 1);
            Console.WriteLine("Sorted array is : ");
            Print(inputArray);
            Console.WriteLine();
            Console.ReadKey();
        }

        static void Print(int[] input)
        {
            for(int i=0; i< input.Length;i++)
            {
                Console.Write(input[i] + " ");
            }
        }

        static void QuickSort(int[] input, int start, int end)
        {
            if (start < end)
            {
                int partitionIndex = Partition(input, start, end);
                QuickSort(input, start, partitionIndex - 1);
                QuickSort(input, partitionIndex + 1, end);
            }
        }

        static int Partition(int[] input, int start, int end)
        {
            Random rnd = new Random();
            int rndIndex = rnd.Next(start, end + 1);
            Swap(input, rndIndex, end);
            int pivot = input[end];
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
                if (input[i] <= pivot)
                {
                    Swap(input, i, pIndex);
                    pIndex++;
                }
            }

            Swap(input, end, pIndex);

            return pIndex;
        }

        static void Swap(int[] input, int idx1, int idx2)
        {
            int temp = input[idx1];
            input[idx1] = input[idx2];
            input[idx2] = temp;
        }
    }
}
