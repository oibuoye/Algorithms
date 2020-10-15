using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day19
{
    public class SearchinRotatedSortedArray
    {
        public static int Search(int[] nums, int target)
        {
            for(int i =0; i < nums.Length; i++)
            {
                if(nums[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
