using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Q
{
    public class MatrixTransposition
    {
        public static void Transpose(int[,] matrix)
        {
            for (int i =0; i< matrix.Length; i++)
            {
                for(int x =0; x < 2; x++)
                {
                    Console.WriteLine(matrix[i, x]);
                }
            }
        }
    }
}
