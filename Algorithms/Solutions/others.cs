using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class others
    {
        public static int Factorial(int n)
        {
            int fact = 1;
           for(int i = n; i>=1; i--)
            {
                fact *= i;
            }
            return fact;
        }


        public static int RecursiveFactorial(int n)
        {
            //int ret = others.RecursiveFactorial(4);


            //if (n <= 1)
            //    return 1;
            //return n * RecursiveFactorial(n - 1);

            if (n <= 1)
                return 1;
            int val = n * RecursiveFactorial(n - 1);

            return val;
        }

        public static int[][] rotateImage(int[][] a)
        {

            //int[][] a =
            //{
            //    new int[] {1, 2, 3},
            //    new int[] {4, 5, 6},
            //    new int[] { 7, 8, 9 }
            //};
            //int[][] ret = others.rotateImage(a);


            //[[1, 2, 3],
            // [4, 5, 6],
            // [7, 8, 9]]

            //[[7, 4, 1],
            // [8, 5, 2],
            // [9, 6, 3]]
            int n = a.Length;

            for(int i =0; i< n; i++)
            {
                for(int j = 0; j <n; j++)
                {
                    int val = a[i][j];
                }
            }
            return a;
        }
    }
}
