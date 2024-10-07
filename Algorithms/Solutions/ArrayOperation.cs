using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class ArrayOperation
    {
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        //int d = 2;
        //int[] result1 = ArrayOperation.ArrayRotation(arr, d);

        public static int[] ArrayRotation(int[] inputArray, int rotationTimes)
        {
            //This method will work for shifting left
            //create temp array with the size of rotation
            int[] tempArray = new int[rotationTimes];

            for (int i = 0; i < inputArray.Length; i++)
            {
                //Save all the arrays within the size of rotation in temp array
                if (i < rotationTimes)
                {
                    tempArray[i] = inputArray[i];
                }
                else
                {
                    //shift other arrays based on size of rotation
                    inputArray[i - 2] = inputArray[i];
                }
            }

            //Get arrays in the temp and fill it back to the main array
            for (int k = 0; k < tempArray.Length; k++)
            {
                inputArray[inputArray.Length - rotationTimes] = tempArray[k];
                rotationTimes--;
            }

            return inputArray;

        }

        public static int[] ArrayRightRotation(int[] nums, int k)
        {
            //This method will work for shifting right
            //create temp array with the size of rotation
            if(nums.Length != k)
            {
                if (nums.Length < k)
                {
                    k = k - nums.Length;
                }
                int[] tempArray = new int[k];
                int counter = 0;

                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    //Save all the arrays within the size of rotation in temp array
                    if (counter < k)
                    {
                        tempArray[counter] = nums[i];
                        counter++;
                    }
                    else
                    {
                        //shift other arrays based on size of rotation
                        nums[i + k] = nums[i];
                    }
                }

                //Get arrays in the temp and fill it back to the main array
                for (int j = 0; j < tempArray.Length; j++)
                {
                    k--;
                    nums[k] = tempArray[j];
                }
            }

            return nums;

        }

        public static void ArrayRightRotation2(int[] nums, int k)
        {
            if(nums.Length == 1)
            { return; }
            if (nums.Length != k)
            {
                if (nums.Length < k)
                {
                    int temp = k / nums.Length;
                    k -= (temp * nums.Length);
                }

                int[] tempArray = new int[k];
                int tempCounter = 0;

                for (int i = k -1; i < nums.Length; i++)
                {
                    tempArray[tempCounter] = nums[i];
                    tempCounter++;
                }

                int counter = nums.Length - 1;
                for (int i = k-1; i >= 0; i--)
                {
                    nums[counter] = nums[i];
                    counter--;
                }

                for (int j = 0; j < tempCounter; j++)
                {
                    nums[j] = tempArray[j];
                }
            }
        }

        public static void ArrayRightRotation3(int[] nums, int k)
        {
            if (nums.Length == 1)
            { return; }
            if (nums.Length != k)
            {
                if (nums.Length < k)
                {
                    int temp = k / nums.Length;
                    k -= (temp * nums.Length);
                }

                int[] tempArray = new int[k];
                int counter = 0;

                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    if (counter < k)
                    {
                        tempArray[counter] = nums[i];
                        counter++;
                    }
                    else
                    {
                        nums[i + k] = nums[i];
                    }
                }

                for (int j = 0; j < tempArray.Length; j++)
                {
                    k--;
                    nums[k] = tempArray[j];
                }
            }
        }

        public static void MoveZeroes(int[] nums)
        {
            if(nums.Length == 0)
            {
                return;
            }

            List<int> zeros = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeros.Add(i);
                }
                else
                {
                    if(zeros.Count != 0)
                    {
                        nums[zeros[0]] = nums[i];
                        nums[i] = 0;

                        zeros.RemoveAt(0);
                        zeros.Add(i);
                    }
                }
            }
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(numbers[0], 1);
            for (int i = 1;i < numbers.Length; i++)
            {
                int temp = target - numbers[i];
                if (dic.ContainsKey(temp))
                {
                    return new int[] { dic[temp], i+1 };
                }
                else
                {
                    if (!dic.ContainsKey(numbers[i]))
                    {
                        dic.Add(numbers[i], i + 1);
                    }
                }
            }
            return new int[] { };
        }

        public static int[] TwoSumGreatSol(int[] numbers, int target)
        {
            int low = 0, high = numbers.Length - 1;
            while (numbers[low] + numbers[high] != target)
            {
                if(numbers[low] + numbers[high] < target)
                {
                    low++;
                }
                else
                {
                    high--;
                }
            }
            return new int[] { low + 1, high + 1};
        }

    }
}
