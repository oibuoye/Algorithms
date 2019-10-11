using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Q
{
    class Leaderofthearray
    {

        //int K = 3;
        //int M = 5;
        //int[] inputArray = { 2, 1, 3, 1, 2, 2, 3 };

        //int K = 0;
        //int M = 2;
        //int[] inputArray = { 1, 2 };

        //int[] result = Leaderofthearray.solution(K, M, inputArray);

        public static int[] solution(int K, int M, int[] A)
        {
           Dictionary<int, int> resVal = new Dictionary<int, int>();
           int rotation = (A.Length - K) + 1;
           for(int i =0; i < rotation; i++)
            {
                int[] ACopy = new int[A.Length];
                Array.Copy(A, ACopy, A.Length);
                Dictionary<int, int> keyValues = new Dictionary<int, int>();
                int counter = 0;
                for (int x=0; x< ACopy.Length; x++)
                {
                    int startIndex = i;
                    if(counter < K && x >= startIndex)
                    {
                        ACopy[x] += 1;
                        counter++;
                    }

                    if (keyValues.ContainsKey(ACopy[x]))
                    {
                        keyValues[ACopy[x]] += 1;
                    }
                    else
                    {
                        keyValues[ACopy[x]] = 1;
                    }
                }

                int highestValues = keyValues.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

                if(keyValues[highestValues] > (A.Length / 2))
                {
                    if (!resVal.ContainsKey(highestValues))
                    {
                        resVal[highestValues] = highestValues;
                    }
                }
            }

            int[] response = new int[resVal.Count];
            int resultCounter = 0;
            if(resVal.Count > 0)
            {
                foreach (var item in resVal)
                {
                    response[resultCounter] = item.Value;
                    resultCounter++;
                }

                Array.Sort(response);
                return response;
            }

            return new int[0];
        }
    }
}
