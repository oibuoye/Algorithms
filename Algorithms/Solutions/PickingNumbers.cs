using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Solutions
{
    public class PickingNumbers
    {
        public static int pickingNumbers(List<int> a)
        {
            //This counts numbers that the absolute of the difference of the adjacent number is less than 2
            a.Sort();
            int len = a.Count;
            int max = 0;
            for (int i = len - 1; i >= 0; i--)
            {
                int count = 1;
                for (int j = i - 1; j >= 0; j--)
                {

                    if ((a[i] - a[j]) < 2)
                    {
                        count++;
                    }

                }
                max = count > max ? count : max;
            }

            return max;
        }

        public static int pickingNumberReversed(List<int> a)
        {
            //This counts numbers that the absolute of the difference of the adjacent number is less than 2
            a.Sort();
            int len = a.Count;
            int max = 0;
            for (int i = 0; i <= len - 1; i++)
            {
                int count = 1;
                for (int j = i + 1; j <= len - 1; j++)
                {

                    if (Math.Abs(a[i] - a[j]) < 2)
                    {
                        count++;
                    }

                }
                max = count > max ? count : max;
            }

            return max;
        }
    }
}
