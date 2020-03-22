using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class NimGame
    {
        /// <summary>
        /// You are playing the following Nim Game with your friend: There is a heap of stones on the table, each time one of you take turns to remove 1 to 3 stones.The one who
        /// removes the last stone will be the winner.You will take the first turn to remove the stones.
        /// Both of you are very clever and have optimal strategies for the game. Write a function to determine whether you can win the game given the number of stones in the heap.
        /// Example:
        /// Input: 4
        ///Output: false
        ///Explanation: If there are 4 stones in the heap, then you will never win the game;
        ///No matter 1, 2, or 3 stones you remove, the last stone will always be removed by your friend.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool CanWinNim(int n)
        {
            int oldNumberForFalse = 4;
            if(n == oldNumberForFalse)
            {
                return false;
            }
            else
            {
                for(int i =0; i < 3; i++)
                {
                    if(n-i == 4)
                    {
                        n -= i;
                    }
                }
            }
            return true;
        }
    }
}
