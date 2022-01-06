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
            bool hasTouchedDownHill = false;
            for(int i =0; i < s.Length; i++)
            {
                if(s[i] == 'U')
                {
                    upHill++;
                    if((upHill - downHill) < 0 && hasTouchedDownHill == false)
                    {
                        //Valley
                        hasTouchedDownHill = true;
                    }
                    else if ((upHill - downHill) == 0 && hasTouchedDownHill == true)
                    {
                        hasTouchedDownHill = false;
                        countValley++;
                    }
                }
                else
                {
                    downHill++;
                    if ((upHill - downHill) < 0 && hasTouchedDownHill == false)
                    {
                        //Valley
                        hasTouchedDownHill = true;
                    }else if((upHill - downHill) == 0 && hasTouchedDownHill == true)
                    {
                        hasTouchedDownHill = false;
                        countValley++;
                    }
                }
            }
            return countValley;
        }
    }
}
