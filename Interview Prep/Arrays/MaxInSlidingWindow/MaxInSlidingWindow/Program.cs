using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxInSlidingWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 3, -1, -3, 5, 3, 6, 7 };
            int windowSize = 3;
            int[] result = FindMax(input, windowSize);
            printArray(result);
            Console.WriteLine();
            Console.WriteLine("done...");
            Console.ReadKey();
        }

        static void printArray(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }

        static int[] FindMax(int[] input, int windowSize)
        {
            LinkedList<int> list = new LinkedList<int>();
            List<int> maxValues = new List<int>();
            int currentWinSize = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (list.Count == 0)
                {
                    list.AddFirst(i);
                }
                else
                {
                    while (list.Count > 0 && input[list.Last.Value] < input[i])
                    {
                        list.RemoveLast();
                    }

                    list.AddLast(i);
                }

                currentWinSize += 1;

                if (currentWinSize == windowSize)
                {
                    if (i - windowSize >= list.First.Value)
                    {
                        list.RemoveFirst();
                    }
                    maxValues.Add(input[list.First.Value]);
                    currentWinSize -= 1;
                }

            }

            return maxValues.ToArray();
        }
    }
}
