using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class BiologicalHazards
    {
        public static long BioHazard(int n, List<int> affected, List<int> poisonous)
        {
            long canCoExist = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    List<string> possibleCom = new List<string>();
                    for (int k = i; k <= j; k++)
                    {
                        possibleCom.Add(k.ToString());
                    }

                    bool coexist = false;
                    //Check that the affected and poisonous are not coexist
                    for (int m = 0; m < affected.Count; m++)
                    {
                        if (possibleCom.Contains(affected[m].ToString()) && possibleCom.Contains(poisonous[m].ToString()))
                        {
                            coexist = true;
                        }
                    }

                    //If both are not present, then add to the list
                    if (!coexist)
                    {
                        canCoExist++;
                    }
                }
            }
            return canCoExist;
        }
    }
}
