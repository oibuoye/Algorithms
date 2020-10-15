using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day02
{
    class HappyNumberSolution
    {
        public static bool IsHappy(int n)
        {
            //https://leetcode.com/problems/happy-number/
            if (n == 1 || n == 7)
                return true;
            if (n < 10)
                return false;

            return IsHappy(AddValues(n.ToString()));
        }

        private static int AddValues(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += (int)Math.Pow(Convert.ToDouble(number[i].ToString()), 2);
            }
            return sum;
        }
    }
}
