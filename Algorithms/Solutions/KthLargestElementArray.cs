using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class KthLargestElementArray
    {
        public static int GetKthLargestElement(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }

        public static int GetKthLargestElement2(int[] nums, int k)
        {
            SortElement(nums);
            return nums[nums.Length - k];
        }

        public static int[] SortElement(int[] arrayofNumbers)
        {
            bool IsSwapped;

            do
            {
                IsSwapped = false;

                for (int i = 0; i < arrayofNumbers.Length - 1; i++)
                {
                    //Do the comparison of the numbers
                    if (arrayofNumbers[i] > arrayofNumbers[i + 1])
                    {
                        //Do the swapping
                        //Keep the second value
                        int tempNumber = arrayofNumbers[i + 1];

                        //swap the highest value into the second value
                        arrayofNumbers[i + 1] = arrayofNumbers[i];

                        //put the second value into the first
                        arrayofNumbers[i] = tempNumber;

                        IsSwapped = true;
                    }
                }
            } while (IsSwapped == true);


            return arrayofNumbers;
        }


    }
}
