using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class chooseFlaskSolution
    {
        public static int chooseFlask(List<int> requirements, int flaskTypes, List<List<int>> markings)
        {
            Dictionary<int, int> results = new Dictionary<int, int>();
            Dictionary<int, int> tracker = new Dictionary<int, int>();
            for (int k = 0; k < flaskTypes; k++)
            {
            }
            for (int i = 0; i < requirements.Count; i++)
            {
                //Let each of the requirement go through the list of Flask markings to see the Flask best satisfied it.
                for (int j = 0; j < markings.Count; j++)
                {
                    //Check if the index of the Flask marking exist in the tracker
                    int satisfiedRequirementIndex = -1;
                    bool hasValue = tracker.ContainsValue(markings[j][0]);
                    if (hasValue)
                    {
                        //
                        satisfiedRequirementIndex = markings[j][0];

                        //Check if the index i requirement has been satisfied for a particular index of Flask markings
                        if (!(satisfiedRequirementIndex == i))
                        {
                            if (markings[j][1] >= requirements[i])
                            {
                                tracker[markings[j][0]] = satisfiedRequirementIndex + 1; //Increase the index of satisfied requirement
                                results[markings[j][0]] += (markings[j][1] - requirements[i]); //Increase loss value in the result
                            }
                        }
                    }
                    else
                    {
                        //Index of the marking item does not exist in the tracker
                        //Compare the value of the marking Flask with the requirement
                        if (markings[j][1] >= requirements[i])
                        {
                            tracker[markings[j][0]] = 0; //Add index of satisfied requirement into the tracker
                            results[markings[j][0]] = (markings[j][1] - requirements[i]); //Add loss into the result
                        }
                    }
                }
            }

            ////Get the index with least value in the dictionary
            //int returnIndex = results.Aggregate((l, r) => l.Value <= r.Value ? l : r).Key;
            int index = -1, previousLoss = 0, requiresMet = 0;
            for (int k = 0; k < flaskTypes; k++)
            {
                bool hasValue = tracker.TryGetValue(k, out requiresMet);
                if (hasValue && ((requiresMet + 1) == requirements.Count))
                {
                    int currentLoss = results[k];
                    if (index == -1)
                    {
                        index = k;
                        previousLoss = currentLoss;
                    }
                    else
                    {
                        index = currentLoss < previousLoss ? k : index;
                        previousLoss = currentLoss < previousLoss ? currentLoss : previousLoss;
                    }
                }
            }
            return index;
        }

    }
}
