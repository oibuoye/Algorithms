using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class LeadaLifeCalculateProfit
    {
        //WIP:::Not passing all the test cases
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
                        //Compare the earning of the previous day with current day
                        //When the earning for previous day is less than cost of eating for the day
                        //and earning for previous day is greater than earning for the current day
                        if(EarningForTheDay(i -1, earning, e) <= EatingForTheDay(i -1, cost, e) && EarningForTheDay(i - 1, earning, e) > EarningForTheDay(i, earning, e))
                        {
                            profit += EarningForTheDay(i - 1, earning, e);
                            energy = 0;
                        }
                        else
                        {
                            profit += EarningForTheDay(i, earning, e);
                            energy = 0;
                        }
                    }
                }
                else
                {
                    if (EarningForTheDay(i, earning, e) > EatingForTheDay(i, cost, e) && energy !=0)
                    {
                        if ((EatingForTheDay(i, cost, e) >= EatingForTheDay(i + 1, cost, e)) && (EarningForTheDay(i + 1, earning, e) <= EatingForTheDay(i + 1, cost, e)))
                        {
                            //Work 
                            profit += EarningForTheDay(i, earning, e);
                            energy = 0;
                        }
                        else
                        {
                            //Work 
                            profit += EarningForTheDay(i, earning, e);
                            energy = 0;

                            //Then eat
                            profit -= EatingForTheDay(i, cost, e);
                            energy += e;
                        }
                    }
                    else if (((EarningForTheDay(i, earning, e) > EarningForTheDay(i + 1, earning, e)) && (EarningForTheDay(i, earning, e) >= EatingForTheDay(i + 1, cost, e)) && energy != 0))
                    {
                        //Work 
                        profit += EarningForTheDay(i, earning, e);
                        energy = 0;
                    }
                    else if ((energy == 0 && (EatingForTheDay(i, cost, e) < EatingForTheDay(i + 1, cost, e))) || (energy == 0 && EarningForTheDay(i + 1, earning, e) > EatingForTheDay(i + 1, cost, e)))
                    {
                        //Then eat
                        profit -= EatingForTheDay(i, cost, e);
                        energy += e;
                    }
                }
            }
            return profit;
        }

        static int EarningForTheDay(int day, List<int> earning, int e)
        {
            return e * earning[day];
        }

        static int EatingForTheDay(int day, List<int> cost, int e)
        {

            return e * cost[day];
        }

    }
}
