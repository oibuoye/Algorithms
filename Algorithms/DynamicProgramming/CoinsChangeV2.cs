using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class CoinsChangeV2
    {
        public static int getNumberOfWays(int N, int[] Coins)
        {
            // int[] coins = { 1,5, 10 };
            //int result = CoinsChangeV2.getNumberOfWays(12, coins);



            //Declare the arrays of ways
            int[] ways = new int[N + 1];

            //set ways of zero to 1 
            ways[0] = 1;


            for(int i =0; i <Coins.Length; i++)
            {
                for(int j = 0; j < ways.Length; j++)
                {
                    if(Coins[i] <= j)
                    {
                        ways[j] += ways[j - Coins[i]];
                    }
                }
            }

            return ways[N];
        }
    }
}
