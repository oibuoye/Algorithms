using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class RepeatedString
    {
        public static long repeatedString(string s, long n)
        {
            ////https://www.hackerrank.com/challenges/repeated-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup

            char toCount = 'a';
            if (s.Length == 1 && s[0] == toCount)
            {
                return n;
            }else if(s.Length == 1 && s[0] == toCount)
            {
                return 0;
            }

            long aOccurrence = 0, aOccurrenceAdd =0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == toCount)
                {
                    aOccurrence++;
                }
            }

            long loopTimes = n / s.Length;
            int loopTimeRemainder = (int)(n - (loopTimes * s.Length));

            for (int i = 0; i < loopTimeRemainder; i++)
            {
                if (s[i] == toCount)
                {
                    aOccurrenceAdd++;
                }
            }

            return (aOccurrence * loopTimes) + aOccurrenceAdd;
        }

    }
}
