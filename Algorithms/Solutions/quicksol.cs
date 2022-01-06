using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class quicksol
    {
        public static char Finddif(string s, string t)
        {
            Dictionary<char, int> sTracker = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (sTracker.ContainsKey(s[i]))
                {
                    sTracker[s[i]] += 1;
                }
                else
                {
                    sTracker.Add(s[i], 1);
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (sTracker.ContainsKey(t[i]))
                {
                    if (sTracker[t[i]] != (t.Count(x => x == t[i])))
                    {
                        return t[i];
                    }
                }
                else
                {
                    return t[i];
                }
            }
            throw new Exception("The two strings letters are equal");
        }

        public static int[] FindErrors(int[] nums)
        {
            int duplicateNum = 0;
            int missingNum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int expected = i + 1;
                if (nums[i] != expected)
                {
                    duplicateNum = nums[i];
                    missingNum = expected;
                }
            }

            return new int[] { duplicateNum, missingNum };
        }

        public int CalPoints(string[] ops)
        {
            List<int> arrayList = new List<int>();
            for (int i = 0; i < ops.Length; i++)
            {
                string item = ops[i];
                switch (item)
                {
                    case "C":
                        arrayList.RemoveAt(arrayList.Count - 1);
                        break;
                    case "D":
                        int newValue = (int)arrayList[arrayList.Count - 1] * 2;
                        arrayList.Insert(arrayList.Count, newValue);
                        break;
                    case "+":
                        int newAddition = (int)arrayList[arrayList.Count - 1] + (int)arrayList[arrayList.Count - 2];
                        arrayList.Insert(arrayList.Count, newAddition);
                        break;
                    default:
                        arrayList.Insert(arrayList.Count, Convert.ToInt32(item));
                        break;
                }
            }
            return arrayList.Sum();
        }

        public static int numPlayers(int k, List<int> scores)
        {
            //Sort request

            scores = SortList(scores);

            //Declare a counter to tracker number of players that achieve the rank k
            int counter = 0;
            //Declare tracker to know when the number of rank required has been met
            int trackerCounter = 0;
            for (int i = scores.Count - 1; i >= 0; i--)
            {
                if (trackerCounter < k)
                {
                    counter++;
                }
                else
                {
                    if (scores[i + 1] == scores[i])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                trackerCounter++;
            }

            return counter;
        }

        public static List<int> SortList(List<int> listOfNumbers)
        {
            bool IsSwapped;

            do
            {
                IsSwapped = false;

                for (int i = 0; i < listOfNumbers.Count - 1; i++)
                {
                    //Do the comparison of the numbers
                    if (listOfNumbers[i] > listOfNumbers[i + 1])
                    {
                        //Do the swapping
                        //Keep the second value
                        int tempNumber = listOfNumbers[i + 1];

                        //swap the highest value into the second value
                        listOfNumbers[i + 1] = listOfNumbers[i];

                        //put the second value into the first
                        listOfNumbers[i] = tempNumber;

                        IsSwapped = true;
                    }
                }
            } while (IsSwapped == true);


            return listOfNumbers;

        }

        public static string reachTheEnd(List<string> grid, int maxTime)
        {
            int moveCounter = 0;
            for (int i = 0; i < grid.Count - 1; i++)
            {
                string currentRowValue = grid[i];
                string nextRowValue = grid[i + 1];
                int movementTrackerIndex = 0;

                for (int k = 0; k < currentRowValue.Length; k++)
                {
                    if (nextRowValue[k] == '#' && currentRowValue[k + 1] == '#')
                    {
                        return "NO";
                    }

                    if (nextRowValue[k] == '.')
                    {
                        if (((grid.Count - 1) == (i + 1)))
                        {
                            moveCounter++;
                            for (int j = movementTrackerIndex; j < nextRowValue.Length; j++)
                            {
                                if (nextRowValue[k] == '.')
                                {
                                    moveCounter++;
                                    movementTrackerIndex++;
                                }
                                else
                                {
                                    return "NO";
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        moveCounter++;
                        movementTrackerIndex++;
                        for (int j = movementTrackerIndex; j < currentRowValue.Length; j++)
                        {
                            if (nextRowValue[j] == '.')
                            {
                                break;
                            }
                            else
                            {
                                return "NO";
                            }
                        }
                    }
                }
            }

            if (moveCounter <= maxTime)
            {
                return "YES";
            }
            return "NO";
        }

        public static string ReachTheEnd(List<string> grid, int maxTime)
        {
            //int moveCounter = 0;
            //for (int i = 0; i < grid.Count - 1; i++)
            //{
            //    string currentRowValue = grid[i];
            //    string nextRowValue = grid[i + 1];
            //    int movementIndexTracker = 0;

            //    for (int k = movementIndexTracker; k < currentRowValue.Length; k++)
            //    {
            //        if (nextRowValue[k] == '#' && currentRowValue[k + 1] == '#')
            //        {
            //            return "NO";
            //        }

            //        if (nextRowValue[k] == '.' && ((grid.Count - 1) == (i + 1)))
            //        {
            //            moveCounter++;
            //            for (int j = movementIndexTracker; j < nextRowValue.Length; j++)
            //            {
            //                if (nextRowValue[k] == '.')
            //                {
            //                    moveCounter++;
            //                }
            //                else
            //                {
            //                    return "NO";
            //                }
            //            }
            //        }
            //        else
            //        {
            //            moveCounter++;
            //            break;
            //        }
            //    }
            //}

            //if (moveCounter <= maxTime)
            //{
            //    return "YES";
            //}
            return "NO";
        }

    }
}
