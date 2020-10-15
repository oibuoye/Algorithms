using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day07
{
    public class CountingElementsSolution
    {
        public static int CountElements(int[] arr)
        {
            int[] numberArr = new int[1002];
            int counter = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                numberArr[arr[i]] = 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if(numberArr[arr[i]+1] != 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
