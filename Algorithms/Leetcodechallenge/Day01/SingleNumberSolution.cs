using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day01
{
    class SingleNumberSolution
    {
        //https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/528/week-1/3283/

        public static int SingleNumber(int[] nums)
        {
            return nums.Aggregate((a, b) => a ^ b);
        }

        public static int SingleNumberSol2(int[] nums)
        {
            Dictionary<int, int> intValues = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (intValues.ContainsKey(nums[i]))
                {
                    intValues.Remove(nums[i]);
                }
                else
                {
                    intValues.Add(nums[i], nums[i]);
                }
            }
            return intValues.Values.FirstOrDefault();
        }
    }
}
