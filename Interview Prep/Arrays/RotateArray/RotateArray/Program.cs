using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = { 1, 10, 20, 0, 59, 86, 32, 11, 9, 40 };
            int[] input = { -1 };
            Console.WriteLine("input..");
            printArray(input);
            int rotations = 2;
            RotateArray(input, rotations);
            Console.WriteLine($"output after {rotations} rotations...");
            printArray(input);
            Console.ReadKey();
        }

        static void printArray(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]} ");
            }

            Console.WriteLine();
        }

        static void RotateArray(int[] input, int rotations)
        {
            rotations = rotations % input.Length;

            if (rotations < 0)
            {
                rotations = rotations + input.Length;
            }
            ReverseArray(input, 0, input.Length - 1);
            ReverseArray(input, 0, rotations - 1);
            ReverseArray(input, rotations, input.Length - 1);
        }

        static void ReverseArray(int[] input, int start, int end)
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
