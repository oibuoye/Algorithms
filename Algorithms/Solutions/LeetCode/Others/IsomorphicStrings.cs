using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions.LeetCode.Others
{
    public class IsomorphicStrings
    {
        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> tracker = new Dictionary<char, char>();
            StringBuilder sb = new StringBuilder(s);

            if (s.Length != t.Length)
            {
                return false;
            }

            for(int i=0; i < s.Length; i++)
            {
                char sValue = s[i];
                if (tracker.ContainsKey(sValue))
                {
                    sb[i] = tracker[sValue];
                }
                else
                {
                    char tValue = t[i];
                    if (tracker.ContainsValue(tValue))
                    {
                        return false;
                    }
                    tracker[sValue] = tValue;
                    sb[i] = tValue;
                }
            }

            if(sb.ToString() == t)
            {
                return true;
            }
            return false;
        }
    }
}
