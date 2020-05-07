using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class FindMinFibonacciNumbersSolution
    {
        public static int FindMinFibonacciNumbers(int k)
        {
            ArrayList fib = new ArrayList();
            fib.Insert(fib.Count, 0);
            fib.Insert(fib.Count, 1);
            fib.Insert(fib.Count, 1);
            int solution = 0;
            int val = 1;

            while (val <= k)
            {
                int count = fib.Count;
                int addition = (int)fib[count - 1] + (int)fib[count - 2];
                fib.Insert(count, addition);
                val = addition;
            }

            for (int i = fib.Count - 1; i >= 0; i--)
            {
                if ((int)fib[i] == k)
                {
                    solution++;
                    return solution;
                }
                else if ((int)fib[i] < k)
                {
                    solution++;
                    k -= (int)fib[i];
                }
            }
            return solution;
        }
    }
}
