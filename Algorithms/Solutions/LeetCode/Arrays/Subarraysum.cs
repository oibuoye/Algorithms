using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions.LeetCode.Arrays
{
    public class Subarraysum
    {
        public static int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> sumTracker = new Dictionary<int, int>();
            sumTracker[nums[0]] = 1;
            sumTracker[nums[nums.Length - 1]] = 1;
            for(int i = 0; i < nums.Length-1; i++)
            {
                for(int j=1; j < nums.Length; j++)
                {

                }
            }
            return sumTracker[k];
        }
    }
}
