using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.May.Day02
{
    public class JewelsandStonesSolution
    {
        public static int NumJewelsInStones(string J, string S)
        {
            int[] jArrayValue = new int[123];
            int counter = 0;

            for(int i =0; i < J.Length; i++)
            {
                jArrayValue[J[i]] = 1;
            }

            for(int i =0; i < S.Length; i++)
            {
                if(jArrayValue[S[i]] == 1)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int NumJewelsInStonesLinqSol(string J, string S)
        {
            return S.Count(x => J.Contains(x));
        }

        public static int NumJewelsInStonesSol2(string J, string S)
        {
            Dictionary<int, char> jewels = new Dictionary<int, char>();
            int jewelCount = 0;

            for (int i = 0; i < J.Length; i++)
            {
                jewels.Add(i, J[i]);
            }
            for (int i = 0; i < S.Length; i++)
            {
                if (jewels.ContainsValue(S[i]))
                {
                    jewelCount++;
                }
            }
            return jewelCount;
        }
    }
}
