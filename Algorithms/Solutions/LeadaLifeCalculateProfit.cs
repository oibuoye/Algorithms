using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class LeadaLifeCalculateProfit
    {
        public static int calculateProfit(int n, List<int> earning, List<int> cost, int e)
        {
            int profit = 0, energy = e;
            for (int i = 0; i < n; i++)
            {
                //Handle last day
                if (i == n - 1)
                {
                    if (energy > 0)
                    {
                        profit += EarningAfterWork(i, earning, e);
                        energy = 0;
                    }
                    else
                    {
                        //Eat then work
                        profit -= EatingAfterWork(i, cost, e);
                        energy += e;

                        //then work
                        profit += EarningAfterWork(i, earning, e);
                        energy = 0;
                    }
                }
                else
                {
                    if (EarningAfterWork(i, earning, e) > EatingAfterWork(i, cost, e))
                    {
                        //Work 
                        profit += EarningAfterWork(i, earning, e);
                        energy = 0;

                        //Then eat
                        profit -= EatingAfterWork(i, cost, e);
                        energy += e;
                    }
                    else if (EarningAfterWork(i, earning, e) == EatingAfterWork(i, cost, e))
                    {
                        //Check the cost of eating
                        if (earning[i] > earning[i + 1])
                        {
                            //Work without eating on that day
                            profit += EarningAfterWork(i, earning, e);
                            energy = 0;
                        }
                    }
                    else
                    {
                        //Check if it better to eat today compare to the next day and next day is not the last day
                        if (EatingAfterWork(i, cost, e) < EatingAfterWork(i + 1, cost, e))
                        {
                            //Then eat
                            if (profit > EatingAfterWork(i, cost, e))
                            {
                                profit -= EatingAfterWork(i, cost, e);
                                energy += e;
                            }
                        }
                    }
                }
            }
            return profit;
        }

        static int EarningAfterWork(int day, List<int> earning, int e)
        {
            return e * earning[day];
        }

        static int EatingAfterWork(int day, List<int> cost, int e)
        {

            return e * cost[day];
        }

    }
}
