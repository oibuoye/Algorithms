using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class Abbreviation
    {
        public static string GetAbbreviation(string a, string b)
        {
            //Get the length of the string
            string aCopy = a;
            for(int i = 0; i < a.Length; i++)
            {
                char ret = a[i];
                if (CheckEquivalent(aCopy, b))
                {
                    return "YES";
                }

                //convert to upper case


                aCopy.Remove(i, 1);
                if (!CheckEquivalent(aCopy, b))
                {
                    
                }

            }


            return string.Empty;
        }

        public static bool CheckEquivalent(string a, string b)
        {
            return a == b;
        }

    }
}
