using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class MakeArrayConsecutive_MissingNumbers_
    {
        public static int MissingNumbers(int[] inputArray)
        {

            return Enumerable.Range(inputArray.Min(), ((inputArray.Max()- inputArray.Min()) + 1)).Except(inputArray).Count();
        }

    }
}
