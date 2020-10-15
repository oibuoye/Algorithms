using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.May.Day08
{
    public class CheckStraightLineSolution
    {
        public static bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length == 1)
            {
                return true;
            }

            float slope = GetSlope(coordinates[0], coordinates[1]);

            for(int i = 2; i < coordinates.Length; i++)
            {
                float newSlope = GetSlope(coordinates[0], coordinates[i]);
                if(slope != newSlope)
                {
                    return false;
                }
            }
            return true;
        }

        public static float GetSlope(int[] firstPoint, int[] secondPoint)
        {
            float slope = (float)(secondPoint[1] - firstPoint[1]) / (secondPoint[0] - firstPoint[0]);
            return slope;
        }
    }
}
