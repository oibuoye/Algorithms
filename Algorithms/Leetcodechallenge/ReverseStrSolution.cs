using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge
{
    public class ReverseStrSolution
    {
        public static string ReverseStr(string s, int k)
        {
            StringBuilder sb = new StringBuilder();
            int inc = k * 2;
            int counter = 0;

            //String length is less than k
            if(s.Length < k)
            {
                for (int i = s.Length-1; i >= 0; i--)
                {
                    sb.Append(s[i]);
                }
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    //if counter is equal to zero 
                    if (counter == 0)
                    {
                        int left = s.Length - i;
                        int maxRange = left < k ? left : k;
                        for (int j = i + maxRange - 1; j >= i; j--)
                        {
                            sb.Append(s[j]);
                        }
                        counter += k;
                        i += k - 1;
                    }
                    else
                    {
                        sb.Append(s[i]);
                        counter++;

                        if (counter == inc)
                        {
                            counter = 0;
                        }
                    }
                }
            }

            return sb.ToString();
        }
    }
}
