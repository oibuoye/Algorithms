using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day15
{
    public class ProductofArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] solutions = new int[nums.Length];
            solutions[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                solutions[i] = solutions[i - 1] * nums[i - 1];
            }
            int rightProduct = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                solutions[i] = rightProduct * solutions[i];
                rightProduct *= nums[i];
            }
            return solutions;
        }
    }
}
