using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 4, 6, 10, 11, 15 };
            int[] alicesArray = { 1, 5, 8, 12, 14, 19 };
            int[] mergedArray = Merge(myArray, alicesArray);
        }

        static int[] Merge(int[] input1, int[] input2)
        {
            int[] mergedArray = new int[input1.Length + input2.Length];
            int resultIndex = 0;
            int minLength;
            int ptr1 = 0;
            int ptr2 = 0;

            if (input1.Length <= input2.Length)
            {
                minLength = input1.Length;
            }
            else
            {
                minLength = input2.Length;
            }

            while (ptr1 < minLength && ptr2 < minLength)
            {
                if (input1[ptr1] <= input2[ptr2])
                {
                    mergedArray[resultIndex++] = input1[ptr1++];
                }
                else
                {
                    mergedArray[resultIndex++] = input2[ptr2++];
                }
            }

            if (ptr1 == minLength)
            {
                while (ptr2 < input2.Length)
                {
                    mergedArray[resultIndex++] = input2[ptr2++];
                }
            }
            if (ptr2 == minLength)
            {
                while (ptr1 < input1.Length)
                {
                    mergedArray[resultIndex++] = input1[ptr1++];
                }
            }           

            return mergedArray;
        }
    }
}
