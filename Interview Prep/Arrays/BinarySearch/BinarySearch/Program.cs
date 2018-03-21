using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 10, 20, 47, 59, 63, 75, 88, 99, 107, 120, 133, 152, 162, 176, 188, 199, 200, 210, 222 };
            //int index = BinarySearch(input, 147, 0, input.Length - 1);
            int index = BinarySearch_Iterative(input, 210, 0, input.Length - 1);
            Console.WriteLine($"Index is {index}");
            Console.ReadKey();
        }

        static int BinarySearch(int[] input, int key, int low, int high)
        {
            if (low > high)
                return -1;

            int mid = (low + high) / 2;

            if (input[mid] == key)
                return mid;

            if (input[mid] < key)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }

            return BinarySearch(input, key, low, high);
        }

        static int BinarySearch_Iterative(int[] input, int key, int low, int high)
        {
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (input[mid] == key)
                    return mid;

                if (input[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }
    }
}
