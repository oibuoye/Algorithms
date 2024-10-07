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

        public static int[] SortNumber(int[] arrayofNumbers)
        {
            return QuickSort(arrayofNumbers, 0, arrayofNumbers.Length - 1);
        }

        public static int[] QuickSort(int[] arrayofNumbers, int low, int high)
        {
            if(low < high)
            {
               int partition = QuickSortPartitions(arrayofNumbers, low, high);

                QuickSort(arrayofNumbers, low, partition - 1);
                QuickSort(arrayofNumbers, partition + 1, high);
            }
            return arrayofNumbers;
        }

        public static int QuickSortPartitions(int[] arr, int low, int high)
        {
            int pivot = arr[high], pivotLoc = low, temp = 0;

            for(int i = low; i <= high; i++)
            {
                if(arr[i] < pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[pivotLoc];
                    arr[pivotLoc] = temp;
                    pivotLoc++;
                }
            }

            temp = arr[pivotLoc];
            arr[pivotLoc] = arr[high];
            arr[high] = temp;
            return pivotLoc;
        }


        public static int findMedian()
        {
            int[] array = { 5, 3, 1, 2, 4, 6 };
            int[] arraycopy = { 5, 3, 1, 2, 4, 6 };

            int kPosition = 3;
            int length = array.Length;

            if (kPosition > length)
            {
                Console.WriteLine("Index out of bound");
            }
            else
            {
                // find kth smallest value
                Console.WriteLine("K-th smallest element in array : " +  kthSmallest(arraycopy, 0, length - 1, kPosition - 1));
            }
            return 1;
        }

        // finds the kth position (of the sorted array)
        // in a given unsorted array i.e this function
        // can be used to find both kth largest and
        // kth smallest element in the array.
        // ASSUMPTION: all elements in []arr are distinct
        public static int kthSmallest(int[] arr, int low, int high, int k)
        {
            // find the partition
            int partition = partitions(arr, low, high);

            // if partition value is equal to the kth position,
            // return value at k.
            if (partition == k)
                return arr[partition];

            // if partition value is less than kth position,
            // search right side of the array.
            else if (partition < k)
                return kthSmallest(arr, partition + 1, high, k);

            // if partition value is more than kth position,
            // search left side of the array.
            else
                return kthSmallest(arr, low, partition - 1, k);
        }

        // partition function similar to quick sort
        // Considers last element as pivot and adds
        // elements with less value to the left and
        // high value to the right and also changes
        // the pivot position to its respective position
        // in the readonly array.
        public static int partitions(int[] arr, int low, int high)
        {
            int pivot = arr[high], pivotloc = low, temp;
            for (int i = low; i <= high; i++)
            {
                // inserting elements of less value
                // to the left of the pivot location
                if (arr[i] < pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[pivotloc];
                    arr[pivotloc] = temp;
                    pivotloc++;
                }
            }

            // swapping pivot to the readonly pivot location
            temp = arr[high];
            arr[high] = arr[pivotloc];
            arr[pivotloc] = temp;

            return pivotloc;
        }

        public static int median(List<int> arr, int low, int high, int k)
        {
            // find the partition
            int partition = partitions(arr, low, high);

            // if partition value is equal to the kth position,
            // return value at k.
            if (partition == k)
                return arr[partition];

            // if partition value is less than kth position,
            // search right side of the array.
            else if (partition < k)
                return median(arr, partition + 1, high, k);

            // if partition value is more than kth position,
            // search left side of the array.
            else
                return median(arr, low, partition - 1, k);
        }

        public static int partitions(List<int> arr, int low, int high)
        {
            int pivot = arr[high], pivotloc = low, temp;
            for (int i = low; i <= high; i++)
            {
                // inserting elements of less value
                // to the left of the pivot location
                if (arr[i] < pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[pivotloc];
                    arr[pivotloc] = temp;
                    pivotloc++;
                }
            }

            // swapping pivot to the readonly pivot location
            temp = arr[high];
            arr[high] = arr[pivotloc];
            arr[pivotloc] = temp;

            return pivotloc;
        }

        public static int BuyChoco(int[] prices, int money)
        {
            int[] sortedPrices = SortNumber(prices);
            int buy = 0;
            int tempMoney = money;
            for (int i = 0; i < prices.Length; i++)
            {
                if (buy == 2)
                {
                    return tempMoney;
                }

                if (sortedPrices[i] > tempMoney)
                {
                    return money;
                }
                tempMoney -= sortedPrices[i];
                buy++;
            }
            return money;
        }

        public static int MinExtraChar(string s, string[] dictionary)
        {
            string[] sortString = SortString(dictionary);
            for (int i = sortString.Length - 1; i >= 0; i--)
            {
                string[] splitResult = s.Split(new string[] { dictionary[i] }, StringSplitOptions.None);
                string newFormedString = "";
                for (int j =0; j < splitResult.Length; j++)
                {
                    if(splitResult[j] != "")
                    {
                        newFormedString = $"{newFormedString}{splitResult[j]}";
                    }
                }
                s = newFormedString;
            }
            return s.Length;
        }


        public static string[] SortString(string[] arrayofString)
        {
            return QuickSort(arrayofString, 0, arrayofString.Length - 1);
        }

        public static string[] QuickSort(string[] arrayofString, int low, int high)
        {
            if (low < high)
            {
                int partition = QuickSortPartitions(arrayofString, low, high);

                QuickSort(arrayofString, low, partition - 1);
                QuickSort(arrayofString, partition + 1, high);
            }
            return arrayofString;
        }

        public static int QuickSortPartitions(string[] arr, int low, int high)
        {
            string pivot = arr[high], temp = "";
            int pivotLoc = low;

            for (int i = low; i <= high; i++)
            {
                if (arr[i].Length < pivot.Length)
                {
                    temp = arr[i];
                    arr[i] = arr[pivotLoc];
                    arr[pivotLoc] = temp;
                    pivotLoc++;
                }
            }

            temp = arr[pivotLoc];
            arr[pivotLoc] = arr[high];
            arr[high] = temp;
            return pivotLoc;
        }

        public static int EvenNumber(int[] k)
        {
            int totalSum = 0;
            int baseIterator = 0;
            int currentIndex = 0;

            while (k.Length != baseIterator)
            {
                int picked = 0;
                baseIterator += 2;
                int tempSum = 0;
                for (int i = currentIndex; i < k.Length; i++)
                {
                    if(currentIndex != k.Length - 1)
                    {
                        picked++;
                        tempSum += k[i];
                        if (picked == baseIterator)
                        {
                            totalSum += tempSum;
                            picked = 0;
                            tempSum = 0;
                            i = i - 1;
                        }
                    }
                }
            }

            return totalSum;


        }

        public static int OddWords(int[] k)
        {
            int totalSum = 0;
            int baseIterator = 0;
            int currentIndex = 0;

            while (k.Length != baseIterator)
            {
                int picked = 0;
                baseIterator += 2;
                int tempSum = 0;
                for (int i = currentIndex; i < k.Length; i++)
                {
                    if (currentIndex != k.Length - 1)
                    {
                        picked++;
                        tempSum += k[i];
                        if (picked == baseIterator)
                        {
                            totalSum += tempSum;
                            picked = 0;
                            tempSum = 0;
                            i = i - 1;
                        }
                    }
                }
            }

            return totalSum;


        }

    }
}
