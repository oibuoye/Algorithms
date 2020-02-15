using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class BinaryConversionSolution
    {
        public int BinaryConversion(int num)
        {
            ArrayList objArr = new ArrayList();
            int binaryGap = 0;
            int numConversion = num;

            while (numConversion > 0)
            {
                int res = numConversion % 2;
                objArr.Insert(0, res);
                numConversion = numConversion / 2;
            }
            int counter = 0;
            foreach (int value in objArr)
            {
                int check = value;
                if (Convert.ToInt64(value) == 1 && counter != 0)
                {
                    if (counter > binaryGap)
                    {
                        binaryGap = counter;
                    }
                    counter = 0;
                }
                else if (Convert.ToInt64(value) == 0)
                {
                    counter++;
                }
            }
            return binaryGap;
        }
    }
}
