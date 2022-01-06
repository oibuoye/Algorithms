using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions.LeetCode.Contest
{
    public static class WeeklyContest
    {
        public static int CountValidWords(string sentence)
        {
            int counter = 0;
            int validWordCounter = 0;
            var strSplit = sentence.Split(' ');
            for (int i = 0; i < strSplit.Length; i++)
            {
                if (strSplit[i] == "")
                {
                    break;
                }

                string word = strSplit[i];
                for (int j = 0; j < word.Length; j++)
                {
                    int tVal = word[j];
                    if ((word[j] >= 60 && word[j] <= 71))
                    {
                        break;
                    }

                    if (word[j] == 41 && j != word.Length - 1)
                    {
                        break;
                    }

                    if (word[j] >= 42 && word[j] <= 57)
                    {
                        break;
                    }


                    if (word[j] == 55)
                    {
                        if (j == 0 || j == word.Length - 1)
                        {
                            break;
                        }

                        if (!((word[j - 1] >= 141 && word[j - 1] <= 172) && (word[j + 1] >= 141 && word[j + 1] <= 172)))
                        {
                            break;
                        }
                    }
                    counter++;
                }

                if (word.Length - 1 == counter)
                {
                    validWordCounter++;
                }
            }
            return validWordCounter;
        }

        public static string KthDistinct(string[] arr, int k)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Count(x => x == arr[i]) == 1)
                {
                    counter++;
                    if (counter == k)
                    {
                        return arr[i];
                    }
                }
            }
            return "";
        }

        public static int MaxTwoEvents(int[][] events)
        {
            int sum1 = 0;
            int sum2 = 0;

            int endCurrentRow = events[0][1];

            int startNextRow = events[1][0];
            int endNextRow = events[1][1];

            int startLastRow = events[2][0];

            if (startNextRow > endCurrentRow)
            {
                sum1 = events[0][2] + events[1][2];
            }else
            {
                sum1 = events[0][2];
                sum2 = events[1][2];
            }

            if (startLastRow > endNextRow)
            {
                int tempSum = events[1][2] + events[2][2];
                if (tempSum > (sum1 + events[2][2]))
                {
                    sum1 = tempSum; 
                }
                else
                {
                    sum1 += events[2][2];
                }
            }
            else
            {
                sum2 += events[2][2];
            }

            return sum1 > sum2 ? sum1 : sum2; ;
        }
    }
}
