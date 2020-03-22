using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class chooseFlaskSolution
    {
        //WIP:::Needs to be optmised
        public static int chooseFlask(List<int> requirements, int flaskTypes, List<List<int>> markings)
        {
            int[] results = new int[flaskTypes];
            int[] requirementMets = new int[flaskTypes];
            int index = -1;
            int requirementsLen = requirements.Count;
            int previousLowestLoss = 0;

            Dictionary<int, List<int>> flaskMarkings = new Dictionary<int, List<int>>();
            for (int i = 0; i < flaskTypes; i++)
            {
                flaskMarkings.Add(i, new List<int>());
            }

            for (int i = 0; i < markings.Count; i++)
            {
                var key = markings[i][0];
                var mark = markings[i][1];
                flaskMarkings[key].Add(mark);
            }

            for(int i =0; i < flaskTypes; i++)
            {
                List<int> reqCopy = new List<int>(requirements);
                var removeValues = new List<int>();
                var marks = flaskMarkings[i];
                for (int k = 0; k < marks.Count; k++)
                {
                    for (int j = 0; j < reqCopy.Count; j++)
                    {
                        if (reqCopy[j] <= marks[k])
                        {
                            requirementMets[i] += 1;
                            results[i] += (marks[k] - reqCopy[j]);
                            removeValues.Add(reqCopy[j]);
                            if (requirementMets[i] == requirementsLen && index == -1)
                            {
                                index = i;
                                previousLowestLoss = results[i];
                                break;
                            }
                            else if (requirementMets[i] == requirementsLen && index != -1)
                            {
                                index = previousLowestLoss != 0 && previousLowestLoss <= results[i] ? index : i;
                                previousLowestLoss = previousLowestLoss <= results[i] ? previousLowestLoss : results[i];
                                break;
                            }
                        }
                    }
                    reqCopy.RemoveAll(x => removeValues.Contains(x));
                    if(reqCopy.Count == 0)
                    {
                        break;
                    }
                }
            }
            return index;
        }

        public static int chooseFlaskImpl2(List<int> requirements, int flaskTypes, List<List<int>> markings)
        {
            int[] results = new int[flaskTypes];
            int[] requirementMets = new int[flaskTypes];
            int index = -1;
            int requirementsLen = requirements.Count;
            int previousLowestLoss = 0;

            for (int i = 0; i < requirementsLen; i++)
            {
                int[] statusTracker = new int[flaskTypes];
                for (int j = 0; j < markings.Count; j++)
                {
                    int currentIndex = markings[j][0];
                    if (requirements[i] <= markings[j][1] && statusTracker[currentIndex] == 0)
                    {
                        statusTracker[currentIndex] = 1;
                        requirementMets[currentIndex] += 1;
                        results[currentIndex] += markings[j][1] - requirements[i];
                        if (requirementMets[currentIndex] == requirementsLen)
                        {
                            if (index == -1)
                            {
                                index = currentIndex;
                                previousLowestLoss = results[currentIndex];
                            }
                            else
                            {
                                index = previousLowestLoss != 0 && previousLowestLoss <= results[currentIndex] ? index : currentIndex;
                                previousLowestLoss = previousLowestLoss <= results[currentIndex] ? previousLowestLoss : results[currentIndex];
                            }
                        }
                    }
                }
            }
            return index;
        }

        public static int chooseFlaskImpl3(List<int> requirements, int flaskTypes, List<List<int>> markings)
        {
            int[] results = new int[flaskTypes];
            int[] requirementMets = new int[flaskTypes];
            int index = -1;
            int requirementsLen = requirements.Count;
            int previousLowestLoss = 0;

            for (int i = 0; i < requirementsLen; i++)
            {
                int[] statusTracker = new int[flaskTypes];
                for (int j = 0; j < markings.Count; j++)
                {
                    int currentIndex = markings[j][0];
                    int mark = markings[j][1];
                    int requirement = requirements[i];
                    if (requirement <= mark && statusTracker[currentIndex] == 0)
                    {
                        statusTracker[currentIndex] = 1;
                        requirementMets[currentIndex] += 1;
                        results[currentIndex] += mark - requirement;
                    }

                    if (statusTracker[flaskTypes - 1] == 1)
                    {
                        break;
                    }
                }
            }

            for (int k = 0; k < flaskTypes; k++)
            {
                if (requirementMets[k] == requirementsLen && index == -1)
                {
                    index = k;
                    previousLowestLoss = results[k];
                }
                else if (requirementMets[k] == requirementsLen && index != -1)
                {
                    index = previousLowestLoss != 0 && previousLowestLoss <= results[k] ? index : k;
                    previousLowestLoss = previousLowestLoss <= results[k] ? previousLowestLoss : results[k];
                }
            }
            return index;
        }

    }
}
