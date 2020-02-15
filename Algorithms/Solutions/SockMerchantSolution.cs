using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class SockMerchantSolution
    {
        public static int sockMerchant(int n, int[] ar)
        {
            Dictionary<int, int> socks = new Dictionary<int, int>();
            int pairCounter = 0;
            for (int i = 0; i < n; i++)
            {
                if (socks.ContainsValue(ar[i]))
                {
                    pairCounter++;
                    socks.Remove(ar[i]);
                }
                else
                {
                    socks[ar[i]] = ar[i];
                }
            }
            return pairCounter;
        }
    }
}
