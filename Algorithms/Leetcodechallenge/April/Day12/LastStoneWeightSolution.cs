using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day12
{
    public class LastStoneWeightSolution
    {
        public static int LastStoneWeight(int[] arr)
        {
            List<int> numbers = new List<int>(arr);

            while(numbers.Count > 1)
            {
                numbers.Sort();
                int count = numbers.Count;
                if (numbers[count - 1] == numbers[count - 2])
                {
                    numbers.RemoveAt(count - 1);
                    numbers.RemoveAt(count - 2);
                }
                else
                {
                    numbers[count - 2] = numbers[count - 1] - numbers[count - 2];
                    numbers.RemoveAt(count - 1);
                }
            }

            if(numbers.Count > 0)
            {
                return numbers[0];
            }
            return 0;
        }
    }
}
