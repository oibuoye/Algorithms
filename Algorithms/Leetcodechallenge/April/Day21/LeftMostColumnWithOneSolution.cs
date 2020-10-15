using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day21
{
    public class LeftMostColumnWithOneSolution
    {
        public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        {
            IList<int> dimension = binaryMatrix.Dimensions();
            int row = dimension[0];
            int column = dimension[1];
            int answer = -1;

            for (int i = 0; i < row; i++)
            {
                for (int j = column - 1; j >= 0; j--)
                {
                    int getValue = binaryMatrix.Get(i, j);
                    if (getValue == 1)
                    {
                        if (answer == -1)
                        {
                            answer = j;
                        }
                        else if (j < answer)
                        {
                            answer = j;
                        }
                        column = j;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return answer;
        }
    }

    public class BinaryMatrix
    {
        public int Get(int x, int y) { return 1; }
        public IList<int> Dimensions() { return new List<int> { }; }
    }
}
