using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class HurdleRace
    {
        // Complete the hurdleRace function below.
        public static int hurdleRace(int k, int[] height)
        {            
            return k >= height.Max() ? 0 : height.Max() - k;
        }
    }
}
