using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class FrogJumpLeaveSolution
    {
        public int Jump(int X, int[] A, int N)
        {
            int retVal = -1;
            bool found = false;

            if (A.Length > 0)
            {

                for (int i = 2; i < A.Length; i++)
                {
                    var missing = Enumerable.Range(1, i).Except(A);

                    if (missing.ToList().Count < 1)
                    {
                        if (found == false)
                        {
                            if (A[i] == X)
                            {
                                retVal = i;
                                found = true;
                            }
                        }
                    }
                }

            }
            else
            {
                retVal = -1;
            }

            return retVal;
        }

    }
}
