using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class Fibonacci
    {
        public static int fib(int n)
        {
                        //int fibval = Fibonacci.fib(4);

            if (n <= 1)
                return n;
            int result = fib(n - 1) + fib(n - 2);

            return result;
        }

        public static int dynfib(int n)
        {
            return 1;
        }

    }
}
