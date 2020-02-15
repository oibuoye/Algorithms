using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class Sorting
    {
        public static int[] SelectionSorting(int[] inputArray)
        {
            int n = inputArray.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n -1; j++)
                {
                    int temp = inputArray[j];
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = temp;
                    }
                }
            }

            return inputArray;
        }

        public static void SelSorting(int[] lst)
        {
            // get the length
            int n = lst.Length;
            for (int i = 0; i < n; i++)
            {
                int index = 0;
                int smallest = lst[i];
                for (int j = i; j < n; j++)
                {
                    if (lst[j] < smallest)
                    {
                        smallest = lst[j];
                        index = j;
                    }
                    int temp = lst[i];
                    lst[i] = smallest;
                    lst[index] = temp;
                }
            }
            Console.WriteLine(lst);
        }

        public int[] BubbleSort()
        {
            int[] arrayofNumbers = { 5, 2, 1, 7, 9, 4 };
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
        public void InsertionSort()
        {
            // Declare an integer array that is not sorted
            int[] arr = { 6, 1, 2 };

            //Declare variable for the insertion value
            int newValue;


            // The outer loop allows us to iterate over the complete array that we will use for sorting
            for (int i = 1; i < arr.Length; i++)
            {
                newValue = arr[i];

                // Also set the start of our inner loop to the same value as i
                int j = i;

                while (j > 0 && arr[j - 1] > newValue)
                {
                    arr[j] = arr[j - 1];

                    j--;

                }

                arr[j] = newValue;

            }
        }

    }
}
