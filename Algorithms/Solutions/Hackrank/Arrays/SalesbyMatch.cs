using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions.Hackrank.Arrays
{
    public class SalesbyMatch
    {
        //https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        public static int sockMerchant(int n, List<int> ar)
        {
            Dictionary<int, int> tracker = new Dictionary<int, int>();
            int pairCounter = 0;
            for(int i =0; i < ar.Count; i++)
            {
                if (tracker.ContainsKey(ar[i]))
                {
                    tracker[ar[i]] += 1;
                    if (tracker[ar[i]] %2 == 0)
                    {
                        pairCounter++;
                        tracker[ar[i]] = 0;
                    }
                }
                else
                {
                    tracker[ar[i]] = 1;
                }
            }
            return pairCounter;
        }
    }
}
