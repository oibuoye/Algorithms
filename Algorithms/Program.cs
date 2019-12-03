using Algorithms.Q;
using Algorithms.VanHack;
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

            var affected = new List<int>() { 1, 2 };
            var poisonous = new List<int>() { 3, 5 };
            int n = 5;

            long result = BiologicalHazards.BioHazardSol2(n, affected, poisonous);

            Console.ReadLine();
        }

    }
}
