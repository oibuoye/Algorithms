using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge
{
    public class OpentheLock
    {
        public static int OpenLock(string[] deadends, string target)
        {
            return 0;
        }

        public static string solution(string S, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int minLetter = S[0];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < S.Length - 1; i++)
            {
                if(S[i+1] < S[i])
                {
                    sb[i] = S[i+1];
                    sb[i+1] = S[i];
                }
            }

            return sb.ToString();
        }
    }
}
