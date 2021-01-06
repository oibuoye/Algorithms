using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.October.Day14
{
    public class HouseRobberII
    {
        public static int Rob(int[] nums)
        {
            //Solution 1
            //If the length of the array is old, set the first and last neighbour to zero
            if(nums.Length%2 != 0 && nums.Length > 1)
            {
                if(nums[0] > nums[nums.Length - 1])
                {
                    nums[nums.Length - 1] = 0;
                }
                else
                {
                    nums[0] = 0;
                }
            }

            int oddSummation = 0;
            int evenSummation = 0;
            int n = nums.Length;
            bool switches = false;

            for (int i = 0; i < n; i++)
            {
                if (switches)
                {
                    evenSummation += nums[i];
                    switches = false;
                }
                else
                {
                    oddSummation += nums[i];
                    switches = true;
                }
            }

            /* return max of incl and excl */
            return ((oddSummation > evenSummation) ? oddSummation : evenSummation);
        }

    }
}
