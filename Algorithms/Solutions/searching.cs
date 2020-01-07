using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class searching
    {
        public static int BinarySearch(int[] inputArray, int x)
        {

            /// { 2, 3, 4, 10, 40 }
            int n = inputArray.Length;
            int mid = n / 2;
            int startIndex = 0;

            if(inputArray[mid] == x)
            {
                return mid;
            }

            if (inputArray[mid] > x)
               startIndex = mid + 1;

            BinarySearch(inputArray, x);

            return -1;
        }

    }
}
