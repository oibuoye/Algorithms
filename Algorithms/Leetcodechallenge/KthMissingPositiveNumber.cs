using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge
{
    public class KthMissingPositiveNumber
    {
        public static int FindKthPositive(int[] arr, int k)
        {
            int missingCounter = 0;
            int kthNumber = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                if (Array.IndexOf(arr, i) == -1)
                {
                    missingCounter++;
                }
                if (missingCounter == k)
                {
                    kthNumber = i;
                    break;
                }
            }
            return kthNumber;
        }
    }
}
