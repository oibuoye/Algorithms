using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class WaysToSumSolution
    {
        public static int ways(int total, int k)
        {
            int[] arrayIntegerToconsider = new int[k];
            for (int i = 0; i < k; i++)
            {
                arrayIntegerToconsider[i] = i + 1;
            }

            int[,] solution = new int[arrayIntegerToconsider.Length + 1, total + 1];

            for (int i = 0; i <= arrayIntegerToconsider.Length; i++)
            {
                solution[i, 0] = 1;
            }

            for (int i = 1; i <= total; i++)
            {
                solution[0, i] = 0;
            }

            for (int i = 1; i <= arrayIntegerToconsider.Length; i++)
            {
                for (int j = 1; j <= total; j++)
                {
                    if (arrayIntegerToconsider[i - 1] <= j)
                    {
                        solution[i, j] = solution[i - 1, j]
                                + solution[i, j - arrayIntegerToconsider[i - 1]];
                    }
                    else
                    {
                        solution[i, j] = solution[i - 1, j];
                    }
                }
            }
            return solution[arrayIntegerToconsider.Length, total];
        }
    }
}
