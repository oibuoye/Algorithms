using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.May.Day09
{
    public class ValidPerfectSquareSolution
    {
        public static bool IsPerfectSquare(int num)
        {
            for(int i =1; i <= num; i++)
            {
                int sqr = i * i;
                if(sqr == num)
                {
                    return true;
                }else if(sqr > num)
                {
                    break;
                }
            }
            return false;
        }
    }
}
