using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge
{
    public class Contest311Solution
    {
        public static int SmallestEvenMultiple(int n)
        {
            if(n%2 == 0)
            {
                return n;
            }
            return n * 2;
        }

        public static int longestSubstringCharacters(string s)
        {
            int stLength = s.Length, max = 0, currentMax = 0;

            if (s.Length == 1) return s.Length;
            max = currentMax = 1;
            for (int i = 1; i < stLength; i++)
            {
                if(s[i] > s[i - 1] && s[i] == s[i - 1] + 1)
                {
                    currentMax++;
                    max = Math.Max(max, currentMax);
                }
                else
                {
                    currentMax = 1;
                }
            }
            return max;
        }

        public static int[] SumPrefixScores(string[] words)
        {
            int[] result = new int[words.Length];
            Dictionary<string, int> tracker = new Dictionary<string, int>();
            ArrayList subArray = new ArrayList();
            for(int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < word.Length; j++)
                {
                    sb.Append(word[j]);
                    subArray.Add(sb.ToString());
                    if (tracker.ContainsKey(sb.ToString()))
                    {
                        tracker[sb.ToString()] += 1;
                    }
                    else
                    {
                        tracker[sb.ToString()] = 1;
                    }
                }
            }

            for (int i = 0; i < subArray.Count; i++)
            {
                string word = words[i];
                StringBuilder sb = new StringBuilder();
                int sum = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    sb.Append(word[j]);
                    sum += tracker[sb.ToString()];
                }
                result[i] = sum;
            }

            return result;
        }
    }
}
