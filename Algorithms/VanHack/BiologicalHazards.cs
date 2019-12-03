using Hangfire;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.VanHack
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

        public static long BioHazardSol2(int n, List<int> affected, List<int> poisonous)
        {
            long canCoExist = 0;
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                for (int j = i; j <= n; j++)
                {
                   count++;
                   var result = Enumerable.Range(i, count);

                    bool coexist = false;
                    //Check that the affected and poisonous are not coexist
                    for (int m = 0; m < affected.Count; m++)
                    {
                        if (result.Contains(affected[m]) && result.Contains(poisonous[m]))
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
