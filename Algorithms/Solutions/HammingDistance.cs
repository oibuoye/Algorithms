using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class HammingDistance
    {
        public static int GetHammingDistance(int x, int y)
        {
            ArrayList xBin = GetBinaryNumber(x);
            ArrayList yBin = GetBinaryNumber(y);
            int counter = 0;

            if(yBin.Count > xBin.Count)
            {
                int d = yBin.Count - xBin.Count;
                for (int i = 0; i < d; i++)
                {
                    xBin.Insert(0, 0);
                }

                for(int i =0; i < yBin.Count; i++)
                {
                    if((int)yBin[i] != (int)xBin[i])
                    {
                        counter++;
                    }
                }
            }else if(xBin.Count > yBin.Count)
            {
                int d = xBin.Count - yBin.Count;
                for (int i = 0; i < d; i++)
                {
                    yBin.Insert(0, 0);
                }

                for (int i = 0; i < xBin.Count; i++)
                {
                    if ((int)yBin[i] != (int)xBin[i])
                    {
                        counter++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < yBin.Count; i++)
                {
                    if ((int)yBin[i] != (int)xBin[i])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        private static ArrayList GetBinaryNumber(int val)
        {
            ArrayList objArr = new ArrayList();
            int numConversion = val;

            while (numConversion > 0)
            {
                int res = numConversion % 2;
                objArr.Insert(0, res);
                numConversion = numConversion / 2;
            }
            return objArr;
        }
    }
}
