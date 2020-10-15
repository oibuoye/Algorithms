using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.CoderByte
{
    public class Challenges
    {
        public static IList<IList<int>> TestSol(int target)
        {
            List<IList<int>> response = new List<IList<int>>();

            return response;
        }

        /// <summary>
        /// Gas station solution
        /// </summary>
        /// <param name="strArr"></param>
        /// <returns></returns>
        public static string GasStation(string[] strArr)
        {
            int responseIndex = 0;
            int stations = Convert.ToInt16(strArr[0]);
            int availableGallons = 0;
            for (int i = 1; i <= stations; i++)
            {
                string stationVal = strArr[i];
                string[] splitValue = stationVal.Split(':');

                availableGallons += Convert.ToInt16(splitValue[0]);
                int journeyGallonRequired = Convert.ToInt16(splitValue[1]);

                if (journeyGallonRequired > availableGallons)
                {
                    availableGallons = 0;
                    responseIndex = 0;
                    continue;
                }
                availableGallons -= journeyGallonRequired;
                responseIndex = i;
            }

            // code goes here
            if (responseIndex == 0)
            {
                return "impossible";
            }

            return responseIndex.ToString();
        }

        /// <summary>
        /// Work in progress: The solution not working perfectly yet
        /// </summary>
        /// <param name="strArr"></param>
        /// <returns></returns>
        public static string BitmapHoles(string[] strArr)
        {
            int hrResponse = 0;
            int vtResponse = 0;
            int hrRegion = 0;
            int vtRegion = 0;
            bool hrConnected = false;
            bool vtConnected = false;
            int n = Convert.ToInt16(strArr.Length);
            for (int i = 0; i < n; i++)
            {
                string currentMat = strArr[i];
                int matrixLength = currentMat.Length;
                for (int j = 1; j < matrixLength; j++)
                {
                    string cr = currentMat[j].ToString();
                    if (cr == "0")
                    {
                        if (currentMat[j - 1].ToString() == "0")
                        {
                            hrRegion++;
                            hrConnected = true;
                        }
                    }
                    else
                    {
                        hrResponse = hrResponse > hrRegion ? hrResponse : hrRegion;
                        hrRegion = 0;
                        hrConnected = false;
                    }
                }

                for (int j = 1; j < n; j++)
                {
                    string currentArray = strArr[j];
                    string currentArrayVal = currentArray[i].ToString();

                    if (currentArrayVal == "0")
                    {
                        string previousArray = strArr[j - 1];
                        string previousArrayVal = previousArray[i].ToString();

                        if (previousArray[i].ToString() == "0")
                        {
                            vtRegion++;
                            vtConnected = true;
                        }
                    }
                    else
                    {
                        vtResponse = vtResponse > vtRegion ? vtResponse : vtRegion;
                        vtRegion = 0;
                        vtConnected = false;
                    }
                }
            }

            // code goes here  
            int finalResponse = hrResponse > vtResponse ? hrResponse + 1 : vtResponse + 1;
            return finalResponse.ToString();
        }
    }
}
