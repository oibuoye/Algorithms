using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class MaxArraySum
    {

        //int[] dif = { -2, 1, 3, -4, 5 };
        //MaxArraySum.maxSubsetSum(dif);

        public static int maxSubsetSum(int[] arr)
        {
            int incl = arr[0];
            int excl = 0;
            int excl_new;
            int i;
            int n = arr.Length;

            for (i = 1; i < n; i++)
            {
                /* current max excluding i */
                excl_new = (incl > excl) ? incl : excl;

                /* current max including i */
                incl = excl + arr[i];
                excl = excl_new;
            }

            /* return max of incl and excl */
            return ((incl > excl) ? incl : excl);
        }

    }
}
