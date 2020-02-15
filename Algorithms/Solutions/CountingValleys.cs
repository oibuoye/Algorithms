using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class CountingValleys
    {
        public static int countingValleys(int n, string s)
        {
            int upHill = 0;
            int downHill = 0;
            int countValley = 0;
            for(int i =0; i < s.Length - 2; i++)
            {
                char getChar = s[i];
                if(getChar == 'U')
                {
                    upHill++;
                    if((upHill - downHill) < 0)
                    {
                        //Valley
                        //Check the next two move
                        char getChar1 = s[i + 1];
                        char getChar2 = s[i + 2];
                        if (getChar1 == 'U' && getChar2 == 'D')
                        {
                            countValley++;
                        }
                    }
                }
                else
                {
                    downHill++;
                    if ((upHill - downHill) < 0)
                    {
                        //Valley
                        //Check the next two move
                        char getChar1 = s[i + 1];
                        char getChar2 = s[i + 2];
                        if (getChar1 == 'U' && getChar2 == 'D')
                        {
                            countValley++;
                        }
                    }
                }
            }
            return countValley;
        }
    }
}
