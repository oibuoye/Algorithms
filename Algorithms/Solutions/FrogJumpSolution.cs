using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class FrogJumpSolution
    {
        public static int FrogJump(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int[] arrayTracker = new int[100001];
            int counter = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int getValue = arrayTracker[A[i]];
                if (getValue == 0 && counter < X)
                {
                    counter++;
                    arrayTracker[A[i]] = 1;
                    if (counter == X)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
