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

        public static int MaxProfit(int k, int[] prices)
        {

            int maxProfit = 0;
            int counter = 0;
            int tracker = -1;
            Dictionary<int, int> profits = new Dictionary<int, int>();
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    if((i != prices.Length -1) && prices[i] > prices[i + 1])
                    {
                        profits[counter] = tracker != -1? prices[i] - tracker : prices[i] - prices[i - 1];
                        counter++;
                        tracker = -1;
                    }
                    else
                    {
                        if(tracker != -1)
                        {
                            profits[counter] = prices[i] - tracker;
                            counter++;
                            tracker = -1;
                        }
                        else
                        {
                            if (i != (prices.Length - 1))
                            {
                                tracker = prices[i - 1];
                            }
                            else
                            {
                                profits[counter] = prices[i] - prices[i - 1];
                                counter++;
                            }
                        }
                    }
                }
            }
            profits = profits.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            counter = 0;
            foreach (var profit in profits)
            {
                if (counter != k)
                {
                    maxProfit += profit.Value;
                    counter++;
                }
                else
                {
                    break;
                }
            }


            //int maxProfit = 0;
            //int counter = 0;
            //Dictionary<int, int> profits = new Dictionary<int, int>();
            //for (int i = 1; i < prices.Length; i++)
            //{
            //    if(prices[i] > prices[i - 1])
            //    {
            //        profits[counter] = prices[i] - prices[i - 1];
            //        counter++;
            //    }
            //}
            //profits = profits.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            //counter = 0;
            //foreach (var profit in profits)
            //{
            //    if(counter != k)
            //    {
            //        maxProfit += profit.Value;
            //        counter++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            return maxProfit;
        }
    }
}
