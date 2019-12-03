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

            string firstDate = "1-January-2000";
            string lastDate = "22-February-2000";
            string weekDay = "Monday";
            StockPrices.openAndClosePrices(firstDate, lastDate, weekDay);

            Console.ReadLine();
        }

    }
}
