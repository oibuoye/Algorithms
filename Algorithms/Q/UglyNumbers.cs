using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Q
{
    public class UglyNumbers
    {
        public static int FindNthUglyNumber(int n)
        {
            int counter = 1;
            int i = 1;

            while(counter < n)
            {
                i++;

                if (i % 2 == 0)
                {
                    counter++;
                }
                else if (i % 3 == 0)
                {
                    counter++;
                }
                else if (i % 5 == 0)
                {
                    counter++;
                }
            }

            return i;
        }
    }
}
