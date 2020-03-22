using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class KthLargestNumber
    {
        public static int GetKthLargestNumber(int[] arr, int kth)
        {
            //Find absolute distance d of the adjacent elements of the array and store in another array until difference of any two elements
            // of the array produce a result that exist in the array
            // then find the kth largest element in the new array
            int len = arr.Length;
            int maxNum = arr.Max();
            int[] newArr = new int[maxNum];
            newArr[newArr.Length - 1] = maxNum; //store the maximum number in the array

            for (int i = len - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    //Find absolute difference
                    int d = Math.Abs(arr[i] - arr[j]);
                    if (newArr[d - 1] == 0)
                    {
                        newArr[d - 1] = d;
                    }
                }
            }

            if (kth < newArr.Length)
            {
                return newArr[newArr.Length - kth];
            }

            return -1;
        }

    }
}
