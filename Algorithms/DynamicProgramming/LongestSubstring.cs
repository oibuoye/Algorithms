using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestSubstring
    {
        public static int longestSubstringCharacters(string value)
        {
            int stLength = value.Length, ans =0;
            int[] index = new int[128];

            for (int i = 0, j=0; i < stLength; i++)
            {
                int ret = value[i];
                j = Math.Max(index[ret], j);
                ans = Math.Max(ans, i - j + 1);
                index[ret] = i + 1;
            }

            return ans;
        }

    }
}
