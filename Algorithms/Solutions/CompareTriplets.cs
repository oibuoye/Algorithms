using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class CompareTriplets
    {
        public static List<int> CompareTripletsNum(List<int> a, List<int> b)
        {
            int aCount = 0;
            int bCount = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if( a[i] < b[i])
                {
                    bCount++;
                }
                else if( a[i] > b[i])
                {
                    aCount++;
                }
            }
            return new List<int> { aCount, bCount };
        }
    }
}
