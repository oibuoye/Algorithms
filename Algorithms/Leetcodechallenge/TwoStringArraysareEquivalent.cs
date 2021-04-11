using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge
{
    public class TwoStringArraysareEquivalent
    {
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            int highestLen = word1.Length > word2.Length ? word1.Length : word2.Length;

            for (int i = 0; i < highestLen; i++)
            {
               sb1.Append(word1[i]);
            }
            for (int i = 0; i < word2.Length; i++)
            {
                sb2.Append(word2[i]);
            }

            if (sb1.ToString() == sb2.ToString())
            {
                return true;
            }

            return false;
        }
    }
}
