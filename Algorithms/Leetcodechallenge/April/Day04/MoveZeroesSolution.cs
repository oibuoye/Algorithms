using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day04
{
    public class MoveZeroesSolution
    {
        public static void MoveZeroes(int[] nums)
        {
            bool IsSwapped;
            do
            {
                IsSwapped = false;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == 0)
                    {
                        if(nums[i + 1] != 0)
                        {
                            int tempNumber = nums[i + 1];
                            nums[i + 1] = nums[i];
                            nums[i] = tempNumber;
                            IsSwapped = true;
                        }
                    }
                }
            } while (IsSwapped == true);
        }
    }
}
