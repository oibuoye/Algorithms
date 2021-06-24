using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions.LeetCode.Arrays
{
    public class NumberofMatchingSubsequences
    {
        public static int NumMatchingSubseq(string s, string[] words)
        {
            int counter = 0;
            for(int i =0; i < words.Length; i++)
            {
                string currentWord = words[i];
                int startingPoint = 0;
                bool statusTracker = false;
                int wordFoundCounter = 0;
                for (int j=0; j < currentWord.Length; j++)
                {
                    for(int k = startingPoint; k < s.Length; k++)
                    {
                        if(currentWord[j] == s[k])
                        {
                            wordFoundCounter++;
                            statusTracker = true;
                            startingPoint = k + 1;
                            break;
                        }
                    }
                }
                if (statusTracker && wordFoundCounter == currentWord.Length)
                {
                    counter++;
                }
            }
            return counter;
        }

     
    }
}
