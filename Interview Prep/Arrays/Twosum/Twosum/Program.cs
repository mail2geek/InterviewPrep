using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twosum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = Solution.TwoSumOptimized(new int[] { 3,3,2,4 }, 7);
            
            if (result != null)
            {
                for(int i=0;i<result.Length;i++)
                {
                    Console.Write(result[i] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("done...");
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length ; j++)
                {
                    if ((target - nums[i]) == nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return null;

        }

        public static int[] TwoSumOptimized(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { i, dict[complement] };
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }

            return null;
        }
    }
}
