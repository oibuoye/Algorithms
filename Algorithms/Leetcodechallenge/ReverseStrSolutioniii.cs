using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge
{
    public class ReverseStrSolutioniii
    {
        public static string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder();

            string[] newWord = s.Split(' ');

            for (int i = 0; i < newWord.Length; i++)
            {
                string word = newWord[i];

                for(int j = word.Length-1; j >= 0; j--)
                {
                    sb.Append(word[j]);
                }

                if(i != newWord.Length - 1)
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}
