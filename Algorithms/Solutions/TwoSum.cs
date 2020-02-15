using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class TwoSum
    {
        public static int[] TwoSu(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j=i+1; j < nums.Length; j++)
                {
                    if((nums[i] + nums[j]) == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("Condition not met");
        }

    }
}
