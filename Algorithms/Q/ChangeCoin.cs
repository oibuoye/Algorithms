using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Q
{
    public class ChangeCoin
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static int change(int amount, int[] v)
        {
            int[,] solution = new int[v.Length + 1, amount + 1];

            // if amount is 0, it willt return empty set to make the change
            // if no coins given, 0 ways to change the amount

            for (int i = 0; i <= v.Length; i++)
            {
                solution[i,0] = 1;
            }

            for (int i = 1; i <= amount; i++)
            {
                solution[0,i] = 0;
            }

            // now fill rest of the matrix.
            for (int i = 1; i <= v.Length; i++)
            {
                for (int j = 1; j <= amount; j++)
                {
                    // check if the coin value is less than the amount needed
                    if (v[i - 1] <= j)
                    {
                        // reduce the amount by coin value and
                        // use the subproblem solution (amount-v[i]) and
                        // add the solution from the top to it
                        solution[i,j] = solution[i - 1,j]
                                + solution[i,j - v[i - 1]];
                    }
                    else
                    {
                        solution[i,j] = solution[i - 1,j];
                    }
                }
            }
            return solution[v.Length,amount];
        }
    }
}
