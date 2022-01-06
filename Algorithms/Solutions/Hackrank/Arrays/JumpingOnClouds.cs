using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions.Hackrank.Arrays
{
    public class JumpingOnClouds
    {
        public static int jumpingOnClouds(List<int> c)
        {
            int jumpCounter = 0;
            bool hasActiveJump = false;

            for(int i =1; i < c.Count; i++)
            {
                if (c[i] == 1)
                {
                    hasActiveJump = true;
                }
                else
                {
                    if (hasActiveJump)
                    {
                        jumpCounter++;
                        hasActiveJump = false;
                    }
                    else if (i < c.Count -1 && c[i + 1] == 0)
                    {
                        hasActiveJump = true;
                    }
                    else
                    {
                        jumpCounter++;
                    }
                }
            }

            return jumpCounter;
        }
    }
}
