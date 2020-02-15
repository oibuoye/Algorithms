using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion
{
    public static class SimpleRecursivePro
    {
        public static void printFun(int test)
        {
            if (test < 1)
                return;
            else
            {
                Console.Write(test + " ");

                // statement 2 
                printFun(test - 1);

                Console.Write(test + " te ");
                return;
            }
        }

        public static void printStar(int n)
        {
            int i = 0;
            if (n > 1)
                printStar(n - 1);
            for (i = 0; i < n; i++)
                Console.Write(" * ");
        }

    }
}
