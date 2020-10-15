using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.October.Day01
{
    public class RecentCounter
    {
        List<int> request;
        public RecentCounter()
        {
            request = new List<int>();
        }

        public int Ping(int t)
        {
           request.Add(t);
           return request.Where(x => x >= (t - 3000) && x <= t).Count();
        }
    }
}
