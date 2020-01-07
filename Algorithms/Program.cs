using Algorithms.DynamicProgramming;
using Algorithms.Solutions;
using Algorithms.Solutions;
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

            string word = "abbc";
            CountSubsequencesofType.GetSubsequentType(word, 1);

            Console.ReadLine();
        }

    }
}
