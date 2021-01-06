using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.October.Day16
{
    public class Search2DMatrix
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int row = matrix.Length;
            Console.WriteLine(matrix);
            Console.WriteLine(row);
            int col = 0;
            if (row != 0)
            {
                if (matrix[0] == null || matrix[0].Length == 0)
                {
                    return false;
                }
                col = matrix[0].Length;
            }

            //Solution 1
            for (int i = 0; i < row; i++)
            {
                int getRowLastInteger = matrix[i][col - 1];

                if (getRowLastInteger == target)
                {
                    return true;
                }
                else if (target < getRowLastInteger)
                {
                    for (int k = 0; k < col; k++)
                    {
                        if (matrix[i][k] == target)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            return false;
        }
    }
}
