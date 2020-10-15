using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day25
{
    public class JumpGameSolution
    {
        public static bool CanJump(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }

            if (nums[0] == 0)
            {
                return false;
            }

            int coveredIndex = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int maxJump = nums[i];
                if (maxJump == 0 && coveredIndex <= i)
                {
                    return false;
                }
                coveredIndex = coveredIndex < i + maxJump ? i + maxJump : coveredIndex;

                int result = nums[i] - (nums.Length - i - 1);
                if (result >= 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CanJump1(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }

            if (nums[0] == 0)
            {
                return false;
            }

            bool hasJump = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int maxJump = nums[i];
                if (maxJump == 0 && !hasJump)
                {
                    return false;
                }
                bool hasValidMove = HasValidMove(nums, i, maxJump);
                hasJump = true;

                if (hasValidMove)
                {
                    int result = nums[i] - (nums.Length - i - 1);
                    if (result >= 0)
                    {
                        return true;
                    }
                }
                else
                {
                    int result = nums[i] - (nums.Length - i - 1);
                    if (result >= 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        public static bool HasValidMove(int[] nums, int currentIndex, int maxJump)
        {   
            bool hasValidMove = false;
            int jValue = 0;
            for (int j = currentIndex + 1; j <= maxJump + currentIndex && j < nums.Length; j++)
            {
                jValue = j;
                if (nums[j] != 0)
                {
                    hasValidMove = true;
                    break;
                }
            }

            if (!hasValidMove && jValue != (maxJump + currentIndex))
            {
                hasValidMove = true;
            } 
            return hasValidMove;
        }

    }
}
