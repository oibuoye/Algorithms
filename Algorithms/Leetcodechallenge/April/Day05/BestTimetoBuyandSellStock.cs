using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day05
{
    public class BestTimetoBuyandSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                maxProfit += Math.Max(prices[i] - prices[i - 1], 0);
            }
            return maxProfit;
        }

        public static int MaxProfitTwo(int[] prices)
        {
            int maxProfit = 0;
            int stockBoughtPrice = 0;
            bool hasBoughtStock = false;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1] && hasBoughtStock == false)
                {
                    hasBoughtStock = true;
                    stockBoughtPrice = prices[i];
                }
                else if (prices[i] > prices[i + 1] && hasBoughtStock == true)
                {
                    hasBoughtStock = false;
                    maxProfit += prices[i] - stockBoughtPrice;
                    stockBoughtPrice = 0;
                }

                if (i == (prices.Length - 2) && hasBoughtStock == true)
                {
                    hasBoughtStock = false;
                    maxProfit += prices[i] > prices[i + 1] ? prices[i] - stockBoughtPrice : prices[i + 1] - stockBoughtPrice;
                    stockBoughtPrice = 0;
                }
            }
            return maxProfit;
        }

    }
}
