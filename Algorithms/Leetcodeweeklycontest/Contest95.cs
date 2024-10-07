using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodeweeklycontest
{
    public class Contest95
    {
        public static string CategorizeBox(int length, int width, int height, int mass)
        {
            long highestVolume = 1000000000;
            long dimension = 10000;
            int heavyWeight = 100;

            long volume = length * (long)width* height;
            int max = Math.Max(Math.Max(length, width), height);

            if((volume >= highestVolume || max >= dimension) && mass >= heavyWeight)
            {
                return "Both";
            }

            if ((volume < highestVolume && max < dimension) && mass < heavyWeight)
            {
                return "Neither";
            }

            if ((volume >= highestVolume || max >= dimension) && mass < heavyWeight)
            {
                return "Bulky";
            }

            return "Heavy";
        }

        public static int XorBeauty(int[] nums)
        {
            int xorResult = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    for(int k =0; k < nums.Length; k++)
                    {
                        int tempResult = (nums[i] | nums[j])&nums[k];
                        xorResult ^= tempResult;
                    }
                }
            }
            return xorResult;
        }
    }

    public class DataStream
    {
        List<int> list;
        int intVal = 0;
        int intK = 0;
        public DataStream(int value, int k)
        {
            intVal = value;
            intK = k;
            list = new List<int>();
        }

        public bool Consec(int num)
        {
            list.Add(num);
            if (list.Count < intK)
            {
                return false;
            }

            if(list.Count == 1)
            {
                if(list[list.Count - 1] == intVal)
                {
                    return true;
                }
                return false;
            }

            for(int i = list.Count - 1; i >= list.Count - intK; i--)
            {
                if(intVal != list[i])
                {
                   return false;
                }
            }

            return true;
        }
    }
}
