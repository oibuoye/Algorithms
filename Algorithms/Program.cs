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
            var list1 = new List<int>() { 1, 0, 1, 1, 1 };
            var list2 = new List<int>() { 1, 0, 1, 1, 0 };
            var list3 = new List<int>() { 1, 1, 1, 1, 0 };
            var list4 = new List<int>() { 1, 1, 1, 1, 0 };
            var list5 = new List<int>() { 1, 1, 1, 1, 1 };
            var numbers = new List<List<int>>();
            numbers.Add(list1);
            numbers.Add(list2);
            numbers.Add(list3);
            numbers.Add(list4);
            numbers.Add(list5);
            int result = ImageEditing.largestMatrix(numbers);

            Console.ReadLine();
        }

    }
}
