﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class knapSackSolution
    {
        public static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // Returns the maximum value that can  
        // be put in a knapsack of capacity W 
        public static int knapSack(int W, int[] wt, int[] val, int n)
        {

            // Base Case 
            if (n == 0 || W == 0)
                return 0;

            // If weight of the nth item is  
            // more than Knapsack capacity W, 
            // then this item cannot be  
            // included in the optimal solution 
            if (wt[n - 1] > W)
            {
                return knapSack(W, wt, val, n - 1);
            }
            else
            {
                // Return the maximum of two cases:  
                // (1) nth item included  
                // (2) not included 
                //max(val[2]+
                return max(val[n - 1] + knapSack(W - wt[n - 1], wt, val, n - 1), knapSack(W, wt, val, n - 1));
            }
        }

        // Returns the maximum value that 
        // can be put in a knapsack of  
        // capacity W 
        public static int knapSack1(int W, int[] wt, int[] val, int n)
        {
            int i, w;
            int[,] K = new int[n + 1, W + 1];

            // Build table K[][] in bottom  
            // up manner 
            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                    {
                        K[i, w] = 0;
                    }
                    else if (wt[i - 1] <= w)
                    {
                        K[i, w] = Math.Max(val[i - 1] + K[i - 1, w - wt[i - 1]], K[i - 1, w]);
                    }
                    else
                    {
                        K[i, w] = K[i - 1, w];
                    }
                }
            }

            return K[n, W];
        }

    }
}
