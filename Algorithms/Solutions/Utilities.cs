using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class Utilities
    {
        public static IEnumerable<int> GetMissingNumbersWithinARange()
        {
            //This will look at the missing numbers starting from zero counting to ten numbers
            int[] numbers = { 1, 4, 5, 6, 8, 3 };
            return Enumerable.Range(0, 10).Except(numbers);
        }

        public static void ReturnKeyWithHighestValueInDictionary()
        {
            //Dictionary<int, int> keyValues = new Dictionary<int, int>();
            //keyValues[1] = 2;
            //keyValues[2] = 5;
            //keyValues[3] = 1;
            //keyValues[4] = 3;

            int[] inputArray = { 2, 3, 3, 1, 2, 5, 3 };
            int val = inputArray.Aggregate((l, r) => l > r? l: r);

            //var result = keyValues.Select((value, key) => value.Value).ke;

            //foreach (var obj in result)
            //{
            //    Console.WriteLine("{0}", obj);
            //}
        }


    }
}
