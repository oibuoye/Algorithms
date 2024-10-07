using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class searching
    {
        public static int BinarySearch(int[] arr, int key)
        {

            int minNum = 0;
            int maxNum = arr.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == arr[mid])
                {
                    return key;
                }
                else if (key < arr[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return -1;
        }

        public static int BinarySearch(int[] arr, int start, int end, int key)
        {
            if(start > end)
            {
                return -1;
            }

            if(end == 0)
            {
                end = arr.Length - 1;
            }

            int mid = (start + end) / 2;
            if (key == arr[mid])
            {
                return key;
            }

            if(mid < key)
            {
                return BinarySearch(arr, mid + 1, end, key);
            }
            else
            {
                return BinarySearch(arr, start, mid - 1, key);
            }
        }

    }
}
