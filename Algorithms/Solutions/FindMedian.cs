using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class FindMedian
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int hLengthArray = nums1.Length > nums2.Length ? nums1.Length : nums2.Length;
            ArrayList newArray = new ArrayList();

            for (int i =0; i < hLengthArray; i++)
            {
                if(i < nums1.Length && i < nums2.Length)
                {
                    if(nums1[i] < nums2[i])
                    {
                        newArray.Insert(newArray.Count, nums1[i]);
                        newArray.Insert(newArray.Count, nums2[i]);
                        SortList(newArray);
                    }
                    else
                    {
                        newArray.Insert(newArray.Count, nums2[i]);
                        newArray.Insert(newArray.Count, nums1[i]);
                        SortList(newArray);
                    }
                }
                else if(i < nums1.Length)
                {
                    newArray.Insert(newArray.Count, nums1[i]);
                    SortList(newArray);
                }
                else if (i < nums2.Length)
                {
                    newArray.Insert(newArray.Count, nums2[i]);
                    SortList(newArray);
                }
            }

            int mid = newArray.Count/2;
            if(newArray.Count % 2 == 0)
            {
                int midSum = (int)newArray[mid - 1] + (int)newArray[mid];
                return (double)midSum / 2;
            }

            return (int)newArray[mid];
        }

        private ArrayList SortList(ArrayList newArray)
        {
            int tempValue = 0;
            for (int j = 1; j < newArray.Count; j++)
            {
                tempValue = (int)newArray[j];
                //store the index
                int k = j;
                while (k > 0 && (int)newArray[k - 1] > tempValue)
                {
                    //store the previous value in current index position
                    newArray[k] = newArray[k - 1];
                    k--;
                }

                newArray[k] = tempValue;
            }

            return newArray;
        }

    }
}
