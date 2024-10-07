using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge
{
    public class CheckRecordSolution
    {
        public static bool CheckRecord(string s)
        {
            int absentCounter = 0;
            int consecutiveLate = 0;
            bool isPreviousLate = false;

            for(int i =0; i < s.Length; i++)
            {
                if(s[i] == 'A')
                {
                    absentCounter++;
                    isPreviousLate = false;
                }
                else if(s[i] == 'L')
                {
                    if (isPreviousLate)
                    {
                        consecutiveLate++;
                    }
                    else
                    {
                        if(consecutiveLate > 2)
                        {
                            break;
                        }
                        consecutiveLate = 0;
                        consecutiveLate++;
                        isPreviousLate = true;
                    }
                }
                else
                {
                    isPreviousLate = false;
                }
            }
            return absentCounter < 2 && consecutiveLate < 3;
        }

        public static int NetworkDelayTime(int[][] times, int n, int k)
        {
            int len = times.Length;
            int time = -1;
            int kstart = k;
            for(int i = 0; i < len; i++)
            {
                if(times[i][0] == kstart && kstart < times[i][1])
                {
                    if(time == -1)
                    {
                        time = times[i][2];
                    }
                    else
                    {
                        time += times[i][2];
                    }
                    kstart = times[i][1];
                }
            }
            return time;
        }
    }
}
