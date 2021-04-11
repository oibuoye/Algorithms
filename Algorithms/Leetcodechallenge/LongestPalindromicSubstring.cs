using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge
{
    public class LongestPalindromicSubstring
    {
        public static string LongestPalindrome(string s)
        {
            if (s == null || s.Length < 1) return "";
            int padLen = 0;
            string sPadLen = "";
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int L = i - 1, R = i + 1;
                if (i >= 0 && i < s.Length && s[L] == s[R])
                {
                    while(L >= 0)
                    {

                        L--;
                        R++;

                    }
                }

            }
            return s.Substring(start, end);
        }

        private static int expandAroundCenter(string s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }
    }
}
