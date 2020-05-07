using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day22
{
    public class SubarraySumEqualsK
    {
        public static int SubarraySum(int[] nums, int k)
        {
            int solution = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int val = nums[i];
                if(k >= val)
                {
                    if (Found(nums, i + 1, k - val))
                    {
                        solution++;
                    }
                }
            }

            return solution;
        }

        public static bool Found(int[] arr, int startIndex, int num)
        {
            for(int i = startIndex; i < arr.Length; i++)
            {
                if(arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
