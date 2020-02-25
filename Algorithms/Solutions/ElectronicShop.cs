using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class ElectronicShop
    {
        public static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int highestGoodsBought = 0;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for(int j=0; j < drives.Length; j++)
                {
                    int totalGoods = keyboards[i] + drives[j];
                    if (totalGoods <= b  && highestGoodsBought < totalGoods)
                    {
                        highestGoodsBought = totalGoods;
                    }
                }
            }

            if(highestGoodsBought > 0)
            {
                return highestGoodsBought;
            }
            return -1;
        }
    }
}
