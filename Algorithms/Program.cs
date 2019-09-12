using Algorithms.Q;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int d = 2;
            int[] result1 = ArrayOperation.ArrayRotation(arr, d);


            int result = UglyNumbers.FindNthUglyNumber(7);

            Console.ReadLine();

        }

    }
}
