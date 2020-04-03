using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day03
{
    class MaximumSubarraySolution
    {
        public static int maxSubsetArray(int[] nums)
        {
            int[] solution = new int[nums.Length];
            int maxSum = nums[0];
            solution[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                solution[i] = (solution[i - 1] < nums[i] && solution[i - 1] < 0) ? nums[i] : nums[i] + solution[i - 1];
                if (solution[i] > maxSum)
                {
                    maxSum = solution[i];
                }
            }
            return maxSum;
        }
    }
}
