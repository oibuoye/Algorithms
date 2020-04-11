using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day09
{
    public class BackspaceStringCompare
    {
        public static bool BackspaceCompare(string S, string T)
        {
            List<string> char_s = new List<string>();
            List<string> char_t = new List<string>();
            int length = S.Length > T.Length ? S.Length : T.Length;

            for (int i = 0; i < length; i++)
            {
                if(i < S.Length)
                {
                    if (S[i].ToString() == "#")
                    {
                        if (char_s.Count > 0)
                        {
                            char_s.RemoveAt(char_s.Count - 1);
                        }
                    }
                    else
                    {
                        char_s.Add(S[i].ToString());
                    }
                }

                if(i < T.Length)
                {
                    if (T[i].ToString() == "#")
                    {
                        if(char_t.Count > 0)
                        {
                            char_t.RemoveAt(char_t.Count - 1);
                        }
                    }
                    else
                    {
                        char_t.Add(T[i].ToString());
                    }
                }
            }

            if(string.Join("", char_s) == string.Join("", char_t))
            {
                return true;
            }
            return false;
        }

    }
}
