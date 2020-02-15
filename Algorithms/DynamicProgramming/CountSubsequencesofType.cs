using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class CountSubsequencesofType
    {
        //Given a string s, the task is to count number of subsequences of the form aibjck, where i >= 1, j >=1 and k >= 1.

        //Note: Two subsequences are considered different if the set of array indexes picked for the 2 subsequences are different.

        public static int GetSubsequentType(string s)
        {
          return fun(s);
        }

        static int fun(string str)
        {
            int a = 0, b = 0, c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    a = 2 * a + 1;
                }
                else if (str[i] == 'b')
                {
                    b = 2 * b + a;
                }
                else if (str[i] == 'c')
                {
                    c = 2 * c + b;
                }
                else
                    continue;
            }
            return c;
        }

        public static int CheckOccurrence(int[] arr, int n)
        {
            //int[] lst = { 2, 3, 4, 3, 2, 1 };
            //int val = CountSubsequencesofType.CheckOccurrence(lst, 3);
            //Console.WriteLine(val);

            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    counter++;
                }
            }

            return counter;
        }


    }
}
