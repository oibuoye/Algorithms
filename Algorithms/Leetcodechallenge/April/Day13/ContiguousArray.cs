using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day13
{
    public class ContiguousArray
    {
        public static int FindMaxLength(int[] nums)
        {
            int countOne = 0;
            int countZero = 0;
            int maxSubArray = 0;
            int[] save = new int[nums.Length];

            for (int i =0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    countZero++;
                }
                else
                {
                    countOne++;
                }

                if (countZero == countOne)
                {
                    maxSubArray = countZero * 2;
                }
                save[i] = maxSubArray;
            }
            return maxSubArray;
        }
    }
}
