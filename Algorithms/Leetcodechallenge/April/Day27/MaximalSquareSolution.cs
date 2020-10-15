using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day27
{
    public class MaximalSquareSolution
    {
        public static int MaximalSquare(char[,] matrix)
        {
            int largestSquare = 0;
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            int asciiZero = 48;

            int[,] tempMatrix = new int[column, column];

            //Fill the first row
            for (int i = 0; i < column; i++)
            {
                tempMatrix[0, i] = matrix[0, i] - asciiZero;
            }

            //Fill the first column
            for (int i = 0; i < row; i++)
            {
                tempMatrix[i, 0] = matrix[i, 0] - asciiZero;
            }

            //Fill the rest
            for (int i = 1; i < row; i++)
            {
                for (int j = 1; j < column; j++)
                {
                    if (matrix[i, j] == 49)
                    {
                        int currentCellValue = Math.Min(matrix[i-1, j - 1], Math.Min(matrix[i-1, j], matrix[i, j - 1])) + 1;
                        int value = currentCellValue - asciiZero;
                        tempMatrix[i, j] = value;
                        matrix[i, j] = Convert.ToChar(currentCellValue);

                        if (largestSquare <= value)
                        {
                            largestSquare = value;
                        }
                    }
                    else
                    {
                        tempMatrix[i, j] = 0;
                    }
                }
            }
            return largestSquare * largestSquare;
        }
    }
}
