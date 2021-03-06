﻿using System;
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

    }
}
