using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions.LeetCode.Others
{
    public class MedianFinder
    {
        List<int> values = null;
        public MedianFinder()
        {
            values = new List<int>();
        }

        public void AddNum(int num)
        {
            values.Add(num);
        }

        public double FindMedian()
        {
            int itemCount = values.Count;

            if(itemCount%2 == 0)
            {
                int midIndex = itemCount / 2;
                double total = values[midIndex - 1] + values[midIndex];
                double median = total / 2;
                return median;
            }
            else
            {
                int midIndex = ((itemCount + 1) / 2) - 1;
                return values[midIndex];
            }
        }
    }
}
