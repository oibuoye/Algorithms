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

        public static int maxSubsetArray1(int[] nums)
        {
            int[] solution = new int[nums.Length];
            int maxSum = nums[0];
            solution[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int max = Math.Max(nums[i], nums[i] + solution[i - 1]);
                if (max > maxSum)
                {
                    maxSum = max;
                }
                solution[i] = max;
            }
            return maxSum;
        }

        public static int maxSubsetArrayCircular(int[] nums)
        {
            int[] solutionMax = new int[nums.Length];
            int[] solutionMin = new int[nums.Length];
            int total = nums[0];
            int maxSum = nums[0];
            int minSum = nums[0];
            solutionMax[0] = nums[0];
            solutionMin[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int max = Math.Max(nums[i], nums[i] + solutionMax[i - 1]);
                int min = Math.Min(nums[i], nums[i] + solutionMin[i - 1]);
                maxSum = max > maxSum ? max : maxSum;
                minSum = min < minSum ? min : minSum;
                total += nums[i];
                solutionMax[i] = max;
                solutionMin[i] = min;
            }
            return maxSum > 0 ? Math.Max(maxSum, total -minSum) : maxSum;
        }

    }
}
