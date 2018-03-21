using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 10, 20, 0, 59, 86, 32, 11, 9, 40 };
            Console.WriteLine("input..");
            printArray(input);
            Console.WriteLine("output...");
            ReverseArray(input);
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

        static void ReverseArray(int[] input)
        {
            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                int temp = input[i];
                input[i] = input[j];
                input[j] = temp;
            }
        }
    }
}
