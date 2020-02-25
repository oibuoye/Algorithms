using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class JumpingontheClouds
    {
        public static int jumpingOnClouds(int[] c)
        {
            int minimumCounter = 0;
            bool isLastJump = false;
            for (int i = 1; i < c.Length; i++)
            {
                if (c[i] == 0 && isLastJump == true)
                {
                    minimumCounter++;
                    isLastJump = false;
                }
                else
                {
                    if( i != c.Length - 1)
                    {
                        if (c[i + 1] == 1)
                        {
                            minimumCounter++;
                        }
                    }
                    isLastJump = true;
                }
            }
            return minimumCounter;
        }
    }
}
