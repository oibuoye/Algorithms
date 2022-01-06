using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class Sorting
    {
        public static int[] SelectionSorting(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n -1; j++)
                {
                    int temp = nums[j];
                    if (nums[j] > nums[j + 1])
                    {
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

            return nums;
        }

        public static int[] BubbleSort(int[] arrayofNumbers)
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
        //Insertion sort
        public static int[] InsertionSort(int[] arrayofNumbers)
        {
            //Declare variable for the insertion value
            int newValue;


            // The outer loop allows us to iterate over the complete array that we will use for sorting
            for (int i = 1; i < arrayofNumbers.Length; i++)
            {
                newValue = arrayofNumbers[i];

                // Also set the start of our inner loop to the same value as i
                int j = i;

                while (j > 0 && arrayofNumbers[j - 1] > newValue)
                {
                    arrayofNumbers[j] = arrayofNumbers[j - 1];

                    j--;

                }

                arrayofNumbers[j] = newValue;
            }
            return arrayofNumbers;
        }

    }
}
