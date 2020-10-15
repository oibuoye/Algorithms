using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class ImageEditing
    {
        public static int largestMatrix(List<List<int>> arr)
        {
            //Get the length of the list
            int arrLength = arr.Count;
            int largestWhiteSpace = 0;

            //Create temp matrix
            int[,] tempMatrix = new int[arrLength, arrLength];

            //Fill the first row of the temp matrix with the value from first list of the int list
            List<int> firstRow = arr[0];
            for(int i =0; i < arrLength; i++)
            {
                tempMatrix[0, i] = firstRow[i];
            }

            //Fill the column of the temp matrix with the value from first column of the int list
            for (int i = 0; i < arrLength; i++)
            {
                List<int> arrList = arr[i];
                tempMatrix[i, 0] = arrList[0];
            }

            //Fill the rest part of the temp matrix
            for (int i = 1; i < arrLength; i++)
            {
                List<int> previousRow = arr[i -1];
                List<int> currentRow = arr[i];

                for (int j = 1; j < arrLength; j++)
                {
                    if (currentRow[j] == 1)
                    {
                        //Check the minimum value of the diagonal cell, the cell up and the cell by the left
                        int currentCellValue = Math.Min(previousRow[j - 1], Math.Min(previousRow[j], currentRow[j - 1])) + 1;
                        //save it into the tempMatrix
                        tempMatrix[i, j] = currentCellValue;
                        //save it to the current list
                        currentRow[j] = currentCellValue;

                        if(largestWhiteSpace <= currentCellValue)
                        {
                            largestWhiteSpace = currentCellValue;
                        }
                    }
                    else
                    {
                        tempMatrix[i, j] = 0;
                    }
                }
            }

            return largestWhiteSpace;
        }
    }
}
