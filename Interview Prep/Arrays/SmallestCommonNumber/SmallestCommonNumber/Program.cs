using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestCommonNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { -1, 5, 6, 25, 30, 63, 64 };
            int[] input2 = { -1, 4, 5, 6, 7, 8, 50 };
            int[] input3 = { 1, 6, 10, 14 };

            int commonValue = Find(input1, input2, input3);
            Console.WriteLine(commonValue);
            Console.ReadKey();
        }

        static int Find(int[] input1, int[] input2, int[] input3)
        {            
            int ptr1 = 0;
            int ptr2 = 0;
            int ptr3 = 0;

            while (true)
            {
                if (AreValuesSame(input1[ptr1], input2[ptr2], input3[ptr3]))
                {
                    return input1[ptr1];
                }

                if (input1[ptr1] <= input2[ptr2] && input1[ptr1] <= input3[ptr3])
                {
                    if (ptr1 < input1.Length - 1)
                    {
                        ptr1 += 1;
                    }
                    else
                    {
                        return int.MinValue;
                    }
                }

                else if (input2[ptr2] <= input1[ptr1] && input2[ptr2] <= input3[ptr3])
                {
                    if (ptr2 < input2.Length - 1)
                    {
                        ptr2 += 1;
                    }
                    else
                    {
                        return int.MinValue;
                    }
                }

                else
                {
                    if (ptr3 < input3.Length - 1)
                    {
                        ptr3 += 1;
                    }
                    else
                    {
                        return int.MinValue;
                    }
                }
            }            
        }

        static bool AreValuesSame(int value1, int value2, int value3)
        {
            return value1 == value2 && value1 == value3;
        }
    }
}
