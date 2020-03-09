using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class CountTripletNumber
    {
        public static long countTriplets(List<long> arr, long r)
        {
            int count = 0;
            for (int i = 0; i < arr.Count - 2; i++)
            {
                for (int j = i + 1; j < arr.Count - 1; j++)
                {
                    for (int k = j + 1; k < arr.Count; k++)
                    {
                        if ((arr[i] * r) == arr[j] && (arr[j] * r) == arr[k])
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        public static long CountTriplets(List<long> arr, long r)
        {
            var mapping2 = new Dictionary<long, long>();
            var mapping3 = new Dictionary<long, long>();
            long result = 0;
            foreach (long val in arr)
            {
                if (mapping3.ContainsKey(val))
                {
                    result += mapping3[val];
                }

                if (mapping2.ContainsKey(val))
                {
                    if (mapping3.ContainsKey(val * r))
                    {
                        mapping3[val * r] += mapping2[val];
                    }
                    else
                    {
                        mapping3[val * r] = mapping2[val];
                    }
                }

                if (mapping2.ContainsKey(val * r))
                {
                    mapping2[val * r]++;
                }
                else
                {
                    mapping2[val * r] = 1;
                }
            }
            return result;
        }
    }
}
