using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodeweeklycontest
{
    public class Week186Solution
    {
        public static bool CanJump(int[] nums)
        {
            return false;
        }

        public static int MaxScore(int[] cardPoints, int k)
        {
            int sum = 0;
            int sumFromBack = 0;
            int counterTaken = 0;
            for(int i =0; i < cardPoints.Length -1; i++)
            {
                if(cardPoints[i] >= cardPoints[cardPoints.Length - 1 - i])
                {
                    sum += cardPoints[i];
                    counterTaken++;
                }

                if (cardPoints[cardPoints.Length - 1 - i] >= cardPoints[i + 1])
                {
                    sum += cardPoints[cardPoints.Length - 1 - i];
                    counterTaken++;
                }
                if (counterTaken == k)
                {
                    break;
                }
            }

            return sum;
        }

        public static int MaxScore1(string s)
        {
            for(int i = 0; i < s.Length; i++)
            {

            }

            return 0;
        }
    }
}
