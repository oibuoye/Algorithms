using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.September.Day09
{
    public class CompareVersionNumbers
    {
        public static int CompareVersion(string version1, string version2)
        {
            var v1Arr = version1.Split('.');
            var v2Arr = version2.Split('.');
            int v1Count = v1Arr.Count();
            int v2Count = v2Arr.Count();
            int lowestCount = v1Arr.Count() > v2Arr.Count() ? v2Arr.Count() : v1Arr.Count();

            for(int i =0; i < lowestCount; i++)
            {
                int v1Num = Convert.ToInt16(v1Arr[i]);
                int v2Num = Convert.ToInt16(v2Arr[i]);
                if (v1Num > v2Num)
                {
                    return 1;
                }else if(v1Num < v2Num)
                {
                    return -1;
                }
            }

            if (v1Count != v2Count)
            {
                if(v1Count > v2Count)
                {
                    int sum = 0;
                    for (int i = v2Count; i < v1Count; i++)
                    {
                        sum += Convert.ToInt16(v1Arr[i]);
                    }

                    if(sum > 0)
                    {
                        return 1;
                    }
                }else if (v2Count > v1Count)
                {
                    int sum = 0;
                    for (int i = v1Count; i < v2Count; i++)
                    {
                        sum += Convert.ToInt16(v2Arr[i]);
                    }

                    if (sum > 0)
                    {
                        return -1;
                    }
                }
            }

            return 0;
        }
    }
}
